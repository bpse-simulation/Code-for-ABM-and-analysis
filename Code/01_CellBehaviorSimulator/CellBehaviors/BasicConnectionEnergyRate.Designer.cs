namespace CellBehaviorSimulator.CellBehaviors
{
    partial class BasicConnectionEnergyRate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numCadType = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.num_tauTJ = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.num_Epcs0_E = new System.Windows.Forms.NumericUpDown();
            this.num_Epcs0 = new System.Windows.Forms.NumericUpDown();
            this.num_EpTJ0_E = new System.Windows.Forms.NumericUpDown();
            this.num_EpTJ0 = new System.Windows.Forms.NumericUpDown();
            this.num_EpAJ0_E = new System.Windows.Forms.NumericUpDown();
            this.num_EpAJ0 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCadType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tauTJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Epcs0_E)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Epcs0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EpTJ0_E)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EpTJ0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EpAJ0_E)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EpAJ0)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numCadType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.num_tauTJ);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.num_Epcs0_E);
            this.groupBox1.Controls.Add(this.num_Epcs0);
            this.groupBox1.Controls.Add(this.num_EpTJ0_E);
            this.groupBox1.Controls.Add(this.num_EpTJ0);
            this.groupBox1.Controls.Add(this.num_EpAJ0_E);
            this.groupBox1.Controls.Add(this.num_EpAJ0);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic connecton energy rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cadherin type ";
            this.toolTip1.SetToolTip(this.label8, "0 : E-cad, 1 : N-cad");
            // 
            // numCadType
            // 
            this.numCadType.Location = new System.Drawing.Point(92, 118);
            this.numCadType.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCadType.Name = "numCadType";
            this.numCadType.Size = new System.Drawing.Size(60, 19);
            this.numCadType.TabIndex = 13;
            this.numCadType.ValueChanged += new System.EventHandler(this.NumCadType_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "*10^";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "*10^";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "*10^";
            // 
            // num_tauTJ
            // 
            this.num_tauTJ.DecimalPlaces = 1;
            this.num_tauTJ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_tauTJ.Location = new System.Drawing.Point(81, 93);
            this.num_tauTJ.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_tauTJ.Name = "num_tauTJ";
            this.num_tauTJ.Size = new System.Drawing.Size(60, 19);
            this.num_tauTJ.TabIndex = 12;
            this.num_tauTJ.ValueChanged += new System.EventHandler(this.Num_tauTJ_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "tau_TJ (h)";
            this.toolTip1.SetToolTip(this.label2, "Time constant for TJ connection");
            // 
            // num_Epcs0_E
            // 
            this.num_Epcs0_E.Location = new System.Drawing.Point(171, 68);
            this.num_Epcs0_E.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_Epcs0_E.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.num_Epcs0_E.Name = "num_Epcs0_E";
            this.num_Epcs0_E.Size = new System.Drawing.Size(40, 19);
            this.num_Epcs0_E.TabIndex = 10;
            this.num_Epcs0_E.ValueChanged += new System.EventHandler(this.Num_Epcs0_E_ValueChanged);
            // 
            // num_Epcs0
            // 
            this.num_Epcs0.DecimalPlaces = 3;
            this.num_Epcs0.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.num_Epcs0.Location = new System.Drawing.Point(81, 68);
            this.num_Epcs0.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            131072});
            this.num_Epcs0.Name = "num_Epcs0";
            this.num_Epcs0.Size = new System.Drawing.Size(50, 19);
            this.num_Epcs0.TabIndex = 8;
            this.num_Epcs0.ValueChanged += new System.EventHandler(this.Num_Epcs0_ValueChanged);
            // 
            // num_EpTJ0_E
            // 
            this.num_EpTJ0_E.Location = new System.Drawing.Point(171, 43);
            this.num_EpTJ0_E.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_EpTJ0_E.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.num_EpTJ0_E.Name = "num_EpTJ0_E";
            this.num_EpTJ0_E.Size = new System.Drawing.Size(40, 19);
            this.num_EpTJ0_E.TabIndex = 7;
            this.num_EpTJ0_E.ValueChanged += new System.EventHandler(this.Num_EpTJ0_E_ValueChanged);
            // 
            // num_EpTJ0
            // 
            this.num_EpTJ0.DecimalPlaces = 3;
            this.num_EpTJ0.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.num_EpTJ0.Location = new System.Drawing.Point(81, 43);
            this.num_EpTJ0.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            131072});
            this.num_EpTJ0.Name = "num_EpTJ0";
            this.num_EpTJ0.Size = new System.Drawing.Size(50, 19);
            this.num_EpTJ0.TabIndex = 5;
            this.num_EpTJ0.ValueChanged += new System.EventHandler(this.Num_EpTJ0_ValueChanged);
            // 
            // num_EpAJ0_E
            // 
            this.num_EpAJ0_E.Location = new System.Drawing.Point(171, 18);
            this.num_EpAJ0_E.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_EpAJ0_E.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.num_EpAJ0_E.Name = "num_EpAJ0_E";
            this.num_EpAJ0_E.Size = new System.Drawing.Size(40, 19);
            this.num_EpAJ0_E.TabIndex = 3;
            this.num_EpAJ0_E.ValueChanged += new System.EventHandler(this.Num_EpAJ0_E_ValueChanged);
            // 
            // num_EpAJ0
            // 
            this.num_EpAJ0.DecimalPlaces = 3;
            this.num_EpAJ0.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.num_EpAJ0.Location = new System.Drawing.Point(81, 18);
            this.num_EpAJ0.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            131072});
            this.num_EpAJ0.Name = "num_EpAJ0";
            this.num_EpAJ0.Size = new System.Drawing.Size(50, 19);
            this.num_EpAJ0.TabIndex = 1;
            this.num_EpAJ0.ValueChanged += new System.EventHandler(this.Num_EpAJ0_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ep_{cs,0} (-)";
            this.toolTip1.SetToolTip(this.label4, "(=E_{cs,0}/E_max)");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ep_{TJ,0} (-)";
            this.toolTip1.SetToolTip(this.label3, "(=E_{TJ,0}/E_max)");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ep_{AJ,0} (-)";
            this.toolTip1.SetToolTip(this.label1, "(=E_{AJ,0}/E_max)");
            // 
            // BasicConnectionEnergyRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox1);
            this.Name = "BasicConnectionEnergyRate";
            this.Size = new System.Drawing.Size(217, 155);
            this.Load += new System.EventHandler(this.ConnectionEnergy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCadType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tauTJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Epcs0_E)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Epcs0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EpTJ0_E)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EpTJ0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EpAJ0_E)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EpAJ0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.NumericUpDown num_Epcs0;
        internal System.Windows.Forms.NumericUpDown num_EpTJ0;
        internal System.Windows.Forms.NumericUpDown num_EpAJ0;
        internal System.Windows.Forms.NumericUpDown num_tauTJ;
        internal System.Windows.Forms.NumericUpDown num_Epcs0_E;
        internal System.Windows.Forms.NumericUpDown num_EpTJ0_E;
        internal System.Windows.Forms.NumericUpDown num_EpAJ0_E;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.NumericUpDown numCadType;
    }
}
