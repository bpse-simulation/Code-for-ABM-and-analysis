namespace CellBehaviorSimulator.CellBehaviors
{
    partial class Migration
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.num_mc = new System.Windows.Forms.NumericUpDown();
            this.numV_mfree = new System.Windows.Forms.NumericUpDown();
            this.labelMassOfCell = new System.Windows.Forms.Label();
            this.labelVmfree0 = new System.Windows.Forms.Label();
            this.checkModuleAvailable = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numFluc_m = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.num_mc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numV_mfree)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFluc_m)).BeginInit();
            this.SuspendLayout();
            // 
            // num_mc
            // 
            this.num_mc.Location = new System.Drawing.Point(155, 43);
            this.num_mc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_mc.Name = "num_mc";
            this.num_mc.Size = new System.Drawing.Size(60, 19);
            this.num_mc.TabIndex = 3;
            this.num_mc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_mc.ValueChanged += new System.EventHandler(this.Num_mc_ValueChanged);
            // 
            // numV_mfree
            // 
            this.numV_mfree.DecimalPlaces = 1;
            this.numV_mfree.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numV_mfree.Location = new System.Drawing.Point(155, 18);
            this.numV_mfree.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numV_mfree.Name = "numV_mfree";
            this.numV_mfree.Size = new System.Drawing.Size(60, 19);
            this.numV_mfree.TabIndex = 1;
            this.numV_mfree.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numV_mfree.ValueChanged += new System.EventHandler(this.NumV_mfree_ValueChanged);
            // 
            // labelMassOfCell
            // 
            this.labelMassOfCell.AutoSize = true;
            this.labelMassOfCell.Location = new System.Drawing.Point(5, 45);
            this.labelMassOfCell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMassOfCell.Name = "labelMassOfCell";
            this.labelMassOfCell.Size = new System.Drawing.Size(48, 12);
            this.labelMassOfCell.TabIndex = 2;
            this.labelMassOfCell.Text = "m_c (ng)";
            this.toolTip1.SetToolTip(this.labelMassOfCell, "Mass of single cell");
            // 
            // labelVmfree0
            // 
            this.labelVmfree0.AutoSize = true;
            this.labelVmfree0.Location = new System.Drawing.Point(5, 20);
            this.labelVmfree0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVmfree0.Name = "labelVmfree0";
            this.labelVmfree0.Size = new System.Drawing.Size(93, 12);
            this.labelVmfree0.TabIndex = 0;
            this.labelVmfree0.Text = "V_{m,free} (um/h)";
            this.toolTip1.SetToolTip(this.labelVmfree0, "Free migration rate");
            // 
            // checkModuleAvailable
            // 
            this.checkModuleAvailable.AutoSize = true;
            this.checkModuleAvailable.Location = new System.Drawing.Point(6, 0);
            this.checkModuleAvailable.Name = "checkModuleAvailable";
            this.checkModuleAvailable.Size = new System.Drawing.Size(71, 16);
            this.checkModuleAvailable.TabIndex = 0;
            this.checkModuleAvailable.Text = "Migration";
            this.checkModuleAvailable.UseVisualStyleBackColor = true;
            this.checkModuleAvailable.CheckedChanged += new System.EventHandler(this.CheckModuleAvailable_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.num_mc);
            this.groupBox1.Controls.Add(this.labelVmfree0);
            this.groupBox1.Controls.Add(this.numFluc_m);
            this.groupBox1.Controls.Add(this.numV_mfree);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelMassOfCell);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // numFluc_m
            // 
            this.numFluc_m.Location = new System.Drawing.Point(155, 68);
            this.numFluc_m.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numFluc_m.Name = "numFluc_m";
            this.numFluc_m.Size = new System.Drawing.Size(60, 19);
            this.numFluc_m.TabIndex = 5;
            this.numFluc_m.ValueChanged += new System.EventHandler(this.NumFluc_m_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fluctuation of migration (%)";
            // 
            // Migration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.checkModuleAvailable);
            this.Controls.Add(this.groupBox1);
            this.Name = "Migration";
            this.Size = new System.Drawing.Size(221, 105);
            this.Load += new System.EventHandler(this.Migration_Load);
            this.VisibleChanged += new System.EventHandler(this.Migration_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.num_mc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numV_mfree)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFluc_m)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown num_mc;
        private System.Windows.Forms.NumericUpDown numV_mfree;
        private System.Windows.Forms.Label labelMassOfCell;
        private System.Windows.Forms.Label labelVmfree0;
        private System.Windows.Forms.CheckBox checkModuleAvailable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown numFluc_m;
        private System.Windows.Forms.Label label1;
    }
}
