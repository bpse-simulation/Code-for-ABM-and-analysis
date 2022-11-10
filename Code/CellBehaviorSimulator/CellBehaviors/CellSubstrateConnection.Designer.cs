namespace CellBehaviorSimulator.CellBehaviors
{
    partial class CellSubstrateConnection
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
            this.num_u_cs = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.num_k_cs = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_u_cs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_k_cs)).BeginInit();
            this.SuspendLayout();
            // 
            // checkModuleAvailable
            // 
            this.checkModuleAvailable.AutoSize = true;
            this.checkModuleAvailable.Enabled = false;
            this.checkModuleAvailable.Location = new System.Drawing.Point(6, 0);
            this.checkModuleAvailable.Name = "checkModuleAvailable";
            this.checkModuleAvailable.Size = new System.Drawing.Size(157, 16);
            this.checkModuleAvailable.TabIndex = 0;
            this.checkModuleAvailable.Text = "Cell-substrate connection";
            this.checkModuleAvailable.UseVisualStyleBackColor = true;
            this.checkModuleAvailable.CheckedChanged += new System.EventHandler(this.CheckModuleAvailable_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.num_u_cs);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.num_k_cs);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // num_u_cs
            // 
            this.num_u_cs.DecimalPlaces = 1;
            this.num_u_cs.Enabled = false;
            this.num_u_cs.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_u_cs.Location = new System.Drawing.Point(118, 43);
            this.num_u_cs.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_u_cs.Name = "num_u_cs";
            this.num_u_cs.Size = new System.Drawing.Size(60, 19);
            this.num_u_cs.TabIndex = 9;
            this.num_u_cs.Visible = false;
            this.num_u_cs.ValueChanged += new System.EventHandler(this.Num_u_cs_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(5, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "u_cs (ng um^2 h^-3)";
            this.toolTip1.SetToolTip(this.label5, "Coefficient of formation rate for cell-substrate adhesion");
            this.label5.Visible = false;
            // 
            // num_k_cs
            // 
            this.num_k_cs.DecimalPlaces = 1;
            this.num_k_cs.Enabled = false;
            this.num_k_cs.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_k_cs.Location = new System.Drawing.Point(118, 18);
            this.num_k_cs.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_k_cs.Name = "num_k_cs";
            this.num_k_cs.Size = new System.Drawing.Size(60, 19);
            this.num_k_cs.TabIndex = 7;
            this.num_k_cs.Visible = false;
            this.num_k_cs.ValueChanged += new System.EventHandler(this.Num_k_cs_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(5, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "k_cs (ng um^2 h^-3)";
            this.toolTip1.SetToolTip(this.label4, "Decay rate for cell-substrate adhesion");
            this.label4.Visible = false;
            // 
            // CellSubstrateConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.checkModuleAvailable);
            this.Controls.Add(this.groupBox1);
            this.Name = "CellSubstrateConnection";
            this.Size = new System.Drawing.Size(184, 80);
            this.Load += new System.EventHandler(this.Connection_Load);
            this.VisibleChanged += new System.EventHandler(this.CellSubstrateConnection_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_u_cs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_k_cs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkModuleAvailable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown num_u_cs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_k_cs;
        private System.Windows.Forms.Label label4;
    }
}
