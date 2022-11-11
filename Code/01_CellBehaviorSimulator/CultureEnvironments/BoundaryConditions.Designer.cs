namespace CellBehaviorSimulator.CultureEnvironments
{
    partial class BoundaryConditions
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
            this.groupBox_PB = new System.Windows.Forms.GroupBox();
            this.checkBoxPB_X = new System.Windows.Forms.CheckBox();
            this.checkBoxPB_Y = new System.Windows.Forms.CheckBox();
            this.checkBoxPB_Z = new System.Windows.Forms.CheckBox();
            this.groupBox_PB.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_PB
            // 
            this.groupBox_PB.AutoSize = true;
            this.groupBox_PB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_PB.Controls.Add(this.checkBoxPB_X);
            this.groupBox_PB.Controls.Add(this.checkBoxPB_Y);
            this.groupBox_PB.Controls.Add(this.checkBoxPB_Z);
            this.groupBox_PB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_PB.Location = new System.Drawing.Point(0, 0);
            this.groupBox_PB.Name = "groupBox_PB";
            this.groupBox_PB.Size = new System.Drawing.Size(186, 48);
            this.groupBox_PB.TabIndex = 0;
            this.groupBox_PB.TabStop = false;
            this.groupBox_PB.Text = "Periodic boundary conditions";
            // 
            // checkBoxPB_X
            // 
            this.checkBoxPB_X.AutoSize = true;
            this.checkBoxPB_X.Checked = true;
            this.checkBoxPB_X.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPB_X.Location = new System.Drawing.Point(5, 16);
            this.checkBoxPB_X.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkBoxPB_X.Name = "checkBoxPB_X";
            this.checkBoxPB_X.Size = new System.Drawing.Size(56, 16);
            this.checkBoxPB_X.TabIndex = 0;
            this.checkBoxPB_X.Text = "X axis";
            this.checkBoxPB_X.UseVisualStyleBackColor = true;
            this.checkBoxPB_X.CheckedChanged += new System.EventHandler(this.CheckBoxPB_X_CheckedChanged);
            // 
            // checkBoxPB_Y
            // 
            this.checkBoxPB_Y.AutoSize = true;
            this.checkBoxPB_Y.Checked = true;
            this.checkBoxPB_Y.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPB_Y.Location = new System.Drawing.Point(65, 16);
            this.checkBoxPB_Y.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkBoxPB_Y.Name = "checkBoxPB_Y";
            this.checkBoxPB_Y.Size = new System.Drawing.Size(56, 16);
            this.checkBoxPB_Y.TabIndex = 1;
            this.checkBoxPB_Y.Text = "Y axis";
            this.checkBoxPB_Y.UseVisualStyleBackColor = true;
            this.checkBoxPB_Y.CheckedChanged += new System.EventHandler(this.CheckBoxPB_Y_CheckedChanged);
            // 
            // checkBoxPB_Z
            // 
            this.checkBoxPB_Z.AutoSize = true;
            this.checkBoxPB_Z.Enabled = false;
            this.checkBoxPB_Z.Location = new System.Drawing.Point(125, 16);
            this.checkBoxPB_Z.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkBoxPB_Z.Name = "checkBoxPB_Z";
            this.checkBoxPB_Z.Size = new System.Drawing.Size(56, 16);
            this.checkBoxPB_Z.TabIndex = 2;
            this.checkBoxPB_Z.Text = "Z axis";
            this.checkBoxPB_Z.UseVisualStyleBackColor = true;
            this.checkBoxPB_Z.CheckedChanged += new System.EventHandler(this.CheckBoxPB_Z_CheckedChanged);
            // 
            // BoundaryConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox_PB);
            this.Name = "BoundaryConditions";
            this.Size = new System.Drawing.Size(186, 48);
            this.Load += new System.EventHandler(this.BoundaryConditions_Load);
            this.groupBox_PB.ResumeLayout(false);
            this.groupBox_PB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_PB;
        private System.Windows.Forms.CheckBox checkBoxPB_X;
        private System.Windows.Forms.CheckBox checkBoxPB_Y;
        private System.Windows.Forms.CheckBox checkBoxPB_Z;
    }
}
