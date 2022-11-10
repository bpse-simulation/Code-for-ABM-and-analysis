using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using CellBehaviorSimulator.CellBehaviors;
using CellBehaviorSimulator.CultureOperations;

namespace CellBehaviorSimulator
{
    public partial class ParameterFileCreator : Form
    {
        public ParameterFileCreator()
        {
            InitializeComponent();
        }

        private static ParameterFileCreator _instance;
        public static ParameterFileCreator Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                { _instance = new ParameterFileCreator(); }
                return _instance;
            }
        }

        private string OutputDirectory;
        private List<int> Params;
        private List<int> CellType;
        private List<double> MaxVal;
        private List<double> MinVal;
        private List<double> Increment;
        private List<string> IncrementFormat;
        private List<bool> AllCellTypes;
        private int pMax = 1;
        private int pNum;

        private enum ParamName
        {
            Ep_AJ0,
            Ep_TJ0,
            Ep_cs0,
            tau_TJ,
            t_deg,
            k_AJ,
            u_AJ,
            k_cs,
            u_cs,
            alpha,
            tau_a,
            t_lag,
            t_g,
            N_c,
            Pr_q,
            V_m_free,
            m_c,
            p_dif,
            Colony_size,
        };

        #region EventHandler
        private void ParameterFileCreator_Load(object sender, EventArgs e)
        {
            numCell_T.Maximum = Behaviors.Maximum - 1;
            Params = new List<int>() { 0 };
            CellType = new List<int>() { (int)numCell_T.Value };
            MaxVal = new List<double>() { double.Parse(textValMin.Text) };
            MinVal = new List<double>() { double.Parse(textValMax.Text) };
            Increment = new List<double>() { double.Parse(textIncrement.Text) };
            IncrementFormat = new List<string>() { Digit(textIncrement.Text) };
            AllCellTypes = new List<bool>() { checkBoxAllCellTypes.Checked };
            string[] Names = Enum.GetNames(typeof(ParamName));
            for (int i = 0; i < Names.Length; i++)
            { comboBoxParam.Items.Add(Names[i]); }
            comboBoxParam.SelectedIndex = 0;
        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "initialize";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (InputParameter.ReadParameter(openFileDialog1.FileName))
                {
                    parameters1.SetParameter();
                }
            }
        }
        private void NumCell_T_Enter(object sender, EventArgs e)
        {
            numCell_T.Maximum = Behaviors.Maximum - 1;
        }
        private void ButtonOutDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxOutDir.Text = folderBrowserDialog1.SelectedPath;
                OutputDirectory = folderBrowserDialog1.SelectedPath;
            }
        }
        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Run();
        }
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ComboBoxParam_SelectedIndexChanged(object sender, EventArgs e)
        {
            Params[pNum] = comboBoxParam.SelectedIndex;
        }
        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            numT.Value = vScrollBar1.Value;
        }
        private void TextBoxOutDir_Leave(object sender, EventArgs e)
        {
            if (textBoxOutDir.Text != "")
            {
                if (!Directory.Exists(textBoxOutDir.Text))
                {
                    string dir;
                    if (Path.IsPathRooted(OutputDirectory))
                    { dir = OutputDirectory; }
                    else
                    {
                        dir = Path.Combine(System.Environment.CurrentDirectory, OutputDirectory);
                    }
                    DialogResult dr = MessageBox.Show("The given path does not refer to an existing directory on disk.\nCreate a new folder : " + dir, "Caution", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            Directory.CreateDirectory(dir);
                            textBoxOutDir.Text = dir;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Can not create a new folder.");
                            textBoxOutDir.Select();
                            textBoxOutDir.SelectAll();
                        }
                    }
                    else
                    {
                        textBoxOutDir.Select();
                        textBoxOutDir.SelectAll();
                    }
                }
            }
        }
        private void TextBoxOutDir_TextChanged(object sender, EventArgs e)
        {
            OutputDirectory = textBoxOutDir.Text;
        }
        private void TextValMin_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textValMin.Text, out double val))
            {
                MinVal[pNum] = val;
            }
            else
            {
                textValMin.Text = MinVal[pNum].ToString();
            }
        }
        private void TextValMax_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textValMax.Text, out double val))
            {
                MaxVal[pNum] = val;
            }
            else
            {
                textValMax.Text = MaxVal[pNum].ToString();
            }
        }
        private void TextIncrement_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textIncrement.Text, out double val))
            {
                Increment[pNum] = val;
                IncrementFormat[pNum] = Digit(textIncrement.Text);
            }
            else
            {
                textIncrement.Text = string.Format("{0:" + IncrementFormat[pNum] + "}", Increment[pNum]);
            }
        }
        private void NumCell_T_ValueChanged(object sender, EventArgs e)
        {
            numCell_T.Maximum = Behaviors.Maximum - 1;
            CellType[pNum] = (int)numCell_T.Value;
        }
        private void NumMax_ValueChanged(object sender, EventArgs e)
        {
            pMax = (int)numMax.Value;
            if (pMax > 0)
            {
                label2.Enabled = true;
                numT.Enabled = true;
                groupBox1.Enabled = true;

                numT.Maximum = pMax - 1;
                vScrollBar1.Maximum = pMax - 1;

                if (pMax >= CellType.Count)
                {
                    Params.Add(comboBoxParam.SelectedIndex);
                    CellType.Add((int)numCell_T.Value);
                    MinVal.Add(double.Parse(textValMin.Text));
                    MaxVal.Add(double.Parse(textValMax.Text));
                    Increment.Add(double.Parse(textIncrement.Text));
                    IncrementFormat.Add(Digit(textIncrement.Text));
                    AllCellTypes.Add(checkBoxAllCellTypes.Checked);
                }
                else
                {
                    Params.RemoveAt(pNum);
                    CellType.RemoveAt(pNum);
                    MaxVal.RemoveAt(pNum);
                    MinVal.RemoveAt(pNum);
                    Increment.RemoveAt(pNum);
                    IncrementFormat.RemoveAt(pNum);
                    AllCellTypes.RemoveAt(pNum);
                }
            }
            else
            {
                label2.Enabled = false;
                numT.Enabled = false;
                groupBox1.Enabled = false;
            }
        }
        private void NumT_ValueChanged(object sender, EventArgs e)
        {
            pNum = (int)numT.Value;
            vScrollBar1.Value = pNum;
            comboBoxParam.SelectedIndex = Params[pNum];
            if (AllCellTypes[pNum])
            { numCell_T.Value = 0; }
            else
            { numCell_T.Value = CellType[pNum]; }
            textValMin.Text = MinVal[pNum].ToString();
            textValMax.Text = MaxVal[pNum].ToString();
            textIncrement.Text = string.Format("{0:" + IncrementFormat[pNum] + "}", Increment[pNum]);
            checkBoxAllCellTypes.Checked = AllCellTypes[pNum];
        }
        private void CheckBoxAllCellTypes_CheckedChanged(object sender, EventArgs e)
        {
            AllCellTypes[(int)numT.Value] = checkBoxAllCellTypes.Checked;
            numCell_T.Enabled = !checkBoxAllCellTypes.Checked;
            if (checkBoxAllCellTypes.Checked)
            {
                CellType[(int)numT.Value] = -1;
            }
            else
            {
                CellType[(int)numT.Value] = (int)numCell_T.Value;
            }
        }
        #endregion

        private async void Run()
        {
            if (Preparation())
            {
                buttonCreateFiles.Enabled = false;
                if (pMax > 0)
                { await Task.Run(() => Run("", 0)); }
                else
                { Run("initialize"); }
            }
            buttonCreateFiles.Enabled = true;
        }
        private bool Preparation()
        {
            for (int i = 0; i < pMax; i++)
            {
                if (MaxVal[i] < MinVal[i])
                {
                    double tmp = MaxVal[i];
                    MaxVal[i] = MinVal[i];
                    MinVal[i] = tmp;
                }
            }

            if (OutputDirectory == "" || OutputDirectory == null)
            {
                MessageBox.Show("The parameter file output directory is not set.");
                return false;
            }

            return true;
        }
        private string Run(string name, int num)
        {
            if (num < pMax)
            {
                int len = UpdateCount(num);
                for (int i = 0; i < len; i++)
                {
                    string str = Run(ParamSettingProc(name, num, i), num + 1);
                    if (num + 1 >= pMax)
                    { Run(str); }
                }
            }
            return name;
        }
        private void Run(string str)
        {
            for (int n = 0; n < numTrial.Value; n++)
            {
                string fileName;
                if (numTrial.Value > 1)
                { fileName = Path.Combine(OutputDirectory, str + "{n=" + n + "}.csv"); }
                else
                { fileName = Path.Combine(OutputDirectory, str + ".csv"); }
                Common.CalcEmax();
                BasicConnectionEnergy.EpsilonToEnergy(Common.Emax);
                InputParameter.SaveParameter(fileName);
            }
        }
        private int UpdateCount(int num)
        {
            if (Increment[num] > 0)
            {
                double val = (MaxVal[num] - MinVal[num]) / Increment[num];
                return (int)Math.Round(val) + 1;
            }
            else { return 1; }
        }
        private string ParamSettingProc(string format, int num, int ind)
        {
            double val = GetValue(num, ind);
            ChangeParamValue((ParamName)Params[num], CellType[num], val.ToString());
            string name = string.Format("{0:" + IncrementFormat[num] + "}", val);
            return Rename(format, name, CellType[num], (string)comboBoxParam.Items[Params[num]]);
        }
        private double GetValue(int num, int ind) => ind * Increment[num] + MinVal[num];
        private void ChangeParamValue(ParamName item, int cellT, string val)
        {
            if (cellT == -1)
            {
                for (int i = 0; i < Behaviors.Maximum; i++)
                { ChangeParamValue(item, i, val); }
            }
            else
            {
                switch (item)
                {
                    case ParamName.Ep_AJ0: BasicConnectionEnergyRate.SetParameter_Ep_AJ0(cellT, val); break;
                    case ParamName.Ep_TJ0: BasicConnectionEnergyRate.SetParameter_Ep_TJ0(cellT, val); break;
                    case ParamName.Ep_cs0: BasicConnectionEnergyRate.SetParameter_Ep_cs0(cellT, val); break;
                    case ParamName.tau_TJ: BasicConnectionEnergyRate.SetParameter_tau_TJ(cellT, val); break;
                    case ParamName.t_deg: CellCellConnection.SetParameter_t_deg(cellT, val); break;
                    case ParamName.k_AJ: CellCellConnection.SetParameter_k_AJ(cellT, val); break;
                    case ParamName.u_AJ: CellCellConnection.SetParameter_u_AJ(cellT, val); break;
                    case ParamName.k_cs: CellSubstrateConnection.SetParameter_k_cs(cellT, val); break;
                    case ParamName.u_cs: CellSubstrateConnection.SetParameter_u_cs(cellT, val); break;
                    case ParamName.alpha: AfterSeeding.SetParameter_alpha(cellT, val); break;
                    case ParamName.tau_a: AfterSeeding.SetParameter_tau_a(cellT, val); break;
                    case ParamName.t_lag: AfterSeeding.SetParameter_t_lag(cellT, val); break;
                    case ParamName.t_g: Division.SetParameter_t_g(cellT, val); break;
                    case ParamName.N_c: Division.SetParameter_N_c(cellT, val); break;
                    case ParamName.Pr_q: Division.SetParameter_Pr_q(cellT, val); break;
                    case ParamName.V_m_free: Migration.SetParameter_V_m_free(cellT, val); break;
                    case ParamName.m_c: Migration.SetParameter_m_c(cellT, val); break;
                    case ParamName.p_dif: Differentiation_Basal_Decay.SetParameter_p_dif(cellT, val); break;
                    case ParamName.Colony_size: Seeding.SetParameter_SingleColony_Cell(val); break;
                    default: break;
                }
            }
        }
        private string Rename(string format, double val, int cellT, string param)
        {
            if (cellT == -1)
            { return string.Format("{{{0}={2}}}{3}", param, cellT, val, format); }
            else
            { return string.Format("{{{0}({1})={2}}}{3}", param, cellT, val, format); }
        }
        private string Rename(string format, string val, int cellT, string param)
        {
            if (cellT == -1)
            { return $"{{{param}={val}}}{format}"; }
            else
            { return $"{{{param}({cellT})={val}}}{format}"; }
        }

        private string Digit(string str)
        {
            for (int i = 1; i < 9; i++)
            {
                str = str.Replace(i.ToString(), "0");
            }
            return str;
        }
    }
}
