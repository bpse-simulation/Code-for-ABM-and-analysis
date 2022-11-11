using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CellBehaviorSimulator.CellBehaviors
{
    public partial class AreaWeighting : UserControl
    {
        public AreaWeighting()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void AreaWeighting_Load(object sender, EventArgs e)
        {
            Flag = new List<bool>() { checkModuleAvailable.Checked };
            A_r = new List<double> { (double)numA_r.Value };
            if (!Flag[0]) { groupBox1.Enabled = false; }
        }
        private void CheckModuleAvailable_CheckedChanged(object sender, EventArgs e)
        {
            Flag[Behaviors.Cell_T] = checkModuleAvailable.Checked;
            if (checkModuleAvailable.Checked)
            {
                groupBox1.Enabled = true;
                ParamChanged();
            }
            else
            { groupBox1.Enabled = false; }
        }
        private void NumA_c_ValueChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            { A_r[Behaviors.Cell_T] = (double)numA_r.Value; }
        }
        private void AreaWeighting_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                checkModuleAvailable.Checked = false;
                for (int i = 0; i < Flag.Count; i++)
                { Flag[i] = false; }
            }
        }
        #endregion
        #region Parameter setting
        internal void ParamChanged()
        {
            checkModuleAvailable.Checked = Flag[Behaviors.Cell_T];
            if (checkModuleAvailable.Checked)
            { numA_r.Value = (decimal)A_r[Behaviors.Cell_T]; }
        }
        internal void ParamAdd()
        {
            Flag.Add(checkModuleAvailable.Checked);
            A_r.Add((double)numA_r.Value);
        }
        internal void ParamRemoveAt(int index)
        {
            Flag.RemoveAt(index);
            A_r.RemoveAt(index);
        }
        internal bool SetParameter()
        {
            ParamChanged();
            for (int i = 0; i < Behaviors.Maximum; i++)
            {
                if (Flag[i])
                {
                    return true;
                }
            }
            return false;
        }
        internal void RegisterParameters(int cellT)
        {
            Flag[cellT] = checkModuleAvailable.Checked;
            if (Flag[cellT])
            {
                A_r[cellT] = (double)numA_r.Value;
            }
        }
        #endregion
        public const string Str_A_r = "A_r";
        #region Parameter definitions
        public static void WriteParameter(System.IO.StreamWriter sw, int i)
        {
            if (Flag[i])
            {
                sw.WriteLine(":," + Str_A_r + "(" + i + ")," + A_r[i]);
            }
        }
        public static bool ReadParameter(string strName, int typeNum, string strValue)
        {
            switch (strName)
            {
                case Str_A_r:
                case "A_c":
                    return SetParameter_A_r(typeNum, strValue);
                default: return false;
            }
        }
        public static void AdjustParameter()
        {
            if (Flag == null) { Flag = new List<bool>(); }
            while (Flag.Count < Behaviors.Maximum)
            { Flag.Add(false); }
            if (A_r == null) { A_r = new List<double>(); }
            while (A_r.Count < Behaviors.Maximum)
            { A_r.Add(1); }
        }
        public static void ClearParameter()
        {
            if (Flag != null)
            {
                Flag.Clear();
                A_r.Clear();
            }
        }
        public static bool SetParameter_A_r(int typeNum, string strVal)
        {
            double defVal = 1;
            Common.InitializeParameter(typeNum, Flag, defVal, A_r);
            if (double.TryParse(strVal, out double val))
            {
                A_r[typeNum] = val;
                Flag[typeNum] = true;
                return true;
            }
            return false;
        }
        #endregion

        public static List<bool> Flag { get; private set; }
        public static List<double> A_r { get; private set; }
    }
}
