namespace CellBehaviorSimulator.CellBehaviors
{
    partial class CellCellConnection
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
            this.check_t_deg_Inf = new System.Windows.Forms.CheckBox();
            this.num_u_AJ = new System.Windows.Forms.NumericUpDown();
            this.num_k_AJ = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_t_deg = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_u_AJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_k_AJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_t_deg)).BeginInit();
            this.SuspendLayout();
            // 
            // checkModuleAvailable
            // 
            this.checkModuleAvailable.AutoSize = true;
            this.checkModuleAvailable.Location = new System.Drawing.Point(6, 0);
            this.checkModuleAvailable.Name = "checkModuleAvailable";
            this.checkModuleAvailable.Size = new System.Drawing.Size(127, 16);
            this.checkModuleAvailable.TabIndex = 0;
            this.checkModuleAvailable.Text = "Cell-cell connection";
            this.checkModuleAvailable.UseVisualStyleBackColor = true;
            this.checkModuleAvailable.CheckedChanged += new System.EventHandler(this.CheckModuleAvailable_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.check_t_deg_Inf);
            this.groupBox1.Controls.Add(this.num_u_AJ);
            this.groupBox1.Controls.Add(this.num_k_AJ);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.num_t_deg);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // check_t_deg_Inf
            // 
            this.check_t_deg_Inf.AutoSize = true;
            this.check_t_deg_Inf.Checked = true;
            this.check_t_deg_Inf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_t_deg_Inf.Location = new System.Drawing.Point(128, 19);
            this.check_t_deg_Inf.Name = "check_t_deg_Inf";
            this.check_t_deg_Inf.Size = new System.Drawing.Size(59, 16);
            this.check_t_deg_Inf.TabIndex = 8;
            this.check_t_deg_Inf.Text = "Infinity";
            this.check_t_deg_Inf.UseVisualStyleBackColor = true;
            this.check_t_deg_Inf.CheckedChanged += new System.EventHandler(this.Check_t_deg_Inf_CheckedChanged);
            // 
            // num_u_AJ
            // 
            this.num_u_AJ.DecimalPlaces = 1;
            this.num_u_AJ.Enabled = false;
            this.num_u_AJ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_u_AJ.Location = new System.Drawing.Point(121, 68);
            this.num_u_AJ.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_u_AJ.Name = "num_u_AJ";
            this.num_u_AJ.Size = new System.Drawing.Size(60, 19);
            this.num_u_AJ.TabIndex = 7;
            this.num_u_AJ.Visible = false;
            this.num_u_AJ.ValueChanged += new System.EventHandler(this.Num_u_AJ_ValueChanged);
            // 
            // num_k_AJ
            // 
            this.num_k_AJ.DecimalPlaces = 1;
            this.num_k_AJ.Enabled = false;
            this.num_k_AJ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_k_AJ.Location = new System.Drawing.Point(121, 43);
            this.num_k_AJ.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_k_AJ.Name = "num_k_AJ";
            this.num_k_AJ.Size = new System.Drawing.Size(60, 19);
            this.num_k_AJ.TabIndex = 5;
            this.num_k_AJ.Visible = false;
            this.num_k_AJ.ValueChanged += new System.EventHandler(this.Num_k_AJ_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(5, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "u_AJ (um^-1)";
            this.toolTip1.SetToolTip(this.label2, "Coefficient of decay rate for E-cadherin");
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(5, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "k_AJ (ng um^2 h^-3)";
            this.toolTip1.SetToolTip(this.label3, "Formation rate for E-cadherin");
            this.label3.Visible = false;
            // 
            // num_t_deg
            // 
            this.num_t_deg.DecimalPlaces = 1;
            this.num_t_deg.Enabled = false;
            this.num_t_deg.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_t_deg.Location = new System.Drawing.Point(62, 18);
            this.num_t_deg.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_t_deg.Name = "num_t_deg";
            this.num_t_deg.Size = new System.Drawing.Size(60, 19);
            this.num_t_deg.TabIndex = 1;
            this.num_t_deg.ValueChanged += new System.EventHandler(this.Num_t_deg_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "t_deg (h)";
            this.toolTip1.SetToolTip(this.label1, "The time for the AJ or TJ connection energy to go to zero");
            // 
            // CellCellConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.checkModuleAvailable);
            this.Controls.Add(this.groupBox1);
            this.Name = "CellCellConnection";
            this.Size = new System.Drawing.Size(193, 105);
            this.Load += new System.EventHandler(this.Connection_Load);
            this.VisibleChanged += new System.EventHandler(this.CellCellConnection_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_u_AJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_k_AJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_t_deg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkModuleAvailable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown num_t_deg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox check_t_deg_Inf;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown num_u_AJ;
        private System.Windows.Forms.NumericUpDown num_k_AJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
