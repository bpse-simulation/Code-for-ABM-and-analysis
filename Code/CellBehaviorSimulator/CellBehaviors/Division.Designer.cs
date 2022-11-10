namespace CellBehaviorSimulator.CellBehaviors
{
    partial class Division
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
            this.numFluc_d = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.differentiation_Basal_AsyncDivision1 = new CellBehaviorSimulator.CellBehaviors.Differentiation_Basal_AsyncDivision();
            this.differentiation_Basal_Decay1 = new CellBehaviorSimulator.CellBehaviors.Differentiation_Basal_Decay();
            this.label1 = new System.Windows.Forms.Label();
            this.num_Nc = new System.Windows.Forms.NumericUpDown();
            this.labelGenerationTime = new System.Windows.Forms.Label();
            this.num_Prq = new System.Windows.Forms.NumericUpDown();
            this.labelContactInhibition = new System.Windows.Forms.Label();
            this.num_tg = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFluc_d)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Nc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Prq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tg)).BeginInit();
            this.SuspendLayout();
            // 
            // checkModuleAvailable
            // 
            this.checkModuleAvailable.AutoSize = true;
            this.checkModuleAvailable.Location = new System.Drawing.Point(6, 0);
            this.checkModuleAvailable.Name = "checkModuleAvailable";
            this.checkModuleAvailable.Size = new System.Drawing.Size(65, 16);
            this.checkModuleAvailable.TabIndex = 0;
            this.checkModuleAvailable.Text = "Division";
            this.checkModuleAvailable.UseVisualStyleBackColor = true;
            this.checkModuleAvailable.CheckedChanged += new System.EventHandler(this.CheckModuleAvailable_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.numFluc_d);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.differentiation_Basal_AsyncDivision1);
            this.groupBox1.Controls.Add(this.differentiation_Basal_Decay1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.num_Nc);
            this.groupBox1.Controls.Add(this.labelGenerationTime);
            this.groupBox1.Controls.Add(this.num_Prq);
            this.groupBox1.Controls.Add(this.labelContactInhibition);
            this.groupBox1.Controls.Add(this.num_tg);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 281);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // numFluc_d
            // 
            this.numFluc_d.Location = new System.Drawing.Point(147, 93);
            this.numFluc_d.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numFluc_d.Name = "numFluc_d";
            this.numFluc_d.Size = new System.Drawing.Size(60, 19);
            this.numFluc_d.TabIndex = 7;
            this.numFluc_d.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numFluc_d.ValueChanged += new System.EventHandler(this.NumFluc_d_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fluctuation of division (%)";
            // 
            // differentiation_Basal_AsyncDivision1
            // 
            this.differentiation_Basal_AsyncDivision1.AutoSize = true;
            this.differentiation_Basal_AsyncDivision1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.differentiation_Basal_AsyncDivision1.Location = new System.Drawing.Point(6, 208);
            this.differentiation_Basal_AsyncDivision1.Name = "differentiation_Basal_AsyncDivision1";
            this.differentiation_Basal_AsyncDivision1.Size = new System.Drawing.Size(197, 55);
            this.differentiation_Basal_AsyncDivision1.TabIndex = 9;
            // 
            // differentiation_Basal_Decay1
            // 
            this.differentiation_Basal_Decay1.AutoSize = true;
            this.differentiation_Basal_Decay1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.differentiation_Basal_Decay1.Location = new System.Drawing.Point(6, 118);
            this.differentiation_Basal_Decay1.Name = "differentiation_Basal_Decay1";
            this.differentiation_Basal_Decay1.Size = new System.Drawing.Size(171, 80);
            this.differentiation_Basal_Decay1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pr_q (-)";
            this.toolTip1.SetToolTip(this.label1, "Probability of vertical division");
            // 
            // num_Nc
            // 
            this.num_Nc.Location = new System.Drawing.Point(147, 68);
            this.num_Nc.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_Nc.Name = "num_Nc";
            this.num_Nc.Size = new System.Drawing.Size(60, 19);
            this.num_Nc.TabIndex = 5;
            this.num_Nc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Nc.ValueChanged += new System.EventHandler(this.Num_Nc_ValueChanged);
            // 
            // labelGenerationTime
            // 
            this.labelGenerationTime.AutoSize = true;
            this.labelGenerationTime.Location = new System.Drawing.Point(5, 20);
            this.labelGenerationTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGenerationTime.Name = "labelGenerationTime";
            this.labelGenerationTime.Size = new System.Drawing.Size(49, 12);
            this.labelGenerationTime.TabIndex = 0;
            this.labelGenerationTime.Text = "<t_g> (h)";
            this.toolTip1.SetToolTip(this.labelGenerationTime, "Generation time");
            // 
            // num_Prq
            // 
            this.num_Prq.DecimalPlaces = 6;
            this.num_Prq.Increment = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.num_Prq.Location = new System.Drawing.Point(137, 43);
            this.num_Prq.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Prq.Name = "num_Prq";
            this.num_Prq.Size = new System.Drawing.Size(70, 19);
            this.num_Prq.TabIndex = 3;
            this.num_Prq.ValueChanged += new System.EventHandler(this.Num_Prq_ValueChanged);
            // 
            // labelContactInhibition
            // 
            this.labelContactInhibition.AutoSize = true;
            this.labelContactInhibition.Location = new System.Drawing.Point(5, 70);
            this.labelContactInhibition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContactInhibition.Name = "labelContactInhibition";
            this.labelContactInhibition.Size = new System.Drawing.Size(82, 12);
            this.labelContactInhibition.TabIndex = 4;
            this.labelContactInhibition.Text = "N_c (unit cube)";
            this.toolTip1.SetToolTip(this.labelContactInhibition, "Number of cell layers for occurrence of contact inhibition ");
            // 
            // num_tg
            // 
            this.num_tg.DecimalPlaces = 1;
            this.num_tg.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_tg.Location = new System.Drawing.Point(147, 18);
            this.num_tg.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_tg.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_tg.Name = "num_tg";
            this.num_tg.Size = new System.Drawing.Size(60, 19);
            this.num_tg.TabIndex = 1;
            this.num_tg.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_tg.ValueChanged += new System.EventHandler(this.Num_tg_ValueChanged);
            // 
            // Division
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.checkModuleAvailable);
            this.Controls.Add(this.groupBox1);
            this.Name = "Division";
            this.Size = new System.Drawing.Size(213, 281);
            this.Load += new System.EventHandler(this.Division_Load);
            this.VisibleChanged += new System.EventHandler(this.Division_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFluc_d)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Nc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Prq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkModuleAvailable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_Nc;
        private System.Windows.Forms.Label labelGenerationTime;
        private System.Windows.Forms.NumericUpDown num_Prq;
        private System.Windows.Forms.Label labelContactInhibition;
        private System.Windows.Forms.NumericUpDown num_tg;
        private System.Windows.Forms.ToolTip toolTip1;
        private Differentiation_Basal_Decay differentiation_Basal_Decay1;
        private Differentiation_Basal_AsyncDivision differentiation_Basal_AsyncDivision1;
        private System.Windows.Forms.NumericUpDown numFluc_d;
        private System.Windows.Forms.Label label2;
    }
}
