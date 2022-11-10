using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CellBehaviorSimulator.CultureEnvironments;
using CellBehaviorSimulator.CellBehaviors;

namespace CellBehaviorSimulator
{
    public partial class Output : UserControl
    {
        public Output()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void Output_Load(object sender, EventArgs e)
        {
            OutputDir = "";
            StepInterval = 0;
        }
        private void ButtonOutputPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbDialog = new FolderBrowserDialog())
            {
                if (Directory.Exists(textBoxOutputPath.Text))
                {
                    fbDialog.SelectedPath = textBoxOutputPath.Text;
                }
                if (fbDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxOutputPath.Text = fbDialog.SelectedPath;
                    OutputDir = fbDialog.SelectedPath;
                }
            }
        }
        private void TextBoxOutputPath_TextChanged(object sender, EventArgs e)
        {
            OutputDir = textBoxOutputPath.Text;
        }
        private void TextBoxOutputPath_Leave(object sender, EventArgs e)
        {
            if (textBoxOutputPath.Text != "")
            {
                if (!Directory.Exists(textBoxOutputPath.Text))
                {
                    string dir;
                    if (Path.IsPathRooted(OutputDir))
                    { dir = OutputDir; }
                    else
                    {
                        dir = Path.Combine(System.Environment.CurrentDirectory, OutputDir);
                    }
                    DialogResult dr = MessageBox.Show("The given path does not refer to an existing directory on disk.\nCreate a new folder : " + dir, "Caution", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            Directory.CreateDirectory(dir);
                            textBoxOutputPath.Text = dir;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Can not create a new folder.");
                            textBoxOutputPath.Select();
                            textBoxOutputPath.SelectAll();
                        }
                    }
                    else
                    {
                        textBoxOutputPath.Select();
                        textBoxOutputPath.SelectAll();
                    }
                }
            }
        }
        private void Num_DeltaTout_ValueChanged(object sender, EventArgs e)
        {
            StepInterval = (int)num_StepInter.Value;
        }
        private void CheckSaveCellCount_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellCount = checkSaveCellCount.Checked;
        }
        private void CheckSaveSubstrate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSaveSubstrate.Checked)
            {
                checkSaveSubstrate.Checked = CheckSubstrateAbility();
            }
            SaveSubstrate = checkSaveSubstrate.Checked;
        }
        #region Cells data
        private void CheckSaveCellsData_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellsData = checkSaveCellsData.Checked;
            groupCellData.Visible = checkSaveCellsData.Checked;

            if (!checkSaveCellsData.Checked)
            {
                checkCellsData_Coordinates.Checked = false;
                checkCellsData_HexCoordinates.Checked = false;
                checkCellsData_N.Checked = false;
                checkCellsData_S.Checked = false;
                checkCellsData_T.Checked = false;
                checkCellsData_t_age.Checked = false;
                checkCellsData_t_d.Checked = false;
                checkCellsData_t_m.Checked = false;
                checkCellsData_V_m.Checked = false;
                checkCellsData_E_AJ.Checked = false;
                checkCellsData_E_TJ.Checked = false;
                checkCellsData_E_cs.Checked = false;
                checkCellsData_E_max.Checked = false;
                checkCellsData_Dir_am.Checked = false;
                checkCellsData_Dir_pm.Checked = false;
                checkCellsData_Dir_pd.Checked = false;
                checkCellsData_THETA.Checked = false;
                checkCellsData_T_de_am.Checked = false;
                checkCellsData_T_de_total.Checked = false;
                checkCellsData_E_cc_total.Checked = false;
                checkCellsData_E_c_total.Checked = false;
            }
        }
        private void ButtonSaveAllCellsData_Click(object sender, EventArgs e)
        {
            checkCellsData_Index.Checked = true;
            checkCellsData_Coordinates.Checked = true;
            checkCellsData_HexCoordinates.Checked = true;
            checkCellsData_N.Checked = true;
            checkCellsData_S.Checked = true;
            checkCellsData_T.Checked = true;
            checkCellsData_t_age.Checked = true;
            checkCellsData_t_d.Checked = true;
            checkCellsData_t_m.Checked = true;
            checkCellsData_V_m.Checked = true;
            checkCellsData_E_AJ.Checked = true;
            checkCellsData_E_TJ.Checked = true;
            checkCellsData_E_cs.Checked = true;
            checkCellsData_E_max.Checked = true;
            checkCellsData_Dir_am.Checked = true;
            checkCellsData_Dir_pm.Checked = true;
            checkCellsData_Dir_pd.Checked = true;
            checkCellsData_THETA.Checked = true;
            checkCellsData_T_de_am.Checked = true;
            checkCellsData_T_de_total.Checked = true;
            checkCellsData_CellMovement.Checked = true;
        }
        private void CheckCellsData_Index_CheckedChanged(object sender, EventArgs e)
        {
            checkCellsData_Index.Checked = true;
        }
        private void CheckCellsData_Coordinates_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellsData_Coordinates = checkCellsData_Coordinates.Checked;
        }
        private void CheckCellsData_HexCoordinates_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellsData_HexCoordinates = checkCellsData_HexCoordinates.Checked;
        }
        private void CheckCellsData_N_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellsData_Cell_N = checkCellsData_N.Checked;
        }
        private void CheckCellsData_S_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellsData_Cell_S = checkCellsData_S.Checked;
        }
        private void CheckCellsData_T_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellsData_Cell_T = checkCellsData_T.Checked;
        }
        private void CheckCellsData_t_age_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellsData_t_age = checkCellsData_t_age.Checked;
        }
        private void CheckCellsData_t_d_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellsData_t_d = checkCellsData_t_d.Checked;
        }
        private void CheckCellsData_t_m_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellsData_t_m = checkCellsData_t_m.Checked;
        }
        private void CheckCellsData_V_m_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellsData_V_m = checkCellsData_V_m.Checked;
        }
        private void CheckCellsData_E_AJ_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellsData_E_AJ = checkCellsData_E_AJ.Checked;
        }
        private void CheckCellsData_E_TJ_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellsData_E_TJ = checkCellsData_E_TJ.Checked;
        }
        private void CheckCellsData_E_cs_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellsData_E_cs = checkCellsData_E_cs.Checked;
        }
        private void CheckCellsData_E_max_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellsData_E_max = checkCellsData_E_max.Checked;
        }
        private void CheckCellsData_Dir_am_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellsData_dir_am = checkCellsData_Dir_am.Checked;
        }
        private void CheckCellsData_Dir_pm_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellsData_dir_pm = checkCellsData_Dir_pm.Checked;
        }
        private void CheckCellsData_Dir_pd_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellsData_dir_pd = checkCellsData_Dir_pd.Checked;
        }
        private void CheckCellsData_THETA_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellsData_THETA = checkCellsData_THETA.Checked;
        }
        private void CheckCellsData_T_de_act_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellsData_T_de_am = checkCellsData_T_de_am.Checked;
        }
        private void CheckCellData_T_de_total_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellsData_T_de_total = checkCellsData_T_de_total.Checked;
        }
        private void CheckCellsData_CellMovement_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellsData_CellMovement = checkCellsData_CellMovement.Checked;
        }
        private void CheckCellsData_MethylationRatio_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void CheckCellsData_E_cc_total_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellsData_E_cc = checkCellsData_E_cc_total.Checked;
        }
        private void CheckCellsData_E_c_CheckedChanged(object sender, EventArgs e)
        {
            SaveCellsData_E_c = checkCellsData_E_c_total.Checked;
        }
        #endregion
        #region Raw image
        private void CheckSaveRawImg_CheckedChanged(object sender, EventArgs e)
        {
            SaveRawImg = checkSaveRawImg.Checked;
            groupRawImage.Visible = checkSaveRawImg.Checked;
        }
        private void CheckRawImg_Index_CheckedChanged(object sender, EventArgs e)
        {
            SaveRawImg_CellIndex = checkRawImg_Index.Checked;
        }
        private void CheckRawImg_CellType_CheckedChanged(object sender, EventArgs e)
        {
            SaveRawImg_CellType = checkRawImg_CellType.Checked;
        }
        private void CheckRawImg_CellState_CheckedChanged(object sender, EventArgs e)
        {
            SaveRawImg_CellState = checkRawImg_CellType.Checked;
        }
        private void CheckRawImg_CellAge_CheckedChanged(object sender, EventArgs e)
        {
            SaveRawImg_CellAge = checkRawImg_CellAge.Checked;
        }
        private void CheckRawImg_Substrate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRawImg_Substrate.Checked)
            {
                checkRawImg_Substrate.Checked = CheckSubstrateAbility();
            }
            SaveRawImg_Substrate = checkRawImg_Substrate.Checked;
        }
        #endregion
        private static bool CheckSubstrateAbility()
        {
            bool flag = true;
            if (!SubstrateAbility.Flag)
            {
                MessageBox.Show("The substrate-ability module is not enabled.");
                flag = false;
            }
            return flag;
        }
        #endregion
        #region Parameter setting
        internal void SetParameter()
        {
            num_StepInter.Value = StepInterval;
            checkSaveCellCount.Checked = SaveCellCount;
            checkSaveSubstrate.Checked = SaveSubstrate;
            checkSaveCellsData.Checked = SaveCellsData;
            checkCellsData_Index.Checked = SaveCellsData_Index;
            checkCellsData_Coordinates.Checked = SaveCellsData_Coordinates;
            checkCellsData_HexCoordinates.Checked = SaveCellsData_HexCoordinates;
            checkCellsData_N.Checked = SaveCellsData_Cell_N;
            checkCellsData_S.Checked = SaveCellsData_Cell_S;
            checkCellsData_T.Checked = SaveCellsData_Cell_T;
            checkCellsData_t_age.Checked = SaveCellsData_t_age;
            checkCellsData_t_d.Checked = SaveCellsData_t_d;
            checkCellsData_t_m.Checked = SaveCellsData_t_m;
            checkCellsData_V_m.Checked = SaveCellsData_V_m;
            checkCellsData_E_AJ.Checked = SaveCellsData_E_AJ;
            checkCellsData_E_TJ.Checked = SaveCellsData_E_TJ;
            checkCellsData_E_cs.Checked = SaveCellsData_E_cs;
            checkCellsData_E_max.Checked = SaveCellsData_E_max;
            checkCellsData_Dir_am.Checked = SaveCellsData_dir_am;
            checkCellsData_Dir_pm.Checked = SaveCellsData_dir_pm;
            checkCellsData_Dir_pd.Checked = SaveCellsData_dir_pd;
            checkCellsData_THETA.Checked = SaveCellsData_THETA;
            checkCellsData_T_de_am.Checked = SaveCellsData_T_de_am;
            checkCellsData_T_de_total.Checked = SaveCellsData_T_de_total;
            checkCellsData_CellMovement.Checked = SaveCellsData_CellMovement;
            checkCellsData_E_c_total.Checked = SaveCellsData_E_c;
            checkCellsData_E_cc_total.Checked = SaveCellsData_E_cc;
            checkSaveRawImg.Checked = SaveRawImg;
            checkRawImg_Index.Checked = SaveRawImg_CellIndex;
            checkRawImg_CellType.Checked = SaveRawImg_CellType;
            checkRawImg_CellState.Checked = SaveRawImg_CellState;
            checkRawImg_CellAge.Checked = SaveRawImg_CellAge;
            checkRawImg_Substrate.Checked = SaveRawImg_Substrate;
        }
        public static void Set_OutputPath(string strVal) => OutputDir = strVal;
        #endregion
        #region Parameter definition
        public enum ParamDef
        {
            Str_OutputStepInterval = 0,
        }

        public const string Str_OutputStepInterval = "OutputStepInterval";
        public const string Str_SaveCellCount = "Save_CellCount";
        public const string Str_SaveSubstrate = "Save_Substrate";
        public const string Str_SaveCellsData = "Save_CellsData";
        public const string Str_SaveCellsData_Index = "Save_CellsData_Index";
        public const string Str_SaveCellsData_Coordinates = "Save_CellsData_Coordinates";
        public const string Str_SaveCellsData_HexCoordinates = "Save_HexCoordinates";
        public const string Str_SaveCellsData_Cell_N = "Save_CellsData_Cell_N";
        public const string Str_SaveCellsData_Cell_S = "Save_CellsData_Cell_S";
        public const string Str_SaveCellsData_Cell_T = "Save_CellsData_Cell_T";
        public const string Str_SaveCellsData_t_age = "Save_CellsData_t_age";
        public const string Str_SaveCellsData_t_d = "Save_CellsData_t_d_c";
        public const string Str_SaveCellsData_t_m = "Save_CellsData_t_m_c";
        public const string Str_SaveCellsData_V_m = "Save_CellsData_V_m_c";
        public const string Str_SaveCellsData_E_AJ = "Save_CellsData_E_AJ_c";
        public const string Str_SaveCellsData_E_TJ = "Save_CellsData_E_TJ_c";
        public const string Str_SaveCellsData_E_cs = "Save_CellsData_E_cs_c";
        public const string Str_SaveCellsData_E_max = "Save_CellsData_E_max_c";
        public const string Str_SaveCellsData_Dir_am = "Save_CellsData_Dir_am";
        public const string Str_SaveCellsData_Dir_pm = "Save_CellsData_Dir_pm";
        public const string Str_SaveCellsData_Dir_pd = "Save_CellsData_Dir_pd";
        public const string Str_SaveCellsData_THETA = "Save_CellsData_THETA";
        public const string Str_SaveCellsData_T_de_act = "Save_CellsData_T_de_act_c";
        public const string Str_SaveCellsData_T_de_total = "Save_CellsData_T_de_total_c";
        public const string Str_SaveCellsData_CellMovement = "Save_CellsData_CellMovement";
        public const string Str_SaveCellsData_MethylationRatio = "Save_CellsData_MethylationRatio";
        public const string Str_SaveCellsData_E_cc_total = "Save_CellsData_E_cc_total";
        public const string Str_SaveCellsData_E_c_total = "Save_CellsData_E_c_total";
        public const string Str_SaveImage_CellIndex = "Save_RawImage_CellIndex";
        public const string Str_SaveImage_CellType = "Save_RawImage_CellType";
        public const string Str_SaveImage_CellState = "Save_RawImage_CellState";
        public const string Str_SaveImage_CellAge = "Save_RawImage_CellAge";
        public const string Str_SaveImage_Substrate = "Save_RawImage_Substrate";
        public const string Str_SaveMQO_Index = "Save_MQO_Index";
        public const string Str_SaveMQO_CellType = "Save_MQO_CellType";
        public const string Str_SaveMQO_CellState = "Save_MQO_CellState";
        public const string Str_SaveMQO_Substrate = "Save_MQO_Substrate";
        public const string Str_MQO_view = "MQO_view";
        #endregion
        #region Parameters related to simulator input/output
        public static void WriteParameter(System.IO.StreamWriter sw)
        {
            sw.WriteLine("# Definition of output parameters");
            sw.WriteLine(":," + Str_OutputStepInterval + "," + StepInterval);
            if (SaveCellCount)
            { sw.WriteLine(":," + Str_SaveCellCount + "," + SaveCellCount); }
            if (SaveSubstrate)
            { sw.WriteLine(":," + Str_SaveSubstrate + "," + SaveSubstrate); }
            if (SaveCellsData)
            {
                if (CheckParameter_SaveCellsData())
                { sw.WriteLine(":," + Str_SaveCellsData + "," + SaveCellsData); }
                else
                {
                    if (SaveCellsData_Index)
                    { sw.WriteLine(":," + Str_SaveCellsData_Index + "," + SaveCellsData_Index); }
                    if (SaveCellsData_Coordinates)
                    { sw.WriteLine(":," + Str_SaveCellsData_Coordinates + "," + SaveCellsData_Coordinates); }
                    if (SaveCellsData_HexCoordinates)
                    { sw.WriteLine(":," + Str_SaveCellsData_HexCoordinates + "," + SaveCellsData_HexCoordinates); }
                    if (SaveCellsData_Cell_N)
                    { sw.WriteLine(":," + Str_SaveCellsData_Cell_N + "," + SaveCellsData_Cell_N); }
                    if (SaveCellsData_Cell_S)
                    { sw.WriteLine(":," + Str_SaveCellsData_Cell_S + "," + SaveCellsData_Cell_S); }
                    if (SaveCellsData_Cell_T)
                    { sw.WriteLine(":," + Str_SaveCellsData_Cell_T + "," + SaveCellsData_Cell_T); }
                    if (SaveCellsData_t_age)
                    { sw.WriteLine(":," + Str_SaveCellsData_t_age + "," + SaveCellsData_t_age); }
                    if (SaveCellsData_t_d)
                    { sw.WriteLine(":," + Str_SaveCellsData_t_d + "," + SaveCellsData_t_d); }
                    if (SaveCellsData_t_m)
                    { sw.WriteLine(":," + Str_SaveCellsData_t_m + "," + SaveCellsData_t_m); }
                    if (SaveCellsData_V_m)
                    { sw.WriteLine(":," + Str_SaveCellsData_V_m + "," + SaveCellsData_V_m); }
                    if (SaveCellsData_E_AJ)
                    { sw.WriteLine(":," + Str_SaveCellsData_E_AJ + "," + SaveCellsData_E_AJ); }
                    if (SaveCellsData_E_TJ)
                    { sw.WriteLine(":," + Str_SaveCellsData_E_TJ + "," + SaveCellsData_E_TJ); }
                    if (SaveCellsData_E_cs)
                    { sw.WriteLine(":," + Str_SaveCellsData_E_cs + "," + SaveCellsData_E_cs); }
                    if (SaveCellsData_E_max)
                    { sw.WriteLine(":," + Str_SaveCellsData_E_max + "," + SaveCellsData_E_max); }
                    if (SaveCellsData_dir_am)
                    { sw.WriteLine(":," + Str_SaveCellsData_Dir_am + "," + SaveCellsData_dir_am); }
                    if (SaveCellsData_dir_pm)
                    { sw.WriteLine(":," + Str_SaveCellsData_Dir_pm + "," + SaveCellsData_dir_pm); }
                    if (SaveCellsData_dir_pd)
                    { sw.WriteLine(":," + Str_SaveCellsData_Dir_pd + "," + SaveCellsData_dir_pd); }
                    if (SaveCellsData_THETA)
                    { sw.WriteLine(":," + Str_SaveCellsData_THETA + "," + SaveCellsData_THETA); }
                    if (SaveCellsData_T_de_am)
                    { sw.WriteLine(":," + Str_SaveCellsData_T_de_act + "," + SaveCellsData_T_de_am); }
                    if (SaveCellsData_T_de_total)
                    { sw.WriteLine(":," + Str_SaveCellsData_T_de_total + "," + SaveCellsData_T_de_total); }
                    if (SaveCellsData_CellMovement)
                    { sw.WriteLine(":," + Str_SaveCellsData_CellMovement + "," + SaveCellsData_CellMovement); }
                    if (SaveCellsData_E_cc)
                    { sw.WriteLine(":," + Str_SaveCellsData_E_cc_total + "," + SaveCellsData_E_cc); }
                    if (SaveCellsData_E_c)
                    { sw.WriteLine(":," + Str_SaveCellsData_E_c_total + "," + SaveCellsData_E_c); }
                }
            }
            if (SaveRawImg)
            {
                if (SaveRawImg_CellIndex)
                { sw.WriteLine(":," + Str_SaveImage_CellIndex + "," + SaveRawImg_CellIndex); }
                if (SaveRawImg_CellType)
                { sw.WriteLine(":," + Str_SaveImage_CellType + "," + SaveRawImg_CellType); }
                if (SaveRawImg_CellState)
                { sw.WriteLine(":," + Str_SaveImage_CellState + "," + SaveRawImg_CellState); }
                if (SaveRawImg_CellAge)
                { sw.WriteLine(":," + Str_SaveImage_CellAge + "," + SaveRawImg_CellAge); }
                if (SaveRawImg_Substrate)
                { sw.WriteLine(":," + Str_SaveImage_Substrate + "," + SaveRawImg_Substrate); }
            }
            if (SaveMQO)
            {
                if (SaveMQO_CellIndex)
                { sw.WriteLine(":," + Str_SaveMQO_Index + "," + SaveMQO_CellIndex); }
                if (SaveMQO_CellType)
                { sw.WriteLine(":," + Str_SaveMQO_CellType + "," + SaveMQO_CellType); }
                if (SaveMQO_CellState)
                { sw.WriteLine(":," + Str_SaveMQO_CellState + "," + SaveMQO_CellState); }
                if (SaveMQO_Substrate)
                { sw.WriteLine(":," + Str_SaveMQO_Substrate + "," + SaveMQO_Substrate); }
                sw.WriteLine(":," + Str_MQO_view + "," + MQOView + ",0 -> Plan view; 1 -> Bird's eye view");
            }
        }
        public static bool ReadParameter(string strName, string strValue)
        {
            switch (strName)
            {
                case Str_OutputStepInterval: return SetParameter_StepInterval(strValue);
                case "SaveCellCount":
                case Str_SaveCellCount: return SetParameter_SaveCellCount(strValue);
                case Str_SaveSubstrate: return SetParameter_SaveSubstrate(strValue);
                case "SaveCellsData":
                case Str_SaveCellsData: return SetParameter_SaveCellsData(strValue);
                case Str_SaveCellsData_Index: return SetParameter_SaveCellsData_Index(strValue);
                case Str_SaveCellsData_Coordinates: return SetParameter_SaveCellsData_Coordinates(strValue);
                case Str_SaveCellsData_HexCoordinates: return SetParameter_SaveCellsData_HexCoordinates(strValue);
                case Str_SaveCellsData_Cell_N: return SetParameter_SaveCellsData_Cell_N(strValue);
                case Str_SaveCellsData_Cell_S: return SetParameter_SaveCellsData_Cell_S(strValue);
                case Str_SaveCellsData_Cell_T: return SetParameter_SaveCellsData_Cell_T(strValue);
                case Str_SaveCellsData_t_age: return SetParameter_SaveCellsData_t_age(strValue);
                case Str_SaveCellsData_t_d: return SetParameter_SaveCellsData_t_d(strValue);
                case Str_SaveCellsData_t_m: return SetParameter_SaveCellsData_t_m(strValue);
                case Str_SaveCellsData_V_m: return SetParameter_SaveCellsData_V_m(strValue);
                case Str_SaveCellsData_E_AJ: return SetParameter_SaveCellsData_E_AJ(strValue);
                case Str_SaveCellsData_E_TJ: return SetParameter_SaveCellsData_E_TJ(strValue);
                case Str_SaveCellsData_E_cs: return SetParameter_SaveCellsData_E_cs(strValue);
                case Str_SaveCellsData_E_max: return SetParameter_SaveCellsData_E_max(strValue);
                case Str_SaveCellsData_Dir_am: return SetParameter_SaveCellsData_Dir_am(strValue);
                case Str_SaveCellsData_Dir_pm: return SetParameter_SaveCellsData_Dir_pm(strValue);
                case Str_SaveCellsData_Dir_pd: return SetParameter_SaveCellsData_Dir_pd(strValue);
                case Str_SaveCellsData_THETA: return SetParameter_SaveCellsData_THETA(strValue);
                case Str_SaveCellsData_T_de_act: return SetParameter_SaveCellsData_T_de_act(strValue);
                case Str_SaveCellsData_T_de_total: return SetParameter_SaveCellsData_T_de_total(strValue);
                case Str_SaveCellsData_CellMovement: return SetParameter_SaveCellsData_CellMovement(strValue);
                case Str_SaveCellsData_E_cc_total: return SetParameter_SaveCellsData_E_cc_total(strValue);
                case Str_SaveCellsData_E_c_total: return SetParameter_SaveCellsData_E_c_total(strValue);
                case Str_SaveImage_CellIndex: return SetParameter_SaveRawCellIndex(strValue);
                case Str_SaveImage_CellType: return SetParameter_SaveRawCellType(strValue);
                case Str_SaveImage_CellState: return SetParameter_SaveRawCellState(strValue);
                case Str_SaveImage_CellAge: return SetParameter_SaveRawCellAge(strValue);
                case Str_SaveImage_Substrate: return SetParameter_SaveRawSubstrate(strValue);
                case Str_SaveMQO_Index: return SetParameter_SaveMQOIndex(strValue);
                case Str_SaveMQO_CellType: return SetParameter_SaveMQOCellType(strValue);
                case Str_SaveMQO_CellState: return SetParameter_SaveMQOCellState(strValue);
                case Str_SaveMQO_Substrate: return SetParameter_SaveMQOSubstrate(strValue);
                case Str_MQO_view: return SetParameter_MQOView(strValue);
                default: return false;
            }
        }
        public static void ClearParameter()
        {
            StepInterval = 0;
            SaveCellCount = false;
            SaveSubstrate = false;
            SaveCellsData = false;
            SaveCellsData_Index = false;
            SaveCellsData_Coordinates = false;
            SaveCellsData_HexCoordinates = false;
            SaveCellsData_Cell_N = false;
            SaveCellsData_Cell_S = false;
            SaveCellsData_Cell_T = false;
            SaveCellsData_t_age = false;
            SaveCellsData_t_d = false;
            SaveCellsData_t_m = false;
            SaveCellsData_V_m = false;
            SaveCellsData_E_AJ = false;
            SaveCellsData_E_TJ = false;
            SaveCellsData_E_cs = false;
            SaveCellsData_E_max = false;
            SaveCellsData_dir_am = false;
            SaveCellsData_dir_pm = false;
            SaveCellsData_dir_pd = false;
            SaveCellsData_THETA = false;
            SaveCellsData_T_de_am = false;
            SaveCellsData_T_de_total = false;
            SaveCellsData_CellMovement = false;
            SaveCellsData_E_cc = false;
            SaveCellsData_E_c = false;
            SaveRawImg = false;
            SaveRawImg_CellIndex = false;
            SaveRawImg_CellType = false;
            SaveRawImg_CellState = false;
            SaveRawImg_CellAge = false;
            SaveRawImg_Substrate = false;
            SaveMQO = false;
            SaveMQO_CellIndex = false;
            SaveMQO_CellType = false;
            SaveMQO_CellState = false;
            SaveMQO_Substrate = false;
            MQOView = 0;
        }
        private static bool SetParameter_StepInterval(string strVal)
        {
            if (int.TryParse(strVal, out int val))
            {
                StepInterval = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellCount(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                SaveCellCount = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveSubstrate(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                SaveSubstrate = val;
                return true;
            }
            return false;
        }
        #region Cells data
        private static bool CheckParameter_SaveCellsData()
        {
            return
                SaveCellsData &&
                SaveCellsData_Index &&
                SaveCellsData_Coordinates &&
                SaveCellsData_HexCoordinates &&
                SaveCellsData_Cell_N &&
                SaveCellsData_Cell_S &&
                SaveCellsData_Cell_T &&
                SaveCellsData_t_age &&
                SaveCellsData_t_d &&
                SaveCellsData_t_m &&
                SaveCellsData_V_m &&
                SaveCellsData_E_AJ &&
                SaveCellsData_E_TJ &&
                SaveCellsData_E_cs &&
                SaveCellsData_E_max &&
                SaveCellsData_dir_am &&
                SaveCellsData_dir_pm &&
                SaveCellsData_dir_pd &&
                SaveCellsData_THETA &&
                SaveCellsData_T_de_am &&
                SaveCellsData_T_de_total &&
                SaveCellsData_CellMovement;
        }
        private static bool SetParameter_SaveCellsData(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                SaveCellsData = val;
                SaveCellsData_Index = val;
                SaveCellsData_Coordinates = val;
                SaveCellsData_HexCoordinates = val;
                SaveCellsData_Cell_N = val;
                SaveCellsData_Cell_S = val;
                SaveCellsData_Cell_T = val;
                SaveCellsData_t_age = val;
                SaveCellsData_t_d = val;
                SaveCellsData_t_m = val;
                SaveCellsData_V_m = val;
                SaveCellsData_E_AJ = val;
                SaveCellsData_E_TJ = val;
                SaveCellsData_E_cs = val;
                SaveCellsData_E_max = val;
                SaveCellsData_dir_am = val;
                SaveCellsData_dir_pm = val;
                SaveCellsData_dir_pd = val;
                SaveCellsData_THETA = val;
                SaveCellsData_T_de_am = val;
                SaveCellsData_T_de_total = val;
                SaveCellsData_CellMovement = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellsData_Index(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val & !SaveCellsData) { SaveCellsData = true; }
                SaveCellsData_Index = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellsData_Coordinates(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val & !SaveCellsData) { SaveCellsData = true; }
                SaveCellsData_Coordinates = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellsData_HexCoordinates(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val & !SaveCellsData) { SaveCellsData = true; }
                SaveCellsData_HexCoordinates = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellsData_Cell_N(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val & !SaveCellsData) { SaveCellsData = true; }
                SaveCellsData_Cell_N = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellsData_Cell_S(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val & !SaveCellsData) { SaveCellsData = true; }
                SaveCellsData_Cell_S = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellsData_Cell_T(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val & !SaveCellsData) { SaveCellsData = true; }
                SaveCellsData_Cell_T = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellsData_t_age(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val & !SaveCellsData) { SaveCellsData = true; }
                SaveCellsData_t_age = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellsData_t_d(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val & !SaveCellsData) { SaveCellsData = true; }
                SaveCellsData_t_d = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellsData_t_m(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val & !SaveCellsData) { SaveCellsData = true; }
                SaveCellsData_t_m = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellsData_V_m(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val & !SaveCellsData) { SaveCellsData = true; }
                SaveCellsData_V_m = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellsData_E_AJ(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val & !SaveCellsData) { SaveCellsData = true; }
                SaveCellsData_E_AJ = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellsData_E_TJ(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val & !SaveCellsData) { SaveCellsData = true; }
                SaveCellsData_E_TJ = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellsData_E_cs(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val & !SaveCellsData) { SaveCellsData = true; }
                SaveCellsData_E_cs = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellsData_E_max(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val & !SaveCellsData) { SaveCellsData = true; }
                SaveCellsData_E_max = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellsData_Dir_am(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val & !SaveCellsData) { SaveCellsData = true; }
                SaveCellsData_dir_am = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellsData_Dir_pm(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val & !SaveCellsData) { SaveCellsData = true; }
                SaveCellsData_dir_pm = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellsData_Dir_pd(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val & !SaveCellsData) { SaveCellsData = true; }
                SaveCellsData_dir_pd = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellsData_THETA(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val & !SaveCellsData) { SaveCellsData = true; }
                SaveCellsData_THETA = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellsData_T_de_act(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val & !SaveCellsData) { SaveCellsData = true; }
                SaveCellsData_T_de_am = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellsData_T_de_total(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val & !SaveCellsData) { SaveCellsData = true; }
                SaveCellsData_T_de_total = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellsData_CellMovement(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val & !SaveCellsData) { SaveCellsData = true; }
                SaveCellsData_CellMovement = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellsData_E_cc_total(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val & !SaveCellsData) { SaveCellsData = true; }
                SaveCellsData_E_cc = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveCellsData_E_c_total(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val & !SaveCellsData) { SaveCellsData = true; }
                SaveCellsData_E_c = val;
                return true;
            }
            return false;
        }
        #endregion
        #region Raw image
        private static bool SetParameter_SaveRawCellIndex(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val) { SaveRawImg = true; }
                SaveRawImg_CellIndex = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveRawCellType(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val) { SaveRawImg = true; }
                SaveRawImg_CellType = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveRawCellState(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val) { SaveRawImg = true; }
                SaveRawImg_CellState = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveRawCellAge(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val) { SaveRawImg = true; }
                SaveRawImg_CellAge = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveRawSubstrate(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val) { SaveRawImg = true; }
                SaveRawImg_Substrate = val;
                return true;
            }
            return false;
        }
        #endregion
        #region MQO
        private static bool SetParameter_SaveMQOIndex(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val) { SaveMQO = true; }
                SaveMQO_CellIndex = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveMQOCellType(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val) { SaveMQO = true; }
                SaveMQO_CellType = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveMQOCellState(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val) { SaveMQO = true; }
                SaveMQO_CellState = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_SaveMQOSubstrate(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                if (val) { SaveMQO = true; }
                SaveMQO_Substrate = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_MQOView(string strVal)
        {
            return int.TryParse(strVal, out MQOView);
        }
        #endregion
        #endregion

        private static string OutputDir;
        private static int StepInterval = 0;
        private static bool SaveCellCount = false;
        private static bool SaveSubstrate = false;
        private static bool SaveCellsData = false;
        private static bool SaveCellsData_Index = false;
        private static bool SaveCellsData_Coordinates = false;
        private static bool SaveCellsData_HexCoordinates = false;
        private static bool SaveCellsData_Cell_N = false;
        private static bool SaveCellsData_Cell_S = false;
        private static bool SaveCellsData_Cell_T = false;
        private static bool SaveCellsData_t_age = false;
        private static bool SaveCellsData_t_d = false;
        private static bool SaveCellsData_t_m = false;
        private static bool SaveCellsData_V_m = false;
        private static bool SaveCellsData_E_AJ = false;
        private static bool SaveCellsData_E_TJ = false;
        private static bool SaveCellsData_E_cs = false;
        private static bool SaveCellsData_E_max = false;
        private static bool SaveCellsData_dir_am = false;
        private static bool SaveCellsData_dir_pm = false;
        private static bool SaveCellsData_dir_pd = false;
        private static bool SaveCellsData_THETA = false;
        private static bool SaveCellsData_T_de_am = false;
        private static bool SaveCellsData_T_de_total = false;
        private static bool SaveCellsData_CellMovement = false;
        private static bool SaveCellsData_E_cc = false;
        private static bool SaveCellsData_E_c = false;
        private static bool SaveRawImg = false;
        private static bool SaveRawImg_CellIndex = false;
        private static bool SaveRawImg_CellType = false;
        private static bool SaveRawImg_CellState = false;
        private static bool SaveRawImg_CellAge = false;
        private static bool SaveRawImg_Substrate = false;
        private static bool SaveMQO = false;
        private static bool SaveMQO_CellIndex = false;
        private static bool SaveMQO_CellType = false;
        private static bool SaveMQO_CellState = false;
        private static bool SaveMQO_Substrate = false;
        private static int MQOView = 0;

        public static bool SaveInitialFile(string version, string date)
        {
            if (OutputDir == "" || OutputDir == null)
            { return false; }
            Directory.CreateDirectory(OutputDir);
            InputParameter.SaveParameter(Path.Combine(OutputDir, "initialize.csv"));
            using (StreamWriter sw = new StreamWriter(File.Open(Path.Combine(OutputDir, "version.txt"), FileMode.Create)))
            {
                sw.WriteLine("Last Updated on " + date + "\n" + version);
            }
            return true;
        }
        public static void SaveSeedingError(double before, double after)
        {
            if (OutputDir == "" || OutputDir == null)
            { return; }
            Directory.CreateDirectory(OutputDir);
            string folder = Path.GetDirectoryName(OutputDir);
            string filename = Path.Combine(folder, "SeedingError.csv");
            if (!File.Exists(filename))
            {
                using (StreamWriter sw = new StreamWriter(File.Open(filename, FileMode.Create, FileAccess.Write)))
                { sw.WriteLine("Folder name,Before \"new Random()\",After \"new Random()\""); }
            }
            string file = Path.GetFileName(OutputDir);
            using (StreamWriter sw = new StreamWriter(File.Open(filename, FileMode.Append, FileAccess.Write), new UTF8Encoding(true)))
            { sw.WriteLine(file + "," + before + "," + after); }
        }

        public static void Run(List<CellData> cells, int step)
        {
            if (StepInterval != 0)
            {
                if (step % StepInterval == 0)
                {
                    Run_Substrate(step);
                    Run_CellData(cells, step);
                    Run_RawImage(cells, step);
                    Run_CellCount(cells, step);
                }
            }
        }

        private static void Run_Substrate(int step)
        {
            if (SaveSubstrate)
            {
                string path = Path.Combine(OutputDir, "Substrate", string.Format("substrate_step_{0:0000}.csv", step));
                Directory.CreateDirectory(Path.Combine(OutputDir, "Substrate"));
                using (StreamWriter sw = new StreamWriter(File.Open(path, FileMode.Create, FileAccess.Write), new UTF8Encoding(true)))
                {
                    string s = Name_Index;
                    s += "," + Name_X + "," + Name_Y + "," + Name_Z;
                    s += "," + Name_hexX + "," + Name_hexY + "," + Name_hexZ;
                    s += ",e_s";
                    sw.WriteLine(s);
                    int cnt = 0;
                    for (int j = 0; j < CultureSpace.Ysize; j++)
                    {
                        for (int i = 0; i < CultureSpace.Xsize; i++)
                        {
                            string str = cnt++.ToString();
                            int x = 2 * i, y = j;
                            if (j % 2 == 1) { x++; }
                            str += "," + (x / 2.0);
                            str += "," + y * Delta.Cf_y;
                            str += "," + 0;
                            str += "," + x;
                            str += "," + y;
                            str += "," + 0;
                            str += "," + SubstrateAbility.Get_e_s(new Point3D(x, y, 0));
                            sw.WriteLine(str);
                        }
                    }
                }
            }
        }
        #region // Run_CellData
        public const string Name_Index = "Index";
        public const string Name_X = "X";
        public const string Name_Y = "Y";
        public const string Name_Z = "Z";
        public const string Name_hexX = "hexX";
        public const string Name_hexY = "hexY";
        public const string Name_hexZ = "hexZ";
        public const string Name_Cell_N = "Cell_N_c";
        public const string Name_Cell_S = "Cell_S_c";
        public const string Name_Cell_T = "Cell_T_c";
        public const string Name_t_age = "t_age_c (h)";
        public const string Name_t_d = "t_d_c (h)";
        public const string Name_t_m = "t_m_c (h)";
        public const string Name_V_m = "V_m_c (um/h)";
        public const string Name_E_AJ = "E_AJ_c (ng um^2 h^(-2))";
        public const string Name_E_TJ = "E_TJ_c (ng um^2 h^(-2))";
        public const string Name_E_cs = "E_cs_c (ng um^2 h^(-2))";
        public const string Name_E_max = "E_max_c (ng um^2 h^(-2))";
        public const string Name_Dir_am = "dir_am_c";
        public const string Name_Dir_pm = "dir_pm_c";
        public const string Name_Dir_pd = "dir_pd_c";
        public const string Name_THETA = "THETA_c (h)";
        public const string Name_T_de_act = "T_de_act_c (h)";
        public const string Name_T_de_total = "T_de_total_c (h)";
        public const string Name_CellMovement_len_app = "l_app (um)";
        public const string Name_CellMovement_len_act = "l_act (um)";
        public const string Name_CellMovement_len_pas = "l_pas (um)";
        public const string Name_CellMovement_len_div = "l_div (um)";
        public const string Name_CellMovement_t_act = "t_act (h)";
        public const string Name_CellMovement_t_pas = "t_pas (h)";
        public const string Name_CellMovement_t_div = "t_div (h)";
        public const string Name_E_cc = "E_cc (ng um^2 h^(-2))";
        public const string Name_E_c = "E_c (ng um^2 h^(-2))";
        private static void Run_CellData(List<CellData> cells, int step)
        {
            if (SaveCellsData)
            {
                string pad = "D" + Digit(Common.PartitionNum);
                string name = "cell_step_{0:" + pad + "}.csv";
                string path = Path.Combine(OutputDir, "CellsData", string.Format(name, step));
                Directory.CreateDirectory(Path.Combine(OutputDir, "CellsData"));
                try
                {
                    using (StreamWriter sw = new StreamWriter(File.Open(path, FileMode.Create, FileAccess.Write), new UTF8Encoding(true)))
                    {
                        string s = Name_Index;
                        if (SaveCellsData_Coordinates) { s += "," + Name_X + "," + Name_Y + "," + Name_Z; }
                        if (SaveCellsData_HexCoordinates) { s += "," + Name_hexX + "," + Name_hexY + "," + Name_hexZ; }
                        if (SaveCellsData_Cell_N) { s += "," + Name_Cell_N; }
                        if (SaveCellsData_Cell_S) { s += "," + Name_Cell_S; }
                        if (SaveCellsData_Cell_T) { s += "," + Name_Cell_T; }
                        if (SaveCellsData_t_age) { s += "," + Name_t_age; }
                        if (SaveCellsData_t_d) { s += "," + Name_t_d; }
                        if (SaveCellsData_t_m) { s += "," + Name_t_m; }
                        if (SaveCellsData_V_m) { s += "," + Name_V_m; }
                        if (SaveCellsData_E_AJ) { s += "," + Name_E_AJ; }
                        if (SaveCellsData_E_TJ) { s += "," + Name_E_TJ; }
                        if (SaveCellsData_E_cs) { s += "," + Name_E_cs; }
                        if (SaveCellsData_E_max) { s += "," + Name_E_max; }
                        if (SaveCellsData_dir_am) { s += "," + Name_Dir_am; }
                        if (SaveCellsData_dir_pm) { s += "," + Name_Dir_pm; }
                        if (SaveCellsData_dir_pd) { s += "," + Name_Dir_pd; }
                        sw.Write(s);
                        bool ETJ0 = false;
                        for (int i = 0; i < Behaviors.Maximum; i++)
                        { ETJ0 |= BasicConnectionEnergy.E_TJ0[i] > 0; }
                        if (SaveCellsData_THETA & ETJ0) { sw.Write("," + Name_THETA); }
                        if (Deviation_hiPSC.Get_flag())
                        {
                            if (SaveCellsData_T_de_am) { sw.Write("," + Name_T_de_act); }
                            if (SaveCellsData_T_de_total) { sw.Write("," + Name_T_de_total); }
                            if (SaveCellsData_CellMovement)
                            {
                                sw.Write("," + Name_CellMovement_len_app);
                                sw.Write("," + Name_CellMovement_len_act);
                                sw.Write("," + Name_CellMovement_len_pas);
                                sw.Write("," + Name_CellMovement_len_div);
                                sw.Write("," + Name_CellMovement_t_act);
                                sw.Write("," + Name_CellMovement_t_pas);
                                sw.Write("," + Name_CellMovement_t_div);
                            }
                        }
                        if (SaveCellsData_E_cc) { sw.Write("," + Name_E_cc); }
                        if (SaveCellsData_E_c) { sw.Write("," + Name_E_c); }
                        sw.WriteLine();
                        for (int i = 0; i < cells.Count; i++)
                        {
                            if (cells[i] != null)
                            {
                                string str = cells[i].Index.ToString();
                                if (SaveCellsData_Coordinates)
                                {
                                    str += "," + cells[i].Location.X / 2.0;
                                    str += "," + cells[i].Location.Y * Delta.Cf_y;
                                    str += "," + cells[i].Location.Z;
                                }
                                if (SaveCellsData_HexCoordinates)
                                {
                                    str += "," + cells[i].Location.X;
                                    str += "," + cells[i].Location.Y;
                                    str += "," + cells[i].Location.Z;
                                }
                                if (SaveCellsData_Cell_N) { str += "," + Str_(cells[i].Cell_N); }
                                if (SaveCellsData_Cell_S) { str += "," + (int)cells[i].Cell_S; }
                                if (SaveCellsData_Cell_T) { str += "," + cells[i].Cell_T; }
                                if (SaveCellsData_t_age) { str += "," + cells[i].Time_age; }
                                if (SaveCellsData_t_d) { str += "," + Str_(cells[i].Time_d); }
                                if (SaveCellsData_t_m) { str += "," + Str_(cells[i].Time_m); }
                                if (SaveCellsData_V_m) { str += "," + cells[i].V_m; }
                                if (SaveCellsData_E_AJ) { str += "," + cells[i].E_AJ; }
                                if (SaveCellsData_E_TJ) { str += "," + cells[i].E_TJ; }
                                if (SaveCellsData_E_cs) { str += "," + cells[i].E_cs; }
                                if (SaveCellsData_E_max) { str += "," + cells[i].E_max; }
                                if (SaveCellsData_dir_am) { str += "," + (cells[i].Dir_am != Direction.DIR.C_1 ? ((int)cells[i].Dir_am).ToString() : ""); }
                                if (SaveCellsData_dir_pm) { str += "," + Str_(cells[i].Dir_pm); }
                                if (SaveCellsData_dir_pd) { str += "," + Str_(cells[i].Dir_pd); }
                                if (SaveCellsData_THETA && ETJ0) { str += "," + Str_(cells[i].THETA, CultureTime.Time_step); }
                                if (Deviation_hiPSC.Get_flag())
                                {
                                    if (SaveCellsData_T_de_am) { str += "," + cells[i].Time_dev_act * CultureTime.Time_step; }
                                    if (SaveCellsData_T_de_total) { str += "," + cells[i].Time_dev_total * CultureTime.Time_step; }
                                    if (SaveCellsData_CellMovement)
                                    {
                                        (double len_app, double len_act, double len_pas, double len_div, int t_act, int t_pas, int t_div) = CellMovement.GetData(i);
                                        str += "," + len_app;
                                        str += "," + len_act;
                                        str += "," + len_pas;
                                        str += "," + len_div;
                                        str += "," + t_act * CultureTime.Time_step;
                                        str += "," + t_pas * CultureTime.Time_step;
                                        str += "," + t_div * CultureTime.Time_step;
                                    }
                                }
                                if (SaveCellsData_E_cc || SaveCellsData_E_c)
                                {
                                    double Ec = BasicConnectionEnergy.CalcEc(cells, i, out double Ecc, out _);
                                    if (SaveCellsData_E_cc)
                                    {
                                        str += "," + Ecc.ToString();
                                    }
                                    if (SaveCellsData_E_c)
                                    {
                                        str += "," + Ec.ToString();
                                    }
                                }
                                sw.WriteLine(str);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (MessageBox.Show(ex.Message + "\r\nRetry?", "Exception", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Run_CellData(cells, step);
                    }
                }
            }
        }
        private static int Digit(int num)
        {
            return (num == 0) ? 1 : ((int)Math.Log10(num) + 1);
        }
        private static string Str_(double val)
        {
            return double.IsInfinity(val) ? "Inf" : val.ToString();
        }
        private static string Str_(List<int> Cell_N)
        {
            string str = Cell_N[0].ToString();
            for (int j = 1; j < Cell_N.Count; j++)
            { str += "_" + Cell_N[j]; }
            return str;
        }
        private static string Str_(List<Direction.DIR> i)
        {
            if (i.Count > 0)
            {
                string str = ((int)i[0]).ToString();
                for (int j = 1; j < i.Count; j++)
                { str += "_" + ((int)i[j]).ToString(); }
                return str;
            }
            else
            { return ""; }
        }
        private static string Str_(int[] i, double val)
        {
            string str = (i[0] * val).ToString();
            for (int j = 1; j < i.Length; j++)
            { str += "_" + i[j] * val; }
            return str;
        }
        #endregion
        private static void Run_RawImage(List<CellData> cells, int step)
        {
            if (SaveRawImg)
            {
                if (step == 0)
                {
                    string dir = Path.Combine(OutputDir, "RawImage");
                    Directory.CreateDirectory(dir);
                    using (StreamWriter sw = new StreamWriter(File.Open(Path.Combine(dir, "CultureSpace.txt"), FileMode.Create)))
                    {
                        sw.WriteLine("Xsize : " + CultureSpace.Xsize);
                        sw.WriteLine("Ysize : " + CultureSpace.Ysize);
                        sw.WriteLine("Zsize : " + CultureSpace.Zsize);
                        sw.WriteLine();
                        sw.WriteLine("Hex Xsize : " + (CultureSpace.Xsize * 2));
                        sw.WriteLine("Hex Ysize : " + CultureSpace.Ysize);
                        sw.WriteLine("Hex Zsize : " + CultureSpace.Zsize);
                    }
                }
                if (SaveRawImg_CellIndex)
                {
                    string dir = Path.Combine(OutputDir, "RawImage", "Index");
                    Directory.CreateDirectory(dir);
                    string str = Path.Combine(dir, string.Format("Index_32-bit-Signed_step_{0:0000}.raw", step));
                    using (BinaryWriter bw = new BinaryWriter(File.OpenWrite(str)))
                    {
                        for (int k = 0; k < CultureSpace.Zsize; k++)
                        {
                            for (int j = 0; j < CultureSpace.Ysize; j++)
                            {
                                for (int i = 0; i < CultureSpace.Xsize; i++)
                                {
                                    if (j % 2 == 0)
                                    {
                                        bw.Write(CultureSpace.GetMap(i * 2, j, k));
                                        bw.Write(CultureSpace.GetMap(i * 2, j, k));
                                    }
                                    else
                                    {
                                        bw.Write(CultureSpace.GetMap(i * 2 - 1, j, k));
                                        bw.Write(CultureSpace.GetMap(i * 2, j, k));
                                    }
                                }
                            }
                        }
                    }
                }
                if (SaveRawImg_CellType)
                {
                    string dir = Path.Combine(OutputDir, "RawImage", "CellType");
                    Directory.CreateDirectory(dir);
                    string str = Path.Combine(dir, string.Format("CellType_8-bit_step_{0:0000}.raw", step));
                    using (BinaryWriter bw = new BinaryWriter(File.OpenWrite(str)))
                    {
                        for (int k = 0; k < CultureSpace.Zsize; k++)
                        {
                            for (int j = 0; j < CultureSpace.Ysize; j++)
                            {
                                for (int i = 0; i < CultureSpace.Xsize; i++)
                                {
                                    if (j % 2 == 0)
                                    {
                                        int val = CultureSpace.GetMap(i * 2, j, k);
                                        if (val >= 0)
                                        {
                                            bw.Write((byte)((CellData.Find(cells, val).Cell_T + 1) * 10));
                                            bw.Write((byte)((CellData.Find(cells, val).Cell_T + 1) * 10));
                                        }
                                        else
                                        {
                                            bw.Write(byte.MinValue);
                                            bw.Write(byte.MinValue);
                                        }
                                    }
                                    else
                                    {
                                        int val = CultureSpace.GetMap(i * 2 - 1, j, k);
                                        if (val >= 0)
                                        {
                                            bw.Write((byte)((CellData.Find(cells, val).Cell_T + 1) * 10));
                                        }
                                        else
                                        {
                                            bw.Write(byte.MinValue);
                                        }
                                        val = CultureSpace.GetMap(i * 2, j, k);
                                        if (val >= 0)
                                        {
                                            bw.Write((byte)((CellData.Find(cells, val).Cell_T + 1) * 10));
                                        }
                                        else
                                        {
                                            bw.Write(byte.MinValue);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (SaveRawImg_CellState)
                {
                    string dir = Path.Combine(OutputDir, "RawImage", "CellState");
                    Directory.CreateDirectory(dir);
                    string str = Path.Combine(dir, string.Format("CellState_8-bit_step_{0:0000}.raw", step));
                    using (BinaryWriter bw = new BinaryWriter(File.OpenWrite(str)))
                    {
                        for (int k = 0; k < CultureSpace.Zsize; k++)
                        {
                            for (int j = 0; j < CultureSpace.Ysize; j++)
                            {
                                for (int i = 0; i < CultureSpace.Xsize; i++)
                                {
                                    if (j % 2 == 0)
                                    {
                                        int val = CultureSpace.GetMap(i * 2, j, k);
                                        if (val >= 0)
                                        {
                                            bw.Write((byte)(((int)CellData.Find(cells, val).Cell_S + 1) * 10));
                                            bw.Write((byte)(((int)CellData.Find(cells, val).Cell_S + 1) * 10));
                                        }
                                        else
                                        {
                                            bw.Write(byte.MinValue);
                                            bw.Write(byte.MinValue);
                                        }
                                    }
                                    else
                                    {
                                        int val = CultureSpace.GetMap(i * 2 - 1, j, k);
                                        if (val >= 0)
                                        {
                                            bw.Write((byte)(((int)CellData.Find(cells, val).Cell_S + 1) * 10));
                                        }
                                        else
                                        {
                                            bw.Write(byte.MinValue);
                                        }
                                        val = CultureSpace.GetMap(i * 2, j, k);
                                        if (val >= 0)
                                        {
                                            bw.Write((byte)(((int)CellData.Find(cells, val).Cell_S + 1) * 10));
                                        }
                                        else
                                        {
                                            bw.Write(byte.MinValue);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (SaveRawImg_CellAge)
                {
                    string dir = Path.Combine(OutputDir, "RawImage", "CellAge");
                    Directory.CreateDirectory(dir);
                    string str = Path.Combine(dir, string.Format("CellAge_64-bit-Real_step_{0:0000}.raw", step));
                    using (BinaryWriter bw = new BinaryWriter(File.OpenWrite(str)))
                    {
                        for (int k = 0; k < CultureSpace.Zsize; k++)
                        {
                            for (int j = 0; j < CultureSpace.Ysize; j++)
                            {
                                for (int i = 0; i < CultureSpace.Xsize; i++)
                                {
                                    if (j % 2 == 0)
                                    {
                                        int val = CultureSpace.GetMap(i * 2, j, k);
                                        if (val >= 0)
                                        {
                                            bw.Write(CellData.Find(cells, val).Time_age);
                                            bw.Write(CellData.Find(cells, val).Time_age);
                                        }
                                        else
                                        {
                                            bw.Write(double.NaN);
                                            bw.Write(double.NaN);
                                        }
                                    }
                                    else
                                    {
                                        int val = CultureSpace.GetMap(i * 2 - 1, j, k);
                                        if (val >= 0)
                                        {
                                            bw.Write(CellData.Find(cells, val).Time_age);
                                        }
                                        else
                                        {
                                            bw.Write(double.NaN);
                                        }
                                        val = CultureSpace.GetMap(i * 2, j, k);
                                        if (val >= 0)
                                        {
                                            bw.Write(CellData.Find(cells, val).Time_age);
                                        }
                                        else
                                        {
                                            bw.Write(double.NaN);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (SubstrateAbility.Flag && SaveRawImg_Substrate)
                {
                    string dir = Path.Combine(OutputDir, "RawImage", "Substrate");
                    Directory.CreateDirectory(dir);
                    string str = Path.Combine(dir, string.Format("Substrate_64-bit-Real_step_{0:0000}.raw", step));
                    using (BinaryWriter bw = new BinaryWriter(File.OpenWrite(str)))
                    {
                        for (int j = 0; j < CultureSpace.Ysize; j++)
                        {
                            for (int i = 0; i < CultureSpace.Xsize; i++)
                            {
                                if (j % 2 == 0)
                                {
                                    double val = SubstrateAbility.Get_e_s(new Point3D(i * 2, j, 0));
                                    bw.Write(val);
                                    bw.Write(val);
                                }
                                else
                                {
                                    double val = SubstrateAbility.Get_e_s(new Point3D(i * 2 - 1, j, 0));
                                    bw.Write(val);
                                    val = SubstrateAbility.Get_e_s(new Point3D(i * 2, j, 0));
                                    bw.Write(val);
                                }
                            }
                        }
                    }
                }
            }
        }
        private static void Run_CellCount(List<CellData> cells, int step)
        {
            if (SaveCellCount)
            {
                string str = Path.Combine(OutputDir, string.Format("cell_count.csv"));
                if (step == 0)
                {
                    using (StreamWriter sw = new StreamWriter(File.Open(str, FileMode.Create), new UTF8Encoding(true)))
                    {
                        sw.Write("step,Total cell number,"
                            + "state:proliferative,"
                            + "state:quiescent,"
                            + "state:nonproliferative,"
                            + "state:dead");
                        for (int i = 0; i < Behaviors.Maximum; i++)
                        {
                            sw.Write(",type:[" + i + "]");
                        }
                        sw.WriteLine();
                    }
                }

                int p = 0, q = 0, n = 0, d = 0;
                int[] t = new int[Behaviors.Maximum];
                for (int i = 0; i < cells.Count; i++)
                {
                    if (Common.IsDeadCell(cells[i]))
                    { d++; }
                    else
                    {
                        CellData.STATE st = cells[i].Cell_S;
                        switch (st)
                        {
                            case CellData.STATE.Block:
                                break;
                            case CellData.STATE.Proliferative:
                                p++;
                                break;
                            case CellData.STATE.Quiescent:
                                q++;
                                break;
                            case CellData.STATE.Nonproliferative:
                                n++;
                                break;
                            case CellData.STATE.Dead:
                                break;
                            default:
                                break;
                        }
                        t[cells[i].Cell_T]++;
                    }
                }

                using (StreamWriter sw = new StreamWriter(File.Open(str, FileMode.Append), new UTF8Encoding(true)))
                {
                    int total = 0;
                    for (int i = 0; i < t.Length; i++)
                    { total += t[i]; }
                    sw.Write(step + "," + total +
                        "," + p + "," + q + "," + n + "," + d);
                    for (int i = 0; i < Behaviors.Maximum; i++)
                    { sw.Write("," + t[i]); }
                    sw.WriteLine();
                }
            }
        }
    }
}
