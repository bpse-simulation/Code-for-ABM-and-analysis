namespace CellBehaviorSimulator
{
    partial class Display
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
            this.labelZ = new System.Windows.Forms.Label();
            this.buttonReload = new System.Windows.Forms.Button();
            this.numZ = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioCellState = new System.Windows.Forms.RadioButton();
            this.radioCellType = new System.Windows.Forms.RadioButton();
            this.radioIndex = new System.Windows.Forms.RadioButton();
            this.checkAutoReload = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(3, 7);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(22, 12);
            this.labelZ.TabIndex = 7;
            this.labelZ.Text = "Z =";
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(76, 2);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(60, 23);
            this.buttonReload.TabIndex = 6;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.ButtonReload_Click);
            // 
            // numZ
            // 
            this.numZ.Location = new System.Drawing.Point(31, 5);
            this.numZ.Name = "numZ";
            this.numZ.Size = new System.Drawing.Size(40, 19);
            this.numZ.TabIndex = 5;
            this.numZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numZ.ValueChanged += new System.EventHandler(this.NumZ_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(82, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // radioCellState
            // 
            this.radioCellState.AutoSize = true;
            this.radioCellState.Location = new System.Drawing.Point(3, 74);
            this.radioCellState.Name = "radioCellState";
            this.radioCellState.Size = new System.Drawing.Size(73, 16);
            this.radioCellState.TabIndex = 10;
            this.radioCellState.Text = "Cell state";
            this.radioCellState.UseVisualStyleBackColor = true;
            this.radioCellState.CheckedChanged += new System.EventHandler(this.RadioCellState_CheckedChanged);
            // 
            // radioCellType
            // 
            this.radioCellType.AutoSize = true;
            this.radioCellType.Location = new System.Drawing.Point(3, 52);
            this.radioCellType.Name = "radioCellType";
            this.radioCellType.Size = new System.Drawing.Size(69, 16);
            this.radioCellType.TabIndex = 9;
            this.radioCellType.Text = "Cell type";
            this.radioCellType.UseVisualStyleBackColor = true;
            this.radioCellType.CheckedChanged += new System.EventHandler(this.RadioCellType_CheckedChanged);
            // 
            // radioIndex
            // 
            this.radioIndex.AutoSize = true;
            this.radioIndex.Checked = true;
            this.radioIndex.Location = new System.Drawing.Point(3, 30);
            this.radioIndex.Name = "radioIndex";
            this.radioIndex.Size = new System.Drawing.Size(50, 16);
            this.radioIndex.TabIndex = 8;
            this.radioIndex.TabStop = true;
            this.radioIndex.Text = "Index";
            this.radioIndex.UseVisualStyleBackColor = true;
            this.radioIndex.CheckedChanged += new System.EventHandler(this.RadioIndex_CheckedChanged);
            // 
            // checkAutoReload
            // 
            this.checkAutoReload.AutoSize = true;
            this.checkAutoReload.Location = new System.Drawing.Point(141, 6);
            this.checkAutoReload.Name = "checkAutoReload";
            this.checkAutoReload.Size = new System.Drawing.Size(126, 16);
            this.checkAutoReload.TabIndex = 11;
            this.checkAutoReload.Text = "Automatic reloading";
            this.checkAutoReload.UseVisualStyleBackColor = true;
            this.checkAutoReload.CheckedChanged += new System.EventHandler(this.CheckAutoReload_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(273, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Interval (secs)";
            // 
            // numInterval
            // 
            this.numInterval.Enabled = false;
            this.numInterval.Location = new System.Drawing.Point(358, 5);
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(60, 19);
            this.numInterval.TabIndex = 13;
            this.numInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.numInterval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkAutoReload);
            this.Controls.Add(this.radioCellType);
            this.Controls.Add(this.radioIndex);
            this.Controls.Add(this.radioCellState);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.numZ);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Display";
            this.Size = new System.Drawing.Size(421, 289);
            ((System.ComponentModel.ISupportInitialize)(this.numZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.NumericUpDown numZ;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioCellState;
        private System.Windows.Forms.RadioButton radioCellType;
        private System.Windows.Forms.RadioButton radioIndex;
        private System.Windows.Forms.CheckBox checkAutoReload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numInterval;
    }
}
