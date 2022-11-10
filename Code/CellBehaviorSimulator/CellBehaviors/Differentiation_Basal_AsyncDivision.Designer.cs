namespace CellBehaviorSimulator.CellBehaviors
{
    partial class Differentiation_Basal_AsyncDivision
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
            this.checkModuleAvailable = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num_CellType = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_CellType)).BeginInit();
            this.SuspendLayout();
            // 
            // checkModuleAvailable
            // 
            this.checkModuleAvailable.AutoSize = true;
            this.checkModuleAvailable.Location = new System.Drawing.Point(6, 0);
            this.checkModuleAvailable.Name = "checkModuleAvailable";
            this.checkModuleAvailable.Size = new System.Drawing.Size(188, 16);
            this.checkModuleAvailable.TabIndex = 0;
            this.checkModuleAvailable.Text = "Basal layer asymmetric division";
            this.checkModuleAvailable.UseVisualStyleBackColor = true;
            this.checkModuleAvailable.CheckedChanged += new System.EventHandler(this.CheckModuleAvailable_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.num_CellType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // num_CellType
            // 
            this.num_CellType.Location = new System.Drawing.Point(105, 18);
            this.num_CellType.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_CellType.Name = "num_CellType";
            this.num_CellType.Size = new System.Drawing.Size(60, 19);
            this.num_CellType.TabIndex = 1;
            this.num_CellType.ValueChanged += new System.EventHandler(this.Num_CellType_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cell type C_{T,dif}";
            // 
            // Differentiation_Basal_AsyncDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.checkModuleAvailable);
            this.Controls.Add(this.groupBox1);
            this.Name = "Differentiation_Basal_AsyncDivision";
            this.Size = new System.Drawing.Size(197, 55);
            this.Load += new System.EventHandler(this.Differentiation_Basal_AsyncDivision_Load);
            this.VisibleChanged += new System.EventHandler(this.Differentiation_Basal_AsyncDivision_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_CellType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkModuleAvailable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown num_CellType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
