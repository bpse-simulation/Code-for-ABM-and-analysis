namespace ImageCreator
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.numColumn = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxRawImage = new System.Windows.Forms.GroupBox();
            this.checkBoxSaveRAW = new System.Windows.Forms.CheckBox();
            this.radioButtonXZY = new System.Windows.Forms.RadioButton();
            this.radioButtonXYZ = new System.Windows.Forms.RadioButton();
            this.groupBoxCombineImage = new System.Windows.Forms.GroupBox();
            this.radioButtonCombineImageH = new System.Windows.Forms.RadioButton();
            this.radioButtonCombineImageV = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxExtension = new System.Windows.Forms.ComboBox();
            this.numStart = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numStep = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSaveFolder = new System.Windows.Forms.Button();
            this.textBoxSaveFolderPath = new System.Windows.Forms.TextBox();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.textBoxOpenFolderPath = new System.Windows.Forms.TextBox();
            this.colorMap1 = new BPSE.ColorMap();
            this.visualizationUsingHexagons1 = new BPSE.VisualizationUsingHexagons();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numColumn)).BeginInit();
            this.StatusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxRawImage.SuspendLayout();
            this.groupBoxCombineImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStep)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numColumn
            // 
            this.numColumn.Location = new System.Drawing.Point(414, 79);
            this.numColumn.Name = "numColumn";
            this.numColumn.Size = new System.Drawing.Size(62, 19);
            this.numColumn.TabIndex = 12;
            this.numColumn.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "Column index to create image";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar1,
            this.StatusLabel1});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 348);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(488, 22);
            this.StatusStrip1.TabIndex = 2;
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
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(12, 296);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(464, 24);
            this.buttonStart.TabIndex = 18;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxRawImage);
            this.panel1.Controls.Add(this.groupBoxCombineImage);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxExtension);
            this.panel1.Controls.Add(this.numStart);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.numStep);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numColumn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonSaveFolder);
            this.panel1.Controls.Add(this.textBoxSaveFolderPath);
            this.panel1.Controls.Add(this.buttonOpenFolder);
            this.panel1.Controls.Add(this.textBoxOpenFolderPath);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.colorMap1);
            this.panel1.Controls.Add(this.visualizationUsingHexagons1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 324);
            this.panel1.TabIndex = 1;
            // 
            // groupBoxRawImage
            // 
            this.groupBoxRawImage.Controls.Add(this.checkBoxSaveRAW);
            this.groupBoxRawImage.Controls.Add(this.radioButtonXZY);
            this.groupBoxRawImage.Controls.Add(this.radioButtonXYZ);
            this.groupBoxRawImage.Location = new System.Drawing.Point(250, 250);
            this.groupBoxRawImage.Name = "groupBoxRawImage";
            this.groupBoxRawImage.Size = new System.Drawing.Size(177, 40);
            this.groupBoxRawImage.TabIndex = 17;
            this.groupBoxRawImage.TabStop = false;
            this.groupBoxRawImage.Text = "Raw image";
            // 
            // checkBoxSaveRAW
            // 
            this.checkBoxSaveRAW.AutoSize = true;
            this.checkBoxSaveRAW.Location = new System.Drawing.Point(6, 18);
            this.checkBoxSaveRAW.Name = "checkBoxSaveRAW";
            this.checkBoxSaveRAW.Size = new System.Drawing.Size(49, 16);
            this.checkBoxSaveRAW.TabIndex = 0;
            this.checkBoxSaveRAW.Text = "Save";
            this.checkBoxSaveRAW.UseVisualStyleBackColor = true;
            this.checkBoxSaveRAW.CheckedChanged += new System.EventHandler(this.CheckBoxSaveRAW_CheckedChanged);
            // 
            // radioButtonXZY
            // 
            this.radioButtonXZY.AutoSize = true;
            this.radioButtonXZY.Enabled = false;
            this.radioButtonXZY.Location = new System.Drawing.Point(119, 18);
            this.radioButtonXZY.Name = "radioButtonXZY";
            this.radioButtonXZY.Size = new System.Drawing.Size(52, 16);
            this.radioButtonXZY.TabIndex = 2;
            this.radioButtonXZY.Text = "x-z-y";
            this.radioButtonXZY.UseVisualStyleBackColor = true;
            // 
            // radioButtonXYZ
            // 
            this.radioButtonXYZ.AutoSize = true;
            this.radioButtonXYZ.Checked = true;
            this.radioButtonXYZ.Enabled = false;
            this.radioButtonXYZ.Location = new System.Drawing.Point(61, 18);
            this.radioButtonXYZ.Name = "radioButtonXYZ";
            this.radioButtonXYZ.Size = new System.Drawing.Size(52, 16);
            this.radioButtonXYZ.TabIndex = 1;
            this.radioButtonXYZ.TabStop = true;
            this.radioButtonXYZ.Text = "x-y-z";
            this.radioButtonXYZ.UseVisualStyleBackColor = true;
            // 
            // groupBoxCombineImage
            // 
            this.groupBoxCombineImage.Controls.Add(this.radioButtonCombineImageH);
            this.groupBoxCombineImage.Controls.Add(this.radioButtonCombineImageV);
            this.groupBoxCombineImage.Location = new System.Drawing.Point(250, 178);
            this.groupBoxCombineImage.Name = "groupBoxCombineImage";
            this.groupBoxCombineImage.Size = new System.Drawing.Size(155, 40);
            this.groupBoxCombineImage.TabIndex = 14;
            this.groupBoxCombineImage.TabStop = false;
            this.groupBoxCombineImage.Text = "Combined image";
            // 
            // radioButtonCombineImageH
            // 
            this.radioButtonCombineImageH.AutoSize = true;
            this.radioButtonCombineImageH.Location = new System.Drawing.Point(75, 18);
            this.radioButtonCombineImageH.Name = "radioButtonCombineImageH";
            this.radioButtonCombineImageH.Size = new System.Drawing.Size(74, 16);
            this.radioButtonCombineImageH.TabIndex = 1;
            this.radioButtonCombineImageH.Text = "Horizontal";
            this.radioButtonCombineImageH.UseVisualStyleBackColor = true;
            // 
            // radioButtonCombineImageV
            // 
            this.radioButtonCombineImageV.AutoSize = true;
            this.radioButtonCombineImageV.Checked = true;
            this.radioButtonCombineImageV.Location = new System.Drawing.Point(6, 18);
            this.radioButtonCombineImageV.Name = "radioButtonCombineImageV";
            this.radioButtonCombineImageV.Size = new System.Drawing.Size(63, 16);
            this.radioButtonCombineImageV.TabIndex = 0;
            this.radioButtonCombineImageV.TabStop = true;
            this.radioButtonCombineImageV.Text = "Vertical";
            this.radioButtonCombineImageV.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Save folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Open folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "Image file format";
            // 
            // comboBoxExtension
            // 
            this.comboBoxExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExtension.FormattingEnabled = true;
            this.comboBoxExtension.Location = new System.Drawing.Point(348, 224);
            this.comboBoxExtension.Name = "comboBoxExtension";
            this.comboBoxExtension.Size = new System.Drawing.Size(128, 20);
            this.comboBoxExtension.TabIndex = 16;
            this.comboBoxExtension.SelectedIndexChanged += new System.EventHandler(this.ComboBoxExtension_SelectedIndexChanged);
            // 
            // numStart
            // 
            this.numStart.Location = new System.Drawing.Point(293, 54);
            this.numStart.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numStart.Name = "numStart";
            this.numStart.Size = new System.Drawing.Size(62, 19);
            this.numStart.TabIndex = 8;
            this.numStart.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "Start:";
            // 
            // numStep
            // 
            this.numStep.Location = new System.Drawing.Point(414, 54);
            this.numStep.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStep.Name = "numStep";
            this.numStep.Size = new System.Drawing.Size(62, 19);
            this.numStep.TabIndex = 10;
            this.numStep.Tag = "";
            this.numStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Step:";
            // 
            // buttonSaveFolder
            // 
            this.buttonSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveFolder.Location = new System.Drawing.Point(457, 29);
            this.buttonSaveFolder.Name = "buttonSaveFolder";
            this.buttonSaveFolder.Size = new System.Drawing.Size(19, 19);
            this.buttonSaveFolder.TabIndex = 6;
            this.buttonSaveFolder.Text = "...";
            this.buttonSaveFolder.UseVisualStyleBackColor = true;
            this.buttonSaveFolder.Click += new System.EventHandler(this.ButtonSaveFolder_Click);
            // 
            // textBoxSaveFolderPath
            // 
            this.textBoxSaveFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSaveFolderPath.Location = new System.Drawing.Point(320, 29);
            this.textBoxSaveFolderPath.Name = "textBoxSaveFolderPath";
            this.textBoxSaveFolderPath.Size = new System.Drawing.Size(131, 19);
            this.textBoxSaveFolderPath.TabIndex = 5;
            this.textBoxSaveFolderPath.Leave += new System.EventHandler(this.TextBoxSaveFolderPath_Leave);
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFolder.Location = new System.Drawing.Point(457, 4);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(19, 19);
            this.buttonOpenFolder.TabIndex = 3;
            this.buttonOpenFolder.Text = "...";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            this.buttonOpenFolder.Click += new System.EventHandler(this.ButtonOpenFolder_Click);
            // 
            // textBoxOpenFolderPath
            // 
            this.textBoxOpenFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOpenFolderPath.Location = new System.Drawing.Point(320, 4);
            this.textBoxOpenFolderPath.Name = "textBoxOpenFolderPath";
            this.textBoxOpenFolderPath.Size = new System.Drawing.Size(131, 19);
            this.textBoxOpenFolderPath.TabIndex = 2;
            // 
            // colorMap1
            // 
            this.colorMap1.AutoSize = true;
            this.colorMap1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorMap1.Location = new System.Drawing.Point(250, 104);
            this.colorMap1.Name = "colorMap1";
            this.colorMap1.Size = new System.Drawing.Size(226, 68);
            this.colorMap1.TabIndex = 13;
            // 
            // visualizationUsingHexagons1
            // 
            this.visualizationUsingHexagons1.AutoSize = true;
            this.visualizationUsingHexagons1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.visualizationUsingHexagons1.Location = new System.Drawing.Point(12, 3);
            this.visualizationUsingHexagons1.Name = "visualizationUsingHexagons1";
            this.visualizationUsingHexagons1.Size = new System.Drawing.Size(232, 274);
            this.visualizationUsingHexagons1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(488, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fileToolStripMenuItem.Text = "File(&F)";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Enabled = false;
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cancelToolStripMenuItem.Text = "Cancel(&C)";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.CancelToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exitToolStripMenuItem.Text = "Exit(&X)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.helpToolStripMenuItem.Text = "Help(&H)";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.aboutToolStripMenuItem.Text = "About(&A)";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 370);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.StatusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(504, 409);
            this.Name = "Main";
            this.Text = "Image creator (hexagon)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numColumn)).EndInit();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxRawImage.ResumeLayout(false);
            this.groupBoxRawImage.PerformLayout();
            this.groupBoxCombineImage.ResumeLayout(false);
            this.groupBoxCombineImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStep)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BPSE.ColorMap colorMap1;
        private System.Windows.Forms.NumericUpDown numColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSaveFolder;
        private System.Windows.Forms.TextBox textBoxSaveFolderPath;
        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.TextBox textBoxOpenFolderPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxExtension;
        private BPSE.VisualizationUsingHexagons visualizationUsingHexagons1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxSaveRAW;
        private System.Windows.Forms.RadioButton radioButtonXZY;
        private System.Windows.Forms.RadioButton radioButtonXYZ;
        private System.Windows.Forms.NumericUpDown numStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numStep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxCombineImage;
        private System.Windows.Forms.RadioButton radioButtonCombineImageV;
        private System.Windows.Forms.RadioButton radioButtonCombineImageH;
        private System.Windows.Forms.GroupBox groupBoxRawImage;
    }
}

