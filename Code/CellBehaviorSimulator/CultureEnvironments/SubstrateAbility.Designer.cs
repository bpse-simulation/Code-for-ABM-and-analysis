namespace CellBehaviorSimulator.CultureEnvironments
{
    partial class SubstrateAbility
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
            this.checkModuleAvailable = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num_k_s = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.num_e_s_min = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_k_s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_e_s_min)).BeginInit();
            this.SuspendLayout();
            // 
            // checkModuleAvailable
            // 
            this.checkModuleAvailable.AutoSize = true;
            this.checkModuleAvailable.Location = new System.Drawing.Point(6, 0);
            this.checkModuleAvailable.Name = "checkModuleAvailable";
            this.checkModuleAvailable.Size = new System.Drawing.Size(108, 16);
            this.checkModuleAvailable.TabIndex = 2;
            this.checkModuleAvailable.Text = "Substrate ability";
            this.checkModuleAvailable.UseVisualStyleBackColor = true;
            this.checkModuleAvailable.CheckedChanged += new System.EventHandler(this.CheckModuleAvailable_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.num_k_s);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.num_e_s_min);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // num_k_s
            // 
            this.num_k_s.DecimalPlaces = 3;
            this.num_k_s.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.num_k_s.Location = new System.Drawing.Point(69, 43);
            this.num_k_s.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_k_s.Name = "num_k_s";
            this.num_k_s.Size = new System.Drawing.Size(60, 19);
            this.num_k_s.TabIndex = 3;
            this.num_k_s.ValueChanged += new System.EventHandler(this.Num_k_s_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "e_s,min (-)";
            // 
            // num_e_s_min
            // 
            this.num_e_s_min.DecimalPlaces = 6;
            this.num_e_s_min.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.num_e_s_min.Location = new System.Drawing.Point(69, 18);
            this.num_e_s_min.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_e_s_min.Name = "num_e_s_min";
            this.num_e_s_min.Size = new System.Drawing.Size(80, 19);
            this.num_e_s_min.TabIndex = 1;
            this.num_e_s_min.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_e_s_min.ValueChanged += new System.EventHandler(this.Num_e_s_min_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "k_s (h^-1)";
            // 
            // SubstrateAbility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.checkModuleAvailable);
            this.Controls.Add(this.groupBox1);
            this.Name = "SubstrateAbility";
            this.Size = new System.Drawing.Size(155, 80);
            this.Load += new System.EventHandler(this.SubstrateAbility_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_k_s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_e_s_min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkModuleAvailable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown num_k_s;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_e_s_min;
        private System.Windows.Forms.Label label2;
    }
}
