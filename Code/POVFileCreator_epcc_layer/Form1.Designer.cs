namespace MQOFileCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.numYsize = new System.Windows.Forms.NumericUpDown();
            this.numXsize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSaveFolder = new System.Windows.Forms.Button();
            this.textBoxSaveFolderPath = new System.Windows.Forms.TextBox();
            this.textBoxOpenFolderPath = new System.Windows.Forms.TextBox();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxHeader = new System.Windows.Forms.TextBox();
            this.checkBoxSubstrate = new System.Windows.Forms.CheckBox();
            this.checkBoxCellsData = new System.Windows.Forms.CheckBox();
            this.groupBoxSubstrate = new System.Windows.Forms.GroupBox();
            this.colorMapSubstrate = new BPSE.ColorMap();
            this.buttonOpenFolderSubstrate = new System.Windows.Forms.Button();
            this.textBoxOpenFolderPathSubstrate = new System.Windows.Forms.TextBox();
            this.groupBoxCellsData = new System.Windows.Forms.GroupBox();
            this.labelTargetCellIndex = new System.Windows.Forms.Label();
            this.numericUpDownTargetCellIndex = new System.Windows.Forms.NumericUpDown();
            this.checkBoxHighlight = new System.Windows.Forms.CheckBox();
            this.colorMapCell = new BPSE.ColorMap();
            this.numColumn = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXsize)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxSubstrate.SuspendLayout();
            this.groupBoxCellsData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTargetCellIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumn)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar1,
            this.StatusLabel1});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 629);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(506, 22);
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
            // numYsize
            // 
            this.numYsize.Location = new System.Drawing.Point(172, 18);
            this.numYsize.Maximum = new decimal(new int[] {
            2147483647,
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
            64,
            0,
            0,
            0});
            this.numYsize.ValueChanged += new System.EventHandler(this.numYsize_ValueChanged);
            // 
            // numXsize
            // 
            this.numXsize.Location = new System.Drawing.Point(48, 18);
            this.numXsize.Maximum = new decimal(new int[] {
            2147483647,
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
            this.numXsize.Tag = "";
            this.numXsize.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numXsize.ValueChanged += new System.EventHandler(this.numXsize_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "X size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y size";
            // 
            // buttonSaveFolder
            // 
            this.buttonSaveFolder.AutoSize = true;
            this.buttonSaveFolder.Location = new System.Drawing.Point(6, 43);
            this.buttonSaveFolder.Name = "buttonSaveFolder";
            this.buttonSaveFolder.Size = new System.Drawing.Size(114, 23);
            this.buttonSaveFolder.TabIndex = 6;
            this.buttonSaveFolder.Text = "Select save folder...";
            this.buttonSaveFolder.UseVisualStyleBackColor = true;
            this.buttonSaveFolder.Click += new System.EventHandler(this.ButtonSaveFolder_Click);
            // 
            // textBoxSaveFolderPath
            // 
            this.textBoxSaveFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSaveFolderPath.Location = new System.Drawing.Point(126, 45);
            this.textBoxSaveFolderPath.Name = "textBoxSaveFolderPath";
            this.textBoxSaveFolderPath.Size = new System.Drawing.Size(350, 19);
            this.textBoxSaveFolderPath.TabIndex = 7;
            this.textBoxSaveFolderPath.TextChanged += new System.EventHandler(this.TextSaveFolderPath_TextChanged);
            this.textBoxSaveFolderPath.Leave += new System.EventHandler(this.TextSaveFolderPath_Leave);
            // 
            // textBoxOpenFolderPath
            // 
            this.textBoxOpenFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOpenFolderPath.Location = new System.Drawing.Point(98, 20);
            this.textBoxOpenFolderPath.Name = "textBoxOpenFolderPath";
            this.textBoxOpenFolderPath.Size = new System.Drawing.Size(378, 19);
            this.textBoxOpenFolderPath.TabIndex = 1;
            this.textBoxOpenFolderPath.TextChanged += new System.EventHandler(this.TextOpenFolderPath_TextChanged);
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.AutoSize = true;
            this.buttonOpenFolder.Location = new System.Drawing.Point(6, 18);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(86, 23);
            this.buttonOpenFolder.TabIndex = 0;
            this.buttonOpenFolder.Text = "Select folder...";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            this.buttonOpenFolder.Click += new System.EventHandler(this.ButtonOpenFolder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.checkBoxSubstrate);
            this.panel1.Controls.Add(this.checkBoxCellsData);
            this.panel1.Controls.Add(this.groupBoxSubstrate);
            this.panel1.Controls.Add(this.groupBoxCellsData);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 605);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBoxHeader);
            this.groupBox1.Controls.Add(this.buttonSaveFolder);
            this.groupBox1.Controls.Add(this.textBoxSaveFolderPath);
            this.groupBox1.Controls.Add(this.numYsize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numXsize);
            this.groupBox1.Location = new System.Drawing.Point(12, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 307);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // textBoxHeader
            // 
            this.textBoxHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHeader.Location = new System.Drawing.Point(6, 72);
            this.textBoxHeader.Multiline = true;
            this.textBoxHeader.Name = "textBoxHeader";
            this.textBoxHeader.Size = new System.Drawing.Size(470, 229);
            this.textBoxHeader.TabIndex = 11;
            this.textBoxHeader.Text = resources.GetString("textBoxHeader.Text");
            // 
            // checkBoxSubstrate
            // 
            this.checkBoxSubstrate.AutoSize = true;
            this.checkBoxSubstrate.Location = new System.Drawing.Point(18, 139);
            this.checkBoxSubstrate.Name = "checkBoxSubstrate";
            this.checkBoxSubstrate.Size = new System.Drawing.Size(73, 16);
            this.checkBoxSubstrate.TabIndex = 2;
            this.checkBoxSubstrate.Text = "Substrate";
            this.checkBoxSubstrate.UseVisualStyleBackColor = true;
            this.checkBoxSubstrate.CheckedChanged += new System.EventHandler(this.CheckBoxSubstrate_CheckedChanged);
            // 
            // checkBoxCellsData
            // 
            this.checkBoxCellsData.AutoSize = true;
            this.checkBoxCellsData.Location = new System.Drawing.Point(18, 12);
            this.checkBoxCellsData.Name = "checkBoxCellsData";
            this.checkBoxCellsData.Size = new System.Drawing.Size(180, 16);
            this.checkBoxCellsData.TabIndex = 0;
            this.checkBoxCellsData.Text = "CellsData, MovementRate, etc.";
            this.checkBoxCellsData.UseVisualStyleBackColor = true;
            this.checkBoxCellsData.CheckedChanged += new System.EventHandler(this.CheckBoxCellsData_CheckedChanged);
            // 
            // groupBoxSubstrate
            // 
            this.groupBoxSubstrate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSubstrate.Controls.Add(this.colorMapSubstrate);
            this.groupBoxSubstrate.Controls.Add(this.buttonOpenFolderSubstrate);
            this.groupBoxSubstrate.Controls.Add(this.textBoxOpenFolderPathSubstrate);
            this.groupBoxSubstrate.Enabled = false;
            this.groupBoxSubstrate.Location = new System.Drawing.Point(12, 139);
            this.groupBoxSubstrate.Name = "groupBoxSubstrate";
            this.groupBoxSubstrate.Size = new System.Drawing.Size(482, 121);
            this.groupBoxSubstrate.TabIndex = 3;
            this.groupBoxSubstrate.TabStop = false;
            // 
            // colorMapSubstrate
            // 
            this.colorMapSubstrate.AutoSize = true;
            this.colorMapSubstrate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorMapSubstrate.Location = new System.Drawing.Point(6, 47);
            this.colorMapSubstrate.Name = "colorMapSubstrate";
            this.colorMapSubstrate.Size = new System.Drawing.Size(226, 68);
            this.colorMapSubstrate.TabIndex = 2;
            // 
            // buttonOpenFolderSubstrate
            // 
            this.buttonOpenFolderSubstrate.AutoSize = true;
            this.buttonOpenFolderSubstrate.Location = new System.Drawing.Point(6, 18);
            this.buttonOpenFolderSubstrate.Name = "buttonOpenFolderSubstrate";
            this.buttonOpenFolderSubstrate.Size = new System.Drawing.Size(86, 23);
            this.buttonOpenFolderSubstrate.TabIndex = 0;
            this.buttonOpenFolderSubstrate.Text = "Select folder...";
            this.buttonOpenFolderSubstrate.UseVisualStyleBackColor = true;
            this.buttonOpenFolderSubstrate.Click += new System.EventHandler(this.ButtonOpenFolderSubstrate_Click);
            // 
            // textBoxOpenFolderPathSubstrate
            // 
            this.textBoxOpenFolderPathSubstrate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOpenFolderPathSubstrate.Location = new System.Drawing.Point(98, 20);
            this.textBoxOpenFolderPathSubstrate.Name = "textBoxOpenFolderPathSubstrate";
            this.textBoxOpenFolderPathSubstrate.Size = new System.Drawing.Size(378, 19);
            this.textBoxOpenFolderPathSubstrate.TabIndex = 1;
            this.textBoxOpenFolderPathSubstrate.TextChanged += new System.EventHandler(this.TextBoxOpenFolderPathSubstrate_TextChanged);
            // 
            // groupBoxCellsData
            // 
            this.groupBoxCellsData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCellsData.Controls.Add(this.labelTargetCellIndex);
            this.groupBoxCellsData.Controls.Add(this.numericUpDownTargetCellIndex);
            this.groupBoxCellsData.Controls.Add(this.checkBoxHighlight);
            this.groupBoxCellsData.Controls.Add(this.buttonOpenFolder);
            this.groupBoxCellsData.Controls.Add(this.textBoxOpenFolderPath);
            this.groupBoxCellsData.Controls.Add(this.colorMapCell);
            this.groupBoxCellsData.Controls.Add(this.numColumn);
            this.groupBoxCellsData.Controls.Add(this.label1);
            this.groupBoxCellsData.Enabled = false;
            this.groupBoxCellsData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCellsData.Name = "groupBoxCellsData";
            this.groupBoxCellsData.Size = new System.Drawing.Size(482, 121);
            this.groupBoxCellsData.TabIndex = 1;
            this.groupBoxCellsData.TabStop = false;
            // 
            // labelTargetCellIndex
            // 
            this.labelTargetCellIndex.AutoSize = true;
            this.labelTargetCellIndex.Enabled = false;
            this.labelTargetCellIndex.Location = new System.Drawing.Point(238, 94);
            this.labelTargetCellIndex.Name = "labelTargetCellIndex";
            this.labelTargetCellIndex.Size = new System.Drawing.Size(91, 12);
            this.labelTargetCellIndex.TabIndex = 7;
            this.labelTargetCellIndex.Text = "Target cell index";
            // 
            // numericUpDownTargetCellIndex
            // 
            this.numericUpDownTargetCellIndex.Enabled = false;
            this.numericUpDownTargetCellIndex.Location = new System.Drawing.Point(335, 92);
            this.numericUpDownTargetCellIndex.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownTargetCellIndex.Name = "numericUpDownTargetCellIndex";
            this.numericUpDownTargetCellIndex.Size = new System.Drawing.Size(78, 19);
            this.numericUpDownTargetCellIndex.TabIndex = 6;
            this.numericUpDownTargetCellIndex.Tag = "";
            // 
            // checkBoxHighlight
            // 
            this.checkBoxHighlight.AutoSize = true;
            this.checkBoxHighlight.Location = new System.Drawing.Point(240, 70);
            this.checkBoxHighlight.Name = "checkBoxHighlight";
            this.checkBoxHighlight.Size = new System.Drawing.Size(226, 16);
            this.checkBoxHighlight.TabIndex = 5;
            this.checkBoxHighlight.Text = "Highlight the target cell (make contour)";
            this.checkBoxHighlight.UseVisualStyleBackColor = true;
            this.checkBoxHighlight.CheckedChanged += new System.EventHandler(this.CheckBoxTransparent_CheckedChanged);
            // 
            // colorMapCell
            // 
            this.colorMapCell.AutoSize = true;
            this.colorMapCell.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorMapCell.Location = new System.Drawing.Point(6, 47);
            this.colorMapCell.Name = "colorMapCell";
            this.colorMapCell.Size = new System.Drawing.Size(226, 68);
            this.colorMapCell.TabIndex = 2;
            // 
            // numColumn
            // 
            this.numColumn.Location = new System.Drawing.Point(318, 45);
            this.numColumn.Name = "numColumn";
            this.numColumn.Size = new System.Drawing.Size(60, 19);
            this.numColumn.TabIndex = 4;
            this.numColumn.Tag = "";
            this.numColumn.ValueChanged += new System.EventHandler(this.numColumn_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Column index";
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(12, 579);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(482, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(506, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fileToolStripMenuItem.Text = "File(&F)";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 651);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(490, 500);
            this.Name = "Form1";
            this.Text = "POV file converter (for CBS ver2)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXsize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSubstrate.ResumeLayout(false);
            this.groupBoxSubstrate.PerformLayout();
            this.groupBoxCellsData.ResumeLayout(false);
            this.groupBoxCellsData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTargetCellIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumn)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.NumericUpDown numYsize;
        private System.Windows.Forms.NumericUpDown numXsize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSaveFolder;
        private System.Windows.Forms.TextBox textBoxSaveFolderPath;
        private System.Windows.Forms.TextBox textBoxOpenFolderPath;
        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numColumn;
        private BPSE.ColorMap colorMapCell;
        private System.Windows.Forms.Button buttonOpenFolderSubstrate;
        private System.Windows.Forms.TextBox textBoxOpenFolderPathSubstrate;
        private System.Windows.Forms.GroupBox groupBoxSubstrate;
        private System.Windows.Forms.GroupBox groupBoxCellsData;
        private System.Windows.Forms.CheckBox checkBoxSubstrate;
        private System.Windows.Forms.CheckBox checkBoxCellsData;
        private BPSE.ColorMap colorMapSubstrate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxHeader;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label labelTargetCellIndex;
        private System.Windows.Forms.NumericUpDown numericUpDownTargetCellIndex;
        private System.Windows.Forms.CheckBox checkBoxHighlight;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

