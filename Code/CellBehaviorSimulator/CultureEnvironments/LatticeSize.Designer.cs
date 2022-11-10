namespace CellBehaviorSimulator.CultureEnvironments
{
    partial class LatticeSize
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num_lc = new System.Windows.Forms.NumericUpDown();
            this.num_hc = new System.Windows.Forms.NumericUpDown();
            this.label_lc = new System.Windows.Forms.Label();
            this.label_hc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_lc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_hc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.num_lc);
            this.groupBox1.Controls.Add(this.num_hc);
            this.groupBox1.Controls.Add(this.label_lc);
            this.groupBox1.Controls.Add(this.label_hc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lattice size";
            // 
            // num_lc
            // 
            this.num_lc.DecimalPlaces = 1;
            this.num_lc.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_lc.Location = new System.Drawing.Point(58, 18);
            this.num_lc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_lc.Name = "num_lc";
            this.num_lc.Size = new System.Drawing.Size(60, 19);
            this.num_lc.TabIndex = 5;
            this.num_lc.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
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
            this.num_hc.Location = new System.Drawing.Point(58, 43);
            this.num_hc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_hc.Name = "num_hc";
            this.num_hc.Size = new System.Drawing.Size(60, 19);
            this.num_hc.TabIndex = 7;
            this.num_hc.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label_lc
            // 
            this.label_lc.AutoSize = true;
            this.label_lc.Location = new System.Drawing.Point(5, 20);
            this.label_lc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_lc.Name = "label_lc";
            this.label_lc.Size = new System.Drawing.Size(45, 12);
            this.label_lc.TabIndex = 4;
            this.label_lc.Text = "l_c (um)";
            // 
            // label_hc
            // 
            this.label_hc.AutoSize = true;
            this.label_hc.Enabled = false;
            this.label_hc.Location = new System.Drawing.Point(5, 45);
            this.label_hc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_hc.Name = "label_hc";
            this.label_hc.Size = new System.Drawing.Size(48, 12);
            this.label_hc.TabIndex = 6;
            this.label_hc.Text = "h_c (um)";
            // 
            // LatticeSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox1);
            this.Name = "LatticeSize";
            this.Size = new System.Drawing.Size(124, 80);
            this.Load += new System.EventHandler(this.LatticeSize_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_lc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_hc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown num_lc;
        private System.Windows.Forms.NumericUpDown num_hc;
        private System.Windows.Forms.Label label_lc;
        private System.Windows.Forms.Label label_hc;
    }
}
