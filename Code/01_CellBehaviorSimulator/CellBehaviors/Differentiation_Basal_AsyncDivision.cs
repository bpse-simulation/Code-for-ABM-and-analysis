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
    public partial class Differentiation_Basal_AsyncDivision : UserControl
    {
        public Differentiation_Basal_AsyncDivision()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void Differentiation_Basal_AsyncDivision_Load(object sender, EventArgs e)
        {
            flag = new List<bool>() { checkModuleAvailable.Checked };
            cell_T_dif = new List<int>() { (int)num_CellType.Value };
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

        private void Num_CellType_ValueChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            { cell_T_dif[Behaviors.Cell_T] = (int)num_CellType.Value; }
        }

        private void Differentiation_Basal_AsyncDivision_VisibleChanged(object sender, EventArgs e)
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
                num_CellType.Value = cell_T_dif[Behaviors.Cell_T];
            }
        }
        internal void ParamAdd()
        {
            flag.Add(checkModuleAvailable.Checked);
            cell_T_dif.Add(Behaviors.Maximum);
        }
        internal void ParamRemoveAt(int index)
        {
            flag.RemoveAt(index);
            cell_T_dif.RemoveAt(index);
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
                cell_T_dif[cellT] = (int)num_CellType.Value;
            }
        }
        #endregion
        public const string Str_C_T_dif = "C_T_dif&Basal_AsyncDivision";
        #region s
        public static void WriteParameter(System.IO.StreamWriter sw, int i)
        {
            if (flag[i])
            {
                sw.WriteLine(":," + Str_C_T_dif + "(" + i + ")," + cell_T_dif[i]);
            }
        }
        public static bool ReadParameter(string strName, int typeNum, string strValue)
        {
            switch (strName)
            {
                case Str_C_T_dif:
                    return SetParameter_C_T_dif(typeNum, strValue);
                default: return false;
            }
        }
        public static void AdjustParameter()
        {
            if (flag == null)
            { flag = new List<bool>(); }
            while (flag.Count < Behaviors.Maximum)
            { flag.Add(false); }
            if (cell_T_dif == null)
            { cell_T_dif = new List<int>(); }
            while (cell_T_dif.Count < Behaviors.Maximum)
            { cell_T_dif.Add(0); }
        }
        public static void ClearParameter()
        {
            if (flag != null)
            {
                flag.Clear();
                cell_T_dif.Clear();
            }
        }
        public static bool SetParameter_C_T_dif(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, flag, 0, cell_T_dif);
            if (int.TryParse(strVal, out int val))
            {
                 cell_T_dif[typeNum] = val;
                flag[typeNum] = true;
                return true;
            }
            return false;
        }
        #endregion

        private static List<bool> flag;
        private static List<int> cell_T_dif;

        public static void Run0(CellData c, bool verticaldivision)
        {
            if (verticaldivision)
            {
                if (flag[c.Cell_T])
                {
                    bool v = c.Cell_S == CellData.STATE.Proliferative || c.Cell_S == CellData.STATE.Quiescent;
                    if (c.Time_age >= 0 && v)
                    {
                        if (c.Cell_T != cell_T_dif[c.Cell_T])
                        {
                            Point3D p = c.Location + new Delta(0, 0, -1);
                            int val = CultureSpace.GetMap(p);
                            if (!(val == -3 && BasicConnectionEnergy.GetEcs(c) > 0))
                            {
                                CellDataRenewal(c);
                            }
                        }
                    }
                }
            }
        }

        private static void CellDataRenewal(CellData c)
        {
            c.Cell_T = (sbyte)cell_T_dif[c.Cell_T];
            c.Cell_S = CellData.STATE.Nonproliferative;
            BasicConnectionEnergy.Initialize(c);

            c.Time_d = double.PositiveInfinity;
            c.Time_m = CellData.InitializeTime_m_c(c.Cell_T);
        }
    }
}
