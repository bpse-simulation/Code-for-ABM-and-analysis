using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CellBehaviorSimulator.CellBehaviors
{
    public partial class AfterSeeding : UserControl
    {
        public AfterSeeding()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void JustAfterSeeding_Load(object sender, EventArgs e)
        {
            flag = new List<bool>() { checkModuleAvailable.Checked };
            alpha = new List<double>() { (double)numAdherentRatio.Value };
            tau_a = new List<double>() { (double)numTimeConstant.Value };
            t_lag = new List<double>() { (double)numLagTime.Value };
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
        private void NumAdherentRatio_ValueChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            { alpha[Behaviors.Cell_T] = (double)numAdherentRatio.Value; }
        }
        private void NumTimeConstant_ValueChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            { tau_a[Behaviors.Cell_T] = (double)numTimeConstant.Value; }
        }
        private void NumLagTime_ValueChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            { t_lag[Behaviors.Cell_T] = (double)numLagTime.Value; }
        }
        private void JustAfterSeeding_VisibleChanged(object sender, EventArgs e)
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
                numAdherentRatio.Value = (decimal)alpha[Behaviors.Cell_T];
                numTimeConstant.Value = (decimal)tau_a[Behaviors.Cell_T];
                numLagTime.Value = (decimal)t_lag[Behaviors.Cell_T];
            }
        }
        internal void ParamAdd()
        {
            flag.Add(checkModuleAvailable.Checked);
            alpha.Add((double)numAdherentRatio.Value);
            tau_a.Add((double)numTimeConstant.Value);
            t_lag.Add((double)numLagTime.Value);
        }
        internal void ParamRemoveAt(int index)
        {
            flag.RemoveAt(index);
            alpha.RemoveAt(index);
            tau_a.RemoveAt(index);
            t_lag.RemoveAt(index);
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
                alpha[cellT] = (double)numAdherentRatio.Value;
                tau_a[cellT] = (double)numTimeConstant.Value;
                t_lag[cellT] = (double)numLagTime.Value;
            }
        }
        #endregion
        public const string Str_alpha = "alpha";
        public const string Str_tau_a = "tau_a";
        public const string Str_t_lag = "t_lag";
        #region Parameter definitions
        public static void WriteParameter(System.IO.StreamWriter sw, int i)
        {
            if (flag[i])
            {
                sw.WriteLine(":," + Str_alpha + "(" + i + ")," + alpha[i]);
                sw.WriteLine(":," + Str_tau_a + "(" + i + ")," + tau_a[i] + ",h");
                sw.WriteLine(":," + Str_t_lag + "(" + i + ")," + t_lag[i] + ",h");
            }
        }
        public static bool ReadParameter(string strName, int typeNum, string strValue)
        {
            switch (strName)
            {
                case Str_alpha:
                    return SetParameter_alpha(typeNum, strValue);
                case Str_tau_a:
                    return SetParameter_tau_a(typeNum, strValue);
                case Str_t_lag:
                    return SetParameter_t_lag(typeNum, strValue);
                default: return false;
            }
        }
        public static void AdjustParameter()
        {
            if (flag == null)
            { flag = new List<bool>(); }
            while (flag.Count < Behaviors.Maximum)
            { flag.Add(false); }
            if (alpha == null)
            { alpha = new List<double>(); }
            while (alpha.Count < Behaviors.Maximum)
            { alpha.Add(1); }
            if (tau_a == null)
            { tau_a = new List<double>(); }
            while (tau_a.Count < Behaviors.Maximum)
            { tau_a.Add(0); }
            if (t_lag == null)
            { t_lag = new List<double>(); }
            while (t_lag.Count < Behaviors.Maximum)
            { t_lag.Add(0); }
        }
        public static void ClearParameter()
        {
            if (flag != null)
            {
                flag.Clear();
                alpha.Clear();
                tau_a.Clear();
                t_lag.Clear();
            }
        }
        public static bool SetParameter_alpha(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, flag, 1, alpha);
            if (double.TryParse(strVal, out double val))
            {
                alpha[typeNum] = val;
                flag[typeNum] = true;
                return true;
            }
            return false;
        }
        public static bool SetParameter_tau_a(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, flag, 0, tau_a);
            if (double.TryParse(strVal, out double val))
            {
                tau_a[typeNum] = val;
                flag[typeNum] = true;
                return true;
            }
            return false;
        }
        public static bool SetParameter_t_lag(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, flag, 0, t_lag);
            if (t_lag == null)
            {
                t_lag = new List<double>();
                flag = new List<bool>();
            }
            while (t_lag.Count <= typeNum)
            {
                t_lag.Add(0);
                if (t_lag.Count > flag.Count)
                {
                    flag.Add(false);
                }
            }
            if (double.TryParse(strVal, out double val))
            {
                t_lag[typeNum] = val;
                flag[typeNum] = true;
                return true;
            }
            return false;
        }
        #endregion

        private static List<bool> flag;
        private static List<double> alpha; // Adherent cell ratio
        private static List<double> tau_a; // Time constant for adhesion
        private static List<double> t_lag; // Duration of acclimation (lag time)

        internal static double Get_alpha(int Cell_T)
        {
            if (flag[Cell_T])
            { return alpha[Cell_T]; }
            else { return 1; }
        }
        internal static double Get_t_lag(int Cell_T)
        {
            if (flag[Cell_T])
            { return t_lag[Cell_T]; }
            else { return 0; }
        }
        internal static double Get_AdherentTime_Stochastic(int Cell_T)
        {
            if (flag[Cell_T])
            {
                double ta = -tau_a[Cell_T] * Math.Log(1.0 - Common.Rand_NextDouble());
                return ta == 0 ? double.Epsilon : ta;
            }
            else { return double.Epsilon; }
        }

    }
}
