namespace CellBehaviorSimulator.CellBehaviors
{
    partial class AreaWeighting
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
            this.label1 = new System.Windows.Forms.Label();
            this.numA_r = new System.Windows.Forms.NumericUpDown();
            this.checkModuleAvailable = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numA_r)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numA_r);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 55);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "A_r (um^2)";
            this.toolTip1.SetToolTip(this.label1, "Average area ratio of single cells");
            // 
            // numA_r
            // 
            this.numA_r.DecimalPlaces = 1;
            this.numA_r.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numA_r.Location = new System.Drawing.Point(71, 18);
            this.numA_r.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numA_r.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numA_r.Name = "numA_r";
            this.numA_r.Size = new System.Drawing.Size(60, 19);
            this.numA_r.TabIndex = 1;
            this.toolTip1.SetToolTip(this.numA_r, "Average area of single cells");
            this.numA_r.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numA_r.ValueChanged += new System.EventHandler(this.NumA_c_ValueChanged);
            // 
            // checkModuleAvailable
            // 
            this.checkModuleAvailable.AutoSize = true;
            this.checkModuleAvailable.Location = new System.Drawing.Point(6, 0);
            this.checkModuleAvailable.Name = "checkModuleAvailable";
            this.checkModuleAvailable.Size = new System.Drawing.Size(100, 16);
            this.checkModuleAvailable.TabIndex = 4;
            this.checkModuleAvailable.Text = "Area weighting";
            this.toolTip1.SetToolTip(this.checkModuleAvailable, "Weighting of area by cell type difference");
            this.checkModuleAvailable.UseVisualStyleBackColor = true;
            this.checkModuleAvailable.CheckedChanged += new System.EventHandler(this.CheckModuleAvailable_CheckedChanged);
            // 
            // AreaWeighting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.checkModuleAvailable);
            this.Controls.Add(this.groupBox1);
            this.Name = "AreaWeighting";
            this.Size = new System.Drawing.Size(137, 55);
            this.Load += new System.EventHandler(this.AreaWeighting_Load);
            this.VisibleChanged += new System.EventHandler(this.AreaWeighting_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numA_r)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numA_r;
        private System.Windows.Forms.CheckBox checkModuleAvailable;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
