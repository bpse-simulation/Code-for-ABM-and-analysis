namespace CellBehaviorSimulator.CultureEnvironments
{
    partial class CultureSpace
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
            this.groupBox_Map = new System.Windows.Forms.GroupBox();
            this.num_lc = new System.Windows.Forms.NumericUpDown();
            this.num_hc = new System.Windows.Forms.NumericUpDown();
            this.label_lc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_hc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.comboBoxMap = new System.Windows.Forms.ComboBox();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.numZ = new System.Windows.Forms.NumericUpDown();
            this.groupBox_Map.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_lc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_hc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZ)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Map
            // 
            this.groupBox_Map.AutoSize = true;
            this.groupBox_Map.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_Map.Controls.Add(this.num_lc);
            this.groupBox_Map.Controls.Add(this.num_hc);
            this.groupBox_Map.Controls.Add(this.label_lc);
            this.groupBox_Map.Controls.Add(this.label4);
            this.groupBox_Map.Controls.Add(this.label_hc);
            this.groupBox_Map.Controls.Add(this.label3);
            this.groupBox_Map.Controls.Add(this.label2);
            this.groupBox_Map.Controls.Add(this.label1);
            this.groupBox_Map.Controls.Add(this.numX);
            this.groupBox_Map.Controls.Add(this.comboBoxMap);
            this.groupBox_Map.Controls.Add(this.numY);
            this.groupBox_Map.Controls.Add(this.numZ);
            this.groupBox_Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Map.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Map.Name = "groupBox_Map";
            this.groupBox_Map.Size = new System.Drawing.Size(196, 181);
            this.groupBox_Map.TabIndex = 1;
            this.groupBox_Map.TabStop = false;
            this.groupBox_Map.Text = "Map setting";
            // 
            // num_lc
            // 
            this.num_lc.DecimalPlaces = 1;
            this.num_lc.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_lc.Location = new System.Drawing.Point(130, 18);
            this.num_lc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_lc.Name = "num_lc";
            this.num_lc.Size = new System.Drawing.Size(60, 19);
            this.num_lc.TabIndex = 1;
            this.num_lc.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_lc.ValueChanged += new System.EventHandler(this.Num_lc_ValueChanged);
            // 
            // num_hc
            // 
            this.num_hc.DecimalPlaces = 1;
            this.num_hc.Enabled = false;
            this.num_hc.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_hc.Location = new System.Drawing.Point(130, 43);
            this.num_hc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_hc.Name = "num_hc";
            this.num_hc.Size = new System.Drawing.Size(60, 19);
            this.num_hc.TabIndex = 3;
            this.num_hc.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_hc.ValueChanged += new System.EventHandler(this.Num_hc_ValueChanged);
            // 
            // label_lc
            // 
            this.label_lc.AutoSize = true;
            this.label_lc.Location = new System.Drawing.Point(6, 20);
            this.label_lc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_lc.Name = "label_lc";
            this.label_lc.Size = new System.Drawing.Size(45, 12);
            this.label_lc.TabIndex = 0;
            this.label_lc.Text = "l_c (um)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Z size (unit cube)";
            // 
            // label_hc
            // 
            this.label_hc.AutoSize = true;
            this.label_hc.Enabled = false;
            this.label_hc.Location = new System.Drawing.Point(6, 45);
            this.label_hc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_hc.Name = "label_hc";
            this.label_hc.Size = new System.Drawing.Size(48, 12);
            this.label_hc.TabIndex = 2;
            this.label_hc.Text = "h_c (um)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y size (unit cube)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "X size (unit cube)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Container shape";
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(110, 94);
            this.numX.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numX.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(80, 19);
            this.numX.TabIndex = 3;
            this.numX.Tag = "";
            this.numX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numX.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numX.ValueChanged += new System.EventHandler(this.NumX_ValueChanged);
            // 
            // comboBoxMap
            // 
            this.comboBoxMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMap.FormattingEnabled = true;
            this.comboBoxMap.Items.AddRange(new object[] {
            "Square",
            "Circle",
            "35mm dish",
            "100mm dish"});
            this.comboBoxMap.Location = new System.Drawing.Point(100, 68);
            this.comboBoxMap.Name = "comboBoxMap";
            this.comboBoxMap.Size = new System.Drawing.Size(90, 20);
            this.comboBoxMap.TabIndex = 1;
            this.comboBoxMap.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMap_SelectedIndexChanged);
            // 
            // numY
            // 
            this.numY.Location = new System.Drawing.Point(110, 119);
            this.numY.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numY.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(80, 19);
            this.numY.TabIndex = 5;
            this.numY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numY.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numY.ValueChanged += new System.EventHandler(this.NumY_ValueChanged);
            // 
            // numZ
            // 
            this.numZ.Location = new System.Drawing.Point(110, 144);
            this.numZ.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numZ.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numZ.Name = "numZ";
            this.numZ.Size = new System.Drawing.Size(80, 19);
            this.numZ.TabIndex = 7;
            this.numZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numZ.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numZ.ValueChanged += new System.EventHandler(this.NumZ_ValueChanged);
            // 
            // CultureSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox_Map);
            this.Name = "CultureSpace";
            this.Size = new System.Drawing.Size(196, 181);
            this.Load += new System.EventHandler(this.CultureSpace_Load);
            this.groupBox_Map.ResumeLayout(false);
            this.groupBox_Map.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_lc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_hc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Map;
        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.ComboBox comboBoxMap;
        private System.Windows.Forms.NumericUpDown numY;
        private System.Windows.Forms.NumericUpDown numZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_lc;
        private System.Windows.Forms.NumericUpDown num_hc;
        private System.Windows.Forms.Label label_lc;
        private System.Windows.Forms.Label label_hc;
    }
}
