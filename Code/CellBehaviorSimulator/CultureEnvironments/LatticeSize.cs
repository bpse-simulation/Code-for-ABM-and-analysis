using System;
using System.Windows.Forms;

namespace CellBehaviorSimulator.CultureEnvironments
{
    public partial class LatticeSize : UserControl
    {
        public LatticeSize()
        {
            InitializeComponent();
        }

        internal static double Size_lc { get; private set; }
        internal static double Size_hc { get; private set; }

        private void LatticeSize_Load(object sender, EventArgs e)
        {
            Size_lc = (double)num_lc.Value;
            Size_hc = (double)num_hc.Value;
        }
    }
}
