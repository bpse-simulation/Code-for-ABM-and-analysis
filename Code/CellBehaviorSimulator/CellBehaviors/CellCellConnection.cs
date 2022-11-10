using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellBehaviorSimulator.CellBehaviors
{
    public partial class CellCellConnection : UserControl
    {
        public CellCellConnection()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void Connection_Load(object sender, EventArgs e)
        {
            flag = new List<bool>() { checkModuleAvailable.Checked };
            t_deg = new List<double>() {
                check_t_deg_Inf.Checked ? double.PositiveInfinity : (double)num_t_deg.Value
            };
            k_AJ = new List<double>() { (double)num_k_AJ.Value };
            u_AJ = new List<double>() { (double)num_u_AJ.Value };
            t_deg_Inf = new List<bool>() { check_t_deg_Inf.Checked }; 
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
        private void Num_t_deg_ValueChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            { t_deg[Behaviors.Cell_T] = (double)num_t_deg.Value; }
        }
        private void Num_k_AJ_ValueChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            { k_AJ[Behaviors.Cell_T] = (double)num_k_AJ.Value; }
        }
        private void Num_u_AJ_ValueChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            { u_AJ[Behaviors.Cell_T] = (double)num_u_AJ.Value; }
        }
        private void Check_t_deg_Inf_CheckedChanged(object sender, EventArgs e)
        {
            if (check_t_deg_Inf.Checked)
            {
                num_t_deg.Enabled = false;
                t_deg[Behaviors.Cell_T] = double.PositiveInfinity;
                t_deg_Inf[Behaviors.Cell_T] = check_t_deg_Inf.Checked;
            }
            else
            {
                num_t_deg.Enabled = true;
                t_deg[Behaviors.Cell_T] = (double)num_t_deg.Value;
                t_deg_Inf[Behaviors.Cell_T] = check_t_deg_Inf.Checked;
            }
        }
        private void CellCellConnection_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                checkModuleAvailable.Checked = false;
                for (int i = 0; i < flag.Count; i++)
                { flag[i] = false; }
            }
        }
        #endregion
        #region Paramter setting
        internal void ParamChanged()
        {
            checkModuleAvailable.Checked = flag[Behaviors.Cell_T];
            if (checkModuleAvailable.Checked)
            {
                if (double.IsPositiveInfinity(t_deg[Behaviors.Cell_T]))
                {
                    num_t_deg.Value = 0;
                    check_t_deg_Inf.Checked = true;
                }
                else
                {
                    num_t_deg.Value = (decimal)t_deg[Behaviors.Cell_T]; 
                    check_t_deg_Inf.Checked = t_deg_Inf[Behaviors.Cell_T];
                }
                num_k_AJ.Value = (decimal)k_AJ[Behaviors.Cell_T];
                num_u_AJ.Value = (decimal)u_AJ[Behaviors.Cell_T];
                check_t_deg_Inf.Checked = t_deg_Inf[Behaviors.Cell_T];
            }
        }

        internal void ParamAdd()
        {
            flag.Add(checkModuleAvailable.Checked);
            t_deg.Add((double)num_t_deg.Value);
            k_AJ.Add((double)num_k_AJ.Value);
            u_AJ.Add((double)num_u_AJ.Value);
            t_deg_Inf.Add(check_t_deg_Inf.Checked);
        }
        internal void ParamRemoveAt(int index)
        {
            flag.RemoveAt(index);
            t_deg.RemoveAt(index);
            k_AJ.RemoveAt(index);
            u_AJ.RemoveAt(index);
            t_deg_Inf.RemoveAt(index);
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
                t_deg[cellT] = (double)num_t_deg.Value;
                k_AJ[cellT] = (double)num_k_AJ.Value;
                u_AJ[cellT] = (double)num_u_AJ.Value;
                t_deg_Inf[cellT] = check_t_deg_Inf.Checked;
            }
        }
        #endregion
        public const string Str_t_deg = "t_deg";
        public const string Str_k_AJ = "k_AJ";
        public const string Str_u_AJ = "u_AJ";
        #region Parameter definitions
        public static void WriteParameter(System.IO.StreamWriter sw, int i)
        {
            if (flag[i])
            {
                if (double.IsInfinity(t_deg[i]))
                { sw.WriteLine(":," + Str_t_deg + "(" + i + "),Inf,h"); }
                else
                { sw.WriteLine(":," + Str_t_deg + "(" + i + ")," + t_deg[i] + ",h"); }
                sw.WriteLine(":," + Str_k_AJ + "(" + i + ")," + k_AJ[i] + ",ng um^2 h^(-3)");
                sw.WriteLine(":," + Str_u_AJ + "(" + i + ")," + u_AJ[i] + ",um^(-1)");
            }
        }
        public static bool ReadParameter(string strName, int typeNum, string strValue)
        {
            switch (strName)
            {
                case Str_t_deg:
                case "tau_L":
                case "tau_d":
                    return SetParameter_t_deg(typeNum, strValue);
                case Str_k_AJ:
                    return SetParameter_k_AJ(typeNum, strValue);
                case Str_u_AJ:
                    return SetParameter_u_AJ(typeNum, strValue);
                default: return false;
            }
        }
        public static void AdjustParameter()
        {
            if (flag == null)
            { flag = new List<bool>(); }
            while (flag.Count < Behaviors.Maximum)
            { flag.Add(false); }
            if (t_deg == null)
            { t_deg = new List<double>(); }
            while (t_deg.Count < Behaviors.Maximum)
            { t_deg.Add(double.PositiveInfinity); }
            if (k_AJ == null)
            { k_AJ = new List<double>(); }
            while (k_AJ.Count < Behaviors.Maximum)
            { k_AJ.Add(0); }
            if (u_AJ == null)
            { u_AJ = new List<double>(); }
            while (u_AJ.Count < Behaviors.Maximum)
            { u_AJ.Add(0); }
            if (t_deg_Inf == null)
            { t_deg_Inf = new List<bool>(); }
            while (t_deg_Inf.Count < Behaviors.Maximum)
            { t_deg_Inf.Add(false); }
        }
        public static void ClearParameter()
        {
            if (flag != null)
            {
                flag.Clear();
                t_deg.Clear();
                k_AJ.Clear();
                u_AJ.Clear();
                t_deg_Inf.Clear();
            }
        }
        public static bool SetParameter_t_deg(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, flag, double.PositiveInfinity, t_deg);
            Common.InitializeParameter(typeNum, flag, true, t_deg_Inf);
            if (double.TryParse(strVal, out double val))
            {
                t_deg[typeNum] = val;
                t_deg_Inf[typeNum] = double.IsPositiveInfinity(val);
                flag[typeNum] = true;
                return true;
            }
            else if (strVal == "Inf")
            {
                t_deg[typeNum] = double.PositiveInfinity;
                t_deg_Inf[typeNum] = true;
                flag[typeNum] = true;
                return true;
            }
            return false;
        }
        public static bool SetParameter_k_AJ(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, flag, 0, k_AJ);
            if (double.TryParse(strVal, out double val))
            {
                k_AJ[typeNum] = val;
                flag[typeNum] = true;
                return true;
            }
            return false;
        }
        public static bool SetParameter_u_AJ(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, flag, 0, u_AJ);
            if (double.TryParse(strVal, out double val))
            {
                u_AJ[typeNum] = val;
                flag[typeNum] = true;
                return true;
            }
            return false;
        }
        #endregion

        private static List<bool> flag;
        private static List<double> t_deg;
        private static List<double> k_AJ;
        private static List<double> u_AJ;
        private static List<bool> t_deg_Inf;

        public static void Run(List<CellData> cells, int[] ind)
        {
            Parallel.ForEach(ind, index =>
            {
                Run(cells, index);
            });
        }

        private static void Run(List<CellData> cells, int index)
        {
            CellData c = CellData.Find(cells, index);
            if (Common.IsDeadCell(c)) { return; }
            if (flag[c.Cell_T])
            {
                if (c.Time_age >= 0)
                {
                    Run_CC(c);
                }
            }
        }

        private static void Run_CC(CellData c)
        {
            sbyte type = c.Cell_T;
            if (!(c.Location.Z == 1 && BasicConnectionEnergy.GetEcs(c) > 0))
            {
                c.E_AJ = Calc_E2(BasicConnectionEnergy.E_AJ0[type], t_deg[type], c.E_AJ);
                c.E_TJ = Calc_E2(BasicConnectionEnergy.E_TJ0[type], t_deg[type], c.E_TJ);
            }
        }

        private static double Calc_E2(double E_max, double tau, double E_before)
        {
            if (double.IsPositiveInfinity(tau))
            { return E_max; }
            else
            {
                double E_after = E_before - E_max / tau * CultureEnvironments.CultureTime.Time_step;
                if (E_after <= 0) { E_after = 0; }
                return E_after;
            }
        }

    }
}
