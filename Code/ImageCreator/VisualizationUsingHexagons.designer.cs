namespace BPSE
{
    partial class VisualizationUsingHexagons
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NumSpecZ = new System.Windows.Forms.NumericUpDown();
            this.checkBoxSpecZ = new System.Windows.Forms.CheckBox();
            this.numPenWidth = new System.Windows.Forms.NumericUpDown();
            this.checkBoxBoundaryColor = new System.Windows.Forms.CheckBox();
            this.buttonBoundaryColor = new System.Windows.Forms.Button();
            this.pictureBoxBoundaryColor = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackgroudColor = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBackgroundColor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NumMag = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NumDepth = new System.Windows.Forms.NumericUpDown();
            this.NumHeight = new System.Windows.Forms.NumericUpDown();
            this.labelPenWidth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumY = new System.Windows.Forms.NumericUpDown();
            this.NumX = new System.Windows.Forms.NumericUpDown();
            this.NumWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumSpecZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoundaryColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackgroudColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.NumSpecZ);
            this.groupBox1.Controls.Add(this.checkBoxSpecZ);
            this.groupBox1.Controls.Add(this.numPenWidth);
            this.groupBox1.Controls.Add(this.checkBoxBoundaryColor);
            this.groupBox1.Controls.Add(this.buttonBoundaryColor);
            this.groupBox1.Controls.Add(this.pictureBoxBoundaryColor);
            this.groupBox1.Controls.Add(this.pictureBoxBackgroudColor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonBackgroundColor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NumMag);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NumDepth);
            this.groupBox1.Controls.Add(this.NumHeight);
            this.groupBox1.Controls.Add(this.labelPenWidth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NumY);
            this.groupBox1.Controls.Add(this.NumX);
            this.groupBox1.Controls.Add(this.NumWidth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "y (-)";
            this.toolTip1.SetToolTip(this.label7, "The y-coordinate of the upper-left corner of the rectangle.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "x (-)";
            this.toolTip1.SetToolTip(this.label6, "The x-coordinate of the upper-left corner of the rectangle.");
            // 
            // NumSpecZ
            // 
            this.NumSpecZ.Enabled = false;
            this.NumSpecZ.Location = new System.Drawing.Point(166, 220);
            this.NumSpecZ.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumSpecZ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumSpecZ.Name = "NumSpecZ";
            this.NumSpecZ.Size = new System.Drawing.Size(60, 19);
            this.NumSpecZ.TabIndex = 17;
            this.NumSpecZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumSpecZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxSpecZ
            // 
            this.checkBoxSpecZ.AutoSize = true;
            this.checkBoxSpecZ.Location = new System.Drawing.Point(6, 221);
            this.checkBoxSpecZ.Name = "checkBoxSpecZ";
            this.checkBoxSpecZ.Size = new System.Drawing.Size(41, 16);
            this.checkBoxSpecZ.TabIndex = 16;
            this.checkBoxSpecZ.Text = "Z =";
            this.checkBoxSpecZ.UseVisualStyleBackColor = true;
            this.checkBoxSpecZ.CheckedChanged += new System.EventHandler(this.CheckBoxSpecZ_CheckedChanged);
            // 
            // numPenWidth
            // 
            this.numPenWidth.Location = new System.Drawing.Point(166, 70);
            this.numPenWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPenWidth.Name = "numPenWidth";
            this.numPenWidth.Size = new System.Drawing.Size(60, 19);
            this.numPenWidth.TabIndex = 5;
            this.numPenWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPenWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxBoundaryColor
            // 
            this.checkBoxBoundaryColor.AutoSize = true;
            this.checkBoxBoundaryColor.Checked = true;
            this.checkBoxBoundaryColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBoundaryColor.Location = new System.Drawing.Point(6, 47);
            this.checkBoxBoundaryColor.Name = "checkBoxBoundaryColor";
            this.checkBoxBoundaryColor.Size = new System.Drawing.Size(101, 16);
            this.checkBoxBoundaryColor.TabIndex = 2;
            this.checkBoxBoundaryColor.Text = "Boundary color";
            this.checkBoxBoundaryColor.UseVisualStyleBackColor = true;
            this.checkBoxBoundaryColor.CheckedChanged += new System.EventHandler(this.CheckBoxBoundaryColor_CheckedChanged);
            // 
            // buttonBoundaryColor
            // 
            this.buttonBoundaryColor.Location = new System.Drawing.Point(206, 44);
            this.buttonBoundaryColor.Name = "buttonBoundaryColor";
            this.buttonBoundaryColor.Size = new System.Drawing.Size(20, 20);
            this.buttonBoundaryColor.TabIndex = 3;
            this.buttonBoundaryColor.Text = "...";
            this.buttonBoundaryColor.UseVisualStyleBackColor = true;
            this.buttonBoundaryColor.Click += new System.EventHandler(this.ButtonBoundaryColor_Click);
            // 
            // pictureBoxBoundaryColor
            // 
            this.pictureBoxBoundaryColor.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBoundaryColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBoundaryColor.Location = new System.Drawing.Point(166, 44);
            this.pictureBoxBoundaryColor.Name = "pictureBoxBoundaryColor";
            this.pictureBoxBoundaryColor.Size = new System.Drawing.Size(34, 20);
            this.pictureBoxBoundaryColor.TabIndex = 11;
            this.pictureBoxBoundaryColor.TabStop = false;
            // 
            // pictureBoxBackgroudColor
            // 
            this.pictureBoxBackgroudColor.BackColor = System.Drawing.Color.White;
            this.pictureBoxBackgroudColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBackgroudColor.Location = new System.Drawing.Point(166, 18);
            this.pictureBoxBackgroudColor.Name = "pictureBoxBackgroudColor";
            this.pictureBoxBackgroudColor.Size = new System.Drawing.Size(34, 20);
            this.pictureBoxBackgroudColor.TabIndex = 9;
            this.pictureBoxBackgroudColor.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Background color";
            // 
            // buttonBackgroundColor
            // 
            this.buttonBackgroundColor.Location = new System.Drawing.Point(206, 18);
            this.buttonBackgroundColor.Name = "buttonBackgroundColor";
            this.buttonBackgroundColor.Size = new System.Drawing.Size(20, 20);
            this.buttonBackgroundColor.TabIndex = 1;
            this.buttonBackgroundColor.Text = "...";
            this.buttonBackgroundColor.UseVisualStyleBackColor = true;
            this.buttonBackgroundColor.Click += new System.EventHandler(this.ButtonBackgroundColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Radius of a circle inscribed\r\nin a regular hexagon (px)";
            // 
            // NumMag
            // 
            this.NumMag.Location = new System.Drawing.Point(166, 245);
            this.NumMag.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumMag.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumMag.Name = "NumMag";
            this.NumMag.Size = new System.Drawing.Size(60, 19);
            this.NumMag.TabIndex = 19;
            this.NumMag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumMag.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "height (-) / Ysize (unit cube)";
            this.toolTip1.SetToolTip(this.label2, "The width of the rectangle.");
            // 
            // NumDepth
            // 
            this.NumDepth.Location = new System.Drawing.Point(166, 195);
            this.NumDepth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumDepth.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumDepth.Name = "NumDepth";
            this.NumDepth.Size = new System.Drawing.Size(60, 19);
            this.NumDepth.TabIndex = 15;
            this.NumDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumDepth.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumDepth.ValueChanged += new System.EventHandler(this.NumZsize_ValueChanged);
            // 
            // NumHeight
            // 
            this.NumHeight.Location = new System.Drawing.Point(166, 170);
            this.NumHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumHeight.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumHeight.Name = "NumHeight";
            this.NumHeight.Size = new System.Drawing.Size(60, 19);
            this.NumHeight.TabIndex = 13;
            this.NumHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumHeight.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // labelPenWidth
            // 
            this.labelPenWidth.AutoSize = true;
            this.labelPenWidth.Location = new System.Drawing.Point(6, 72);
            this.labelPenWidth.Name = "labelPenWidth";
            this.labelPenWidth.Size = new System.Drawing.Size(55, 12);
            this.labelPenWidth.TabIndex = 4;
            this.labelPenWidth.Text = "Pen width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "width (-) / Xsize (unit cube)";
            this.toolTip1.SetToolTip(this.label1, "The width of the rectangle.");
            // 
            // NumY
            // 
            this.NumY.DecimalPlaces = 1;
            this.NumY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.NumY.Location = new System.Drawing.Point(166, 120);
            this.NumY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumY.Name = "NumY";
            this.NumY.Size = new System.Drawing.Size(60, 19);
            this.NumY.TabIndex = 9;
            this.NumY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumX
            // 
            this.NumX.DecimalPlaces = 1;
            this.NumX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.NumX.Location = new System.Drawing.Point(166, 95);
            this.NumX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumX.Name = "NumX";
            this.NumX.Size = new System.Drawing.Size(60, 19);
            this.NumX.TabIndex = 7;
            this.NumX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumWidth
            // 
            this.NumWidth.Location = new System.Drawing.Point(166, 145);
            this.NumWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumWidth.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumWidth.Name = "NumWidth";
            this.NumWidth.Size = new System.Drawing.Size(60, 19);
            this.NumWidth.TabIndex = 11;
            this.NumWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumWidth.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "Zsize (unit cube)";
            // 
            // VisualizationUsingHexagons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox1);
            this.Name = "VisualizationUsingHexagons";
            this.Size = new System.Drawing.Size(232, 274);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumSpecZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoundaryColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackgroudColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumMag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumDepth;
        private System.Windows.Forms.NumericUpDown NumHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxBackgroudColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonBackgroundColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonBoundaryColor;
        private System.Windows.Forms.PictureBox pictureBoxBoundaryColor;
        private System.Windows.Forms.CheckBox checkBoxBoundaryColor;
        private System.Windows.Forms.NumericUpDown numPenWidth;
        private System.Windows.Forms.Label labelPenWidth;
        private System.Windows.Forms.NumericUpDown NumSpecZ;
        private System.Windows.Forms.CheckBox checkBoxSpecZ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NumY;
        private System.Windows.Forms.NumericUpDown NumX;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
