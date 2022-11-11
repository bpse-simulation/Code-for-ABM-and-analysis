using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellBehaviorSimulator.CultureEnvironments
{
    public partial class Connectability : UserControl
    {
        public Connectability()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void Connectability_Load(object sender, EventArgs e)
        {
            comboBoxLAMBDA.SelectedIndex = 1;
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLAMBDA.SelectedIndex == 0)
            {
                LAMBDA = 1.0;
                LAMBDA2 = 1;
            }
            else if (comboBoxLAMBDA.SelectedIndex == 1)
            {
                LAMBDA = Math.Sqrt(2.0); // √2
                LAMBDA2 = 2;
            }
            else if (comboBoxLAMBDA.SelectedIndex == 2)
            {
                LAMBDA = Math.Sqrt(3.0); // √3
                LAMBDA2 = 3;
            }
        }
        #endregion
        #region Parameter setting
        internal void SetParameter()
        {
            comboBoxLAMBDA.SelectedIndex = LAMBDA2 - 1;
        }
        #endregion
        #region Parameter definitions
        public static void WriteParameter(System.IO.StreamWriter sw)
        {
            sw.WriteLine(":,LAMBDA2," + LAMBDA2 + ",# LAMBDA2 = LAMBDA^2 / l_c");
        }
        public static bool ReadParameter(string strName, string strValue)
        {
            return strName == "LAMBDA2" ? SetParameter_LAMBDA2(strValue) : false;
        }
        public static void ClearParameter()
        {
            LAMBDA = Math.Sqrt(2.0); // √2
            LAMBDA2 = 2;
        }
        private static bool SetParameter_LAMBDA2(string strVal)
        {
            if (int.TryParse(strVal, out int val))
            {
                LAMBDA2 = val;
                return true;
            }
            return false;
        }
        #endregion

        internal static double LAMBDA { get; private set; }
        internal static int LAMBDA2 { get; private set; }
    }
}
