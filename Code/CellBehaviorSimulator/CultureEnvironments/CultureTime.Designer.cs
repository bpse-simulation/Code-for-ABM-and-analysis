namespace CellBehaviorSimulator.CultureEnvironments
{
    partial class CultureTime
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.groupBox_Time = new System.Windows.Forms.GroupBox();
            this.num_TotalTime = new System.Windows.Forms.NumericUpDown();
            this.labelTime_step = new System.Windows.Forms.Label();
            this.labelCultureTotalTime = new System.Windows.Forms.Label();
            this.num_t_step = new System.Windows.Forms.NumericUpDown();
            this.labelInitialStartTime = new System.Windows.Forms.Label();
            this.num_t_init = new System.Windows.Forms.NumericUpDown();
            this.groupBox_Time.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_TotalTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_t_step)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_t_init)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Time
            // 
            this.groupBox_Time.AutoSize = true;
            this.groupBox_Time.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_Time.Controls.Add(this.labelInitialStartTime);
            this.groupBox_Time.Controls.Add(this.num_t_init);
            this.groupBox_Time.Controls.Add(this.num_TotalTime);
            this.groupBox_Time.Controls.Add(this.labelTime_step);
            this.groupBox_Time.Controls.Add(this.labelCultureTotalTime);
            this.groupBox_Time.Controls.Add(this.num_t_step);
            this.groupBox_Time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Time.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Time.Name = "groupBox_Time";
            this.groupBox_Time.Size = new System.Drawing.Size(225, 105);
            this.groupBox_Time.TabIndex = 0;
            this.groupBox_Time.TabStop = false;
            this.groupBox_Time.Text = "Time setting";
            // 
            // num_TotalTime
            // 
            this.num_TotalTime.Location = new System.Drawing.Point(159, 18);
            this.num_TotalTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_TotalTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_TotalTime.Name = "num_TotalTime";
            this.num_TotalTime.Size = new System.Drawing.Size(60, 19);
            this.num_TotalTime.TabIndex = 1;
            this.num_TotalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_TotalTime.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_TotalTime.ValueChanged += new System.EventHandler(this.NumUpDnTotalTime_ValueChanged);
            // 
            // labelTime_step
            // 
            this.labelTime_step.AutoSize = true;
            this.labelTime_step.Location = new System.Drawing.Point(5, 45);
            this.labelTime_step.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime_step.Name = "labelTime_step";
            this.labelTime_step.Size = new System.Drawing.Size(108, 12);
            this.labelTime_step.TabIndex = 2;
            this.labelTime_step.Text = "Time step t_step (h)";
            // 
            // labelCultureTotalTime
            // 
            this.labelCultureTotalTime.AutoSize = true;
            this.labelCultureTotalTime.Location = new System.Drawing.Point(5, 20);
            this.labelCultureTotalTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCultureTotalTime.Name = "labelCultureTotalTime";
            this.labelCultureTotalTime.Size = new System.Drawing.Size(149, 12);
            this.labelCultureTotalTime.TabIndex = 0;
            this.labelCultureTotalTime.Text = "Total culture time t_total (h)";
            // 
            // num_t_step
            // 
            this.num_t_step.DecimalPlaces = 2;
            this.num_t_step.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.num_t_step.Location = new System.Drawing.Point(159, 43);
            this.num_t_step.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_t_step.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.num_t_step.Name = "num_t_step";
            this.num_t_step.Size = new System.Drawing.Size(60, 19);
            this.num_t_step.TabIndex = 3;
            this.num_t_step.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_t_step.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_t_step.ValueChanged += new System.EventHandler(this.NumUpDnDeltaT_ValueChanged);
            // 
            // labelInitialStartTime
            // 
            this.labelInitialStartTime.AutoSize = true;
            this.labelInitialStartTime.Location = new System.Drawing.Point(5, 70);
            this.labelInitialStartTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInitialStartTime.Name = "labelInitialStartTime";
            this.labelInitialStartTime.Size = new System.Drawing.Size(133, 12);
            this.labelInitialStartTime.TabIndex = 4;
            this.labelInitialStartTime.Text = "Initial start time t_init (h)";
            // 
            // num_t_init
            // 
            this.num_t_init.DecimalPlaces = 2;
            this.num_t_init.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.num_t_init.Location = new System.Drawing.Point(159, 68);
            this.num_t_init.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_t_init.Name = "num_t_init";
            this.num_t_init.Size = new System.Drawing.Size(60, 19);
            this.num_t_init.TabIndex = 5;
            this.num_t_init.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_t_init.ValueChanged += new System.EventHandler(this.Num_t_init_ValueChanged);
            // 
            // CultureTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox_Time);
            this.Name = "CultureTime";
            this.Size = new System.Drawing.Size(225, 105);
            this.Load += new System.EventHandler(this.CultureTime_Load);
            this.groupBox_Time.ResumeLayout(false);
            this.groupBox_Time.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_TotalTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_t_step)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_t_init)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Time;
        private System.Windows.Forms.NumericUpDown num_TotalTime;
        private System.Windows.Forms.Label labelTime_step;
        private System.Windows.Forms.Label labelCultureTotalTime;
        private System.Windows.Forms.NumericUpDown num_t_step;
        private System.Windows.Forms.Label labelInitialStartTime;
        private System.Windows.Forms.NumericUpDown num_t_init;
    }
}
