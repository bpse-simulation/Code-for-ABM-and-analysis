namespace ImageCreator_Ecc
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
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.FilePaths = new System.Windows.Forms.ListBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.SaveFolderPath = new System.Windows.Forms.TextBox();
            this.SelectSaveFolder = new System.Windows.Forms.Button();
            this.SelectCellsData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NumZsize = new System.Windows.Forms.NumericUpDown();
            this.NumYsize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.NumXsize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveRawData = new System.Windows.Forms.CheckBox();
            this.radioButtonMean = new System.Windows.Forms.RadioButton();
            this.radioButtonMax = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTotal = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonYZ = new System.Windows.Forms.RadioButton();
            this.radioButtonXY = new System.Windows.Forms.RadioButton();
            this.numColumn = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxBGColor = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.colorMap1 = new BPSE.ColorMap();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumZsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumYsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumXsize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBGColor)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar1,
            this.StatusLabel1});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 368);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(468, 22);
            this.StatusStrip1.TabIndex = 16;
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
            // FilePaths
            // 
            this.FilePaths.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilePaths.FormattingEnabled = true;
            this.FilePaths.HorizontalScrollbar = true;
            this.FilePaths.ItemHeight = 12;
            this.FilePaths.Location = new System.Drawing.Point(12, 40);
            this.FilePaths.Name = "FilePaths";
            this.FilePaths.Size = new System.Drawing.Size(444, 112);
            this.FilePaths.TabIndex = 1;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonStart.Location = new System.Drawing.Point(123, 343);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(333, 22);
            this.ButtonStart.TabIndex = 15;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // SaveFolderPath
            // 
            this.SaveFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveFolderPath.Location = new System.Drawing.Point(12, 186);
            this.SaveFolderPath.Multiline = true;
            this.SaveFolderPath.Name = "SaveFolderPath";
            this.SaveFolderPath.Size = new System.Drawing.Size(444, 19);
            this.SaveFolderPath.TabIndex = 3;
            this.SaveFolderPath.TextChanged += new System.EventHandler(this.SaveFolderPath_TextChanged);
            this.SaveFolderPath.Leave += new System.EventHandler(this.SaveFolderPath_Leave);
            // 
            // SelectSaveFolder
            // 
            this.SelectSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectSaveFolder.AutoSize = true;
            this.SelectSaveFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SelectSaveFolder.Location = new System.Drawing.Point(12, 158);
            this.SelectSaveFolder.Name = "SelectSaveFolder";
            this.SelectSaveFolder.Size = new System.Drawing.Size(157, 22);
            this.SelectSaveFolder.TabIndex = 2;
            this.SelectSaveFolder.Text = "Select folder (Save image)...";
            this.SelectSaveFolder.UseVisualStyleBackColor = true;
            this.SelectSaveFolder.Click += new System.EventHandler(this.SelectSaveFolder_Click);
            // 
            // SelectCellsData
            // 
            this.SelectCellsData.AutoSize = true;
            this.SelectCellsData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SelectCellsData.Location = new System.Drawing.Point(12, 12);
            this.SelectCellsData.Name = "SelectCellsData";
            this.SelectCellsData.Size = new System.Drawing.Size(143, 22);
            this.SelectCellsData.TabIndex = 0;
            this.SelectCellsData.Text = "Select files (Cells data)...";
            this.SelectCellsData.UseVisualStyleBackColor = true;
            this.SelectCellsData.Click += new System.EventHandler(this.SelectCellsData_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ysize (-)";
            // 
            // NumZsize
            // 
            this.NumZsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NumZsize.Location = new System.Drawing.Point(312, 260);
            this.NumZsize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumZsize.Name = "NumZsize";
            this.NumZsize.Size = new System.Drawing.Size(60, 19);
            this.NumZsize.TabIndex = 11;
            this.NumZsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumZsize.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // NumYsize
            // 
            this.NumYsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NumYsize.Location = new System.Drawing.Point(312, 235);
            this.NumYsize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumYsize.Name = "NumYsize";
            this.NumYsize.Size = new System.Drawing.Size(60, 19);
            this.NumYsize.TabIndex = 9;
            this.NumYsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumYsize.Value = new decimal(new int[] {
            52,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Xsize (-)";
            // 
            // NumXsize
            // 
            this.NumXsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NumXsize.Location = new System.Drawing.Point(312, 210);
            this.NumXsize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumXsize.Name = "NumXsize";
            this.NumXsize.Size = new System.Drawing.Size(60, 19);
            this.NumXsize.TabIndex = 7;
            this.NumXsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumXsize.Value = new decimal(new int[] {
            52,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Zsize (-)";
            // 
            // SaveRawData
            // 
            this.SaveRawData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveRawData.AutoSize = true;
            this.SaveRawData.Location = new System.Drawing.Point(12, 347);
            this.SaveRawData.Name = "SaveRawData";
            this.SaveRawData.Size = new System.Drawing.Size(105, 16);
            this.SaveRawData.TabIndex = 14;
            this.SaveRawData.Text = "Save raw image";
            this.SaveRawData.UseVisualStyleBackColor = true;
            this.SaveRawData.CheckedChanged += new System.EventHandler(this.SaveRawData_CheckedChanged);
            // 
            // radioButtonMean
            // 
            this.radioButtonMean.AutoSize = true;
            this.radioButtonMean.Checked = true;
            this.radioButtonMean.Location = new System.Drawing.Point(12, 18);
            this.radioButtonMean.Name = "radioButtonMean";
            this.radioButtonMean.Size = new System.Drawing.Size(113, 16);
            this.radioButtonMean.TabIndex = 0;
            this.radioButtonMean.TabStop = true;
            this.radioButtonMean.Text = "Average intensity";
            this.radioButtonMean.UseVisualStyleBackColor = true;
            // 
            // radioButtonMax
            // 
            this.radioButtonMax.AutoSize = true;
            this.radioButtonMax.Location = new System.Drawing.Point(131, 18);
            this.radioButtonMax.Name = "radioButtonMax";
            this.radioButtonMax.Size = new System.Drawing.Size(92, 16);
            this.radioButtonMax.TabIndex = 1;
            this.radioButtonMax.Text = "Max intensity";
            this.radioButtonMax.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.radioButtonTotal);
            this.groupBox1.Controls.Add(this.radioButtonMean);
            this.groupBox1.Controls.Add(this.radioButtonMax);
            this.groupBox1.Location = new System.Drawing.Point(12, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 52);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projection";
            // 
            // radioButtonTotal
            // 
            this.radioButtonTotal.AutoSize = true;
            this.radioButtonTotal.Location = new System.Drawing.Point(229, 18);
            this.radioButtonTotal.Name = "radioButtonTotal";
            this.radioButtonTotal.Size = new System.Drawing.Size(97, 16);
            this.radioButtonTotal.TabIndex = 2;
            this.radioButtonTotal.Text = "Total intensity";
            this.radioButtonTotal.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.radioButtonYZ);
            this.groupBox2.Controls.Add(this.radioButtonXY);
            this.groupBox2.Location = new System.Drawing.Point(350, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 52);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "XYZ";
            // 
            // radioButtonYZ
            // 
            this.radioButtonYZ.AutoSize = true;
            this.radioButtonYZ.Location = new System.Drawing.Point(55, 18);
            this.radioButtonYZ.Name = "radioButtonYZ";
            this.radioButtonYZ.Size = new System.Drawing.Size(43, 16);
            this.radioButtonYZ.TabIndex = 1;
            this.radioButtonYZ.Text = "Y-Z";
            this.radioButtonYZ.UseVisualStyleBackColor = true;
            // 
            // radioButtonXY
            // 
            this.radioButtonXY.AutoSize = true;
            this.radioButtonXY.Checked = true;
            this.radioButtonXY.Location = new System.Drawing.Point(6, 18);
            this.radioButtonXY.Name = "radioButtonXY";
            this.radioButtonXY.Size = new System.Drawing.Size(43, 16);
            this.radioButtonXY.TabIndex = 0;
            this.radioButtonXY.TabStop = true;
            this.radioButtonXY.Text = "X-Y";
            this.radioButtonXY.UseVisualStyleBackColor = true;
            // 
            // numColumn
            // 
            this.numColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numColumn.Location = new System.Drawing.Point(310, 161);
            this.numColumn.Name = "numColumn";
            this.numColumn.Size = new System.Drawing.Size(62, 19);
            this.numColumn.TabIndex = 18;
            this.numColumn.Tag = "";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "Column index";
            // 
            // pictureBoxBGColor
            // 
            this.pictureBoxBGColor.BackColor = System.Drawing.Color.White;
            this.pictureBoxBGColor.Location = new System.Drawing.Point(418, 258);
            this.pictureBoxBGColor.Name = "pictureBoxBGColor";
            this.pictureBoxBGColor.Size = new System.Drawing.Size(36, 19);
            this.pictureBoxBGColor.TabIndex = 19;
            this.pictureBoxBGColor.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 21;
            this.button1.Text = "Background color...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // colorMap1
            // 
            this.colorMap1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.colorMap1.AutoSize = true;
            this.colorMap1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorMap1.Location = new System.Drawing.Point(12, 211);
            this.colorMap1.Name = "colorMap1";
            this.colorMap1.Size = new System.Drawing.Size(226, 68);
            this.colorMap1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxBGColor);
            this.Controls.Add(this.numColumn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SaveRawData);
            this.Controls.Add(this.colorMap1);
            this.Controls.Add(this.FilePaths);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.SaveFolderPath);
            this.Controls.Add(this.SelectSaveFolder);
            this.Controls.Add(this.SelectCellsData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumZsize);
            this.Controls.Add(this.NumYsize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumXsize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StatusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 429);
            this.Name = "Form1";
            this.Text = "Projection image creator";
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumZsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumYsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumXsize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBGColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.ListBox FilePaths;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.TextBox SaveFolderPath;
        private System.Windows.Forms.Button SelectSaveFolder;
        private System.Windows.Forms.Button SelectCellsData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumZsize;
        private System.Windows.Forms.NumericUpDown NumYsize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumXsize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox SaveRawData;
        private BPSE.ColorMap colorMap1;
        private System.Windows.Forms.RadioButton radioButtonMean;
        private System.Windows.Forms.RadioButton radioButtonMax;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonYZ;
        private System.Windows.Forms.RadioButton radioButtonXY;
        private System.Windows.Forms.NumericUpDown numColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonTotal;
        private System.Windows.Forms.PictureBox pictureBoxBGColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
    }
}

