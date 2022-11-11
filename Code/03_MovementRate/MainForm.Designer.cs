namespace MovementRate
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.checkPeriodic = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumYsize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.NumXsize = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Num_hc = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Num_lc = new System.Windows.Forms.NumericUpDown();
            this.num_interval_t = new System.Windows.Forms.NumericUpDown();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.textDirCellsData = new System.Windows.Forms.TextBox();
            this.buttonDirLoad = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.Num_delta_t = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textPattern = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioAllCell = new System.Windows.Forms.RadioButton();
            this.radioFirstLayer = new System.Windows.Forms.RadioButton();
            this.groupTarget = new System.Windows.Forms.GroupBox();
            this.radioSuprabasalLayer = new System.Windows.Forms.RadioButton();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SaveFolderPath = new System.Windows.Forms.TextBox();
            this.SelectSaveFolder = new System.Windows.Forms.Button();
            this.checkParallel = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxSingleCell = new System.Windows.Forms.CheckBox();
            this.checkBoxSaveList = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumYsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumXsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_hc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_lc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_interval_t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_delta_t)).BeginInit();
            this.groupTarget.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkPeriodic
            // 
            this.checkPeriodic.AutoSize = true;
            this.checkPeriodic.Checked = true;
            this.checkPeriodic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPeriodic.Location = new System.Drawing.Point(14, 161);
            this.checkPeriodic.Name = "checkPeriodic";
            this.checkPeriodic.Size = new System.Drawing.Size(165, 16);
            this.checkPeriodic.TabIndex = 9;
            this.checkPeriodic.Text = "Periodic boundary condition";
            this.checkPeriodic.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ysize";
            // 
            // NumYsize
            // 
            this.NumYsize.Location = new System.Drawing.Point(154, 183);
            this.NumYsize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumYsize.Name = "NumYsize";
            this.NumYsize.Size = new System.Drawing.Size(60, 19);
            this.NumYsize.TabIndex = 11;
            this.NumYsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumYsize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumYsize.ValueChanged += new System.EventHandler(this.NumYsize_ValueChanged);
            this.NumYsize.Enter += new System.EventHandler(this.NumYsize_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "Xsize";
            // 
            // NumXsize
            // 
            this.NumXsize.Location = new System.Drawing.Point(50, 183);
            this.NumXsize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumXsize.Name = "NumXsize";
            this.NumXsize.Size = new System.Drawing.Size(60, 19);
            this.NumXsize.TabIndex = 10;
            this.NumXsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumXsize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumXsize.ValueChanged += new System.EventHandler(this.NumXsize_ValueChanged);
            this.NumXsize.Enter += new System.EventHandler(this.NumXsize_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "h_c (um)";
            // 
            // Num_hc
            // 
            this.Num_hc.DecimalPlaces = 1;
            this.Num_hc.Location = new System.Drawing.Point(357, 136);
            this.Num_hc.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Num_hc.Name = "Num_hc";
            this.Num_hc.Size = new System.Drawing.Size(60, 19);
            this.Num_hc.TabIndex = 8;
            this.Num_hc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Num_hc.ValueChanged += new System.EventHandler(this.Num_hc_ValueChanged);
            this.Num_hc.Enter += new System.EventHandler(this.Num_hc_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "l_c (um)";
            // 
            // Num_lc
            // 
            this.Num_lc.DecimalPlaces = 1;
            this.Num_lc.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Num_lc.Location = new System.Drawing.Point(222, 136);
            this.Num_lc.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Num_lc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Num_lc.Name = "Num_lc";
            this.Num_lc.Size = new System.Drawing.Size(60, 19);
            this.Num_lc.TabIndex = 7;
            this.Num_lc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Num_lc.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Num_lc.ValueChanged += new System.EventHandler(this.Num_lc_ValueChanged);
            this.Num_lc.Enter += new System.EventHandler(this.Num_lc_Enter);
            // 
            // num_interval_t
            // 
            this.num_interval_t.DecimalPlaces = 2;
            this.num_interval_t.Location = new System.Drawing.Point(108, 111);
            this.num_interval_t.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_interval_t.Name = "num_interval_t";
            this.num_interval_t.Size = new System.Drawing.Size(60, 19);
            this.num_interval_t.TabIndex = 5;
            this.num_interval_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_interval_t.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.num_interval_t.ValueChanged += new System.EventHandler(this.Num_interval_t_ValueChanged);
            this.num_interval_t.Enter += new System.EventHandler(this.Num_interval_t_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Time interval (h)";
            // 
            // textDirCellsData
            // 
            this.textDirCellsData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDirCellsData.Location = new System.Drawing.Point(82, 61);
            this.textDirCellsData.Name = "textDirCellsData";
            this.textDirCellsData.Size = new System.Drawing.Size(310, 19);
            this.textDirCellsData.TabIndex = 1;
            this.textDirCellsData.TextChanged += new System.EventHandler(this.TextDirCellsData_TextChanged);
            // 
            // buttonDirLoad
            // 
            this.buttonDirLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDirLoad.Location = new System.Drawing.Point(398, 61);
            this.buttonDirLoad.Name = "buttonDirLoad";
            this.buttonDirLoad.Size = new System.Drawing.Size(19, 19);
            this.buttonDirLoad.TabIndex = 2;
            this.buttonDirLoad.Text = "...";
            this.buttonDirLoad.UseVisualStyleBackColor = true;
            this.buttonDirLoad.Click += new System.EventHandler(this.ButtonDirLoad_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonStart.Location = new System.Drawing.Point(306, 239);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(111, 50);
            this.buttonStart.TabIndex = 14;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // Num_delta_t
            // 
            this.Num_delta_t.DecimalPlaces = 2;
            this.Num_delta_t.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Num_delta_t.Location = new System.Drawing.Point(91, 136);
            this.Num_delta_t.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Num_delta_t.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Num_delta_t.Name = "Num_delta_t";
            this.Num_delta_t.Size = new System.Drawing.Size(60, 19);
            this.Num_delta_t.TabIndex = 6;
            this.Num_delta_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Num_delta_t.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Num_delta_t.ValueChanged += new System.EventHandler(this.Num_delta_t_ValueChanged);
            this.Num_delta_t.Enter += new System.EventHandler(this.Num_delta_t_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "t_step Δt (h)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "Open folder";
            // 
            // textPattern
            // 
            this.textPattern.Location = new System.Drawing.Point(113, 36);
            this.textPattern.Name = "textPattern";
            this.textPattern.Size = new System.Drawing.Size(130, 19);
            this.textPattern.TabIndex = 0;
            this.textPattern.Text = "cell_step_*.csv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "File name pattern";
            // 
            // radioAllCell
            // 
            this.radioAllCell.AutoSize = true;
            this.radioAllCell.Checked = true;
            this.radioAllCell.Location = new System.Drawing.Point(6, 18);
            this.radioAllCell.Name = "radioAllCell";
            this.radioAllCell.Size = new System.Drawing.Size(77, 16);
            this.radioAllCell.TabIndex = 0;
            this.radioAllCell.TabStop = true;
            this.radioAllCell.Text = "Total cells";
            this.radioAllCell.UseVisualStyleBackColor = true;
            // 
            // radioFirstLayer
            // 
            this.radioFirstLayer.AutoSize = true;
            this.radioFirstLayer.Location = new System.Drawing.Point(89, 18);
            this.radioFirstLayer.Name = "radioFirstLayer";
            this.radioFirstLayer.Size = new System.Drawing.Size(80, 16);
            this.radioFirstLayer.TabIndex = 1;
            this.radioFirstLayer.Text = "Basal cells";
            this.radioFirstLayer.UseVisualStyleBackColor = true;
            // 
            // groupTarget
            // 
            this.groupTarget.AutoSize = true;
            this.groupTarget.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupTarget.Controls.Add(this.radioSuprabasalLayer);
            this.groupTarget.Controls.Add(this.radioAllCell);
            this.groupTarget.Controls.Add(this.radioFirstLayer);
            this.groupTarget.Location = new System.Drawing.Point(12, 208);
            this.groupTarget.Name = "groupTarget";
            this.groupTarget.Size = new System.Drawing.Size(288, 52);
            this.groupTarget.TabIndex = 12;
            this.groupTarget.TabStop = false;
            this.groupTarget.Text = "Target";
            // 
            // radioSuprabasalLayer
            // 
            this.radioSuprabasalLayer.AutoSize = true;
            this.radioSuprabasalLayer.Location = new System.Drawing.Point(175, 18);
            this.radioSuprabasalLayer.Name = "radioSuprabasalLayer";
            this.radioSuprabasalLayer.Size = new System.Drawing.Size(107, 16);
            this.radioSuprabasalLayer.TabIndex = 2;
            this.radioSuprabasalLayer.Text = "Suprabasal cells";
            this.radioSuprabasalLayer.UseVisualStyleBackColor = true;
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar1,
            this.StatusLabel1});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 292);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(429, 22);
            this.StatusStrip1.TabIndex = 22;
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
            // SaveFolderPath
            // 
            this.SaveFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveFolderPath.Location = new System.Drawing.Point(82, 86);
            this.SaveFolderPath.Name = "SaveFolderPath";
            this.SaveFolderPath.Size = new System.Drawing.Size(310, 19);
            this.SaveFolderPath.TabIndex = 3;
            this.SaveFolderPath.TextChanged += new System.EventHandler(this.SaveFolderPath_TextChanged);
            this.SaveFolderPath.Leave += new System.EventHandler(this.SaveFolderPath_Leave);
            // 
            // SelectSaveFolder
            // 
            this.SelectSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectSaveFolder.Location = new System.Drawing.Point(398, 86);
            this.SelectSaveFolder.Name = "SelectSaveFolder";
            this.SelectSaveFolder.Size = new System.Drawing.Size(19, 19);
            this.SelectSaveFolder.TabIndex = 4;
            this.SelectSaveFolder.Text = "...";
            this.SelectSaveFolder.UseVisualStyleBackColor = true;
            this.SelectSaveFolder.Click += new System.EventHandler(this.SelectSaveFolder_Click);
            // 
            // checkParallel
            // 
            this.checkParallel.AutoSize = true;
            this.checkParallel.Location = new System.Drawing.Point(306, 217);
            this.checkParallel.Name = "checkParallel";
            this.checkParallel.Size = new System.Drawing.Size(62, 16);
            this.checkParallel.TabIndex = 13;
            this.checkParallel.Text = "Parallel";
            this.checkParallel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxSingleCell);
            this.panel1.Controls.Add(this.checkBoxSaveList);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SaveFolderPath);
            this.panel1.Controls.Add(this.checkParallel);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.buttonDirLoad);
            this.panel1.Controls.Add(this.textDirCellsData);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.SelectSaveFolder);
            this.panel1.Controls.Add(this.num_interval_t);
            this.panel1.Controls.Add(this.Num_lc);
            this.panel1.Controls.Add(this.groupTarget);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textPattern);
            this.panel1.Controls.Add(this.Num_hc);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Num_delta_t);
            this.panel1.Controls.Add(this.NumXsize);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkPeriodic);
            this.panel1.Controls.Add(this.NumYsize);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 292);
            this.panel1.TabIndex = 25;
            // 
            // checkBoxSingleCell
            // 
            this.checkBoxSingleCell.AutoSize = true;
            this.checkBoxSingleCell.Location = new System.Drawing.Point(92, 266);
            this.checkBoxSingleCell.Name = "checkBoxSingleCell";
            this.checkBoxSingleCell.Size = new System.Drawing.Size(126, 16);
            this.checkBoxSingleCell.TabIndex = 26;
            this.checkBoxSingleCell.Text = "Exclude single cells";
            this.checkBoxSingleCell.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaveList
            // 
            this.checkBoxSaveList.AutoSize = true;
            this.checkBoxSaveList.Location = new System.Drawing.Point(14, 266);
            this.checkBoxSaveList.Name = "checkBoxSaveList";
            this.checkBoxSaveList.Size = new System.Drawing.Size(72, 16);
            this.checkBoxSaveList.TabIndex = 27;
            this.checkBoxSaveList.Text = "Save List";
            this.checkBoxSaveList.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(355, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = "The movement rate is calculated from the route distance.\r\nNot the distance betwee" +
    "n the start and end points!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "Note: Size including wall unit prism";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "Save folder";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 314);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StatusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(445, 324);
            this.Name = "MainForm";
            this.Text = "Movement rate calculator";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumYsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumXsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_hc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_lc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_interval_t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_delta_t)).EndInit();
            this.groupTarget.ResumeLayout(false);
            this.groupTarget.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkPeriodic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumYsize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumXsize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Num_hc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Num_lc;
        private System.Windows.Forms.NumericUpDown num_interval_t;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textDirCellsData;
        private System.Windows.Forms.Button buttonDirLoad;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown Num_delta_t;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textPattern;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioAllCell;
        private System.Windows.Forms.RadioButton radioFirstLayer;
        private System.Windows.Forms.GroupBox groupTarget;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.TextBox SaveFolderPath;
        private System.Windows.Forms.Button SelectSaveFolder;
        private System.Windows.Forms.CheckBox checkParallel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioSuprabasalLayer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxSaveList;
        private System.Windows.Forms.CheckBox checkBoxSingleCell;
    }
}

