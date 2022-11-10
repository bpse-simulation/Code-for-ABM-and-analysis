using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using CellBehaviorSimulator.CultureEnvironments;

namespace CellBehaviorSimulator.CellBehaviors
{
    public partial class Migration : UserControl
    {
        public Migration()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void Migration_Load(object sender, EventArgs e)
        {
            flag = new List<bool>() { checkModuleAvailable.Checked };
            V_m_free = new List<double> { (double)numV_mfree.Value };
            m_c = new List<double> { (double)num_mc.Value };
            Fluc_m = new List<double> { (double)numFluc_m.Value * 0.01 };
            if (!flag[0]) { groupBox1.Enabled = false; }
        }

        private void CheckModuleAvailable_CheckedChanged(object sender, EventArgs e)
        {
            flag[Behaviors.Cell_T] = checkModuleAvailable.Checked;
            if (checkModuleAvailable.Checked)
            {
                groupBox1.Enabled = true;
                ParamChanged();
            }
            else
            {
                groupBox1.Enabled = false;
                numV_mfree.Value = (decimal)_V_m_free;
                num_mc.Value = (decimal)_m_c;
            }
        }
        private void NumV_mfree_ValueChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            { V_m_free[Behaviors.Cell_T] = (double)numV_mfree.Value; }
        }
        private void Num_mc_ValueChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            { m_c[Behaviors.Cell_T] = (double)num_mc.Value; }
        }
        private void NumFluc_m_ValueChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            { Fluc_m[Behaviors.Cell_T] = (double)numFluc_m.Value * 0.01; }
        }
        private void Migration_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                checkModuleAvailable.Checked = false;
                for (int i = 0; i < flag.Count; i++)
                { flag[i] = false; }
            }
        }
        #endregion
        #region Parameter setting
        internal void ParamChanged()
        {
            checkModuleAvailable.Checked = flag[Behaviors.Cell_T];
            if (checkModuleAvailable.Checked)
            {
                numV_mfree.Value = (decimal)V_m_free[Behaviors.Cell_T];
                num_mc.Value = (decimal)m_c[Behaviors.Cell_T];
                numFluc_m.Value = (decimal)(Fluc_m[Behaviors.Cell_T] * 100);
            }
        }
        internal void ParamAdd()
        {
            flag.Add(checkModuleAvailable.Checked);
            V_m_free.Add((double)numV_mfree.Value);
            m_c.Add((double)num_mc.Value);
            Fluc_m.Add((double)numFluc_m.Value * 0.01);
        }
        internal void ParamRemoveAt(int index)
        {
            flag.RemoveAt(index);
            V_m_free.RemoveAt(index);
            m_c.RemoveAt(index);
            Fluc_m.RemoveAt(index);
        }
        internal bool SetParameter()
        {
            ParamChanged();
            for (int i = 0; i < Behaviors.Maximum; i++)
            {
                if (flag[i])
                {
                    return true;
                }
            }
            return false;
        }
        internal void RegisterParameters(int cellT)
        {
            flag[cellT] = checkModuleAvailable.Checked;
            if (flag[cellT])
            {
                V_m_free[cellT] = (double)numV_mfree.Value;
                m_c[cellT] = (double)num_mc.Value;
                Fluc_m[cellT] = (double)numFluc_m.Value * 0.01;
            }
        }
        #endregion
        private const string Str_V_m_free = "V_m_free";
        private const string Str_m_c = "m_c";
        private const string Str_Fluc_m = "Fluc_m";
        #region Parameter definitions
        public static void WriteParameter(System.IO.StreamWriter sw, int i)
        {
            if (flag[i])
            {
                sw.WriteLine(":," + Str_V_m_free + "(" + i + ")," + V_m_free[i] + ",um/h");
                sw.WriteLine(":," + Str_m_c + "(" + i + ")," + m_c[i] + ",ng");
                sw.WriteLine(":," + Str_Fluc_m + "(" + i + ")," + (Fluc_m[i] * 100) + ",%");
            }
        }
        public static bool ReadParameter(string strName, int typeNum, string strValue)
        {
            switch (strName)
            {
                case Str_V_m_free:
                    return SetParameter_V_m_free(typeNum, strValue);
                case Str_m_c:
                    return SetParameter_m_c(typeNum, strValue);
                case Str_Fluc_m:
                    return SetParameter_Fluc_Emax(typeNum, strValue);
                default: return false;
            }
        }
        public static void AdjustParameter()
        {
            if (flag == null)
            { flag = new List<bool>(); }
            while (flag.Count < Behaviors.Maximum)
            { flag.Add(false); }
            if (V_m_free == null)
            { V_m_free = new List<double>(); }
            while (V_m_free.Count < Behaviors.Maximum)
            { V_m_free.Add(0); }
            if (m_c == null)
            { m_c = new List<double>(); }
            while (m_c.Count < Behaviors.Maximum)
            { m_c.Add(1); }
            if (Fluc_m == null)
            { Fluc_m = new List<double>(); }
            while (Fluc_m.Count < Behaviors.Maximum)
            { Fluc_m.Add(0); }
        }
        public static void ClearParameter()
        {
            if (flag != null)
            {
                flag.Clear();
                V_m_free.Clear();
                m_c.Clear();
                Fluc_m.Clear();
            }
        }
        public static bool SetParameter_V_m_free(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, flag, 0, V_m_free);
            if (double.TryParse(strVal, out double val))
            {
                V_m_free[typeNum] = val;
                flag[typeNum] = true;
                return true;
            }
            return false;
        }
        public static bool SetParameter_m_c(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, flag, 1, m_c);
            if (double.TryParse(strVal, out double val))
            {
                m_c[typeNum] = val;
                flag[typeNum] = true;
                return true;
            }
            return false;
        }
        public static bool SetParameter_Fluc_Emax(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, flag, 0, Fluc_m);
            if (double.TryParse(strVal, out double val))
            {
                Fluc_m[typeNum] = val * 0.01;
                flag[typeNum] = true;
                return true;
            }
            return false;
        }
        #endregion

        private static List<bool> flag;
        private static List<double> V_m_free;
        private static List<double> m_c;
        private static List<double> Fluc_m;
        private static readonly double _V_m_free = Math.Sqrt(2);
        private static readonly double _m_c = 1;

        public static bool Get_flag(int Cell_T)
        {
            return flag[Cell_T];
        }
        public static double Get_V_m_free(int Cell_T)
        {
            if (flag[Cell_T])
            { return V_m_free[Cell_T]; }
            else { return _V_m_free; }
        }
        public static double Get_m_c(int Cell_T)
        {
            if (flag[Cell_T])
            { return m_c[Cell_T]; }
            else { return _m_c; }
        }
        public static double Get_FlucRate(int Cell_T)
        {
            return Common.UniformWhiteNoise(Fluc_m[Cell_T]);
        }

        public static void Run(List<CellData> cells, int[] ind)
        {
            foreach (int index in ind)
            {
                Run(cells, index);
            }
        }
        private static void Run(List<CellData> cells, int index)
        {
            CellData c = CellData.Find(cells, index);
            if (Common.IsDeadCell(c)) { return; }
            if (flag[c.Cell_T])
            {
                if (V_m_free[c.Cell_T] > 0 && c.Time_age >= 0)
                {
                    if (c.Time_m <= 0)
                    {
                        Delta del = Common.RandomDirection(MigrationPrm(cells, c, out double[] epsB));
                        if (del != null)
                        {
                            int indNei = Common.CellReplacement(cells, c, del);
                            ActiveMovementRate(c, epsB, del, out double t_m);
                            PassiveMovementRate(cells, indNei, del, t_m);
                        }
                        else
                        {
                            c.V_m = 0;
                            c.Dir_am = Direction.DIR.C_1;
                        }
                    }
                }
            }
        }
        private static void PassiveMovementRate(List<CellData> cells, int indNeighbor, Delta d, double time)
        {
            if (indNeighbor >= 0)
            {
                CellData.Find(cells, indNeighbor).Dir_pm.Add(Direction.GetDirection(-d));
                CellData.Find(cells, indNeighbor).Time_m += time;
            }
        }

        private static void ActiveMovementRate(CellData c, double[] epsilonB, Delta d, out double t_m)
        {
            double vmc = GetVmc(c, epsilonB, d);
            double lm = MigrationDistance(d);
            t_m = lm / vmc;
            c.Time_m += t_m;
            c.V_m = vmc;
            c.Dir_am = Direction.GetDirection(d);
        }

        private static double GetVmc(CellData c, double[] epsilonB, Delta d)
        {
            double val = 1.0 - epsilonB[(int)Direction.GetDirection(d)];
            return V_m_free[c.Cell_T] * Math.Sqrt(c.E_max / Common.Emax[c.Cell_T]) * Math.Sqrt(val);
        }

        private static double MigrationDistance(Delta d)
        {
            return Delta.GetLength(d) * CultureSpace.Size_lc;
        }

        public static double[] MigrationPrm(List<CellData> cells, CellData c, out double[] epsilonB)
        {
            epsilonB = MigrationPm(cells, c, out double[] Pm);
            _ = Parallel.For(0, 20, dir =>
            {
                if (Pm[dir] > 0)
                {
                    Point3D p = c.Location + Delta.GetDelta(dir);
                    int indS = CultureSpace.GetMap(p);
                    if (indS >= 0)
                    {
                        CellData cs = CellData.Find(cells, indS);
                        MigrationPm(cells, cs, out double[] Pm2);
                        Pm[dir] *= Pm2[19 - dir];
                    }
                }
            });
            return Pm;
        }

        public static double[] MigrationPm(List<CellData> cells, CellData c, out double[] Pm)
        {
            Pm = new double[20];
            double[] epsilonB = new double[20];
            double sumPm = 0.0;
            for (int dir = 0; dir < 20; dir++)
            {
                int  val = CultureSpace.GetMap(c.Location, Delta.GetDelta(dir));
                if (val >= -1)
                {
                    if (MigrationHm_dir(c, dir))
                    {
                        double Rmdir = MigrationRm_dir(cells, c, dir, out epsilonB[dir]);
                        double Smdir = MigrationSm_dir(cells, c, val);
                        Pm[dir] = Common.Omega[dir] * Rmdir * Smdir;
                    }
                    else
                    {
                        Pm[dir] = 0;
                        epsilonB[dir] = double.PositiveInfinity;
                    }
                }
                else
                {
                    Pm[dir] = 0;
                    epsilonB[dir] = double.PositiveInfinity;
                }
                sumPm += Pm[dir];
            }
            if (sumPm > 0.0)
            {
                for (int i = 0; i < 20; i++)
                {
                    Pm[i] /= sumPm;
                }
            }
            return epsilonB;
        }

        private static double MigrationSm_dir(List<CellData> cells, CellData c, int val)
        {
            if (val >= 0 && AreaWeighting.Flag[c.Cell_T])
            {
                CellData c2 = CellData.Find(cells, val);
                if (c.Cell_T != c2.Cell_T && AreaWeighting.Flag[c2.Cell_T])
                {
                    double a1 = AreaWeighting.A_r[c.Cell_T];
                    double a2 = AreaWeighting.A_r[c2.Cell_T];
                    return Math.Min(a1, a2) / Math.Max(a1, a2);
                }
            }
            return 1;
        }
        private static bool MigrationHm_dir(CellData c, int dir)
        {
            Delta d = Delta.GetDelta(dir);
            for (int i = 0; i < 20; i++)
            {
                if (Common.GetW(i))
                {
                    Delta _d = 19 - i - dir == 0 ? d : d + Delta.GetDelta(i);
                    Point3D p = c.Location + _d;
                    int val = CultureSpace.GetMap(p);
                    if (val >= 0 || val == -3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static double MigrationRm_dir(List<CellData> cells, CellData c, int dir, out double EpB_dir)
        {
            double EA = 0;
            double EB_dir = 0;
            for (int d = 0; d < 20; d++)
            {
                double Ec = Common.CalcEc(cells, c, d, out _, out double ETJ, out _);
                EA += Ec;
                double deltaE = 0;
                if (Common.GetDeltaW(dir, d) == 1) { deltaE = Ec; }
                else if (Common.GetDeltaW(dir, d) == 0) { deltaE = ETJ; }
                if (deltaE > 0)
                { EB_dir += deltaE; }
            }
            if (EA == 0)
            {
                EpB_dir = 0;
                return 0;
            }
            else
            {
                EpB_dir = EB_dir / c.E_max;
                if (EpB_dir >= 1)
                { return 0; }
                else
                { return (EA - EB_dir) / EA; }
            }
        }

        public static bool IsMigratable(List<CellData> cells, CellData c)
        {
            if (flag[c.Cell_T])
            {
                for (int dir = 0; dir < 20; dir++)
                {
                    int val = CultureSpace.GetMap(c.Location, Delta.GetDelta(dir));
                    if (val >= -1)
                    {
                        if (IsMigratable(cells, c, dir))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool IsMigratable(List<CellData> cells, CellData c, int dir)
        {
            if (MigrationHm_dir(c, dir))
            {
                double Rmdir = MigrationRm_dir(cells, c, dir, out _);
                return Rmdir > 0;
            }
            else
            {
                return false;
            }
        }
        public static bool IsMigratable(List<CellData> cells, CellData c, int dir, out double EpB_dir)
        {
            if (MigrationHm_dir(c, dir))
            {
                double Rmdir = MigrationRm_dir(cells, c, dir, out EpB_dir);
                return Rmdir > 0;
            }
            else
            {
                EpB_dir = 0;
                return false;
            }
        }
    }
}
