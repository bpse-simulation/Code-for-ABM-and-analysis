using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CellBehaviorSimulator.CultureEnvironments;

namespace CellBehaviorSimulator.CellBehaviors
{
    public partial class Division : UserControl
    {
        public Division()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void Division_Load(object sender, EventArgs e)
        {
            flag = new List<bool>() { checkModuleAvailable.Checked };
            t_g = new List<double>() { (double)num_tg.Value };
            N_c = new List<int>() { (int)num_Nc.Value };
            Pr_q = new List<double>() { (double)num_Prq.Value };
            Fluc_d = new List<double> { (double)numFluc_d.Value * 0.01 };
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
            { groupBox1.Enabled = false; }
        }
        private void Num_tg_ValueChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            { t_g[Behaviors.Cell_T] = (double)num_tg.Value; }
        }
        private void Num_Prq_ValueChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            { Pr_q[Behaviors.Cell_T] = (double)num_Prq.Value; }
        }
        private void Num_Nc_ValueChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            { N_c[Behaviors.Cell_T] = (int)num_Nc.Value; }
        }
        private void NumFluc_d_ValueChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            { Fluc_d[Behaviors.Cell_T] = (double)numFluc_d.Value * 0.01; }
        }
        private void Division_VisibleChanged(object sender, EventArgs e)
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
                if (double.IsInfinity(t_g[Behaviors.Cell_T]))
                { num_tg.Value = num_tg.Maximum; }
                else
                { num_tg.Value = (decimal)t_g[Behaviors.Cell_T]; }
                num_Nc.Value = N_c[Behaviors.Cell_T];
                num_Prq.Value = (decimal)Pr_q[Behaviors.Cell_T];
                numFluc_d.Value = (decimal)(Fluc_d[Behaviors.Cell_T] * 100);
            }
            differentiation_Basal_AsyncDivision1.ParamChanged();
            differentiation_Basal_Decay1.ParamChanged();
        }
        internal void ParamAdd()
        {
            flag.Add(checkModuleAvailable.Checked);
            t_g.Add((double)num_tg.Value);
            N_c.Add((int)num_Nc.Value);
            Pr_q.Add((double)num_Prq.Value);
            Fluc_d.Add((double)numFluc_d.Value * 0.01);
            differentiation_Basal_AsyncDivision1.ParamAdd();
            differentiation_Basal_Decay1.ParamAdd();
        }
        internal void ParamRemoveAt(int index)
        {
            flag.RemoveAt(index);
            t_g.RemoveAt(index);
            N_c.RemoveAt(index);
            Pr_q.RemoveAt(index);
            Fluc_d.RemoveAt(index);
            differentiation_Basal_AsyncDivision1.ParamRemoveAt(index);
            differentiation_Basal_Decay1.ParamRemoveAt(index);
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
                t_g[cellT] = (double)num_tg.Value;
                N_c[cellT] = (int)num_Nc.Value;
                Pr_q[cellT] = (double)num_Prq.Value;
                Fluc_d[cellT] = (double)numFluc_d.Value * 0.01;
            }
            differentiation_Basal_AsyncDivision1.RegisterParameters(cellT);
            differentiation_Basal_Decay1.RegisterParameters(cellT);
        }
        #endregion
        private const string Str_t_g = "t_g";
        private const string Str_N_c = "N_c";
        private const string Str_Pr_q = "Pr_q";
        private const string Str_Fluc_d = "Fluc_d";
        #region Parameter definitions
        public static void WriteParameter(System.IO.StreamWriter sw, int i)
        {
            if (flag[i])
            {
                if (double.IsInfinity(t_g[i]))
                { sw.WriteLine(":," + Str_t_g + "(" + i + "),Inf,h"); }
                else
                { sw.WriteLine(":," + Str_t_g + "(" + i + ")," + t_g[i] + ",h"); }
                sw.WriteLine(":," + Str_N_c + "(" + i + ")," + N_c[i]);
                sw.WriteLine(":," + Str_Pr_q + "(" + i + ")," + Pr_q[i]);
                sw.WriteLine(":," + Str_Fluc_d + "(" + i + ")," + (Fluc_d[i] * 100) + ",%");
                Differentiation_Basal_AsyncDivision.WriteParameter(sw, i);
                Differentiation_Basal_Decay.WriteParameter(sw, i);
            }
        }
        public static bool ReadParameter(string strName, int typeNum, string strValue)
        {
            switch (strName)
            {
                case Str_t_g:
                    return SetParameter_t_g(typeNum, strValue);
                case Str_N_c:
                    return SetParameter_N_c(typeNum, strValue);
                case Str_Pr_q:
                    return SetParameter_Pr_q(typeNum, strValue);
                case Str_Fluc_d:
                    return SetParameter_Fluc_t_g(typeNum, strValue);
                default:
                    if (Differentiation_Basal_AsyncDivision.ReadParameter(strName, typeNum, strValue))
                    { return true; }
                    else if (Differentiation_Basal_Decay.ReadParameter(strName, typeNum, strValue))
                    { return true; }
                    else
                    { return false; }
            }
        }
        public static void AdjustParameter()
        {
            if (flag == null)
            { flag = new List<bool>(); }
            while (flag.Count < Behaviors.Maximum)
            { flag.Add(false); }
            if (t_g == null)
            { t_g = new List<double>(); }
            while (t_g.Count < Behaviors.Maximum)
            { t_g.Add(double.PositiveInfinity); }
            if (N_c == null)
            { N_c = new List<int>(); }
            while (N_c.Count < Behaviors.Maximum)
            { N_c.Add(0); }
            if (Pr_q == null)
            { Pr_q = new List<double>(); }
            while (Pr_q.Count < Behaviors.Maximum)
            { Pr_q.Add(0); }
            if (Fluc_d == null)
            { Fluc_d = new List<double>(); }
            while (Fluc_d.Count < Behaviors.Maximum)
            { Fluc_d.Add(0); }
            Differentiation_Basal_AsyncDivision.AdjustParameter();
            Differentiation_Basal_Decay.AdjustParameter();
        }
        public static void ClearParameter()
        {
            if (flag != null)
            {
                flag.Clear();
                t_g.Clear();
                N_c.Clear();
                Pr_q.Clear();
                Fluc_d.Clear();
                Differentiation_Basal_AsyncDivision.ClearParameter();
                Differentiation_Basal_Decay.ClearParameter();
            }
        }
        public static bool SetParameter_t_g(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, flag, double.PositiveInfinity, t_g);
            if (double.TryParse(strVal, out double val))
            {
                t_g[typeNum] = val;
                flag[typeNum] = true;
                return true;
            }
            else if (strVal == "Inf")
            {
                t_g[typeNum] = double.PositiveInfinity;
                flag[typeNum] = true;
                return true;
            }
            return false;
        }
        public static bool SetParameter_N_c(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, flag, 0, N_c);
            if (int.TryParse(strVal, out int val))
            {
                N_c[typeNum] = val;
                flag[typeNum] = true;
                return true;
            }
            return false;
        }
        public static bool SetParameter_Pr_q(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, flag, 0, Pr_q);
            if (double.TryParse(strVal, out double val))
            {
                Pr_q[typeNum] = val;
                flag[typeNum] = true;
                return true;
            }
            return false;
        }
        public static bool SetParameter_Fluc_t_g(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, flag, 0, Fluc_d);
            if (double.TryParse(strVal, out double val))
            {
                Fluc_d[typeNum] = val * 0.01;
                flag[typeNum] = true;
                return true;
            }
            return false;
        }
        #endregion

        private static List<bool> flag;
        private static List<double> t_g;
        private static List<int> N_c;
        private static List<double> Pr_q;
        private static List<double> Fluc_d;

        public static double Get_t_g(int Cell_T)
        {
            return flag[Cell_T] ? t_g[Cell_T] : double.PositiveInfinity;
        }
        public static double Get_Fluc_t_g(int Cell_T)
        {
            return flag[Cell_T] ? t_g[Cell_T] * Get_FlucRate(Cell_T) : double.PositiveInfinity;
        }
        public static double Get_FlucRate(int Cell_T)
        {
            return Common.UniformWhiteNoise(Fluc_d[Cell_T]);
        }

        internal static CellData.STATE GetCellState(int Cell_T)
        {
            return flag[Cell_T] ? CellData.STATE.Proliferative : CellData.STATE.Nonproliferative;
        }

        public static int[] Run6(List<CellData> cells, int[] ind)
        {
            int[] result = new int[ind.Length];
            for (int i = 0; i < ind.Length; i++)
            {
                result[i] = Run6(cells, ind[i]);
            }
            return result;
        }
        private static int Run6(List<CellData> cells, int index)
        {
            CellData c = CellData.Find(cells, index);
            if (Common.IsDeadCell(c)) { return -1; }
            if (flag[c.Cell_T])
            {
                if (c.Time_age >= 0 && !double.IsInfinity(c.Time_d))
                {
                    bool f = true;
                    Delta d = SearchUnitCube6(cells, c, out bool isDetatched_cs);
                    if (d != null)
                    {
                        if (c.Cell_S == CellData.STATE.Proliferative ||
                            c.Cell_S == CellData.STATE.Quiescent)
                        {
                            c.Cell_S = CellData.STATE.Proliferative;
                            if (c.Time_d <= 0)
                            {
                                if (CellPushOut(cells, index, d))
                                {
                                    CellData cp = SetDaughterCell(cells, index, d);
                                    PassiveMovement(c, d);
                                    CellDataRenewal(cells, index);
                                    Differentiation(c, cp, d, isDetatched_cs);
                                    return cp.Index;
                                }
                            }
                            f = false;
                        }
                    }
                    else if (c.Cell_S == CellData.STATE.Proliferative)
                    {
                        c.Cell_S = CellData.STATE.Quiescent;
                    }
                    if (f)
                    {
                        c.Time_d += CultureTime.Time_step;
                    }
                }
            }
            return -1;
        }
        private static Delta SearchUnitCube6(List<CellData> cells, CellData c, out bool isDetatched_cs)
        {
            if (N_c[c.Cell_T] > 0)
            {
                isDetatched_cs = Common.IsDetatched_cs(c);
                if (isDetatched_cs)
                {
                    bool flag;
                    List<(Delta, int)> NcReg;
                    for (int i = 1; true; i++)
                    {
                        NcReg = SearchNcRegion_3D(c.Location, i);
                        flag = NcReg.Count > 0;
                        if (N_c[c.Cell_T] <= i || flag) { break; }
                    }
                    return flag ? Common.RandomDirection(NcReg) : null;
                }
                else
                {
                    bool flag;
                    List<(Delta, int)> NcReg;
                    for (int i = 1; true; i++)
                    {
                        NcReg = SearchNcRegion_2D(c.Location, i);
                        flag = NcReg.Count > 0;
                        if (N_c[c.Cell_T] <= i || flag) { break; }
                    }
                    if (flag)
                    {
                        return Pr_q[c.Cell_T] > Common.Rand_NextDouble() && Pr_q[c.Cell_T] > 0
                            ? VerticalDivision5(cells, c)
                            : Common.RandomDirection(NcReg);
                    }
                    else if (Pr_q[c.Cell_T] > 0)
                    {
                        return VerticalDivision5(cells, c);
                    }
                    else
                    { return null; }
                }
            }
            else
            {
                isDetatched_cs = false;
                return null;
            }
        }
        private static void Differentiation(CellData c, CellData cp, Delta d, bool isDetatched_cs)
        {
            Differentiation_Basal_AsyncDivision.Run0(c, !isDetatched_cs && d.DZ > 0);
            Differentiation_Basal_Decay.Run0(cp, !isDetatched_cs && d.DZ > 0);
        }
        private static Delta VerticalDivision5(List<CellData> cells, CellData c)
        {
            List<(Delta, int)> NcReg = new List<(Delta, int)>();
            if (CultureSpace.GetMap(c.Location, Delta.GetDelta(Direction.DIR.C_2)) == -1)
            {
                return Delta.GetDelta(Direction.DIR.C_2);
            }
            for (int dir = 0; dir < 7; dir++)
            {
                Delta d = Delta.GetDelta(dir);
                int val = CultureSpace.GetMap(c.Location, d);
                if (val == -1)
                {
                    NcReg.Add((d, Common.Omega[dir]));
                }
            }
            if (NcReg.Count > 0)
            {
                return Common.RandomDirection(NcReg);
            }
            return EffectOfCellMigrationOnVerticalDivision5(cells, c);
        }
        private static Delta EffectOfCellMigrationOnVerticalDivision5(List<CellData> cells, CellData c)
        {
            if (Migration.Get_flag(c.Cell_T))
            {
                for (int dir = 0; dir < 20; dir++)
                {
                    int val = CultureSpace.GetMap(c.Location, Delta.GetDelta(dir));
                    if (val >= -1)
                    {
                        if (Migration.IsMigratable(cells, c, dir))
                        {
                            return Z_direction5(c.Location);
                        }
                    }
                }
                return null;
            }
            else
            {
                return Z_direction5(c.Location);
            }
        }
        private static Delta Z_direction5(Point3D location)
        {
            int size = CultureSpace.Zsize - 1 - location.Z;
            List<(Delta, int)> NcReg;
            for (int i = 2; i < size; i++)
            {
                NcReg = SearchNcRegion_hemisphere(location, i);
                if (NcReg.Count > 0)
                {
                    return Common.RandomDirection(NcReg);
                }
            }
            return null;
        }
        private static List<(Delta, int)> SearchNcRegion_hemisphere(Point3D location, int N)
        {
            int z = location.Z; int y = location.Y; int x = location.X;
            List<(Delta, int)> NcReg = new List<(Delta, int)>();
            if (N < 4)
            {
                int n = (int)(N / Delta.Cf_y);
                for (int k = z + 1; k <= z + N; k++)
                {
                    for (int j = y - n; j <= y + n; j++)
                    {
                        for (int i = x - N * 2; i <= x + N * 2; i += 2)
                        {
                            int ii = (j - y) % 2 == 0 ? i : i + 1;
                            Delta d = new Delta(ii - x, j - y, k - z);
                            double len = Delta.GetLength(d);
                            if (len <= N && len > N - 1)
                            {
                                Point3D p = BoundaryConditions.Check(ii, j, k);
                                if (CultureSpace.GetMap(p) == -1)
                                {
                                    NcReg.Add((d, 1));
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                int n = (int)(N / Delta.Cf_y);
                List<(Delta, int)>[] ds = new List<(Delta, int)>[N];
                Parallel.For(z + 1, z + N + 1, k =>
                {
                    ds[k - (z + 1)] = new List<(Delta, int)>();
                    for (int j = y - n; j <= y + n; j++)
                    {
                        for (int i = x - N * 2; i <= x + N * 2; i += 2)
                        {
                            int ii = (j - y) % 2 == 0 ? i : i + 1;
                            Delta d = new Delta(ii - x, j - y, k - z);
                            double len = Delta.GetLength(d);
                            if (len <= N && len > N - 1)
                            {
                                Point3D p = BoundaryConditions.Check(ii, j, k);
                                if (CultureSpace.GetMap(p) == -1)
                                {
                                    ds[k - (z + 1)].Add((d, 1));
                                }
                            }
                        }
                    }
                });
                for (int i = 0; i < ds.Length; i++)
                { NcReg.AddRange(ds[i]); }
            }
            return NcReg;
        }

        private static List<(Delta, int)> SearchNcRegion_3D(Point3D location, int N)
        {
            int z = location.Z; int y = location.Y; int x = location.X;
            List<(Delta, int)> NcReg = new List<(Delta, int)>();
            if (N == 1)
            {
                for (int i = 0; i < 20; i++)
                {
                    Delta d = Delta.GetDelta(i);
                    int mval = CultureSpace.GetMap(location, d);
                    if (mval == -1)
                    {
                        NcReg.Add((d, Common.Omega[i]));
                    }
                }
            }
            else if (N < 4)
            {
                int n = (int)(N / Delta.Cf_y);
                for (int k = z - N; k <= z + N; k++)
                {
                    for (int j = y - n; j <= y + n; j++)
                    {
                        for (int i = x - N * 2; i <= x + N * 2; i += 2)
                        {
                            int ii = (j - y) % 2 == 0 ? i : i + 1;
                            Delta d = new Delta(ii - x, j - y, k - z);
                            double len = Delta.GetLength(d);
                            if (len <= N && len > N - 1)
                            {
                                Point3D p = BoundaryConditions.Check(ii, j, k);
                                if (CultureSpace.GetMap(p) == -1)
                                {
                                    NcReg.Add((d, 1));
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                int n = (int)(N / Delta.Cf_y);
                List<(Delta, int)>[] ds = new List<(Delta, int)>[2 * N + 1];
                Parallel.For(z - N, z + N + 1, k =>
                {
                    ds[k - (z - N)] = new List<(Delta, int)>();
                    for (int j = y - n; j <= y + n; j++)
                    {
                        for (int i = x - N * 2; i <= x + N * 2; i += 2)
                        {
                            int ii = (j - y) % 2 == 0 ? i : i + 1;
                            Delta d = new Delta(ii - x, j - y, k - z);
                            double len = Delta.GetLength(d);
                            if (len <= N && len > N - 1)
                            {
                                Point3D p = BoundaryConditions.Check(ii, j, k);
                                if (CultureSpace.GetMap(p) == -1)
                                {
                                    ds[k - (z - N)].Add((d, 1));
                                }
                            }
                        }
                    }
                });
                for (int i = 0; i < ds.Length; i++)
                { NcReg.AddRange(ds[i]); }
            }
            return NcReg;
        }
        private static List<(Delta, int)> SearchNcRegion_2D(Point3D location, int N)
        {
            int y = location.Y; int x = location.X;
            List<(Delta, int)> NcReg = new List<(Delta, int)>();
            if (N == 1)
            {
                for (int i = 7; i < 13; i++)
                {
                    Delta d = Delta.GetDelta(i);
                    int mval = CultureSpace.GetMap(location, d);
                    if (mval == -1)
                    {
                        NcReg.Add((d, Common.Omega[i]));
                    }
                }
            }
            else if (N < 5)
            {
                int n = (int)(N / Delta.Cf_y);
                for (int j = y - n; j <= y + n; j++)
                {
                    for (int i = x - N * 2; i <= x + N * 2; i += 2)
                    {
                        int ii = (j - y) % 2 == 0 ? i : i + 1;
                        Delta d = new Delta(ii - x, j - y, 0);
                        double len = Delta.GetLength(d);
                        if (len <= N && len > N - 1)
                        {
                            Point3D p = BoundaryConditions.Check(ii, j, 1);
                            if (CultureSpace.GetMap(p) == -1)
                            {
                                NcReg.Add((d, 1));
                            }
                        }
                    }
                }
            }
            else
            {
                int n = (int)(N / Delta.Cf_y);
                List<(Delta, int)>[] ds = new List<(Delta, int)>[2 * n + 1];
                Parallel.For(y - n, y + n + 1, j =>
                {
                    ds[j - (y - n)] = new List<(Delta, int)>();
                    for (int i = x - N * 2; i <= x + N * 2; i += 2)
                    {
                        int ii = (j - y) % 2 == 0 ? i : i + 1;
                        Delta d = new Delta(ii - x, j - y, 0);
                        double len = Delta.GetLength(d);
                        if (len <= N && len > N - 1)
                        {
                            Point3D p = BoundaryConditions.Check(ii, j, 1);
                            if (CultureSpace.GetMap(p) == -1)
                            {
                                ds[j - (y - n)].Add((d, 1));
                            }
                        }
                    }
                });
                for (int i = 0; i < ds.Length; i++)
                { NcReg.AddRange(ds[i]); }
            }
            return NcReg;
        }
        private static bool CellPushOut(List<CellData> cells, int index, Delta d)
        {
            CellData c = CellData.Find(cells, index);
            Delta d_ori = Delta.Copy(d);

            while (true)
            {
                int dir = ExtrusionDirection(d, d_ori, c.Location, out int val);
                if (dir == -1)
                {
                    MessageBox.Show("ERROR: Division: CellPushOut | Infinite loop | Can't get out of an infinite loop.");
                    return false;
                }
                Delta dout = -Delta.GetDelta(dir);
                Delta drenew = d - dout;
                if (Delta.GetLength_pow2(drenew) == 0)
                { return true; }
                if (val >= 0)
                {
                    Delta.Copy(drenew, d);
                    CellData c2 = CellData.Find(cells, val);
                    Common.CellReplacement(cells, c2, dout);
                    PassiveMovement(c2, dout);
                }
                else if (val == -1)
                {
                    Delta.Copy(drenew, d);
                    if (Direction.GetDirection(dout) == Direction.DIR.C_1)
                    {
                        MessageBox.Show("ERROR: Division: CellPushOut | Infinite loop | Can't get out of an infinite loop with an empty unit cube.");
                        return false;
                    }
                }
                else
                {
                    using (System.IO.BinaryWriter bw = new System.IO.BinaryWriter(System.IO.File.OpenWrite("ERROR_Division_CellPushOut.raw")))
                    {
                        for (int k = 0; k < CultureSpace.Zsize; k++)
                        {
                            for (int j = 0; j < CultureSpace.Ysize; j++)
                            {
                                for (int i = 0; i < CultureSpace.Xsize; i++)
                                {
                                    if (j % 2 == 0)
                                    {
                                        bw.Write(CultureSpace.GetMap(i * 2, j, k));
                                        bw.Write(CultureSpace.GetMap(i * 2, j, k));
                                    }
                                    else
                                    {
                                        bw.Write(CultureSpace.GetMap(i * 2 - 1, j, k));
                                        bw.Write(CultureSpace.GetMap(i * 2, j, k));
                                    }
                                }
                            }
                        }
                    }
                    MessageBox.Show(string.Format("ERROR: Division: CellPushOut | The cell {0} is about to push out the wall or substrate unit cube.", index));
                    return false;
                }
            }
        }
        private static int ExtrusionDirection(Delta d, Delta d_ori, Point3D point, out int val)
        {
            double d_dist = Delta.GetLength_pow2(d);
            int dir = -1;
            double minLen = double.MaxValue;
            val = int.MinValue;

            int iMin = 7; int iMax = 13;
            if (d.DZ < 0) { iMin = 0; }
            else if (d.DZ > 0) { iMax = 20; }

            for (int i = iMin; i < iMax; i++)
            {
                Delta d2 = d + Delta.GetDelta(i);
                Point3D p = point + d2;
                int _val = CultureSpace.GetMap(p);
                if (_val >= -1)
                {
                    double d2_dist = Delta.GetLength_pow2(d2);
                    if (d_dist > d2_dist)
                    {
                        double len = Delta.DistanceFromPointToLine(d_ori, d2);
                        if (minLen > len ||
                            minLen == len && Common.Rand_NextDouble() > 0.5)
                        {
                            minLen = len;
                            dir = i;
                            val = _val;
                        }
                    }
                }
            }
            return dir;
        }
        private static CellData SetDaughterCell(List<CellData> cells, int index, Delta d)
        {
            CellData c = CellData.Find(cells, index);
            CellData cp = c.Clone();
            cp.Index = cells.Count;
            cells.Add(cp);
            CultureSpace.SetMap(cp.Location, cp.Index);
            c.Location = c.Location + d;
            CultureSpace.SetMap(c.Location, index);

            return cp;
        }
        private static void PassiveMovement(CellData c, Delta d)
        {
            c.Dir_pd.Add(Direction.GetDirection(d));
        }
        private static void CellDataRenewal(List<CellData> cells, int index)
        {
            CellData c = CellData.Find(cells, index);
            int mInd = cells.Count - 1;
            cells[mInd].Cell_N.Add(index);
            cells[mInd].Time_d = Get_Fluc_t_g(c.Cell_T);
            cells[mInd].Time_age = 0;
            cells[mInd].THETA = new int[20];
            c.Cell_N.Add(index);
            c.Time_d = Get_Fluc_t_g(c.Cell_T);
            c.Time_age = 0;
            c.THETA = new int[20];
        }
    }
}
