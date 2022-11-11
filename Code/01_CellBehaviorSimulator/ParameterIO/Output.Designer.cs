namespace CellBehaviorSimulator
{
    partial class Output
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOutputPath = new System.Windows.Forms.Button();
            this.textBoxOutputPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num_StepInter = new System.Windows.Forms.NumericUpDown();
            this.checkSaveCellsData = new System.Windows.Forms.CheckBox();
            this.checkSaveRawImg = new System.Windows.Forms.CheckBox();
            this.checkSaveCellCount = new System.Windows.Forms.CheckBox();
            this.groupRawImage = new System.Windows.Forms.GroupBox();
            this.checkRawImg_Substrate = new System.Windows.Forms.CheckBox();
            this.checkRawImg_CellAge = new System.Windows.Forms.CheckBox();
            this.checkRawImg_CellState = new System.Windows.Forms.CheckBox();
            this.checkRawImg_CellType = new System.Windows.Forms.CheckBox();
            this.checkRawImg_Index = new System.Windows.Forms.CheckBox();
            this.groupCellData = new System.Windows.Forms.GroupBox();
            this.checkCellsData_E_c_total = new System.Windows.Forms.CheckBox();
            this.checkCellsData_E_cc_total = new System.Windows.Forms.CheckBox();
            this.checkCellsData_CellMovement = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkCellsData_Index = new System.Windows.Forms.CheckBox();
            this.checkCellsData_HexCoordinates = new System.Windows.Forms.CheckBox();
            this.checkCellsData_Coordinates = new System.Windows.Forms.CheckBox();
            this.buttonSaveAllCellsData = new System.Windows.Forms.Button();
            this.checkCellsData_T_de_total = new System.Windows.Forms.CheckBox();
            this.checkCellsData_T_de_am = new System.Windows.Forms.CheckBox();
            this.checkCellsData_THETA = new System.Windows.Forms.CheckBox();
            this.checkCellsData_Dir_pd = new System.Windows.Forms.CheckBox();
            this.checkCellsData_Dir_pm = new System.Windows.Forms.CheckBox();
            this.checkCellsData_Dir_am = new System.Windows.Forms.CheckBox();
            this.checkCellsData_E_max = new System.Windows.Forms.CheckBox();
            this.checkCellsData_E_cs = new System.Windows.Forms.CheckBox();
            this.checkCellsData_E_TJ = new System.Windows.Forms.CheckBox();
            this.checkCellsData_E_AJ = new System.Windows.Forms.CheckBox();
            this.checkCellsData_V_m = new System.Windows.Forms.CheckBox();
            this.checkCellsData_t_m = new System.Windows.Forms.CheckBox();
            this.checkCellsData_t_d = new System.Windows.Forms.CheckBox();
            this.checkCellsData_t_age = new System.Windows.Forms.CheckBox();
            this.checkCellsData_T = new System.Windows.Forms.CheckBox();
            this.checkCellsData_S = new System.Windows.Forms.CheckBox();
            this.checkCellsData_N = new System.Windows.Forms.CheckBox();
            this.checkSaveSubstrate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_StepInter)).BeginInit();
            this.groupRawImage.SuspendLayout();
            this.groupCellData.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOutputPath
            // 
            this.buttonOutputPath.Location = new System.Drawing.Point(2, 15);
            this.buttonOutputPath.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonOutputPath.Name = "buttonOutputPath";
            this.buttonOutputPath.Size = new System.Drawing.Size(23, 23);
            this.buttonOutputPath.TabIndex = 1;
            this.buttonOutputPath.Text = "...";
            this.buttonOutputPath.UseVisualStyleBackColor = true;
            this.buttonOutputPath.Click += new System.EventHandler(this.ButtonOutputPath_Click);
            // 
            // textBoxOutputPath
            // 
            this.textBoxOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputPath.Location = new System.Drawing.Point(30, 17);
            this.textBoxOutputPath.Name = "textBoxOutputPath";
            this.textBoxOutputPath.Size = new System.Drawing.Size(324, 19);
            this.textBoxOutputPath.TabIndex = 2;
            this.textBoxOutputPath.TextChanged += new System.EventHandler(this.TextBoxOutputPath_TextChanged);
            this.textBoxOutputPath.Leave += new System.EventHandler(this.TextBoxOutputPath_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Output path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output interval (step)";
            // 
            // num_StepInter
            // 
            this.num_StepInter.Location = new System.Drawing.Point(124, 44);
            this.num_StepInter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_StepInter.Name = "num_StepInter";
            this.num_StepInter.Size = new System.Drawing.Size(60, 19);
            this.num_StepInter.TabIndex = 4;
            this.num_StepInter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_StepInter.ValueChanged += new System.EventHandler(this.Num_DeltaTout_ValueChanged);
            // 
            // checkSaveCellsData
            // 
            this.checkSaveCellsData.AutoSize = true;
            this.checkSaveCellsData.Location = new System.Drawing.Point(3, 91);
            this.checkSaveCellsData.Name = "checkSaveCellsData";
            this.checkSaveCellsData.Size = new System.Drawing.Size(103, 16);
            this.checkSaveCellsData.TabIndex = 6;
            this.checkSaveCellsData.Text = "Save cells data";
            this.checkSaveCellsData.UseVisualStyleBackColor = true;
            this.checkSaveCellsData.CheckedChanged += new System.EventHandler(this.CheckSaveCellsData_CheckedChanged);
            // 
            // checkSaveRawImg
            // 
            this.checkSaveRawImg.AutoSize = true;
            this.checkSaveRawImg.Location = new System.Drawing.Point(121, 91);
            this.checkSaveRawImg.Name = "checkSaveRawImg";
            this.checkSaveRawImg.Size = new System.Drawing.Size(105, 16);
            this.checkSaveRawImg.TabIndex = 9;
            this.checkSaveRawImg.Text = "Save raw image";
            this.checkSaveRawImg.UseVisualStyleBackColor = true;
            this.checkSaveRawImg.CheckedChanged += new System.EventHandler(this.CheckSaveRawImg_CheckedChanged);
            // 
            // checkSaveCellCount
            // 
            this.checkSaveCellCount.AutoSize = true;
            this.checkSaveCellCount.Location = new System.Drawing.Point(3, 69);
            this.checkSaveCellCount.Name = "checkSaveCellCount";
            this.checkSaveCellCount.Size = new System.Drawing.Size(103, 16);
            this.checkSaveCellCount.TabIndex = 5;
            this.checkSaveCellCount.Text = "Save cell count";
            this.checkSaveCellCount.UseVisualStyleBackColor = true;
            this.checkSaveCellCount.CheckedChanged += new System.EventHandler(this.CheckSaveCellCount_CheckedChanged);
            // 
            // groupRawImage
            // 
            this.groupRawImage.AutoSize = true;
            this.groupRawImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupRawImage.Controls.Add(this.checkRawImg_Substrate);
            this.groupRawImage.Controls.Add(this.checkRawImg_CellAge);
            this.groupRawImage.Controls.Add(this.checkRawImg_CellState);
            this.groupRawImage.Controls.Add(this.checkRawImg_CellType);
            this.groupRawImage.Controls.Add(this.checkRawImg_Index);
            this.groupRawImage.Location = new System.Drawing.Point(121, 113);
            this.groupRawImage.Name = "groupRawImage";
            this.groupRawImage.Size = new System.Drawing.Size(86, 140);
            this.groupRawImage.TabIndex = 10;
            this.groupRawImage.TabStop = false;
            this.groupRawImage.Text = "Raw image";
            this.groupRawImage.Visible = false;
            // 
            // checkRawImg_Substrate
            // 
            this.checkRawImg_Substrate.AutoSize = true;
            this.checkRawImg_Substrate.Location = new System.Drawing.Point(6, 106);
            this.checkRawImg_Substrate.Name = "checkRawImg_Substrate";
            this.checkRawImg_Substrate.Size = new System.Drawing.Size(73, 16);
            this.checkRawImg_Substrate.TabIndex = 4;
            this.checkRawImg_Substrate.Text = "Substrate";
            this.checkRawImg_Substrate.UseVisualStyleBackColor = true;
            this.checkRawImg_Substrate.CheckedChanged += new System.EventHandler(this.CheckRawImg_Substrate_CheckedChanged);
            // 
            // checkRawImg_CellAge
            // 
            this.checkRawImg_CellAge.AutoSize = true;
            this.checkRawImg_CellAge.Location = new System.Drawing.Point(6, 84);
            this.checkRawImg_CellAge.Name = "checkRawImg_CellAge";
            this.checkRawImg_CellAge.Size = new System.Drawing.Size(66, 16);
            this.checkRawImg_CellAge.TabIndex = 3;
            this.checkRawImg_CellAge.Text = "Cell age";
            this.checkRawImg_CellAge.UseVisualStyleBackColor = true;
            this.checkRawImg_CellAge.CheckedChanged += new System.EventHandler(this.CheckRawImg_CellAge_CheckedChanged);
            // 
            // checkRawImg_CellState
            // 
            this.checkRawImg_CellState.AutoSize = true;
            this.checkRawImg_CellState.Location = new System.Drawing.Point(6, 62);
            this.checkRawImg_CellState.Name = "checkRawImg_CellState";
            this.checkRawImg_CellState.Size = new System.Drawing.Size(74, 16);
            this.checkRawImg_CellState.TabIndex = 2;
            this.checkRawImg_CellState.Text = "Cell state";
            this.checkRawImg_CellState.UseVisualStyleBackColor = true;
            this.checkRawImg_CellState.CheckedChanged += new System.EventHandler(this.CheckRawImg_CellState_CheckedChanged);
            // 
            // checkRawImg_CellType
            // 
            this.checkRawImg_CellType.AutoSize = true;
            this.checkRawImg_CellType.Location = new System.Drawing.Point(6, 40);
            this.checkRawImg_CellType.Name = "checkRawImg_CellType";
            this.checkRawImg_CellType.Size = new System.Drawing.Size(70, 16);
            this.checkRawImg_CellType.TabIndex = 1;
            this.checkRawImg_CellType.Text = "Cell type";
            this.checkRawImg_CellType.UseVisualStyleBackColor = true;
            this.checkRawImg_CellType.CheckedChanged += new System.EventHandler(this.CheckRawImg_CellType_CheckedChanged);
            // 
            // checkRawImg_Index
            // 
            this.checkRawImg_Index.AutoSize = true;
            this.checkRawImg_Index.Location = new System.Drawing.Point(6, 18);
            this.checkRawImg_Index.Name = "checkRawImg_Index";
            this.checkRawImg_Index.Size = new System.Drawing.Size(51, 16);
            this.checkRawImg_Index.TabIndex = 0;
            this.checkRawImg_Index.Text = "Index";
            this.checkRawImg_Index.UseVisualStyleBackColor = true;
            this.checkRawImg_Index.CheckedChanged += new System.EventHandler(this.CheckRawImg_Index_CheckedChanged);
            // 
            // groupCellData
            // 
            this.groupCellData.AutoSize = true;
            this.groupCellData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupCellData.Controls.Add(this.checkCellsData_E_c_total);
            this.groupCellData.Controls.Add(this.checkCellsData_E_cc_total);
            this.groupCellData.Controls.Add(this.checkCellsData_CellMovement);
            this.groupCellData.Controls.Add(this.label2);
            this.groupCellData.Controls.Add(this.checkCellsData_Index);
            this.groupCellData.Controls.Add(this.checkCellsData_HexCoordinates);
            this.groupCellData.Controls.Add(this.checkCellsData_Coordinates);
            this.groupCellData.Controls.Add(this.buttonSaveAllCellsData);
            this.groupCellData.Controls.Add(this.checkCellsData_T_de_total);
            this.groupCellData.Controls.Add(this.checkCellsData_T_de_am);
            this.groupCellData.Controls.Add(this.checkCellsData_THETA);
            this.groupCellData.Controls.Add(this.checkCellsData_Dir_pd);
            this.groupCellData.Controls.Add(this.checkCellsData_Dir_pm);
            this.groupCellData.Controls.Add(this.checkCellsData_Dir_am);
            this.groupCellData.Controls.Add(this.checkCellsData_E_max);
            this.groupCellData.Controls.Add(this.checkCellsData_E_cs);
            this.groupCellData.Controls.Add(this.checkCellsData_E_TJ);
            this.groupCellData.Controls.Add(this.checkCellsData_E_AJ);
            this.groupCellData.Controls.Add(this.checkCellsData_V_m);
            this.groupCellData.Controls.Add(this.checkCellsData_t_m);
            this.groupCellData.Controls.Add(this.checkCellsData_t_d);
            this.groupCellData.Controls.Add(this.checkCellsData_t_age);
            this.groupCellData.Controls.Add(this.checkCellsData_T);
            this.groupCellData.Controls.Add(this.checkCellsData_S);
            this.groupCellData.Controls.Add(this.checkCellsData_N);
            this.groupCellData.Location = new System.Drawing.Point(3, 113);
            this.groupCellData.Name = "groupCellData";
            this.groupCellData.Size = new System.Drawing.Size(112, 577);
            this.groupCellData.TabIndex = 7;
            this.groupCellData.TabStop = false;
            this.groupCellData.Text = "Cell data";
            this.groupCellData.Visible = false;
            // 
            // checkCellsData_E_c_total
            // 
            this.checkCellsData_E_c_total.AutoSize = true;
            this.checkCellsData_E_c_total.Location = new System.Drawing.Point(6, 543);
            this.checkCellsData_E_c_total.Name = "checkCellsData_E_c_total";
            this.checkCellsData_E_c_total.Size = new System.Drawing.Size(76, 16);
            this.checkCellsData_E_c_total.TabIndex = 25;
            this.checkCellsData_E_c_total.Text = "E_c (total)";
            this.checkCellsData_E_c_total.UseVisualStyleBackColor = true;
            this.checkCellsData_E_c_total.CheckedChanged += new System.EventHandler(this.CheckCellsData_E_c_CheckedChanged);
            // 
            // checkCellsData_E_cc_total
            // 
            this.checkCellsData_E_cc_total.AutoSize = true;
            this.checkCellsData_E_cc_total.Location = new System.Drawing.Point(6, 521);
            this.checkCellsData_E_cc_total.Name = "checkCellsData_E_cc_total";
            this.checkCellsData_E_cc_total.Size = new System.Drawing.Size(82, 16);
            this.checkCellsData_E_cc_total.TabIndex = 24;
            this.checkCellsData_E_cc_total.Text = "E_cc (total)";
            this.checkCellsData_E_cc_total.UseVisualStyleBackColor = true;
            this.checkCellsData_E_cc_total.CheckedChanged += new System.EventHandler(this.CheckCellsData_E_cc_total_CheckedChanged);
            // 
            // checkCellsData_CellMovement
            // 
            this.checkCellsData_CellMovement.AutoSize = true;
            this.checkCellsData_CellMovement.Location = new System.Drawing.Point(6, 487);
            this.checkCellsData_CellMovement.Name = "checkCellsData_CellMovement";
            this.checkCellsData_CellMovement.Size = new System.Drawing.Size(100, 16);
            this.checkCellsData_CellMovement.TabIndex = 21;
            this.checkCellsData_CellMovement.Text = "Cell movement";
            this.checkCellsData_CellMovement.UseVisualStyleBackColor = true;
            this.checkCellsData_CellMovement.CheckedChanged += new System.EventHandler(this.CheckCellsData_CellMovement_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "Options";
            // 
            // checkCellsData_Index
            // 
            this.checkCellsData_Index.AutoSize = true;
            this.checkCellsData_Index.Checked = true;
            this.checkCellsData_Index.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCellsData_Index.Enabled = false;
            this.checkCellsData_Index.Location = new System.Drawing.Point(6, 47);
            this.checkCellsData_Index.Name = "checkCellsData_Index";
            this.checkCellsData_Index.Size = new System.Drawing.Size(51, 16);
            this.checkCellsData_Index.TabIndex = 1;
            this.checkCellsData_Index.Text = "Index";
            this.checkCellsData_Index.UseVisualStyleBackColor = true;
            this.checkCellsData_Index.CheckedChanged += new System.EventHandler(this.CheckCellsData_Index_CheckedChanged);
            // 
            // checkCellsData_HexCoordinates
            // 
            this.checkCellsData_HexCoordinates.AutoSize = true;
            this.checkCellsData_HexCoordinates.Location = new System.Drawing.Point(6, 91);
            this.checkCellsData_HexCoordinates.Name = "checkCellsData_HexCoordinates";
            this.checkCellsData_HexCoordinates.Size = new System.Drawing.Size(81, 16);
            this.checkCellsData_HexCoordinates.TabIndex = 3;
            this.checkCellsData_HexCoordinates.Text = "Hex X, Y, Z";
            this.checkCellsData_HexCoordinates.UseVisualStyleBackColor = true;
            this.checkCellsData_HexCoordinates.CheckedChanged += new System.EventHandler(this.CheckCellsData_HexCoordinates_CheckedChanged);
            // 
            // checkCellsData_Coordinates
            // 
            this.checkCellsData_Coordinates.AutoSize = true;
            this.checkCellsData_Coordinates.Location = new System.Drawing.Point(6, 69);
            this.checkCellsData_Coordinates.Name = "checkCellsData_Coordinates";
            this.checkCellsData_Coordinates.Size = new System.Drawing.Size(57, 16);
            this.checkCellsData_Coordinates.TabIndex = 2;
            this.checkCellsData_Coordinates.Text = "X, Y, Z";
            this.checkCellsData_Coordinates.UseVisualStyleBackColor = true;
            this.checkCellsData_Coordinates.CheckedChanged += new System.EventHandler(this.CheckCellsData_Coordinates_CheckedChanged);
            // 
            // buttonSaveAllCellsData
            // 
            this.buttonSaveAllCellsData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveAllCellsData.Location = new System.Drawing.Point(6, 18);
            this.buttonSaveAllCellsData.Name = "buttonSaveAllCellsData";
            this.buttonSaveAllCellsData.Size = new System.Drawing.Size(98, 23);
            this.buttonSaveAllCellsData.TabIndex = 0;
            this.buttonSaveAllCellsData.Text = "All";
            this.buttonSaveAllCellsData.UseVisualStyleBackColor = true;
            this.buttonSaveAllCellsData.Click += new System.EventHandler(this.ButtonSaveAllCellsData_Click);
            // 
            // checkCellsData_T_de_total
            // 
            this.checkCellsData_T_de_total.AutoSize = true;
            this.checkCellsData_T_de_total.Location = new System.Drawing.Point(6, 465);
            this.checkCellsData_T_de_total.Name = "checkCellsData_T_de_total";
            this.checkCellsData_T_de_total.Size = new System.Drawing.Size(80, 16);
            this.checkCellsData_T_de_total.TabIndex = 20;
            this.checkCellsData_T_de_total.Text = "T_de,total,c";
            this.checkCellsData_T_de_total.UseVisualStyleBackColor = true;
            this.checkCellsData_T_de_total.CheckedChanged += new System.EventHandler(this.CheckCellData_T_de_total_CheckedChanged);
            // 
            // checkCellsData_T_de_am
            // 
            this.checkCellsData_T_de_am.AutoSize = true;
            this.checkCellsData_T_de_am.Location = new System.Drawing.Point(6, 443);
            this.checkCellsData_T_de_am.Name = "checkCellsData_T_de_am";
            this.checkCellsData_T_de_am.Size = new System.Drawing.Size(72, 16);
            this.checkCellsData_T_de_am.TabIndex = 19;
            this.checkCellsData_T_de_am.Text = "T_de,am,c";
            this.checkCellsData_T_de_am.UseVisualStyleBackColor = true;
            this.checkCellsData_T_de_am.CheckedChanged += new System.EventHandler(this.CheckCellsData_T_de_act_CheckedChanged);
            // 
            // checkCellsData_THETA
            // 
            this.checkCellsData_THETA.AutoSize = true;
            this.checkCellsData_THETA.Location = new System.Drawing.Point(6, 421);
            this.checkCellsData_THETA.Name = "checkCellsData_THETA";
            this.checkCellsData_THETA.Size = new System.Drawing.Size(69, 16);
            this.checkCellsData_THETA.TabIndex = 18;
            this.checkCellsData_THETA.Text = "THETA,c";
            this.checkCellsData_THETA.UseVisualStyleBackColor = true;
            this.checkCellsData_THETA.CheckedChanged += new System.EventHandler(this.CheckCellsData_THETA_CheckedChanged);
            // 
            // checkCellsData_Dir_pd
            // 
            this.checkCellsData_Dir_pd.AutoSize = true;
            this.checkCellsData_Dir_pd.Location = new System.Drawing.Point(6, 399);
            this.checkCellsData_Dir_pd.Name = "checkCellsData_Dir_pd";
            this.checkCellsData_Dir_pd.Size = new System.Drawing.Size(63, 16);
            this.checkCellsData_Dir_pd.TabIndex = 17;
            this.checkCellsData_Dir_pd.Text = "Dir_pd,c";
            this.checkCellsData_Dir_pd.UseVisualStyleBackColor = true;
            this.checkCellsData_Dir_pd.CheckedChanged += new System.EventHandler(this.CheckCellsData_Dir_pd_CheckedChanged);
            // 
            // checkCellsData_Dir_pm
            // 
            this.checkCellsData_Dir_pm.AutoSize = true;
            this.checkCellsData_Dir_pm.Location = new System.Drawing.Point(6, 377);
            this.checkCellsData_Dir_pm.Name = "checkCellsData_Dir_pm";
            this.checkCellsData_Dir_pm.Size = new System.Drawing.Size(66, 16);
            this.checkCellsData_Dir_pm.TabIndex = 16;
            this.checkCellsData_Dir_pm.Text = "Dir_pm,c";
            this.checkCellsData_Dir_pm.UseVisualStyleBackColor = true;
            this.checkCellsData_Dir_pm.CheckedChanged += new System.EventHandler(this.CheckCellsData_Dir_pm_CheckedChanged);
            // 
            // checkCellsData_Dir_am
            // 
            this.checkCellsData_Dir_am.AutoSize = true;
            this.checkCellsData_Dir_am.Location = new System.Drawing.Point(6, 355);
            this.checkCellsData_Dir_am.Name = "checkCellsData_Dir_am";
            this.checkCellsData_Dir_am.Size = new System.Drawing.Size(66, 16);
            this.checkCellsData_Dir_am.TabIndex = 15;
            this.checkCellsData_Dir_am.Text = "Dir_am,c";
            this.checkCellsData_Dir_am.UseVisualStyleBackColor = true;
            this.checkCellsData_Dir_am.CheckedChanged += new System.EventHandler(this.CheckCellsData_Dir_am_CheckedChanged);
            // 
            // checkCellsData_E_max
            // 
            this.checkCellsData_E_max.AutoSize = true;
            this.checkCellsData_E_max.Location = new System.Drawing.Point(6, 333);
            this.checkCellsData_E_max.Name = "checkCellsData_E_max";
            this.checkCellsData_E_max.Size = new System.Drawing.Size(64, 16);
            this.checkCellsData_E_max.TabIndex = 14;
            this.checkCellsData_E_max.Text = "E_max,c";
            this.checkCellsData_E_max.UseVisualStyleBackColor = true;
            this.checkCellsData_E_max.CheckedChanged += new System.EventHandler(this.CheckCellsData_E_max_CheckedChanged);
            // 
            // checkCellsData_E_cs
            // 
            this.checkCellsData_E_cs.AutoSize = true;
            this.checkCellsData_E_cs.Location = new System.Drawing.Point(6, 311);
            this.checkCellsData_E_cs.Name = "checkCellsData_E_cs";
            this.checkCellsData_E_cs.Size = new System.Drawing.Size(55, 16);
            this.checkCellsData_E_cs.TabIndex = 13;
            this.checkCellsData_E_cs.Text = "E_cs,c";
            this.checkCellsData_E_cs.UseVisualStyleBackColor = true;
            this.checkCellsData_E_cs.CheckedChanged += new System.EventHandler(this.CheckCellsData_E_cs_CheckedChanged);
            // 
            // checkCellsData_E_TJ
            // 
            this.checkCellsData_E_TJ.AutoSize = true;
            this.checkCellsData_E_TJ.Location = new System.Drawing.Point(6, 289);
            this.checkCellsData_E_TJ.Name = "checkCellsData_E_TJ";
            this.checkCellsData_E_TJ.Size = new System.Drawing.Size(57, 16);
            this.checkCellsData_E_TJ.TabIndex = 12;
            this.checkCellsData_E_TJ.Text = "E_TJ,c";
            this.checkCellsData_E_TJ.UseVisualStyleBackColor = true;
            this.checkCellsData_E_TJ.CheckedChanged += new System.EventHandler(this.CheckCellsData_E_TJ_CheckedChanged);
            // 
            // checkCellsData_E_AJ
            // 
            this.checkCellsData_E_AJ.AutoSize = true;
            this.checkCellsData_E_AJ.Location = new System.Drawing.Point(6, 267);
            this.checkCellsData_E_AJ.Name = "checkCellsData_E_AJ";
            this.checkCellsData_E_AJ.Size = new System.Drawing.Size(58, 16);
            this.checkCellsData_E_AJ.TabIndex = 11;
            this.checkCellsData_E_AJ.Text = "E_AJ,c";
            this.checkCellsData_E_AJ.UseVisualStyleBackColor = true;
            this.checkCellsData_E_AJ.CheckedChanged += new System.EventHandler(this.CheckCellsData_E_AJ_CheckedChanged);
            // 
            // checkCellsData_V_m
            // 
            this.checkCellsData_V_m.AutoSize = true;
            this.checkCellsData_V_m.Location = new System.Drawing.Point(6, 245);
            this.checkCellsData_V_m.Name = "checkCellsData_V_m";
            this.checkCellsData_V_m.Size = new System.Drawing.Size(53, 16);
            this.checkCellsData_V_m.TabIndex = 10;
            this.checkCellsData_V_m.Text = "V_m,c";
            this.checkCellsData_V_m.UseVisualStyleBackColor = true;
            this.checkCellsData_V_m.CheckedChanged += new System.EventHandler(this.CheckCellsData_V_m_CheckedChanged);
            // 
            // checkCellsData_t_m
            // 
            this.checkCellsData_t_m.AutoSize = true;
            this.checkCellsData_t_m.Location = new System.Drawing.Point(6, 223);
            this.checkCellsData_t_m.Name = "checkCellsData_t_m";
            this.checkCellsData_t_m.Size = new System.Drawing.Size(49, 16);
            this.checkCellsData_t_m.TabIndex = 9;
            this.checkCellsData_t_m.Text = "t_m,c";
            this.checkCellsData_t_m.UseVisualStyleBackColor = true;
            this.checkCellsData_t_m.CheckedChanged += new System.EventHandler(this.CheckCellsData_t_m_CheckedChanged);
            // 
            // checkCellsData_t_d
            // 
            this.checkCellsData_t_d.AutoSize = true;
            this.checkCellsData_t_d.Location = new System.Drawing.Point(6, 201);
            this.checkCellsData_t_d.Name = "checkCellsData_t_d";
            this.checkCellsData_t_d.Size = new System.Drawing.Size(46, 16);
            this.checkCellsData_t_d.TabIndex = 8;
            this.checkCellsData_t_d.Text = "t_d,c";
            this.checkCellsData_t_d.UseVisualStyleBackColor = true;
            this.checkCellsData_t_d.CheckedChanged += new System.EventHandler(this.CheckCellsData_t_d_CheckedChanged);
            // 
            // checkCellsData_t_age
            // 
            this.checkCellsData_t_age.AutoSize = true;
            this.checkCellsData_t_age.Location = new System.Drawing.Point(6, 179);
            this.checkCellsData_t_age.Name = "checkCellsData_t_age";
            this.checkCellsData_t_age.Size = new System.Drawing.Size(80, 16);
            this.checkCellsData_t_age.TabIndex = 7;
            this.checkCellsData_t_age.Text = "theta_age,c";
            this.checkCellsData_t_age.UseVisualStyleBackColor = true;
            this.checkCellsData_t_age.CheckedChanged += new System.EventHandler(this.CheckCellsData_t_age_CheckedChanged);
            // 
            // checkCellsData_T
            // 
            this.checkCellsData_T.AutoSize = true;
            this.checkCellsData_T.Location = new System.Drawing.Point(6, 157);
            this.checkCellsData_T.Name = "checkCellsData_T";
            this.checkCellsData_T.Size = new System.Drawing.Size(63, 16);
            this.checkCellsData_T.TabIndex = 6;
            this.checkCellsData_T.Text = "Cell_T,c";
            this.checkCellsData_T.UseVisualStyleBackColor = true;
            this.checkCellsData_T.CheckedChanged += new System.EventHandler(this.CheckCellsData_T_CheckedChanged);
            // 
            // checkCellsData_S
            // 
            this.checkCellsData_S.AutoSize = true;
            this.checkCellsData_S.Location = new System.Drawing.Point(6, 135);
            this.checkCellsData_S.Name = "checkCellsData_S";
            this.checkCellsData_S.Size = new System.Drawing.Size(63, 16);
            this.checkCellsData_S.TabIndex = 5;
            this.checkCellsData_S.Text = "Cell_S,c";
            this.checkCellsData_S.UseVisualStyleBackColor = true;
            this.checkCellsData_S.CheckedChanged += new System.EventHandler(this.CheckCellsData_S_CheckedChanged);
            // 
            // checkCellsData_N
            // 
            this.checkCellsData_N.AutoSize = true;
            this.checkCellsData_N.Location = new System.Drawing.Point(6, 113);
            this.checkCellsData_N.Name = "checkCellsData_N";
            this.checkCellsData_N.Size = new System.Drawing.Size(64, 16);
            this.checkCellsData_N.TabIndex = 4;
            this.checkCellsData_N.Text = "Cell_N,c";
            this.checkCellsData_N.UseVisualStyleBackColor = true;
            this.checkCellsData_N.CheckedChanged += new System.EventHandler(this.CheckCellsData_N_CheckedChanged);
            // 
            // checkSaveSubstrate
            // 
            this.checkSaveSubstrate.AutoSize = true;
            this.checkSaveSubstrate.Location = new System.Drawing.Point(121, 69);
            this.checkSaveSubstrate.Name = "checkSaveSubstrate";
            this.checkSaveSubstrate.Size = new System.Drawing.Size(171, 16);
            this.checkSaveSubstrate.TabIndex = 8;
            this.checkSaveSubstrate.Text = "Save substrate ability (CSV)";
            this.checkSaveSubstrate.UseVisualStyleBackColor = true;
            this.checkSaveSubstrate.CheckedChanged += new System.EventHandler(this.CheckSaveSubstrate_CheckedChanged);
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.checkSaveSubstrate);
            this.Controls.Add(this.groupCellData);
            this.Controls.Add(this.buttonOutputPath);
            this.Controls.Add(this.groupRawImage);
            this.Controls.Add(this.textBoxOutputPath);
            this.Controls.Add(this.checkSaveCellCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkSaveRawImg);
            this.Controls.Add(this.checkSaveCellsData);
            this.Controls.Add(this.num_StepInter);
            this.Controls.Add(this.label1);
            this.Name = "Output";
            this.Size = new System.Drawing.Size(357, 693);
            this.Load += new System.EventHandler(this.Output_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_StepInter)).EndInit();
            this.groupRawImage.ResumeLayout(false);
            this.groupRawImage.PerformLayout();
            this.groupCellData.ResumeLayout(false);
            this.groupCellData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOutputPath;
        private System.Windows.Forms.TextBox textBoxOutputPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_StepInter;
        private System.Windows.Forms.CheckBox checkSaveCellsData;
        private System.Windows.Forms.CheckBox checkSaveRawImg;
        private System.Windows.Forms.CheckBox checkSaveCellCount;
        private System.Windows.Forms.GroupBox groupRawImage;
        private System.Windows.Forms.CheckBox checkRawImg_CellAge;
        private System.Windows.Forms.CheckBox checkRawImg_CellType;
        private System.Windows.Forms.CheckBox checkRawImg_Index;
        private System.Windows.Forms.CheckBox checkRawImg_CellState;
        private System.Windows.Forms.CheckBox checkRawImg_Substrate;
        private System.Windows.Forms.GroupBox groupCellData;
        private System.Windows.Forms.CheckBox checkCellsData_N;
        private System.Windows.Forms.CheckBox checkCellsData_S;
        private System.Windows.Forms.CheckBox checkCellsData_T;
        private System.Windows.Forms.CheckBox checkCellsData_t_age;
        private System.Windows.Forms.CheckBox checkCellsData_t_d;
        private System.Windows.Forms.CheckBox checkCellsData_t_m;
        private System.Windows.Forms.CheckBox checkCellsData_V_m;
        private System.Windows.Forms.CheckBox checkCellsData_E_AJ;
        private System.Windows.Forms.CheckBox checkCellsData_E_TJ;
        private System.Windows.Forms.CheckBox checkCellsData_E_cs;
        private System.Windows.Forms.CheckBox checkCellsData_Dir_am;
        private System.Windows.Forms.CheckBox checkCellsData_Dir_pm;
        private System.Windows.Forms.CheckBox checkCellsData_Dir_pd;
        private System.Windows.Forms.CheckBox checkCellsData_T_de_total;
        private System.Windows.Forms.CheckBox checkCellsData_T_de_am;
        private System.Windows.Forms.CheckBox checkCellsData_THETA;
        private System.Windows.Forms.Button buttonSaveAllCellsData;
        private System.Windows.Forms.CheckBox checkCellsData_Coordinates;
        private System.Windows.Forms.CheckBox checkCellsData_Index;
        private System.Windows.Forms.CheckBox checkCellsData_HexCoordinates;
        private System.Windows.Forms.CheckBox checkSaveSubstrate;
        private System.Windows.Forms.CheckBox checkCellsData_E_cc_total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkCellsData_CellMovement;
        private System.Windows.Forms.CheckBox checkCellsData_E_c_total;
        private System.Windows.Forms.CheckBox checkCellsData_E_max;
    }
}
