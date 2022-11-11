namespace CellBehaviorSimulator
{
    partial class ParameterFileCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParameterFileCreator));
            this.numT = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.buttonCreateFiles = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numTrial = new System.Windows.Forms.NumericUpDown();
            this.buttonOutDir = new System.Windows.Forms.Button();
            this.textBoxOutDir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textValMax = new System.Windows.Forms.TextBox();
            this.textValMin = new System.Windows.Forms.TextBox();
            this.textIncrement = new System.Windows.Forms.TextBox();
            this.numCell_T = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.comboBoxParam = new System.Windows.Forms.ComboBox();
            this.checkBoxAllCellTypes = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.parameters1 = new CellBehaviorSimulator.ParameterIO.Parameters();
            ((System.ComponentModel.ISupportInitialize)(this.numT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrial)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCell_T)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numT
            // 
            this.numT.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numT.Location = new System.Drawing.Point(206, 212);
            this.numT.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numT.Name = "numT";
            this.numT.Size = new System.Drawing.Size(40, 19);
            this.numT.TabIndex = 4;
            this.numT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numT.ValueChanged += new System.EventHandler(this.NumT_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Target parameter number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of parameters to change";
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(206, 187);
            this.numMax.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(40, 19);
            this.numMax.TabIndex = 3;
            this.numMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMax.ValueChanged += new System.EventHandler(this.NumMax_ValueChanged);
            // 
            // buttonCreateFiles
            // 
            this.buttonCreateFiles.Location = new System.Drawing.Point(12, 27);
            this.buttonCreateFiles.Name = "buttonCreateFiles";
            this.buttonCreateFiles.Size = new System.Drawing.Size(234, 60);
            this.buttonCreateFiles.TabIndex = 6;
            this.buttonCreateFiles.Text = "Create files";
            this.buttonCreateFiles.UseVisualStyleBackColor = true;
            this.buttonCreateFiles.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "Number of trials n";
            // 
            // numTrial
            // 
            this.numTrial.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numTrial.Location = new System.Drawing.Point(206, 162);
            this.numTrial.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrial.Name = "numTrial";
            this.numTrial.Size = new System.Drawing.Size(40, 19);
            this.numTrial.TabIndex = 2;
            this.numTrial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTrial.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrial.ValueChanged += new System.EventHandler(this.NumT_ValueChanged);
            // 
            // buttonOutDir
            // 
            this.buttonOutDir.Location = new System.Drawing.Point(12, 135);
            this.buttonOutDir.Name = "buttonOutDir";
            this.buttonOutDir.Size = new System.Drawing.Size(23, 23);
            this.buttonOutDir.TabIndex = 1;
            this.buttonOutDir.Text = "...";
            this.buttonOutDir.UseVisualStyleBackColor = true;
            this.buttonOutDir.Click += new System.EventHandler(this.ButtonOutDir_Click);
            // 
            // textBoxOutDir
            // 
            this.textBoxOutDir.Location = new System.Drawing.Point(41, 137);
            this.textBoxOutDir.Name = "textBoxOutDir";
            this.textBoxOutDir.Size = new System.Drawing.Size(205, 19);
            this.textBoxOutDir.TabIndex = 0;
            this.textBoxOutDir.TextChanged += new System.EventHandler(this.TextBoxOutDir_TextChanged);
            this.textBoxOutDir.Leave += new System.EventHandler(this.TextBoxOutDir_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "Output directory for initial parameter files";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.createToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fileToolStripMenuItem.Text = "File(&F)";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.openToolStripMenuItem.Text = "Open(&O)...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.createToolStripMenuItem.Text = "Create(&A)";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.closeToolStripMenuItem.Text = "Close(&C)";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "initialize";
            this.openFileDialog1.Filter = "CSV|*.csv";
            this.openFileDialog1.Title = "Load input parameter file";
            // 
            // textValMax
            // 
            this.textValMax.Location = new System.Drawing.Point(84, 119);
            this.textValMax.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.textValMax.Name = "textValMax";
            this.textValMax.Size = new System.Drawing.Size(60, 19);
            this.textValMax.TabIndex = 4;
            this.textValMax.Text = "0";
            this.textValMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textValMax.TextChanged += new System.EventHandler(this.TextValMax_TextChanged);
            // 
            // textValMin
            // 
            this.textValMin.Location = new System.Drawing.Point(84, 94);
            this.textValMin.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.textValMin.Name = "textValMin";
            this.textValMin.Size = new System.Drawing.Size(60, 19);
            this.textValMin.TabIndex = 3;
            this.textValMin.Text = "0";
            this.textValMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textValMin.TextChanged += new System.EventHandler(this.TextValMin_TextChanged);
            // 
            // textIncrement
            // 
            this.textIncrement.Location = new System.Drawing.Point(84, 69);
            this.textIncrement.Name = "textIncrement";
            this.textIncrement.Size = new System.Drawing.Size(60, 19);
            this.textIncrement.TabIndex = 2;
            this.textIncrement.Text = "0";
            this.textIncrement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textIncrement.TextChanged += new System.EventHandler(this.TextIncrement_TextChanged);
            // 
            // numCell_T
            // 
            this.numCell_T.Location = new System.Drawing.Point(104, 44);
            this.numCell_T.Name = "numCell_T";
            this.numCell_T.Size = new System.Drawing.Size(40, 19);
            this.numCell_T.TabIndex = 1;
            this.numCell_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCell_T.ValueChanged += new System.EventHandler(this.NumCell_T_ValueChanged);
            this.numCell_T.Enter += new System.EventHandler(this.NumCell_T_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "Increment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Value Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Value Min";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(147, 15);
            this.vScrollBar1.Maximum = 0;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 138);
            this.vScrollBar1.TabIndex = 5;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar1_Scroll);
            // 
            // comboBoxParam
            // 
            this.comboBoxParam.FormattingEnabled = true;
            this.comboBoxParam.Location = new System.Drawing.Point(6, 18);
            this.comboBoxParam.Name = "comboBoxParam";
            this.comboBoxParam.Size = new System.Drawing.Size(138, 20);
            this.comboBoxParam.TabIndex = 0;
            this.comboBoxParam.SelectedIndexChanged += new System.EventHandler(this.ComboBoxParam_SelectedIndexChanged);
            // 
            // checkBoxAllCellTypes
            // 
            this.checkBoxAllCellTypes.AutoSize = true;
            this.checkBoxAllCellTypes.Location = new System.Drawing.Point(6, 45);
            this.checkBoxAllCellTypes.Name = "checkBoxAllCellTypes";
            this.checkBoxAllCellTypes.Size = new System.Drawing.Size(92, 16);
            this.checkBoxAllCellTypes.TabIndex = 2;
            this.checkBoxAllCellTypes.Text = "All cell types";
            this.checkBoxAllCellTypes.UseVisualStyleBackColor = true;
            this.checkBoxAllCellTypes.CheckedChanged += new System.EventHandler(this.CheckBoxAllCellTypes_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.checkBoxAllCellTypes);
            this.groupBox1.Controls.Add(this.comboBoxParam);
            this.groupBox1.Controls.Add(this.vScrollBar1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numCell_T);
            this.groupBox1.Controls.Add(this.textIncrement);
            this.groupBox1.Controls.Add(this.textValMin);
            this.groupBox1.Controls.Add(this.textValMax);
            this.groupBox1.Location = new System.Drawing.Point(79, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 156);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameter";
            // 
            // parameters1
            // 
            this.parameters1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parameters1.Location = new System.Drawing.Point(252, 27);
            this.parameters1.Name = "parameters1";
            this.parameters1.Size = new System.Drawing.Size(480, 500);
            this.parameters1.TabControl_SelectedIndex = 0;
            this.parameters1.TabIndex = 20;
            // 
            // ParameterFileCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 539);
            this.Controls.Add(this.parameters1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonOutDir);
            this.Controls.Add(this.textBoxOutDir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonCreateFiles);
            this.Controls.Add(this.numTrial);
            this.Controls.Add(this.numT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numMax);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(760, 578);
            this.Name = "ParameterFileCreator";
            this.Text = "Parameter file creator";
            this.Load += new System.EventHandler(this.ParameterFileCreator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrial)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCell_T)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.Button buttonCreateFiles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numTrial;
        private System.Windows.Forms.Button buttonOutDir;
        private System.Windows.Forms.TextBox textBoxOutDir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox textValMax;
        private System.Windows.Forms.TextBox textValMin;
        private System.Windows.Forms.TextBox textIncrement;
        private System.Windows.Forms.NumericUpDown numCell_T;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ComboBox comboBoxParam;
        private System.Windows.Forms.CheckBox checkBoxAllCellTypes;
        private System.Windows.Forms.GroupBox groupBox1;
        private ParameterIO.Parameters parameters1;
    }
}