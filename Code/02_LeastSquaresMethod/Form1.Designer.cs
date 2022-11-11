namespace LeastSquaresMethod
{
    partial class Form1
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.numTimeInit = new System.Windows.Forms.NumericUpDown();
            this.numLatticeSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTinit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numXsize = new System.Windows.Forms.NumericUpDown();
            this.numYsize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDt = new System.Windows.Forms.Label();
            this.numTime_dt = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textDataPath = new System.Windows.Forms.TextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.fbDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDataPath = new System.Windows.Forms.Button();
            this.textSavePath = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.radioLogRSS = new System.Windows.Forms.RadioButton();
            this.labelN = new System.Windows.Forms.Label();
            this.numN = new System.Windows.Forms.NumericUpDown();
            this.groupModel = new System.Windows.Forms.GroupBox();
            this.radioHex = new System.Windows.Forms.RadioButton();
            this.radioSqu = new System.Windows.Forms.RadioButton();
            this.groupMethod = new System.Windows.Forms.GroupBox();
            this.radioRSS = new System.Windows.Forms.RadioButton();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupUnit = new System.Windows.Forms.GroupBox();
            this.radioMovRate = new System.Windows.Forms.RadioButton();
            this.radioNumber = new System.Windows.Forms.RadioButton();
            this.radioDensity = new System.Windows.Forms.RadioButton();
            this.SpaceParam = new System.Windows.Forms.GroupBox();
            this.comboBoxFileNamePattern = new System.Windows.Forms.ComboBox();
            this.textBoxSelectedFolder = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelNumOfTargetFiles = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeInit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLatticeSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTime_dt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numN)).BeginInit();
            this.groupModel.SuspendLayout();
            this.groupMethod.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.groupUnit.SuspendLayout();
            this.SpaceParam.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "File name pattern";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numTimeInit
            // 
            this.numTimeInit.DecimalPlaces = 2;
            this.numTimeInit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numTimeInit.Location = new System.Drawing.Point(356, 157);
            this.numTimeInit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTimeInit.Name = "numTimeInit";
            this.numTimeInit.Size = new System.Drawing.Size(60, 19);
            this.numTimeInit.TabIndex = 20;
            this.numTimeInit.Value = new decimal(new int[] {
            72,
            0,
            0,
            0});
            // 
            // numLatticeSize
            // 
            this.numLatticeSize.DecimalPlaces = 1;
            this.numLatticeSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numLatticeSize.Location = new System.Drawing.Point(68, 68);
            this.numLatticeSize.Name = "numLatticeSize";
            this.numLatticeSize.Size = new System.Drawing.Size(60, 19);
            this.numLatticeSize.TabIndex = 5;
            this.numLatticeSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "l_c (um)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTinit
            // 
            this.labelTinit.AutoSize = true;
            this.labelTinit.Location = new System.Drawing.Point(303, 159);
            this.labelTinit.Name = "labelTinit";
            this.labelTinit.Size = new System.Drawing.Size(47, 12);
            this.labelTinit.TabIndex = 19;
            this.labelTinit.Text = "t_init (h)";
            this.labelTinit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Xsize (px)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numXsize
            // 
            this.numXsize.Location = new System.Drawing.Point(68, 18);
            this.numXsize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numXsize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numXsize.Name = "numXsize";
            this.numXsize.Size = new System.Drawing.Size(60, 19);
            this.numXsize.TabIndex = 1;
            this.numXsize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numYsize
            // 
            this.numYsize.Location = new System.Drawing.Point(68, 43);
            this.numYsize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numYsize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numYsize.Name = "numYsize";
            this.numYsize.Size = new System.Drawing.Size(60, 19);
            this.numYsize.TabIndex = 3;
            this.numYsize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ysize (px)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDt
            // 
            this.labelDt.AutoSize = true;
            this.labelDt.Location = new System.Drawing.Point(297, 134);
            this.labelDt.Name = "labelDt";
            this.labelDt.Size = new System.Drawing.Size(53, 12);
            this.labelDt.TabIndex = 17;
            this.labelDt.Text = "t_step (h)";
            this.labelDt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numTime_dt
            // 
            this.numTime_dt.DecimalPlaces = 2;
            this.numTime_dt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numTime_dt.Location = new System.Drawing.Point(356, 132);
            this.numTime_dt.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTime_dt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numTime_dt.Name = "numTime_dt";
            this.numTime_dt.Size = new System.Drawing.Size(60, 19);
            this.numTime_dt.TabIndex = 18;
            this.numTime_dt.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(322, 207);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(94, 88);
            this.buttonStart.TabIndex = 23;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // textDataPath
            // 
            this.textDataPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDataPath.Location = new System.Drawing.Point(113, 78);
            this.textDataPath.Name = "textDataPath";
            this.textDataPath.Size = new System.Drawing.Size(278, 19);
            this.textDataPath.TabIndex = 8;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(240, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(321, 12);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // buttonDataPath
            // 
            this.buttonDataPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDataPath.Location = new System.Drawing.Point(397, 78);
            this.buttonDataPath.Name = "buttonDataPath";
            this.buttonDataPath.Size = new System.Drawing.Size(19, 19);
            this.buttonDataPath.TabIndex = 9;
            this.buttonDataPath.Text = "...";
            this.buttonDataPath.UseVisualStyleBackColor = true;
            this.buttonDataPath.Click += new System.EventHandler(this.ButtonDataPath_Click);
            // 
            // textSavePath
            // 
            this.textSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSavePath.Location = new System.Drawing.Point(113, 107);
            this.textSavePath.Name = "textSavePath";
            this.textSavePath.Size = new System.Drawing.Size(278, 19);
            this.textSavePath.TabIndex = 11;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(397, 107);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(19, 19);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "...";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // radioLogRSS
            // 
            this.radioLogRSS.AutoSize = true;
            this.radioLogRSS.Checked = true;
            this.radioLogRSS.Location = new System.Drawing.Point(6, 18);
            this.radioLogRSS.Name = "radioLogRSS";
            this.radioLogRSS.Size = new System.Drawing.Size(67, 16);
            this.radioLogRSS.TabIndex = 0;
            this.radioLogRSS.TabStop = true;
            this.radioLogRSS.Text = "Log RSS";
            this.radioLogRSS.UseVisualStyleBackColor = true;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(331, 184);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(19, 12);
            this.labelN.TabIndex = 21;
            this.labelN.Text = "N=";
            // 
            // numN
            // 
            this.numN.Location = new System.Drawing.Point(356, 182);
            this.numN.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numN.Name = "numN";
            this.numN.Size = new System.Drawing.Size(60, 19);
            this.numN.TabIndex = 22;
            this.numN.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // groupModel
            // 
            this.groupModel.AutoSize = true;
            this.groupModel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupModel.Controls.Add(this.radioHex);
            this.groupModel.Controls.Add(this.radioSqu);
            this.groupModel.Location = new System.Drawing.Point(12, 132);
            this.groupModel.Name = "groupModel";
            this.groupModel.Size = new System.Drawing.Size(143, 52);
            this.groupModel.TabIndex = 13;
            this.groupModel.TabStop = false;
            this.groupModel.Text = "Grid model";
            // 
            // radioHex
            // 
            this.radioHex.AutoSize = true;
            this.radioHex.Checked = true;
            this.radioHex.Location = new System.Drawing.Point(6, 18);
            this.radioHex.Name = "radioHex";
            this.radioHex.Size = new System.Drawing.Size(67, 16);
            this.radioHex.TabIndex = 0;
            this.radioHex.TabStop = true;
            this.radioHex.Text = "Hexagon";
            this.radioHex.UseVisualStyleBackColor = true;
            // 
            // radioSqu
            // 
            this.radioSqu.AutoSize = true;
            this.radioSqu.Enabled = false;
            this.radioSqu.Location = new System.Drawing.Point(79, 18);
            this.radioSqu.Name = "radioSqu";
            this.radioSqu.Size = new System.Drawing.Size(58, 16);
            this.radioSqu.TabIndex = 1;
            this.radioSqu.Text = "Square";
            this.radioSqu.UseVisualStyleBackColor = true;
            // 
            // groupMethod
            // 
            this.groupMethod.AutoSize = true;
            this.groupMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupMethod.Controls.Add(this.radioRSS);
            this.groupMethod.Controls.Add(this.radioLogRSS);
            this.groupMethod.Location = new System.Drawing.Point(161, 132);
            this.groupMethod.Name = "groupMethod";
            this.groupMethod.Size = new System.Drawing.Size(130, 52);
            this.groupMethod.TabIndex = 14;
            this.groupMethod.TabStop = false;
            this.groupMethod.Text = "Method";
            // 
            // radioRSS
            // 
            this.radioRSS.AutoSize = true;
            this.radioRSS.Location = new System.Drawing.Point(79, 18);
            this.radioRSS.Name = "radioRSS";
            this.radioRSS.Size = new System.Drawing.Size(45, 16);
            this.radioRSS.TabIndex = 1;
            this.radioRSS.Text = "RSS";
            this.radioRSS.UseVisualStyleBackColor = true;
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar1,
            this.StatusLabel1});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 298);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(428, 22);
            this.StatusStrip1.TabIndex = 1;
            this.StatusStrip1.Text = "statusStrip1";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(100, 17);
            this.ProgressBar1.Visible = false;
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(73, 17);
            this.StatusLabel1.Text = "StatusLabel1";
            this.StatusLabel1.Visible = false;
            // 
            // groupUnit
            // 
            this.groupUnit.AutoSize = true;
            this.groupUnit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupUnit.Controls.Add(this.radioMovRate);
            this.groupUnit.Controls.Add(this.radioNumber);
            this.groupUnit.Controls.Add(this.radioDensity);
            this.groupUnit.Location = new System.Drawing.Point(12, 190);
            this.groupUnit.Name = "groupUnit";
            this.groupUnit.Size = new System.Drawing.Size(164, 96);
            this.groupUnit.TabIndex = 15;
            this.groupUnit.TabStop = false;
            this.groupUnit.Text = "Data unit";
            // 
            // radioMovRate
            // 
            this.radioMovRate.AutoSize = true;
            this.radioMovRate.Location = new System.Drawing.Point(6, 62);
            this.radioMovRate.Name = "radioMovRate";
            this.radioMovRate.Size = new System.Drawing.Size(138, 16);
            this.radioMovRate.TabIndex = 2;
            this.radioMovRate.Text = "Movement rate (um/h)";
            this.radioMovRate.UseVisualStyleBackColor = true;
            this.radioMovRate.CheckedChanged += new System.EventHandler(this.RadioMovRate_CheckedChanged);
            // 
            // radioNumber
            // 
            this.radioNumber.AutoSize = true;
            this.radioNumber.Location = new System.Drawing.Point(6, 40);
            this.radioNumber.Name = "radioNumber";
            this.radioNumber.Size = new System.Drawing.Size(120, 16);
            this.radioNumber.TabIndex = 1;
            this.radioNumber.Text = "Cell number (cells)";
            this.radioNumber.UseVisualStyleBackColor = true;
            this.radioNumber.CheckedChanged += new System.EventHandler(this.RadioNumber_CheckedChanged);
            // 
            // radioDensity
            // 
            this.radioDensity.AutoSize = true;
            this.radioDensity.Checked = true;
            this.radioDensity.Location = new System.Drawing.Point(6, 18);
            this.radioDensity.Name = "radioDensity";
            this.radioDensity.Size = new System.Drawing.Size(152, 16);
            this.radioDensity.TabIndex = 0;
            this.radioDensity.TabStop = true;
            this.radioDensity.Text = "Cell density (cells/cm^2)";
            this.radioDensity.UseVisualStyleBackColor = true;
            this.radioDensity.CheckedChanged += new System.EventHandler(this.RadioDensity_CheckedChanged);
            // 
            // SpaceParam
            // 
            this.SpaceParam.AutoSize = true;
            this.SpaceParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SpaceParam.Controls.Add(this.label2);
            this.SpaceParam.Controls.Add(this.label4);
            this.SpaceParam.Controls.Add(this.numLatticeSize);
            this.SpaceParam.Controls.Add(this.numXsize);
            this.SpaceParam.Controls.Add(this.label5);
            this.SpaceParam.Controls.Add(this.numYsize);
            this.SpaceParam.Location = new System.Drawing.Point(182, 190);
            this.SpaceParam.Name = "SpaceParam";
            this.SpaceParam.Size = new System.Drawing.Size(134, 105);
            this.SpaceParam.TabIndex = 16;
            this.SpaceParam.TabStop = false;
            this.SpaceParam.Text = "Spatial parameter";
            // 
            // comboBoxFileNamePattern
            // 
            this.comboBoxFileNamePattern.FormattingEnabled = true;
            this.comboBoxFileNamePattern.Items.AddRange(new object[] {
            "cell_step_*.csv",
            "cell_count.csv",
            "out_MovRate_*.csv"});
            this.comboBoxFileNamePattern.Location = new System.Drawing.Point(113, 14);
            this.comboBoxFileNamePattern.Name = "comboBoxFileNamePattern";
            this.comboBoxFileNamePattern.Size = new System.Drawing.Size(121, 20);
            this.comboBoxFileNamePattern.TabIndex = 1;
            // 
            // textBoxSelectedFolder
            // 
            this.textBoxSelectedFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSelectedFolder.Location = new System.Drawing.Point(113, 41);
            this.textBoxSelectedFolder.Name = "textBoxSelectedFolder";
            this.textBoxSelectedFolder.ReadOnly = true;
            this.textBoxSelectedFolder.Size = new System.Drawing.Size(303, 19);
            this.textBoxSelectedFolder.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "Selected folder";
            // 
            // labelNumOfTargetFiles
            // 
            this.labelNumOfTargetFiles.AutoSize = true;
            this.labelNumOfTargetFiles.Location = new System.Drawing.Point(111, 63);
            this.labelNumOfTargetFiles.Name = "labelNumOfTargetFiles";
            this.labelNumOfTargetFiles.Size = new System.Drawing.Size(124, 12);
            this.labelNumOfTargetFiles.TabIndex = 6;
            this.labelNumOfTargetFiles.Text = "Number of target files :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "In vitro data path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Save file path";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.numN);
            this.panel1.Controls.Add(this.labelNumOfTargetFiles);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textDataPath);
            this.panel1.Controls.Add(this.textBoxSelectedFolder);
            this.panel1.Controls.Add(this.buttonOpen);
            this.panel1.Controls.Add(this.comboBoxFileNamePattern);
            this.panel1.Controls.Add(this.textSavePath);
            this.panel1.Controls.Add(this.numTime_dt);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.SpaceParam);
            this.panel1.Controls.Add(this.buttonDataPath);
            this.panel1.Controls.Add(this.groupUnit);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.labelTinit);
            this.panel1.Controls.Add(this.labelN);
            this.panel1.Controls.Add(this.labelDt);
            this.panel1.Controls.Add(this.groupModel);
            this.panel1.Controls.Add(this.groupMethod);
            this.panel1.Controls.Add(this.numTimeInit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 298);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 320);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StatusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(444, 359);
            this.Name = "Form1";
            this.Text = "Least-squares_method";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTimeInit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLatticeSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTime_dt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numN)).EndInit();
            this.groupModel.ResumeLayout(false);
            this.groupModel.PerformLayout();
            this.groupMethod.ResumeLayout(false);
            this.groupMethod.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.groupUnit.ResumeLayout(false);
            this.groupUnit.PerformLayout();
            this.SpaceParam.ResumeLayout(false);
            this.SpaceParam.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numTimeInit;
        private System.Windows.Forms.NumericUpDown numLatticeSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTinit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numXsize;
        private System.Windows.Forms.NumericUpDown numYsize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDt;
        private System.Windows.Forms.NumericUpDown numTime_dt;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textDataPath;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.FolderBrowserDialog fbDialog;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDataPath;
        private System.Windows.Forms.TextBox textSavePath;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.RadioButton radioLogRSS;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.NumericUpDown numN;
        private System.Windows.Forms.GroupBox groupModel;
        private System.Windows.Forms.RadioButton radioHex;
        private System.Windows.Forms.RadioButton radioSqu;
        private System.Windows.Forms.GroupBox groupMethod;
        private System.Windows.Forms.RadioButton radioRSS;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.GroupBox groupUnit;
        private System.Windows.Forms.RadioButton radioNumber;
        private System.Windows.Forms.RadioButton radioDensity;
        private System.Windows.Forms.RadioButton radioMovRate;
        private System.Windows.Forms.GroupBox SpaceParam;
        private System.Windows.Forms.ComboBox comboBoxFileNamePattern;
        private System.Windows.Forms.TextBox textBoxSelectedFolder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelNumOfTargetFiles;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}

