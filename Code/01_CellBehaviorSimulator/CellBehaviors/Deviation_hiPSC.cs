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
    public partial class Deviation_hiPSC : UserControl
    {
        public Deviation_hiPSC()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void Deviation_hiPSC_Load(object sender, EventArgs e)
        {
            flag = new List<bool>() { checkModuleAvailable.Checked };
            C_T_dev_act_mig = new List<int>() { (int)num_CellType_devAct.Value };
            C_T_dev_app = new List<int>() { (int)num_CellType_devApparent.Value };
            V_dev_act_mig = new List<double>() { (double)num_V_de_act.Value };
            V_dev_app = new List<double>() { (double)num_V_de_app.Value };
            t_dev_crit_act_mig = new List<double>() { (double)num_t_de_crit_act.Value };
            t_dev_crit_app = new List<double>() { (double)num_t_de_crit_app.Value };
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
        private void Num_CellTypeAct_ValueChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            { C_T_dev_act_mig[Behaviors.Cell_T] = (int)num_CellType_devAct.Value; }
        }
        private void Num_CellTypeTotoal_ValueChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            { C_T_dev_app[Behaviors.Cell_T] = (int)num_CellType_devApparent.Value; }
        }
        private void Num_V_de_act_ValueChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            { V_dev_act_mig[Behaviors.Cell_T] = (double)num_V_de_act.Value; }
        }
        private void Num_V_de_total_ValueChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            { V_dev_app[Behaviors.Cell_T] = (double)num_V_de_app.Value; }
        }
        private void Num_t_de_crit_act_ValueChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            { t_dev_crit_act_mig[Behaviors.Cell_T] = (double)num_t_de_crit_act.Value; }
        }
        private void Num_t_de_crit_total_ValueChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            { t_dev_crit_app[Behaviors.Cell_T] = (double)num_t_de_crit_app.Value; }
        }
        private void Num_CellTypeMax_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                checkModuleAvailable.Checked = false;
                for (int i = 0; i < flag.Count; i++)
                { flag[i] = false; }
            }
        }
        private void Deviation_hiPSC_VisibleChanged(object sender, EventArgs e)
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
                num_CellType_devAct.Value = C_T_dev_act_mig[Behaviors.Cell_T];
                num_CellType_devApparent.Value = C_T_dev_app[Behaviors.Cell_T];
                num_V_de_act.Value = (decimal)V_dev_act_mig[Behaviors.Cell_T];
                num_V_de_app.Value = (decimal)V_dev_app[Behaviors.Cell_T];
                num_t_de_crit_act.Value = (decimal)t_dev_crit_act_mig[Behaviors.Cell_T];
                num_t_de_crit_app.Value = (decimal)t_dev_crit_app[Behaviors.Cell_T];
            }
        }
        internal void ParamAdd()
        {
            flag.Add(checkModuleAvailable.Checked);
            C_T_dev_act_mig.Add((int)num_CellType_devAct.Value);
            C_T_dev_app.Add((int)num_CellType_devApparent.Value);
            V_dev_act_mig.Add((double)num_V_de_act.Value);
            V_dev_app.Add((double)num_V_de_app.Value);
            t_dev_crit_act_mig.Add((double)num_t_de_crit_act.Value);
            t_dev_crit_app.Add((double)num_t_de_crit_app.Value);
        }
        internal void ParamRemoveAt(int index)
        {
            flag.RemoveAt(index);
            C_T_dev_act_mig.RemoveAt(index);
            C_T_dev_app.RemoveAt(index);
            V_dev_act_mig.RemoveAt(index);
            V_dev_app.RemoveAt(index);
            t_dev_crit_act_mig.RemoveAt(index);
            t_dev_crit_app.RemoveAt(index);
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
                C_T_dev_act_mig[cellT] = (int)num_CellType_devAct.Value;
                C_T_dev_app[cellT] = (int)num_CellType_devApparent.Value;
                V_dev_act_mig[cellT] = (double)num_V_de_act.Value;
                V_dev_app[cellT] = (double)num_V_de_app.Value;
                t_dev_crit_act_mig[cellT] = (double)num_t_de_crit_act.Value;
                t_dev_crit_app[cellT] = (double)num_t_de_crit_app.Value;
            }
        }
        #endregion
        public const string Str_C_T_dev_act = "C_T_dev_act_mig";
        public const string Str_C_T_dev_app = "C_T_dev_app";
        public const string Str_V_dev_act = "V_dev_act_mig";
        public const string Str_V_dev_app = "V_dev_app";
        public const string Str_t_dev_crit_act = "t_dev_crit_act_mig";
        public const string Str_t_dev_crit_app = "t_dev_crit_app";
        #region Parameter definitions
        public static void WriteParameter(System.IO.StreamWriter sw, int i)
        {
            if (flag[i])
            {
                sw.WriteLine(":," + Str_C_T_dev_act + "(" + i + ")," + C_T_dev_act_mig[i]);
                sw.WriteLine(":," + Str_C_T_dev_app + "(" + i + ")," + C_T_dev_app[i]);
                sw.WriteLine(":," + Str_V_dev_act + "(" + i + ")," + V_dev_act_mig[i] + ",um/h");
                sw.WriteLine(":," + Str_V_dev_app + "(" + i + ")," + V_dev_app[i] + ",um/h");
                sw.WriteLine(":," + Str_t_dev_crit_act + "(" + i + ")," + t_dev_crit_act_mig[i] + ",h");
                sw.WriteLine(":," + Str_t_dev_crit_app + "(" + i + ")," + t_dev_crit_app[i] + ",h");
            }
        }
        public static bool ReadParameter(string strName, int typeNum, string strValue)
        {
            switch (strName)
            {
                case Str_C_T_dev_act:
                case "C_T_dev_act":
                    return SetParameter_C_T_dev_act_mig(typeNum, strValue);
                case Str_C_T_dev_app:
                case "C_T_dev_total":
                    return SetParameter_C_T_dev_apparent(typeNum, strValue);
                case Str_V_dev_act:
                case "V_dev_act":
                    return SetParameter_V_de_act_mig(typeNum, strValue);
                case Str_V_dev_app:
                case "V_dev_total":
                    return SetParameter_V_de_apparent(typeNum, strValue);
                case Str_t_dev_crit_act:
                case "t_dev_crit_act":
                    return SetParameter_t_de_crit_act_mig(typeNum, strValue);
                case Str_t_dev_crit_app:
                case "t_dev_crit_total":
                    return SetParameter_t_de_crit_app(typeNum, strValue);
                default: return false;
            }
        }
        public static void AdjustParameter()
        {
            if (flag == null)
            { flag = new List<bool>(); }
            while (flag.Count < Behaviors.Maximum)
            { flag.Add(false); }

            if (C_T_dev_act_mig == null)
            { C_T_dev_act_mig = new List<int>(); }
            while (C_T_dev_act_mig.Count < Behaviors.Maximum)
            { C_T_dev_act_mig.Add(0); }
            if (C_T_dev_app == null)
            { C_T_dev_app = new List<int>(); }
            while (C_T_dev_app.Count < Behaviors.Maximum)
            { C_T_dev_app.Add(0); }

            if (V_dev_act_mig == null)
            { V_dev_act_mig = new List<double>(); }
            while (V_dev_act_mig.Count < Behaviors.Maximum)
            { V_dev_act_mig.Add(0); }
            if (V_dev_app == null)
            { V_dev_app = new List<double>(); }
            while (V_dev_app.Count < Behaviors.Maximum)
            { V_dev_app.Add(0); }

            if (t_dev_crit_act_mig == null)
            { t_dev_crit_act_mig = new List<double>(); }
            while (t_dev_crit_act_mig.Count < Behaviors.Maximum)
            { t_dev_crit_act_mig.Add(0); }
            if (t_dev_crit_app == null)
            { t_dev_crit_app = new List<double>(); }
            while (t_dev_crit_app.Count < Behaviors.Maximum)
            { t_dev_crit_app.Add(0); }
        }
        public static void ClearParameter()
        {
            if (flag != null)
            {
                flag.Clear();
                C_T_dev_act_mig.Clear();
                C_T_dev_app.Clear();
                V_dev_act_mig.Clear();
                V_dev_app.Clear();
                t_dev_crit_act_mig.Clear();
                t_dev_crit_app.Clear();
            }
        }
        public static bool SetParameter_C_T_dev_act_mig(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, flag, 0, C_T_dev_act_mig);
            if (int.TryParse(strVal, out int val))
            {
                C_T_dev_act_mig[typeNum] = val;
                flag[typeNum] = true;
                return true;
            }
            return false;
        }
        public static bool SetParameter_C_T_dev_apparent(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, flag, 0, C_T_dev_app);
            if (int.TryParse(strVal, out int val))
            {
                C_T_dev_app[typeNum] = val;
                flag[typeNum] = true;
                return true;
            }
            return false;
        }
        public static bool SetParameter_V_de_act_mig(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, flag, 0, V_dev_act_mig);
            if (double.TryParse(strVal, out double val))
            {
                V_dev_act_mig[typeNum] = val;
                flag[typeNum] = true;
                return true;
            }
            return false;
        }
        public static bool SetParameter_V_de_apparent(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, flag, 0, V_dev_app);
            if (double.TryParse(strVal, out double val))
            {
                V_dev_app[typeNum] = val;
                flag[typeNum] = true;
                return true;
            }
            return false;
        }
        public static bool SetParameter_t_de_crit_act_mig(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, flag, 0, t_dev_crit_act_mig);
            if (double.TryParse(strVal, out double val))
            {
                t_dev_crit_act_mig[typeNum] = val;
                flag[typeNum] = true;
                return true;
            }
            return false;
        }
        public static bool SetParameter_t_de_crit_app(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, flag, 0, t_dev_crit_app);
            if (double.TryParse(strVal, out double val))
            {
                t_dev_crit_app[typeNum] = val;
                flag[typeNum] = true;
                return true;
            }
            return false;
        }
        #endregion

        private static List<bool> flag;
        private static List<int> C_T_dev_act_mig;
        private static List<int> C_T_dev_app;
        private static List<double> V_dev_act_mig;
        private static List<double> V_dev_app;
        private static List<double> t_dev_crit_act_mig;
        private static List<double> t_dev_crit_app;

        public static bool Get_flag()
        {
            for (int i = 0; i < flag.Count; i++)
            {
                if (flag[i])
                { return true; }
            }
            return false;
        }

        internal static void Run(List<CellData> cells)
        {
            CellMovement.Run(cells);
            Parallel.For(0, cells.Count, index =>
            {
                CellData c = CellData.Find(cells, index);
                if (!Common.IsDeadCell(c))
                {
                    if (flag[c.Cell_T])
                    {
                        if (c.Time_age >= 0)
                        {
                            CellMovement vals = CellMovement.Renew(cells, index);
                            bool flagT = TimeDevApparent(c, vals);
                            bool flagA = TimeDevAct_mig(c, vals);
                            if (flagT & flagA)
                            {
                                if (0.5 < Common.Rand_NextDouble())
                                { flagT = false; }
                                else
                                { flagA = false; }
                            }
                            if (flagT)
                            { Run(c, C_T_dev_app[c.Cell_T]); }
                            else if (flagA)
                            { Run(c, C_T_dev_act_mig[c.Cell_T]); }
                        }
                    }
                }
            });
        }

        private static bool TimeDevAct_mig(CellData c, CellMovement vals)
        {
            if (flag[c.Cell_T] && c.Cell_T != C_T_dev_act_mig[c.Cell_T])
            {
                if (vals.Length_act_mig_c > 0)
                {
                    double Vact = vals.GetMovementRate_active_mig();
                    if (Vact > V_dev_act_mig[c.Cell_T])
                    {
                        c.Time_dev_act += vals.Time_act_mig_c;
                        if (c.Time_dev_act * CultureTime.Time_step >= t_dev_crit_act_mig[c.Cell_T])
                        { return true; }
                    }
                    else
                    { c.Time_dev_act = 0; }
                }
            }
            return false;
        }
        private static bool TimeDevApparent(CellData c, CellMovement vals)
        {
            if (flag[c.Cell_T] && c.Cell_T != C_T_dev_app[c.Cell_T])
            {
                if (vals.Length_apparent_c > 0)
                {
                    double Vapp = vals.GetMovementRate_apparent();
                    if (Vapp < V_dev_app[c.Cell_T])
                    {
                        c.Time_dev_total += vals.Time_apparent_c;
                        if (c.Time_dev_total * CultureTime.Time_step >= t_dev_crit_app[c.Cell_T])
                        { return true; }
                    }
                    else
                    { c.Time_dev_total = 0; }
                }
            }
            return false;
        }

        private static void Run(CellData c, int cellType)
        {
            c.Cell_T = (sbyte)cellType;
            BasicConnectionEnergy.Initialize(c);
            c.Time_d = Division.Get_t_g(cellType);
            c.Time_m = CellData.InitializeTime_m_c(cellType);
        }

    }
}
