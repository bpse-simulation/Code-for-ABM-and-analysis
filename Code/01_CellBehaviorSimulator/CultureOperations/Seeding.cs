using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CellBehaviorSimulator.CultureEnvironments;
using CellBehaviorSimulator.CellBehaviors;
using System.IO;

namespace CellBehaviorSimulator.CultureOperations
{
    public partial class Seeding : UserControl
    {
        public Seeding()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void Seeding_Load(object sender, EventArgs e)
        {
            comboBoxInit.SelectedIndex = (int)InitializationMethod.NEW;
            initMet = InitializationMethod.NEW;
            InputCSV = "";
            InputCSVpre = "";
            comboBoxType.SelectedIndex = (int)SeedingTYPE.SingleColony_CellNumber;
            sType = (SeedingTYPE)comboBoxType.SelectedIndex;
            if (Behaviors.Maximum > 0)
            { numCellType.Maximum = Behaviors.Maximum - 1; }
            else
            { numCellType.Maximum = 0; }
            X_0 = new List<int>() { 0 };
            for (int i = 0; i < Behaviors.Maximum - 1; i++)
            { X_0.Add(0); }
            ColonyRadius = (int)numColonyRadius.Value;
            GridInterval = (int)numGridInterval.Value;
            NumOfColonies = (int)numNumOfColonies.Value;
            ColonyNum_SD = (int)numColNumSD.Value;
            ColonyCellsMu = (int)numColonyCellsMu.Value;
            ColonyCellsSigma = (int)numColonyCellsSigma.Value;
            LoadGeomInfo = "";
            ImagePath = "";
            PixelSize = (double)numPixelSize.Value;
            ColonyCells = (int)numColonyCells.Value;
            Uniformity = (double)numUniformity_a.Value;
            Uniformity_Inf = false;
            ConcentrationParameter = (double)numConParam.Value;
            CenterPeripheryRatio = (double)numCenterPeriphery.Value;

            ErrFlag = true;
        }

        private void ComboBoxInit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxInit.SelectedIndex == 0)
            {
                panelCSV.Visible = true;
                flowLayoutPanelMethod.Visible = false;
                initMet = InitializationMethod.CSV;
            }
            else if (comboBoxInit.SelectedIndex == 1)
            {
                flowLayoutPanelMethod.Location = new Point(0, 0);
                flowLayoutPanelMethod.Visible = true;
                panelCSV.Visible = false;
                initMet = InitializationMethod.NEW;
            }
        }
        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 2; i < flowLayoutPanelMethod.Controls.Count; i++)
            { flowLayoutPanelMethod.Controls[i].Visible = false; }

            int val = comboBoxType.SelectedIndex;
            sType = (SeedingTYPE)val;
            switch (sType)
            {
                case SeedingTYPE.Random_NoBias:
                    panelRand.Visible = true; break;
                case SeedingTYPE.Random_CenterBiased:
                    panelRand.Visible = true;
                    panelCenterBiased.Visible = true;
                    break;
                case SeedingTYPE.Uniform:
                    panelGridInterval.Visible = true; break;
                case SeedingTYPE.SingleColony_Layer:
                    panelColonyRadius.Visible = true; break;
                case SeedingTYPE.SingleColony_CellNumber:
                    panelColonyCells.Visible = true; break;
                case SeedingTYPE.MultipleColony_Random_mean_colony_size:
                    panelMultiColRand.Visible = true; break;
                case SeedingTYPE.MultupleColony_Random_inoculum_size:
                    panelRand.Visible = true;
                    panelMultiColRand2.Visible = true; break;
                case SeedingTYPE.MultipleAggregation_Random:
                    panelMultiColRand.Visible = true; break;
                case SeedingTYPE.MultipleColony_Determined:
                    panelMultiColDet.Visible = true; break;
                case SeedingTYPE.LoadCellPlacement:
                    panelLoadCellPlace.Visible = true; break;
                case SeedingTYPE.NonUniformDistribution:
                    panelRand.Visible = true; 
                    panelNonuniform.Visible = true; break;
                default: break;
            }
        }

        private void NumCellType_Enter(object sender, EventArgs e)
        {
            if (Behaviors.Maximum > 0)
            {
                numCellType.Maximum = Behaviors.Maximum - 1;
                if (X_0.Count < Behaviors.Maximum)
                {
                    int val = Behaviors.Maximum - X_0.Count;
                    for (int i = 0; i < val; i++)
                    { X_0.Add(0); }
                }
                else if (X_0.Count > Behaviors.Maximum)
                {
                    int val = X_0.Count - Behaviors.Maximum;
                    X_0.RemoveRange(Behaviors.Cell_T, val);
                }
            }
        }
        private void NumCellType_ValueChanged(object sender, EventArgs e)
        {
            numInoculum.Value = X_0[(int)numCellType.Value];
        }
        private void NumInoculum_ValueChanged(object sender, EventArgs e)
        {
            X_0[(int)numCellType.Value] = (int)numInoculum.Value;
        }
        private void NumGridInterval_ValueChanged(object sender, EventArgs e)
        {
            GridInterval = (int)numGridInterval.Value;
        }
        private void NumColonyRadius_ValueChanged(object sender, EventArgs e)
        {
            ColonyRadius = (int)numColonyRadius.Value;
        }
        private void NumColonyCells_ValueChanged(object sender, EventArgs e)
        {
            ColonyCells = (int)numColonyCells.Value;
        }
        private void NumNumOfColonies_ValueChanged(object sender, EventArgs e)
        {
            NumOfColonies = (int)numNumOfColonies.Value;
        }
        private void NumColNumSD_ValueChanged(object sender, EventArgs e)
        {
            ColonyNum_SD = (int)numColNumSD.Value;
        }
        private void NumColonyCellsMu_ValueChanged(object sender, EventArgs e)
        {
            ColonyCellsMu = (int)numColonyCellsMu.Value;
        }
        private void NumColonyCellsSigma_ValueChanged(object sender, EventArgs e)
        {
            ColonyCellsSigma = (int)numColonyCellsSigma.Value;
        }
        private void TextBoxMultiColDet_TextChanged(object sender, EventArgs e)
        {
            LoadGeomInfo = textBoxMultiColDet.Text;
        }
        private void TextBoxLoadCellPlace_TextChanged(object sender, EventArgs e)
        {
            ImagePath = textBoxLoadCellPlace.Text;
        }
        private void NumPixelSize_ValueChanged(object sender, EventArgs e)
        {
            PixelSize = (double)numPixelSize.Value;
        }
        private void TextBoxCSV_TextChanged(object sender, EventArgs e)
        {
            InputCSV = textBoxCSV.Text;
        }
        private void TextBoxCSV_Leave(object sender, EventArgs e)
        {
            if (textBoxCSV.Text != "")
            {
                if (File.Exists(textBoxCSV.Text)) { InputCSV = textBoxCSV.Text; }
                else
                {
                    MessageBox.Show("The given path does not refer to an existing file on disk.");
                    textBoxCSV.Focus();
                    textBoxCSV.SelectAll();
                }
            }
        }
        private void ButtonCSV_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofDialog = new OpenFileDialog())
            {
                ofDialog.Filter = "CSV|*.csv";
                if (ofDialog.ShowDialog() == DialogResult.OK)
                {
                    InputCSV = ofDialog.FileName;
                    textBoxCSV.Text = InputCSV;
                }
            }
        }
        private void TextBoxCSVpre_TextChanged(object sender, EventArgs e)
        {
            InputCSVpre = textBoxCSVpre.Text;
        }
        private void TextBoxCSVpre_Leave(object sender, EventArgs e)
        {
            if (textBoxCSVpre.Text != "")
            {
                if (File.Exists(textBoxCSVpre.Text)) { InputCSVpre = textBoxCSVpre.Text; }
                else
                {
                    MessageBox.Show("The given path does not refer to an existing file on disk.");
                    textBoxCSVpre.Focus();
                    textBoxCSVpre.SelectAll();
                }
            }
        }
        private void ButtonCSVpre_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofDialog = new OpenFileDialog())
            {
                ofDialog.Filter = "CSV|*.csv";
                if (ofDialog.ShowDialog() == DialogResult.OK)
                {
                    InputCSVpre = ofDialog.FileName;
                    textBoxCSVpre.Text = InputCSVpre;
                }
            }
        }
        private void NumNumOfColonies2_ValueChanged(object sender, EventArgs e)
        {
            NumOfColonies = (int)numNumOfColonies2.Value;
        }
        private void ButtonMultiColDet_Click(object sender, EventArgs e)
        {
        }
        private void ButtonLoadCellPlace_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofDialog = new OpenFileDialog())
            {
                ofDialog.Filter = "Image file|*.tif;*.bmp;*.png;*.jpg";
                if (ofDialog.ShowDialog() == DialogResult.OK)
                {
                    ImagePath = ofDialog.FileName;
                    textBoxLoadCellPlace.Text = ImagePath;
                }
            }
        }
        private void LabelRef_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://doi.org/10.1098/rsos.160500");
        }
        private void LabelRef_MouseEnter(object sender, EventArgs e)
        {
            labelRef.Cursor = Cursors.Hand;
        }
        private void CheckInf_CheckedChanged(object sender, EventArgs e)
        {
            numUniformity_a.Enabled = !checkInf.Checked;
            Uniformity_Inf = checkInf.Checked;
            if (Uniformity_Inf)
            { Uniformity = double.PositiveInfinity; }
        }
        private void NumUniformity_a_ValueChanged(object sender, EventArgs e)
        {
            Uniformity = (double)numUniformity_a.Value;
        }
        private void NumConParam_ValueChanged(object sender, EventArgs e)
        {
            ConcentrationParameter = (double)numConParam.Value;
        }

        private void NumCenterPeriphery_ValueChanged(object sender, EventArgs e)
        {
            CenterPeripheryRatio = (double)numCenterPeriphery.Value;
        }
        #endregion
        #region Parameter setting
        internal void SetParameter()
        {
            comboBoxInit.SelectedIndex = (int)initMet;
            switch (initMet)
            {
                case InitializationMethod.CSV:
                    textBoxCSV.Text = InputCSV;
                    textBoxCSVpre.Text = InputCSVpre;
                    break;
                case InitializationMethod.NEW:
                    comboBoxType.SelectedIndex = (int)sType;
                    switch (sType)
                    {
                        case SeedingTYPE.Random_NoBias:
                            numCellType.Value = 0;
                            numInoculum.Value = X_0[0];
                            break;
                        case SeedingTYPE.Random_CenterBiased:
                            numCellType.Value = 0;
                            numInoculum.Value = X_0[0];
                            numConParam.Value = (decimal)ConcentrationParameter;
                            numCenterPeriphery.Value = (decimal)CenterPeripheryRatio;
                            break;
                        case SeedingTYPE.Uniform:
                            numGridInterval.Value = GridInterval;
                            break;
                        case SeedingTYPE.SingleColony_Layer:
                            numColonyRadius.Value = ColonyRadius;
                            break;
                        case SeedingTYPE.SingleColony_CellNumber:
                            numColonyCells.Value = ColonyCells;
                            break;
                        case SeedingTYPE.MultipleAggregation_Random:
                            numNumOfColonies.Value = NumOfColonies;
                            numColonyCellsMu.Value = ColonyCellsMu;
                            numColonyCellsSigma.Value = ColonyCellsSigma;
                            break;
                        case SeedingTYPE.MultipleColony_Random_mean_colony_size:
                            numNumOfColonies.Value = NumOfColonies;
                            numColNumSD.Value = ColonyNum_SD;
                            numColonyCellsMu.Value = ColonyCellsMu;
                            numColonyCellsSigma.Value = ColonyCellsSigma;
                            break;
                        case SeedingTYPE.MultupleColony_Random_inoculum_size:
                            numNumOfColonies2.Value = NumOfColonies;
                            numCellType.Value = 0;
                            numInoculum.Value = X_0[0];
                            break;
                        case SeedingTYPE.MultipleColony_Determined:
                            break;
                        case SeedingTYPE.LoadCellPlacement:
                            textBoxLoadCellPlace.Text = ImagePath;
                            numPixelSize.Value = (decimal)PixelSize;
                            break;
                        case SeedingTYPE.NonUniformDistribution:
                            numCellType.Value = 0;
                            numInoculum.Value = X_0[0];
                            if (double.IsPositiveInfinity(Uniformity))
                            {
                                numUniformity_a.Value = numUniformity_a.Minimum;
                            }
                            else
                            {
                                numUniformity_a.Value = (decimal)Uniformity;
                            }
                            checkInf.Checked = Uniformity_Inf;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion
        private const string Str_InitializationMethod = "InitializationMethod";
        private const string Str_Input_CellsData = "Input_CellsData";
        private const string Str_Input_CellsData_pre = "Input_CellsData_pre";
        private const string Str_Seeding_type = "Seeding_type";
        private const string Str_X_0 = "X_0";
        private const string Str_GridInterval = "GridInterval";
        private const string Str_SingleColony_Layer = "SingleColony_layer";
        private const string Str_SingleColony_Cell = "SingleColony_cells";
        private const string Str_Num_of_colonies = "Num_of_colonies";
        private const string Str_Num_of_colonies_SD = "ColonyNumber_SD";
        private const string Str_Colony_CellsMu = "Colony_CellsMu";
        private const string Str_Colony_CellsSigma = "Colony_CellsSigma";
        private const string Str_ImagePath = "ImagePath";
        private const string Str_PixelSize = "PixelSize";
        private const string Str_Uniformity = "Uniformity";
        private const string Str_ConcentrationParameter = "ConcentrationParameter";
        private const string Str_CenterPeripheryRatio = "CenterPeriphery_Ratio";
        #region Parameter definitions
        public static void WriteParameter(System.IO.StreamWriter sw)
        {
            sw.WriteLine(":," + Str_InitializationMethod + "," + (int)initMet + ",# 0 -> CSV(Input CellsData); 1 -> NEW(Initialize CellsData);");
            switch (initMet)
            {
                case InitializationMethod.CSV:
                    sw.WriteLine(":," + Str_Input_CellsData + "," + InputCSV);
                    if (InputCSVpre != "")
                    { sw.WriteLine(":," + Str_Input_CellsData_pre + "," + InputCSVpre); }
                    break;
                case InitializationMethod.NEW:
                    sw.WriteLine(":," + Str_Seeding_type + "," + (int)sType + ",# "
                        + "0 -> Random (no bias); "
                        + "1 -> Random (center biased); "
                        + "2 -> Uniform; "
                        + "3 -> Single colony (layer); "
                        + "4 -> Single colony (cell); "
                        + "5 -> Multiple colony (random: mean colony size); "
                        + "6 -> Multiple colony (random: inoculum size); "
                        + "7 -> Multiple colony (determined); "
                        + "8 -> Multiple aggregation (random); "
                        + "9 -> Load cell placement; "
                        + "10 -> Uniformity of cell distribution");
                    switch (sType)
                    {
                        case SeedingTYPE.Random_NoBias:
                            sw.Write(":," + Str_X_0 + "," + X_0[0]);
                            for (int i = 1; i < X_0.Count; i++)
                            {
                                if (X_0[i] > 0)
                                { sw.Write("_" + X_0[i]); }
                            }
                            sw.WriteLine(",cells/cm2");
                            break;
                        case SeedingTYPE.Random_CenterBiased:
                            sw.Write(":," + Str_X_0 + "," + X_0[0]);
                            for (int i = 1; i < X_0.Count; i++)
                            {
                                if (X_0[i] > 0)
                                { sw.Write("_" + X_0[i]); }
                            }
                            sw.WriteLine(",cells/cm2");
                            sw.WriteLine(":," + Str_ConcentrationParameter + "," + ConcentrationParameter);
                            sw.WriteLine(":," + Str_CenterPeripheryRatio + "," + CenterPeripheryRatio);
                            break;
                        case SeedingTYPE.Uniform:
                            sw.WriteLine(":," + Str_GridInterval + "," + GridInterval);
                            break;
                        case SeedingTYPE.SingleColony_Layer:
                            sw.WriteLine(":," + Str_SingleColony_Layer + "," + ColonyRadius);
                            break;
                        case SeedingTYPE.SingleColony_CellNumber:
                            sw.WriteLine(":," + Str_SingleColony_Cell + "," + ColonyCells);
                            break;
                        case SeedingTYPE.MultipleColony_Random_mean_colony_size:
                            sw.WriteLine(":," + Str_Num_of_colonies + "," + NumOfColonies);
                            sw.WriteLine(":," + Str_Num_of_colonies_SD + "," + ColonyNum_SD);
                            sw.WriteLine(":," + Str_Colony_CellsMu + "," + ColonyCellsMu);
                            sw.WriteLine(":," + Str_Colony_CellsSigma + "," + ColonyCellsSigma);
                            break;
                        case SeedingTYPE.MultupleColony_Random_inoculum_size:
                            sw.WriteLine(":," + Str_X_0 + "," + X_0[0]);
                            sw.WriteLine(":," + Str_Num_of_colonies + "," + NumOfColonies);
                            break;
                        case SeedingTYPE.MultipleAggregation_Random:
                            sw.WriteLine(":," + Str_Num_of_colonies + "," + NumOfColonies);
                            sw.WriteLine(":," + Str_Colony_CellsMu + "," + ColonyCellsMu);
                            sw.WriteLine(":," + Str_Colony_CellsSigma + "," + ColonyCellsSigma);
                            break;
                        case SeedingTYPE.MultipleColony_Determined:
                            break;
                        case SeedingTYPE.LoadCellPlacement:
                            sw.WriteLine(":," + Str_ImagePath + "," + ImagePath);
                            sw.WriteLine(":," + Str_PixelSize + "," + PixelSize + ",um/px");
                            break;
                        case SeedingTYPE.NonUniformDistribution:
                            sw.Write(":," + Str_X_0 + "," + X_0[0]);
                            for (int i = 1; i < X_0.Count; i++)
                            {
                                if (X_0[i] > 0)
                                { sw.Write("_" + X_0[i]); }
                            }
                            sw.WriteLine();
                            if (double.IsPositiveInfinity(Uniformity))
                            { sw.WriteLine(":," + Str_Uniformity + ",Inf,-"); }
                            else
                            { sw.WriteLine(":," + Str_Uniformity + "," + Uniformity + ",-"); }
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        public static bool ReadParameter(string strName, string strValue)
        {
            switch (strName)
            {
                case Str_InitializationMethod: return SetParameter_InitializationMethod(strValue);
                case Str_Input_CellsData: return SetParameter_Input_CellsData(strValue);
                case Str_Input_CellsData_pre: return SetParameter_Input_CellsData_pre(strValue);
                case Str_Seeding_type: return SetParameter_SeedingTYPE(strValue);
                case Str_X_0: return SetParameter_InoculumSize(strValue);
                case Str_GridInterval: return SetParameter_GirdInterval(strValue);
                case Str_SingleColony_Layer: return SetParameter_SingleColony_Layer(strValue);
                case Str_SingleColony_Cell: return SetParameter_SingleColony_Cell(strValue);
                case Str_Num_of_colonies: return SetParameter_Num_of_colonies(strValue);
                case Str_Num_of_colonies_SD : return SetParameter_Num_of_colonies_SD(strValue);
                case Str_Colony_CellsMu: return SetParameter_Colony_CellsMu(strValue);
                case Str_Colony_CellsSigma: return SetParameter_Colony_CellsSigma(strValue);
                case Str_ImagePath: return SetParameter_ImagePath(strValue);
                case Str_PixelSize: return SetParameter_PixelSize(strValue);
                case Str_Uniformity: return SetParameter_Uniformity(strValue);
                case Str_ConcentrationParameter: return SetParameter_ConcentrationParameter(strValue);
                case Str_CenterPeripheryRatio: return SetParameter_CenterPeripheryRatio(strValue);
                default: return false;
            }
        }

        public static void ClearParameter()
        {
            initMet = InitializationMethod.NEW;
            InputCSV = "";
            InputCSVpre = "";
            sType = 0;
            X_0 = new List<int>() { 0 };
            for (int i = 0; i < Behaviors.Maximum - 1; i++)
            { X_0.Add(0); }
            ColonyRadius = 0;
            GridInterval = 0;
            ColonyCells = 0;
            ImagePath = "";
            PixelSize = 1.325;
            Uniformity = 1.0;
            ConcentrationParameter = 0.5;
            CenterPeripheryRatio = 0;
        }
        private static bool SetParameter_InitializationMethod(string strVal)
        {
            if (int.TryParse(strVal, out int val))
            {
                initMet = (InitializationMethod)val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_Input_CellsData(string strVal)
        {
            if (strVal != "")
            {
                InputCSV = strVal;
                return true;
            }
            return false;
        }
        private static bool SetParameter_Input_CellsData_pre(string strVal)
        {
            if (strVal != "")
            {
                InputCSVpre = strVal;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SeedingTYPE(string strVal)
        {
            if (int.TryParse(strVal, out int val))
            {
                sType = (SeedingTYPE)val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_InoculumSize(string strVal)
        {
            string[] strs = strVal.Split('_');
            X_0 = new List<int>();
            for (int i = 0; i < Behaviors.Maximum; i++)
            {
                if (i < strs.Length)
                {
                    if (int.TryParse(strs[i], out int val))
                    { X_0.Add(val); }
                    else
                    { return false; }
                }
                else
                { X_0.Add(0); }
            }
            return true;
        }
        private static bool SetParameter_GirdInterval(string strVal)
        {
            if (int.TryParse(strVal, out int val))
            {
                GridInterval = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SingleColony_Layer(string strVal)
        {
            if (int.TryParse(strVal, out int val))
            {
                ColonyRadius = val;
                return true;
            }
            return false;
        }
        public static bool SetParameter_SingleColony_Cell(string strVal)
        {
            if (int.TryParse(strVal, out int val))
            {
                ColonyCells = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_Num_of_colonies(string strVal)
        {
            if (int.TryParse(strVal, out int val))
            {
                NumOfColonies = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_Num_of_colonies_SD(string strVal)
        {
            if (int.TryParse(strVal, out int val))
            {
                ColonyNum_SD = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_Colony_CellsMu(string strVal)
        {
            if (int.TryParse(strVal, out int val))
            {
                ColonyCellsMu = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_Colony_CellsSigma(string strVal)
        {
            if (int.TryParse(strVal, out int val))
            {
                ColonyCellsSigma = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_ImagePath(string strVal)
        {
            ImagePath = strVal;
            return true;
        }
        private static bool SetParameter_PixelSize(string strVal)
        {
            if (double.TryParse(strVal, out double val))
            {
                PixelSize = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_Uniformity(string strVal)
        {
            if (double.TryParse(strVal, out double val))
            {
                Uniformity = val;
                Uniformity_Inf = double.IsPositiveInfinity(val);
                return true;
            }
            else if (strVal == "Inf")
            {
                Uniformity = double.PositiveInfinity;
                Uniformity_Inf = true;
                return true;
            }
            return false;
        }
        private static bool SetParameter_ConcentrationParameter(string strVal)
        {
            if (double.TryParse(strVal, out double val))
            {
                ConcentrationParameter = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_CenterPeripheryRatio(string strVal)
        {
            if (double.TryParse(strVal, out double val))
            {
                CenterPeripheryRatio = val;
                return true;
            }
            return false;
        }
        #endregion

        private enum InitializationMethod
        {
            CSV = 0, // Input CellsData
            NEW = 1, // Initialize CellsData
        }
        private enum SeedingTYPE
        {
            Random_NoBias = 0,
            Random_CenterBiased = 1,
            Uniform = 2,
            SingleColony_Layer = 3,
            SingleColony_CellNumber = 4,
            MultipleColony_Random_mean_colony_size = 5,
            MultupleColony_Random_inoculum_size = 6,
            MultipleColony_Determined = 7,
            MultipleAggregation_Random = 8,
            LoadCellPlacement = 9,
            NonUniformDistribution = 10,
        }

        private static InitializationMethod initMet;
        private static string InputCSV;
        private static string InputCSVpre;
        private static SeedingTYPE sType;
        private static List<int> X_0;
        private static int ColonyRadius;
        private static int ColonyCells;
        private static int GridInterval;
        private static int NumOfColonies;
        private static int ColonyNum_SD;
        private static int ColonyCellsMu;
        private static int ColonyCellsSigma;
        private static string LoadGeomInfo;
        private static string ImagePath;
        private static double PixelSize;
        private static double Uniformity;
        private static bool Uniformity_Inf;
        private static bool ErrFlag;
        private static double ConcentrationParameter;
        private static double CenterPeripheryRatio;

        public static bool Run(out List<CellData> cells)
        {
            bool preData = false;
            switch (initMet)
            {
                case InitializationMethod.CSV:
                    (cells, preData) = InputCellsData();
                    break;
                case InitializationMethod.NEW:
                    switch (sType)
                    {
                        case SeedingTYPE.Random_NoBias:
                            cells = CellInitialization_Random();
                            if (cells == null) { break; }
                            InitialCellPlacement_Random(cells);
                            break;
                        case SeedingTYPE.Random_CenterBiased:
                            cells = CellInitialization_Random();
                            if (cells == null) { break; }
                            InitialCellPlacement_Random_CenterBiased(cells);
                            break;
                        case SeedingTYPE.Uniform:
                            cells = CellInitialization_Uniform();
                            break;
                        case SeedingTYPE.SingleColony_Layer:
                            cells = CellInitialization_SingleColony();
                            InitialCellPlacement_SingleColony(cells);
                            break;
                        case SeedingTYPE.SingleColony_CellNumber:
                            cells = CellInitialization_SingleColony_CellNumber();
                            InitialCellPlacement_SingleColony_CellNumber(cells);
                            break;
                        case SeedingTYPE.MultipleColony_Random_mean_colony_size:
                            cells = CellInitialization_MultipleColony_Random_MeanColony();
                            break;
                        case SeedingTYPE.MultupleColony_Random_inoculum_size:
                            cells = CellInitialization_MultipleColony_Random_Inoculum();
                            break;
                        case SeedingTYPE.MultipleAggregation_Random:
                            cells = CellInitialization_MultipleAggregation_Random();
                            break;
                        case SeedingTYPE.MultipleColony_Determined:
                            MessageBox.Show("未実装：MultipleColony_Determined");
                            cells = null;
                            break;
                        case SeedingTYPE.LoadCellPlacement:
                            cells = CellInitialization_LoadCellPlacement();
                            break;
                        case SeedingTYPE.NonUniformDistribution:
                            cells = CellInitialization_Random();
                            if (cells == null) { break; }
                            InitialCellPlacement_NonUniform(ref cells);
                            break;
                        default:
                            cells = null;
                            break;
                    }
                    break;
                default:
                    cells = null;
                    break;
            }

            if (cells != null && !preData)
            {
                Common.MaintainStates(cells);
            }

            return cells != null;
        }

        #region InputCellsData
        private static (List<CellData>, bool) InputCellsData()
        {
            bool flag = false;
            List<CellData> pre = InputCellsData(InputCSVpre);
            if (pre != null)
            {
                Common.MaintainStates(pre);
                flag = true;
                CultureSpace.MapCreation();
            }

            return (InputCellsData(InputCSV), flag);
        }
        public static List<CellData> InputCellsData(string filename)
        {
            if (!File.Exists(filename))
            { return null; }
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (StreamReader sr = new StreamReader(fs))
            {
                string[] str = new string[] {
                    Output.Name_Index,
                    Output.Name_X,
                    Output.Name_Y,
                    Output.Name_Z,
                    Output.Name_hexX,
                    Output.Name_hexY,
                    Output.Name_hexZ,
                    Output.Name_Cell_N,
                    Output.Name_Cell_S,
                    Output.Name_Cell_T,
                    Output.Name_t_age,
                    Output.Name_t_d,
                    Output.Name_t_m,
                    Output.Name_V_m,
                    Output.Name_E_AJ,
                    Output.Name_E_TJ,
                    Output.Name_E_cs,
                    Output.Name_E_max,
                    Output.Name_Dir_am,
                    Output.Name_Dir_pm,
                    Output.Name_Dir_pd,
                    Output.Name_THETA,
                    Output.Name_T_de_act,
                    Output.Name_T_de_total,
                    Output.Name_CellMovement_len_app,
                    Output.Name_CellMovement_len_act,
                    Output.Name_CellMovement_len_pas,
                    Output.Name_CellMovement_len_div,
                    Output.Name_CellMovement_t_act,
                    Output.Name_CellMovement_t_pas,
                    Output.Name_CellMovement_t_div,
                };
                string[] labels = sr.ReadLine().Split(',');
                int[] lut = new int[str.Length];
                string errStr = "";
                for (int i = 0; i < str.Length; i++)
                {
                    lut[i] = Array.FindIndex(labels, s => s == str[i]);
                    if (lut[i] == -1)
                    { errStr += str[i] + "\r\n"; }
                }
                if (errStr != "" && ErrFlag)
                {
                    if (MessageBox.Show(
                        "Ignore the data of CellsData with the following column name?\r\n" + errStr,
                        "Confirmation of cell seeding", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                        == DialogResult.Yes)
                    { ErrFlag = false; }
                    else
                    { return null; }
                }
                if (labels[0] == Output.Name_Index)
                {
                    List<CellData> cells = new List<CellData>();
                    while (!sr.EndOfStream)
                    {
                        string[] strs = sr.ReadLine().Split(',');
                        sbyte cellT = (sbyte)(lut[9] > -1 ? Input_SByte(strs[lut[9]]) : 0);
                        CellData c = new CellData(cellT)
                        {
                            Index = Input_Int32(strs[lut[0]]),
                            Location = new Point3D(
                                Input_Int32(strs[lut[4]]),
                                Input_Int32(strs[lut[5]]),
                                Input_Int32(strs[lut[6]])),
                        };
                        if (lut[7] > -1) { c.Cell_N = Input_List_Int32(strs[lut[7]]); }
                        if (lut[8] > -1) { c.Cell_S = (CellData.STATE)Input_Int32(strs[lut[8]]); }
                        if (lut[10] > -1) { c.Time_age = Input_Double(strs[lut[10]]); }
                        if (lut[11] > -1) { c.Time_d = Input_Double(strs[lut[11]]); }
                        if (lut[12] > -1) { c.Time_m = Input_Double(strs[lut[12]]); }
                        if (lut[13] > -1) { c.V_m = Input_Double(strs[lut[13]]); }
                        if (lut[14] > -1) { c.E_AJ = Input_Double(strs[lut[14]]); }
                        if (lut[15] > -1) { c.E_TJ = Input_Double(strs[lut[15]]); }
                        if (lut[16] > -1) { c.E_cs = Input_Double(strs[lut[16]]); }
                        if (lut[17] > -1) { c.E_max = Input_Double(strs[lut[17]]); }
                        if (lut[18] > -1) { c.Dir_am = (Direction.DIR)Input_Int32(strs[lut[18]]); }
                        if (lut[19] > -1) { c.Dir_pm = Input_DIR(strs[lut[19]]); }
                        if (lut[20] > -1) { c.Dir_pd = Input_DIR(strs[lut[20]]); }
                        if (lut[21] > -1) { c.THETA = Input_Array_Int32(strs, lut[21]); }
                        if (lut[22] > -1) { c.Time_dev_act = (int)Math.Round(Input_Double(strs[lut[22]]) / CultureTime.Time_step); }
                        if (lut[23] > -1) { c.Time_dev_total = (int)Math.Round(Input_Double(strs[lut[23]]) / CultureTime.Time_step); }
                        if (lut[24] > -1 && lut[25] > -1 && lut[26] > -1 && lut[27] > -1 && lut[28] > -1 && lut[29] > -1 && lut[30] > -1)
                        {
                            CellMovement.SetValue(
                                Input_Double(strs[lut[24]]),
                                Input_Double(strs[lut[25]]),
                                Input_Double(strs[lut[26]]),
                                Input_Double(strs[lut[27]]),
                                (int)Math.Round(Input_Double(strs[lut[28]]) / CultureTime.Time_step),
                                (int)Math.Round(Input_Double(strs[lut[29]]) / CultureTime.Time_step),
                                (int)Math.Round(Input_Double(strs[lut[30]]) / CultureTime.Time_step));
                        }
                        while (cells.Count < c.Index)
                        {
                            cells.Add(null);
                            CellMovement.SetValue();
                        }
                        cells.Add(c);
                        if (CultureSpace.Xsize - 2 < c.Location.X / 2 && CultureSpace.Ysize - 2 < c.Location.Y)
                        {
                            MessageBox.Show("Out of memory.\nMap size is not correct.");
                            return null;
                        }
                        CultureSpace.SetMap(c.Location, c.Index);
                    }
                    return cells;
                }
                return null;
            }
        }

        private static int[] Input_Array_Int32(string[] strs, int label)
        {
            if (label > 0)
            {
                string[] s = strs[label].Split('_');
                if (s.Length == 20)
                {
                    int[] val = new int[20];
                    for (int i = 0; i < 20; i++)
                    {
                        if (double.TryParse(s[i], out double result))
                        { val[i] = (int)(result / CultureTime.Time_step); }
                    }
                    return val;
                }
            }
            return new int[20];
        }
        private static List<Direction.DIR> Input_DIR(string str)
        {
            string[] s = str.Split('_');
            List<Direction.DIR> val = new List<Direction.DIR>();
            for (int i = 0; i < s.Length; i++)
            { if (int.TryParse(s[i], out int result)) { val.Add((Direction.DIR)result); } }
            return val;
        }
        private static List<int> Input_List_Int32(string str)
        {
            string[] s = str.Split('_');
            List<int> val = new List<int>();
            for (int i = 0; i < s.Length; i++)
            { if (int.TryParse(s[i], out int result)) { val.Add(result); } }
            return val;
        }
        private static sbyte Input_SByte(string str)
        {
            if (sbyte.TryParse(str, out sbyte result))
            { return result; }
            return -1;
        }
        private static int Input_Int32(string str)
        {
            if (int.TryParse(str, out int result))
            { return result; }
            return -1;
        }
        private static double Input_Double(string str)
        {
            if (double.TryParse(str, out double result))
            { return result; }
            else if (str == "Inf")
            { return double.PositiveInfinity; }
            else { return double.NaN; }
        }
        #endregion
        #region Random
        private static List<CellData> CellInitialization_Random()
        {
            List<CellData> cells = new List<CellData>();
            int Nsub = GetNsub();
            double Ac = CultureSpace.Size_lc * CultureSpace.Size_lc * 1E-8 * Math.Sqrt(3) / 2.0;
            int ind = 0;
            for (sbyte j = 0; j < X_0.Count; j++)
            {
                int Nseed = (int)(Ac * Nsub * X_0[j]);
                int n = (int)(AfterSeeding.Get_alpha(j) * Nseed);
                for (int i = 0; i < n; i++)
                {
                    CellData c = new CellData
                    {
                        Cell_T = j,
                        Index = ind++
                    };
                    cells.Add(c);
                }
                if (Nsub < cells.Count)
                {
                    return null;
                }
            }
            return cells;
        }
        private static int GetNsub()
        {
            int Nsub = 0;
            for (int j = 0; j < CultureSpace.Ysize; j++)
            {
                for (int i = 0; i < CultureSpace.Xsize; i++)
                {
                    if (CultureSpace.GetMap(i * 2, j, 1) == -1)
                    {
                        Nsub++;
                    }
                }
            }

            return Nsub;
        }

        private static void InitialCellPlacement_Random(List<CellData> cells)
        {
            for (int i = 0; i < cells.Count; i++)
            {
                while (true)
                {
                    int x = (int)((CultureSpace.Xsize - 2) * Common.Rand_NextDouble()) * 2;
                    int y = (int)((CultureSpace.Ysize - 2) * Common.Rand_NextDouble()) + 1;
                    if (y % 2 == 1)
                    { x++; }
                    Point3D p = new Point3D(x, y, 1);
                    if (CultureSpace.GetMap(p) == -1)
                    {
                        cells[i].Location = p;
                        CultureSpace.SetMap(p, i);
                        break;
                    }
                }
            }
        }
        private static void InitialCellPlacement_Random_CenterBiased(List<CellData> cells)
        {
            int y_center = CultureSpace.Ysize / 2 - 1;
            double x_center = y_center % 2 == 0 ? CultureSpace.Xsize / 2 - 1 : CultureSpace.Xsize / 2 - 0.5;
            double y_center_ = CultureSpace.Ysize * Delta.Cf_y / 2.0;
            double r = (y_center_ < x_center ? y_center_ : x_center) - 1;

            int[] inds = Common.RandomlySort(cells);
            foreach (int i in inds)
            {
                while (true)
                {
                    double theta = 2.0 * Math.PI * Common.Rand_NextDouble();
                    double r1 = Math.Pow(Common.Rand_NextDouble(), ConcentrationParameter);

                    double _y = r * r1 * Math.Sin(theta);
                    int y = (int)Math.Round(_y / Delta.Cf_y + y_center);

                    double _x = r * (r1 * (Math.Cos(theta) + CenterPeripheryRatio) - CenterPeripheryRatio);
                    int x = (int)Math.Round(_x + x_center) * 2 + (y % 2 == 1 ? 1 : 0);

                    {
                        Point3D p = new Point3D(x, y, 1);
                        if (CultureSpace.GetMap(p) == -1)
                        {
                            cells[i].Location = p;
                            CultureSpace.SetMap(p, i);
                            break;
                        }
                    }
                }
            }
        }
        #endregion
        #region Uniform
        private static List<CellData> CellInitialization_Uniform()
        {
            List<CellData> cells = new List<CellData>();
            int cnt = 0;
            for (int j = 1; j < CultureSpace.Ysize; j += GridInterval)
            {
                for (int i = cnt % 2 == 0 ? 1 : (GridInterval / 2 + 1); i < CultureSpace.Xsize; i += GridInterval)
                {
                    int ii = j % 2 == 0 ? i * 2 : i * 2 + 1;
                    Point3D p = new Point3D(ii, j, 1);
                    if (CultureSpace.GetMap(p) == -1)
                    {
                        int ind = cells.Count;
                        cells.Add(new CellData
                        {
                            Index = ind,
                            Location = p,
                        });
                        CultureSpace.SetMap(p, ind);
                    }
                }
                cnt++;
            }
            return cells;
        }
        #endregion
        #region SingleColony_Layer
        private static int SeedingCellNumber_Colony(int layer)
        {
            int y2 = CultureSpace.Ysize / 2 - 1;
            double x2 = y2 % 2 == 0 ? CultureSpace.Xsize / 2 - 1 : CultureSpace.Xsize / 2 - 0.5;

            int cnt = 0;
            for (int j = 1; j < CultureSpace.Ysize - 1; j++)
            {
                for (int i = 1; i < CultureSpace.Xsize - 1; i++)
                {
                    double len = j % 2 == 0
                        ? Delta.GetLength(new Delta((int)((i - x2) * 2), j - y2, 0))
                        : Delta.GetLength(new Delta((int)((i - x2) * 2 + 1), j - y2, 0));
                    if (len <= layer) { cnt++; }
                }
            }
            return cnt;
        }
        private static List<CellData> CellInitialization_SingleColony()
        {
            int n = SeedingCellNumber_Colony(ColonyRadius);
            List<CellData> cells = new List<CellData>();
            for (int i = 0; i < n; i++)
            {
                cells.Add(new CellData());
            }

            return cells;
        }
        private static void InitialCellPlacement_SingleColony(List<CellData> cells)
        {
            int[] arr = new int[cells.Count];
            for (int i = 0; i < cells.Count; i++)
            { arr[i] = i; }

            int y2 = CultureSpace.Ysize / 2 - 1;
            double x2 = y2 % 2 == 0 ? CultureSpace.Xsize / 2 - 1 : CultureSpace.Xsize / 2 - 0.5;

            int cnt = 0;
            for (int j = 1; j < CultureSpace.Ysize - 1; j++)
            {
                for (int i = 1; i < CultureSpace.Xsize - 1; i++)
                {
                    if (cnt < cells.Count)
                    {
                        double len;
                        int ii;
                        if (j % 2 == 0)
                        {
                            len = Delta.GetLength(new Delta((int)((i - x2) * 2), j - y2, 0));
                            ii = i * 2;
                        }
                        else
                        {
                            len = Delta.GetLength(new Delta((int)((i - x2) * 2 + 1), j - y2, 0));
                            ii = i * 2 + 1;
                        }
                        if (len <= ColonyRadius && CultureSpace.GetMap(i * 2, j, 1) == -1)
                        {
                            int ind = arr[cnt];
                            cells[ind].Index = ind;
                            cells[ind].Location = new Point3D(ii, j, 1);
                            CultureSpace.SetMap(ii, j, 1, ind);
                            cnt++;
                        }
                    }
                }
            }
            if (cnt < cells.Count)
            {
                for (int i = 0; i < cells.Count - cnt; i++)
                {
                    cells.RemoveAt(cells.Count - 1 - i);
                }
            }
        }
        #endregion
        #region SingleColony_CellNumber
        private static List<CellData> CellInitialization_SingleColony_CellNumber()
        {
            List<CellData> cells = new List<CellData>();
            for (int i = 0; i < ColonyCells; i++)
            {
                cells.Add(new CellData());
            }

            return cells;
        }
        private static void InitialCellPlacement_SingleColony_CellNumber(List<CellData> cells)
        {
            int cellNum = (CultureSpace.Xsize - 2) * (CultureSpace.Ysize - 2);
            if (cellNum > cells.Count)
            { cellNum = cells.Count; }

            int y = CultureSpace.Ysize / 2;
            int x = y % 2 == 0 ? CultureSpace.Xsize : CultureSpace.Xsize + 1;
            cellNum--;
            Point3D center = BoundaryConditions.Check(x, y, 1);
            cells[0].Index = 0;
            cells[0].Location = center;
            CultureSpace.SetMap(center, 0);


            int k = 1;
            int cnt = 1;
            while (cellNum > 0)
            {
                List<Point3D> Ps = new List<Point3D>();
                for (int j = y - (int)(k / Delta.Cf_y); j <= y + (int)(k / Delta.Cf_y); j++)
                {
                    for (int i = x - k * 2; i <= x + k * 2; i += 2)
                    {
                        int ii = (j - y) % 2 == 0 ? i : i + 1;
                        Point3D p = BoundaryConditions.Check(ii, j, 1);
                        Delta d = new Delta(p.X - x, p.Y - y, 0);
                        if (Delta.GetLength(d) <= k && CultureSpace.GetMap(p) == -1)
                        {
                            Ps.Add(p);
                            cnt++;
                        }
                    }
                }

                if (Ps.Count < cellNum)
                {
                    for (int i = 0; i < Ps.Count; i++)
                    {
                        cellNum--;
                        int ind = cnt - Ps.Count + i;
                        cells[ind].Index = ind;
                        cells[ind].Location = Ps[i];
                        CultureSpace.SetMap(Ps[i], ind);
                    }
                }
                else
                {
                    int tmp = 0;
                    while (cellNum > 0)
                    {
                        int i = (int)(Ps.Count * Common.Rand_NextDouble());
                        if (CultureSpace.GetMap(Ps[i]) == -1)
                        {
                            for (int j = 7; j < 13; j++)
                            {
                                Point3D p = Ps[i] + Delta.GetDelta(j);
                                if (CultureSpace.GetMap(p) >= 0)
                                {
                                    cellNum--;
                                    int ind = cnt - Ps.Count + tmp++;
                                    cells[ind].Index = ind;
                                    cells[ind].Location = Ps[i];
                                    CultureSpace.SetMap(Ps[i], ind);
                                    break;
                                }
                            }
                        }
                    }
                }
                k++;
            }
        }
        #endregion
        #region Multiple colony or aggregation (Random)
        private static List<CellData> CellInitialization_MultipleColony_Random_MeanColony()
        {
            List<CellData> cells = new List<CellData>();
            int colonyNum = (int)RandomBoxMuller.Next(NumOfColonies, ColonyNum_SD);
            for (int n = 0; n < colonyNum; n++)
            {
                int cellNum = (int)RandomBoxMuller.Next(ColonyCellsMu, ColonyCellsSigma);

                CellInitialization_Multiple_SelectCenter(cells, out int x, out int y, out int z);
                cellNum--;

                int N = 1;
                while (cellNum > 0)
                {
                    List<Point3D> Ps = new List<Point3D>();
                    int k = z;
                    {
                        for (int j = y - (int)(N / Delta.Cf_y); j <= y + (int)(N / Delta.Cf_y); j++)
                        {
                            for (int i = x - N * 2; i <= x + N * 2; i += 2)
                            {
                                int ii = (j - y) % 2 == 0 ? i : i + 1;
                                Point3D p = BoundaryConditions.Check(ii, j, k);
                                if ((j - p.Y) % 2 != 0)
                                { p = BoundaryConditions.Check(ii + 1, p.Y, p.Z); }
                                Delta d = new Delta(ii - x, j - y, k - z);
                                if (Delta.GetLength(d) <= N && CultureSpace.GetMap(p) == -1)
                                { Ps.Add(p); }
                            }
                        }
                    }

                    CellInitialization_Multiple_SetCells(cells, ref cellNum, Ps);

                    if (Ps.Count == 0)
                    { N++; }
                }
            }

            return cells;
        }
        private static List<CellData> CellInitialization_MultipleColony_Random_Inoculum()
        {
            List<CellData> cells = new List<CellData>();
            int Nsub = GetNsub();
            double Ac = CultureSpace.Size_lc * CultureSpace.Size_lc * 1E-8 * Math.Sqrt(3) / 2.0;
            int Nseed = (int)(Ac * Nsub * X_0[0]);
            if (Nseed < NumOfColonies)
            {
                MessageBox.Show("(Nseed:" + Nseed + ") < (NumOfColonies:" + NumOfColonies + ")");
                return null;
            }
            for (int n = 0; n < NumOfColonies; n++)
            {
                int cellNum = (int)((double)(n + 1) * Nseed / NumOfColonies) - cells.Count;

                CellInitialization_Multiple_SelectCenter(cells, out int x, out int y, out int z);
                cellNum--;

                int N = 1;
                while (cellNum > 0)
                {
                    List<Point3D> Ps = new List<Point3D>();
                    int k = z;
                    {
                        for (int j = y - (int)(N / Delta.Cf_y); j <= y + (int)(N / Delta.Cf_y); j++)
                        {
                            for (int i = x - N * 2; i <= x + N * 2; i += 2)
                            {
                                int ii = (j - y) % 2 == 0 ? i : i + 1;
                                Point3D p = BoundaryConditions.Check(ii, j, k);
                                if ((j - p.Y) % 2 != 0)
                                { p = BoundaryConditions.Check(ii + 1, p.Y, p.Z); }
                                Delta d = new Delta(ii - x, j - y, k - z);
                                if (Delta.GetLength(d) <= N && CultureSpace.GetMap(p) == -1)
                                { Ps.Add(p); }
                            }
                        }
                    }

                    CellInitialization_Multiple_SetCells(cells, ref cellNum, Ps);

                    if (Ps.Count == 0)
                    { N++; }
                }
            }

            return cells;
        }
        private static List<CellData> CellInitialization_MultipleAggregation_Random()
        {
            List<CellData> cells = new List<CellData>();
            for (int n = 0; n < NumOfColonies; n++)
            {
                int cellNum = (int)RandomBoxMuller.Next(ColonyCellsMu, ColonyCellsSigma);

                CellInitialization_Multiple_SelectCenter(cells, out int x, out int y, out int z);
                cellNum--;

                int N = 1;
                while (cellNum > 0)
                {
                    List<Point3D> Ps = new List<Point3D>();
                    for (int k = z; k <= z + N; k++)
                    {
                        for (int j = y - (int)(N / Delta.Cf_y); j <= y + (int)(N / Delta.Cf_y); j++)
                        {
                            for (int i = x - N * 2; i <= x + N * 2; i += 2)
                            {
                                int ii = (j - y) % 2 == 0 ? i : i + 1;
                                Point3D p = BoundaryConditions.Check(ii, j, k);
                                if ((j - p.Y) % 2 != 0)
                                { p = BoundaryConditions.Check(ii + 1, p.Y, p.Z); }
                                Delta d = new Delta(ii - x, j - y, k - z);
                                if (Delta.GetLength(d) <= N && CultureSpace.GetMap(p) == -1)
                                { Ps.Add(p); }
                            }
                        }
                    }

                    CellInitialization_Multiple_SetCells(cells, ref cellNum, Ps);

                    if (Ps.Count == 0)
                    { N++; }
                }
            }

            return cells;
        }
        private static void CellInitialization_Multiple_SelectCenter(List<CellData> cells, out int x, out int y, out int z)
        {
            z = 1;
            while (true)
            {
                x = (int)((CultureSpace.Xsize - 2) * Common.Rand_NextDouble()) * 2;
                y = (int)((CultureSpace.Ysize - 2) * Common.Rand_NextDouble()) + 1;
                if (y % 2 == 1) { x++; }

                Point3D p = BoundaryConditions.Check(x, y, z);
                if (CultureSpace.GetMap(p) == -1)
                {
                    CellsAdd_SetMap(cells, p);
                    break;
                }
            }
        }
        private static void CellsAdd_SetMap(List<CellData> cells, Point3D p)
        {
            int ind = cells.Count;
            cells.Add(new CellData()
            {
                Index = ind,
                Location = p
            });
            CultureSpace.SetMap(p, ind);
        }
        private static void CellInitialization_Multiple_SetCells(List<CellData> cells, ref int cellNum, List<Point3D> Ps)
        {
            if (Ps.Count < cellNum)
            {
                while (Ps.Count > 0)
                {
                    cellNum--;
                    CellsAdd_SetMap(cells, Ps[0]);
                    Ps.RemoveAt(0);
                }
            }
            else
            {
                while (cellNum > 0 && Ps.Count > 0)
                {
                    int i = (int)(Ps.Count * Common.Rand_NextDouble());
                    if (CultureSpace.GetMap(Ps[i]) == -1)
                    {
                        for (int j = 0; j < 20; j++)
                        {
                            Point3D p = Ps[i] + Delta.GetDelta(j);
                            if (CultureSpace.GetMap(p) >= 0)
                            {
                                cellNum--;
                                CellsAdd_SetMap(cells, Ps[i]);
                                Ps.RemoveAt(i);
                                break;
                            }
                        }
                    }
                }
            }
        }
        #endregion
        #region Load cell placement
        private static List<CellData> CellInitialization_LoadCellPlacement()
        {
            List<CellData> cells = new List<CellData>();
            using (Bitmap img = (Bitmap)Image.FromFile(ImagePath))
            {
                int cnt = 0;
                for (int j = 1; j < CultureSpace.Ysize - 1; j++)
                {
                    for (int i = 1; i < CultureSpace.Xsize - 1; i++)
                    {
                        int ii = j % 2 == 0 ? i * 2 : i * 2 + 1;
                        int x = (int)((ii / 2.0 - 0.5) * CultureSpace.Size_lc / PixelSize);
                        int y = (int)((j - 0.5) * Delta.Cf_y * CultureSpace.Size_lc / PixelSize);
                        if (x >= 0 && x < img.Width && y >= 0 && y < img.Height)
                        {
                            int val = img.GetPixel(x, y).R + img.GetPixel(x, y).G + img.GetPixel(x, y).B;
                            if (val / 3.0 > 128)
                            {
                                Point3D p = new Point3D(ii, j, 1);
                                if (CultureSpace.GetMap(p) == -1)
                                {
                                    CellData c = new CellData()
                                    {
                                        Location = p,
                                        Index = cnt++
                                    };
                                    cells.Add(c);
                                    CultureSpace.SetMap(p, c.Index);
                                }
                            }
                        }
                    }
                }
            }
            return cells;
        }
        #endregion Load cell placement
        #region Non-uniform distribution
        private static void InitialCellPlacement_NonUniform(ref List<CellData> cells)
        {
            int y_center = CultureSpace.Ysize / 2 - 1;
            double x_center = y_center % 2 == 0 ? CultureSpace.Xsize / 2 - 1 : CultureSpace.Xsize / 2 - 0.5;
            double y_center_ = CultureSpace.Ysize * Delta.Cf_y / 2.0;
            double r = (y_center_ < x_center ? y_center_ : x_center) - 1;

            int[] inds = Common.RandomlySort(cells);
            foreach (int i in inds)
            {
                int cnt = 0;
                while (true)
                {
                    double theta = 2.0 * Math.PI * Common.Rand_NextDouble();
                    double r1 = Math.Sqrt(Common.Rand_NextDouble());

                    double _y = r * r1 * Math.Sin(theta);
                    int y = (int)Math.Round(_y / Delta.Cf_y + y_center);

                    double _x = r * r1 * Math.Cos(theta);
                    int x = (int)Math.Round(_x + x_center) * 2 + (y % 2 == 1 ? 1 : 0);

                    {
                        Point3D p = new Point3D(x, y, 1);
                        if (CultureSpace.GetMap(p) == -1)
                        {
                            double pr;
                            if (Uniformity_Inf)
                            { pr = 1.0; }
                            else
                            {
                                pr = Math.Exp(-r1 / Uniformity / r)
                                    / (Uniformity * r * (1.0 - Math.Exp(-1.0 / Uniformity)));
                            }
                            if (Common.Rand_NextDouble() < pr)
                            {
                                cells[i].Location = p;
                                CultureSpace.SetMap(p, i);
                                break;
                            }
                        }
                        if (cnt++ == int.MaxValue)
                        {
                            cells = null;
                            break;
                        }
                    }
                }
                if (cells == null)
                { break; }
            }
        }
        #endregion
    }
}
