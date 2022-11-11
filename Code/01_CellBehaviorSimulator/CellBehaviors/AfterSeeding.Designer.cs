namespace CellBehaviorSimulator.CellBehaviors
{
    partial class AfterSeeding
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numLagTime = new System.Windows.Forms.NumericUpDown();
            this.numTimeConstant = new System.Windows.Forms.NumericUpDown();
            this.numAdherentRatio = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkModuleAvailable = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLagTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeConstant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdherentRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.numLagTime);
            this.groupBox1.Controls.Add(this.numTimeConstant);
            this.groupBox1.Controls.Add(this.numAdherentRatio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // numLagTime
            // 
            this.numLagTime.DecimalPlaces = 1;
            this.numLagTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numLagTime.Location = new System.Drawing.Point(138, 68);
            this.numLagTime.Name = "numLagTime";
            this.numLagTime.Size = new System.Drawing.Size(60, 19);
            this.numLagTime.TabIndex = 5;
            this.numLagTime.ValueChanged += new System.EventHandler(this.NumLagTime_ValueChanged);
            // 
            // numTimeConstant
            // 
            this.numTimeConstant.DecimalPlaces = 1;
            this.numTimeConstant.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numTimeConstant.Location = new System.Drawing.Point(138, 43);
            this.numTimeConstant.Name = "numTimeConstant";
            this.numTimeConstant.Size = new System.Drawing.Size(60, 19);
            this.numTimeConstant.TabIndex = 3;
            this.numTimeConstant.ValueChanged += new System.EventHandler(this.NumTimeConstant_ValueChanged);
            // 
            // numAdherentRatio
            // 
            this.numAdherentRatio.DecimalPlaces = 2;
            this.numAdherentRatio.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numAdherentRatio.Location = new System.Drawing.Point(138, 18);
            this.numAdherentRatio.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAdherentRatio.Name = "numAdherentRatio";
            this.numAdherentRatio.Size = new System.Drawing.Size(60, 19);
            this.numAdherentRatio.TabIndex = 1;
            this.numAdherentRatio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAdherentRatio.ValueChanged += new System.EventHandler(this.NumAdherentRatio_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lag time t_lag (h)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time constant tau_a (h)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adherent ratio alpha (-)";
            // 
            // checkModuleAvailable
            // 
            this.checkModuleAvailable.AutoSize = true;
            this.checkModuleAvailable.Location = new System.Drawing.Point(6, 0);
            this.checkModuleAvailable.Name = "checkModuleAvailable";
            this.checkModuleAvailable.Size = new System.Drawing.Size(93, 16);
            this.checkModuleAvailable.TabIndex = 0;
            this.checkModuleAvailable.Text = "After seeding";
            this.checkModuleAvailable.UseVisualStyleBackColor = true;
            this.checkModuleAvailable.CheckedChanged += new System.EventHandler(this.CheckModuleAvailable_CheckedChanged);
            // 
            // AfterSeeding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.checkModuleAvailable);
            this.Controls.Add(this.groupBox1);
            this.Name = "AfterSeeding";
            this.Size = new System.Drawing.Size(204, 105);
            this.Load += new System.EventHandler(this.JustAfterSeeding_Load);
            this.VisibleChanged += new System.EventHandler(this.JustAfterSeeding_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLagTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeConstant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdherentRatio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkModuleAvailable;
        private System.Windows.Forms.NumericUpDown numAdherentRatio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numLagTime;
        private System.Windows.Forms.NumericUpDown numTimeConstant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
