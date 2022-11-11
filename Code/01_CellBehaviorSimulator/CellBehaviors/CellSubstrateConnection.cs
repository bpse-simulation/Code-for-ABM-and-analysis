using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using CellBehaviorSimulator.CultureEnvironments;

namespace CellBehaviorSimulator.CellBehaviors
{
    public partial class CellSubstrateConnection : UserControl
    {
        public CellSubstrateConnection()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void Connection_Load(object sender, EventArgs e)
        {
            flag = new List<bool>() { checkModuleAvailable.Checked };
            k_cs = new List<double>() { (double)num_k_cs.Value };
            u_cs = new List<double>() { (double)num_u_cs.Value };
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
        private void Num_k_cs_ValueChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            { k_cs[Behaviors.Cell_T] = (double)num_k_cs.Value; }
        }
        private void Num_u_cs_ValueChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            { u_cs[Behaviors.Cell_T] = (double)num_u_cs.Value; }
        }
        private void CellSubstrateConnection_VisibleChanged(object sender, EventArgs e)
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
                num_k_cs.Value = (decimal)k_cs[Behaviors.Cell_T];
                num_u_cs.Value = (decimal)u_cs[Behaviors.Cell_T];
            }
        }
        internal void ParamAdd()
        {
            flag.Add(checkModuleAvailable.Checked);
            k_cs.Add((double)num_k_cs.Value);
            u_cs.Add((double)num_u_cs.Value);
        }
        internal void ParamRemoveAt(int index)
        {
            flag.RemoveAt(index);
            k_cs.RemoveAt(index);
            u_cs.RemoveAt(index);
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
                k_cs[cellT] = (double)num_k_cs.Value;
                u_cs[cellT] = (double)num_u_cs.Value;
            }
        }
        #endregion
        public const string Str_k_cs = "k_cs";
        public const string Str_u_cs = "u_cs";
        #region Parameter definitions
        public static void WriteParameter(System.IO.StreamWriter sw, int i)
        {
            if (flag[i])
            {
                sw.WriteLine(":," + Str_k_cs + "(" + i + ")," + k_cs[i] + ",ng um^2 h^(-3)");
                sw.WriteLine(":," + Str_u_cs + "(" + i + ")," + u_cs[i] + ",ng um^2 h^(-3)");
            }
        }
        public static bool ReadParameter(string strName, int typeNum, string strValue)
        {
            switch (strName)
            {
                case Str_k_cs:
                    return SetParameter_k_cs(typeNum, strValue);
                case Str_u_cs:
                    return SetParameter_u_cs(typeNum, strValue);
                default: return false;
            }
        }
        public static void AdjustParameter()
        {
            if (flag == null)
            { flag = new List<bool>(); }
            while (flag.Count < Behaviors.Maximum)
            { flag.Add(false); }
            if (k_cs == null)
            { k_cs = new List<double>(); }
            while (k_cs.Count < Behaviors.Maximum)
            { k_cs.Add(0); }
            if (u_cs == null)
            { u_cs = new List<double>(); }
            while (u_cs.Count < Behaviors.Maximum)
            { u_cs.Add(0); }
        }
        public static void ClearParameter()
        {
            if (flag != null)
            {
                flag.Clear();
                k_cs.Clear();
                u_cs.Clear();
            }
        }
        public static bool SetParameter_k_cs(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, flag, 0, k_cs);
            if (double.TryParse(strVal, out double val))
            {
                k_cs[typeNum] = val;
                flag[typeNum] = true;
                return true;
            }
            return false;
        }
        public static bool SetParameter_u_cs(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, flag, 0, u_cs);
            if (double.TryParse(strVal, out double val))
            {
                u_cs[typeNum] = val;
                flag[typeNum] = true;
                return true;
            }
            return false;
        }
        #endregion

        private static List<bool> flag;
        private static List<double> k_cs;
        private static List<double> u_cs;

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
                    if (flag[c.Cell_T])
                    {
                        Run_CS(c);
                    }
                }
            }
        }

        private static void Run_CS(CellData c)
        {
            sbyte type = c.Cell_T;

            switch (c.Cell_S)
            {
                case CellData.STATE.Proliferative:
                    double tmp = c.E_cs + c.V_m * u_cs[type] * CultureTime.Time_step;
                    c.E_cs = Math.Max(0, tmp);
                    break;
                case CellData.STATE.Quiescent:
                    tmp = c.E_cs + (c.V_m * u_cs[type] - k_cs[type]) * CultureTime.Time_step;
                    c.E_cs = Math.Max(0, tmp);
                    break;
                default:
                    break;
            }
        }
    }
}
