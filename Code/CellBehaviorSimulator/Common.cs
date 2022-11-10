using CellBehaviorSimulator.CultureEnvironments;
using CellBehaviorSimulator.CellBehaviors;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CellBehaviorSimulator
{
    public static class Common
    {
        public static void Preparation(bool newRun)
        {
            DirectionWeight();
            FunctionW(Connectability.LAMBDA2);
            CalcEmax();
            if (newRun)
            { BasicConnectionEnergy.EpsilonToEnergy(Emax); }
            CultureSpace.MapPre = new int[CultureSpace.Zsize, CultureSpace.Ysize, CultureSpace.Xsize];
            CellData.CellsPre = new CellData[0];
            PartitionNum = CultureTime.Get_PartitionNumber();
            Ecsmax = BasicConnectionEnergy.CalcEcsmax();
            CellMovement.Initialize();
        }

        private static bool[] _W;
        private static sbyte[,] _deltaW;
        public static int PartitionNum;

        public static double[] Emax { get; private set; }
        public static double Ecsmax { get; private set; }
        public static int[] Omega { get; private set; }
        public static double Rand_NextDouble()
        {
            return RandomGen2.NextDouble();
        }

        public static void MaintainStates(List<CellData> cells)
        {
            CellData.CellsPre = new CellData[cells.Count];
            Parallel.For(0, cells.Count, i =>
            { CellData.CellsPre[i] = CellData.Clone(cells[i]); });
            Parallel.For(0, CultureSpace.Zsize * CultureSpace.Ysize * CultureSpace.Xsize, n =>
            {
                int k = n / (CultureSpace.Ysize * CultureSpace.Xsize);
                int j = n % (CultureSpace.Ysize * CultureSpace.Xsize) / CultureSpace.Xsize;
                int i = n % (CultureSpace.Ysize * CultureSpace.Xsize) % CultureSpace.Xsize;
                CultureSpace.MapPre[k, j, i] = CultureSpace.GetMap(i * 2, j, k);
            });
        }

        public static void CalcEmax()
        {
            int len = Behaviors.Maximum;
            Emax = new double[len];
            for (int i = 0; i < len; i++)
            {
                double vmfree = Migration.Get_V_m_free(i);
                Emax[i] = 0.5 * Migration.Get_m_c(i) * vmfree * vmfree;
            }
        }

        public static double CalcEc(List<CellData> cells, CellData c, int dir, out double EAJ, out double ETJ, out double Ecs)
        {
            Point3D p = c.Location + Delta.GetDelta(dir);
            int val = CultureSpace.GetMap(p);
            EAJ = 0;
            ETJ = 0;
            Ecs = 0;
            if (val >= 0)
            {
                CellData c2 = CellData.Find(cells, val);
                (EAJ, ETJ) = BasicConnectionEnergy.GetE_AJ_TJ(c, c2, c.THETA[dir]);
                return EAJ + ETJ;
            }
            else if (val == -3)
            {
                return BasicConnectionEnergy.GetEcs(c, Delta.GetDelta(dir));
            }
            return 0;
        }

        private static void DirectionWeight()
        {
            Omega = new int[20] {
                292, 292, 292, 746, 292, 292, 292,
                834, 834, 834,      834, 834, 834,
                292, 292, 292, 746, 292, 292, 292 };
        }
        private static void FunctionW(int Lambda2)
        {
            _W = new bool[20];
            for (int j = 0; j < _W.Length; j++)
            {
                Delta d1 = Delta.GetDelta(j);
                _W[j] = Delta.GetLength_pow2(d1) <= Lambda2;
            }
            _deltaW = new sbyte[_W.Length, _W.Length];
            for (int j = 0; j < _W.Length; j++)
            {
                Delta d1 = Delta.GetDelta(j);
                for (int i = 0; i < _W.Length; i++)
                {
                    Delta d2 = Delta.GetDelta(i) - d1;
                    int val = Delta.GetLength_pow2(d2) <= Lambda2 ? 1 : 0;
                    _deltaW[j, i] = (sbyte)((_W[i] ? 1 : 0) - val);
                }
            }
        }

        public static bool GetW(Direction.DIR dir)
        {
            return GetW((int)dir);
        }
        public static bool GetW(int dir)
        {
            return _W[dir];
        }
        public static sbyte GetDeltaW(Direction.DIR dir1, Direction.DIR dir2)
        {
            return GetDeltaW((int)dir1, (int)dir2);
        }
        public static sbyte GetDeltaW(int dir1, int dir2)
        {
            return _deltaW[dir1, dir2];
        }

        public static Delta RandomDirection(List<(Delta, int)> weight)
        {
            int[] arr = new int[weight.Count];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                (_, int w) = weight[i];
                arr[i] = w;
                sum += arr[i];
            }
            if (sum > 0)
            {
                double val = sum * Rand_NextDouble();
                for (int i = 0; i < arr.Length; i++)
                {
                    (Delta d, int w) = weight[i];
                    val -= w;
                    if (val < 0)
                    { return d; }
                }
            }
            return null;
        }
        public static Delta RandomDirection(double[] weight)
        {
            double sum = 0;
            for (int i = 0; i < 20; i++)
            { sum += weight[i]; }
            if (sum > 0)
            {
                double val = sum * Rand_NextDouble();
                for (int i = 0; i < 20; i++)
                {
                    val -= weight[i];
                    if (val < 0)
                    { return Delta.GetDelta(i); }
                }
            }
            return null;
        }

        public static bool IsDeadCell(CellData c)
        {
            return c == null;
        }

        public static bool IsAgeGreaterThanZero(CellData c)
        {
            return c.Time_age >= 0;
        }

        public static int[] RandomlySort(List<CellData> cells)
        {
            List<int> arr = new List<int>();
            for (int i = 0; i < cells.Count; i++)
            {
                if (!IsDeadCell(cells[i]))
                { arr.Add(cells[i].Index); }
            }
            for (int i = 0; i < arr.Count; i++)
            {
                int val = (int)(Rand_NextDouble() * (arr.Count - i)) + i;
                (arr[val], arr[i]) = (arr[i], arr[val]);
            }
            return arr.ToArray();
        }

        public static int[] RandomlySort(object[] obj)
        {
            int len = obj.Length;
            int[] arr = new int[len];
            for (int i = 0; i < len; i++)
            { arr[i] = i; }
            for (int i = 0; i < len; i++)
            {
                int val = (int)(Rand_NextDouble() * (len - i)) + i;
                (arr[val], arr[i]) = (arr[i], arr[val]);
            }
            return arr;
        }

        public static double[] UniformWhiteNoise(double inputTime, int n)
        {
            double[] outputTime = new double[n];
            for (int i = 0; i < n; i++)
            {
                outputTime[i] = inputTime * (0.9 + Rand_NextDouble() * 0.2);
            }
            return outputTime;
        }
        public static double UniformWhiteNoise(double rate)
        {
            return (Rand_NextDouble() * 2.0 - 1.0) * rate + 1.0;
        }

        public static int CellReplacement(List<CellData> cells, CellData c, Delta d)
        {
            Point3D cp = c.Location;
            Point3D p = c.Location + d;
            ResetDurationTime(cells, c);
            int ind2 = CultureSpace.GetMap(p);
            CultureSpace.SetMap(p, CultureSpace.GetMap(c.Location));
            CultureSpace.SetMap(c.Location, ind2);
            c.Location = p;
            if (ind2 >= 0)
            {
                CellData c2 = CellData.Find(cells, ind2);
                ResetDurationTime(cells, c2);
                c2.Location = cp;
            }
            return ind2;
        }

        private static void ResetDurationTime(List<CellData> cells, CellData c)
        {
            for (int dir = 0; dir < 20; dir++)
            {
                c.THETA[dir] = 0;
                Point3D p = c.Location + Delta.GetDelta(dir);
                int ind = CultureSpace.GetMap(p);
                if (ind >= 0)
                {
                    cells[ind].THETA[19 - dir] = 0;
                }
            }
        }

        public static bool IsDetatched_cs(CellData c)
        {
            int val = CultureSpace.GetMap(c.Location, new Delta(0, 0, -1));
            if (val == -3)
            {
                if (SubstrateAbility.Flag)
                {
                    for (int i = 13; i < 20; i++)
                    {
                        if (BasicConnectionEnergy.GetEcs(c, Delta.GetDelta(i)) > 0.0)
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                { return c.E_cs == 0.0; }
            }
            else
            {
                return true;
            }
        }


        public static void InitializeParameter<T>(int typeNum, List<bool> flag, T defVal, List<T> param)// where T : IComparable
        {
            if (param == null)
            {
                param = new List<T>();
                flag = new List<bool>();
            }
            while (param.Count <= typeNum)
            {
                param.Add(defVal);
                if (param.Count > flag.Count)
                { flag.Add(false); }
            }
        }
        public static void InitializeParameter<T>(int typeNum, T defVal, params List<T>[] param)// where T : IComparable
        {
            for (int i = 0; i < param.Length; i++)
            {
                if (param[i] == null)
                {
                    param[i] = new List<T>();
                }
                while (param[i].Count <= typeNum)
                {
                    param[i].Add(defVal);
                }
            }
        }
    }
}
