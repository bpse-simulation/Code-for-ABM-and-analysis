using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellBehaviorSimulator.CellBehaviors
{
    public partial class BasicConnectionEnergyRate : UserControl
    {
        public BasicConnectionEnergyRate()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void ConnectionEnergy_Load(object sender, EventArgs e)
        {
            Ep_AJ0 = new List<double> { (double)num_EpAJ0.Value };
            Ep_TJ0 = new List<double> { (double)num_EpTJ0.Value };
            Ep_cs0 = new List<double> { (double)num_Epcs0.Value };
            Ep_AJ0_E = new List<double> { (double)num_EpAJ0_E.Value };
            Ep_TJ0_E = new List<double> { (double)num_EpTJ0_E.Value };
            Ep_cs0_E = new List<double> { (double)num_Epcs0_E.Value };
            Tau_TJ = new List<double> { (double)num_tauTJ.Value };
            CadType = new List<int> { (int)numCadType.Value };
        }
        private void Num_EpAJ0_ValueChanged(object sender, EventArgs e)
        {
            Ep_AJ0[Behaviors.Cell_T] = (double)num_EpAJ0.Value;
        }
        private void Num_EpTJ0_ValueChanged(object sender, EventArgs e)
        {
            Ep_TJ0[Behaviors.Cell_T] = (double)num_EpTJ0.Value;
        }
        private void Num_Epcs0_ValueChanged(object sender, EventArgs e)
        {
            Ep_cs0[Behaviors.Cell_T] = (double)num_Epcs0.Value;
        }
        private void Num_EpAJ0_E_ValueChanged(object sender, EventArgs e)
        {
            Ep_AJ0_E[Behaviors.Cell_T] = (double)num_EpAJ0_E.Value;
        }
        private void Num_EpTJ0_E_ValueChanged(object sender, EventArgs e)
        {
            Ep_TJ0_E[Behaviors.Cell_T] = (double)num_EpTJ0_E.Value;
        }
        private void Num_Epcs0_E_ValueChanged(object sender, EventArgs e)
        {
            Ep_cs0_E[Behaviors.Cell_T] = (double)num_Epcs0_E.Value;
        }
        private void Num_tauTJ_ValueChanged(object sender, EventArgs e)
        {
            Tau_TJ[Behaviors.Cell_T] = (double)num_tauTJ.Value;
        }
        private void NumCadType_ValueChanged(object sender, EventArgs e)
        {
            CadType[Behaviors.Cell_T] = (int)numCadType.Value;
        }
        #endregion
        #region Parameter setting
        internal void ParamChanged()
        {
            num_EpAJ0.Value = (decimal)Ep_AJ0[Behaviors.Cell_T];
            num_EpTJ0.Value = (decimal)Ep_TJ0[Behaviors.Cell_T];
            num_Epcs0.Value = (decimal)Ep_cs0[Behaviors.Cell_T];
            num_EpAJ0_E.Value = (decimal)Ep_AJ0_E[Behaviors.Cell_T];
            num_EpTJ0_E.Value = (decimal)Ep_TJ0_E[Behaviors.Cell_T];
            num_Epcs0_E.Value = (decimal)Ep_cs0_E[Behaviors.Cell_T];
            num_tauTJ.Value = (decimal)Tau_TJ[Behaviors.Cell_T];
            numCadType.Value = CadType[Behaviors.Cell_T];
        }
        internal void ParamAdd()
        {
            Ep_AJ0.Add((double)num_EpAJ0.Value);
            Ep_TJ0.Add((double)num_EpTJ0.Value);
            Ep_cs0.Add((double)num_Epcs0.Value);
            Ep_AJ0_E.Add((double)num_EpAJ0_E.Value);
            Ep_TJ0_E.Add((double)num_EpTJ0_E.Value);
            Ep_cs0_E.Add((double)num_Epcs0_E.Value);
            Tau_TJ.Add((double)num_tauTJ.Value);
            CadType.Add((int)numCadType.Value);
        }
        internal void ParamRemoveAt(int index)
        {
            Ep_AJ0.RemoveAt(index);
            Ep_TJ0.RemoveAt(index);
            Ep_cs0.RemoveAt(index);
            Ep_AJ0_E.RemoveAt(index);
            Ep_TJ0_E.RemoveAt(index);
            Ep_cs0_E.RemoveAt(index);
            Tau_TJ.RemoveAt(index);
            CadType.RemoveAt(index);
        }
        internal void RegisterParameters(int cellT)
        {
            Ep_AJ0[cellT] = (double)num_EpAJ0.Value;
            Ep_AJ0_E[cellT] = (double)num_EpAJ0_E.Value;
            Ep_TJ0[cellT] = (double)num_EpTJ0.Value;
            Ep_TJ0_E[cellT] = (double)num_EpTJ0_E.Value;
            Ep_cs0[cellT] = (double)num_Epcs0.Value;
            Ep_cs0_E[cellT] = (double)num_Epcs0_E.Value;
            Tau_TJ[cellT] = (double)num_tauTJ.Value;
            CadType[cellT] = (int)numCadType.Value;
        }
        #endregion
        #region Parameter definitions
        public static bool SetParameter_Ep_AJ0(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, 1, Ep_AJ0, Ep_AJ0_E);
            if (double.TryParse(strVal, out double val))
            {
                Ep_AJ0[typeNum] = val;
                Ep_AJ0_E[typeNum] = 0;
                return true;
            }
            return false;
        }
        public static bool SetParameter_Ep_TJ0(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, 1, Ep_TJ0, Ep_TJ0_E);
            if (double.TryParse(strVal, out double val))
            {
                Ep_TJ0[typeNum] = val;
                Ep_TJ0_E[typeNum] = 0;
                return true;
            }
            return false;
        }
        public static bool SetParameter_Ep_cs0(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, 1, Ep_cs0, Ep_cs0_E);
            if (double.TryParse(strVal, out double val))
            {
                Ep_cs0[typeNum] = val;
                Ep_cs0_E[typeNum] = 0;
                return true;
            }
            return false;
        }
        public static bool SetParameter_tau_TJ(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, 1.0, Tau_TJ);
            if (double.TryParse(strVal, out double val))
            {
                Tau_TJ[typeNum] = val;
                return true;
            }
            return false;
        }
        public static bool SetParameter_CadType(int typeNum, string strVal)
        {
            Common.InitializeParameter(typeNum, 0, CadType);
            if (int.TryParse(strVal, out int val))
            {
                CadType[typeNum] = val;
                return true;
            }
            return false;
        }
        #endregion

        protected static List<double> Ep_AJ0 { get; set; }
        protected static List<double> Ep_TJ0 { get; set; }
        protected static List<double> Ep_cs0 { get; set; }
        protected static List<double> Ep_AJ0_E { get; set; }
        protected static List<double> Ep_TJ0_E { get; set; }
        protected static List<double> Ep_cs0_E { get; set; }
        protected static List<double> Tau_TJ { get; set; }
        protected static List<int> CadType { get; set; }

    }
}
