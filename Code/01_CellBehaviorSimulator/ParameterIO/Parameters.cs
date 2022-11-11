using System;
using System.Windows.Forms;

namespace CellBehaviorSimulator.ParameterIO
{
    public partial class Parameters : UserControl
    {
        public Parameters()
        {
            InitializeComponent();
        }

        public void SetMainForm(MainForm value) => mForm = value;
        private MainForm mForm;

        private void Parameters_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < tabControl1.TabCount; i++)
            {
                tabControl1.SelectedIndex = i;
            }
            tabControl1.SelectedIndex = 0;
        }

        public void SetParameter()
        {
            tabControl1.SelectedIndex = 0;
            environment1.SetParameter();
            tabControl1.SelectedIndex = 1;
            behavior1.SetParameter();
            tabControl1.SelectedIndex = 2;
            operation1.SetParameter();
            tabControl1.SelectedIndex = 3;
            output1.SetParameter();
        }
        public void Display_DrawImage()
        { display1.DrawImage(); }

        public void Display_AutoReload()
        { display1.AutoReload(); }

        public int TabControl_SelectedIndex
        {
            get => tabControl1.SelectedIndex;
            set => tabControl1.SelectedIndex = value;
        }
        public int TabControl_TabCount => tabControl1.TabCount;
        public bool Parameters_Enabled
        {
            set
            {
                environment1.Enabled = value;
                behavior1.Enabled = value;
                operation1.Enabled = value;
                output1.Enabled = value;
            }
        }

        public void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FindForm() == mForm)
            {
                if (tabControl1.SelectedIndex < tabControl1.TabCount - 2)
                { mForm.StartButton = "Next"; }
                else
                { mForm.StartButton = "Start"; }
            }
        }
    }
}
