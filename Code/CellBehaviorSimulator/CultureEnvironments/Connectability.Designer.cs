namespace CellBehaviorSimulator.CultureEnvironments
{
    partial class Connectability
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
            this.groupBox_Connectability = new System.Windows.Forms.GroupBox();
            this.comboBoxLAMBDA = new System.Windows.Forms.ComboBox();
            this.labelConnectability = new System.Windows.Forms.Label();
            this.groupBox_Connectability.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Connectability
            // 
            this.groupBox_Connectability.AutoSize = true;
            this.groupBox_Connectability.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_Connectability.Controls.Add(this.comboBoxLAMBDA);
            this.groupBox_Connectability.Controls.Add(this.labelConnectability);
            this.groupBox_Connectability.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Connectability.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Connectability.Name = "groupBox_Connectability";
            this.groupBox_Connectability.Size = new System.Drawing.Size(150, 56);
            this.groupBox_Connectability.TabIndex = 0;
            this.groupBox_Connectability.TabStop = false;
            this.groupBox_Connectability.Text = "Connectability";
            // 
            // comboBoxLAMBDA
            // 
            this.comboBoxLAMBDA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLAMBDA.FormattingEnabled = true;
            this.comboBoxLAMBDA.Items.AddRange(new object[] {
            "1",
            "2^(1/2)",
            "3^(1/2)"});
            this.comboBoxLAMBDA.Location = new System.Drawing.Point(64, 18);
            this.comboBoxLAMBDA.Name = "comboBoxLAMBDA";
            this.comboBoxLAMBDA.Size = new System.Drawing.Size(80, 20);
            this.comboBoxLAMBDA.TabIndex = 4;
            this.comboBoxLAMBDA.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // labelConnectability
            // 
            this.labelConnectability.AutoSize = true;
            this.labelConnectability.Location = new System.Drawing.Point(5, 21);
            this.labelConnectability.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConnectability.Name = "labelConnectability";
            this.labelConnectability.Size = new System.Drawing.Size(54, 12);
            this.labelConnectability.TabIndex = 2;
            this.labelConnectability.Text = "Λ/l_c (-)";
            // 
            // Connectability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox_Connectability);
            this.Name = "Connectability";
            this.Size = new System.Drawing.Size(150, 56);
            this.Load += new System.EventHandler(this.Connectability_Load);
            this.groupBox_Connectability.ResumeLayout(false);
            this.groupBox_Connectability.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Connectability;
        private System.Windows.Forms.Label labelConnectability;
        private System.Windows.Forms.ComboBox comboBoxLAMBDA;
    }
}
