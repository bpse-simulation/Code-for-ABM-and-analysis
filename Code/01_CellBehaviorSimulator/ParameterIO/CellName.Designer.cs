namespace CellBehaviorSimulator
{
    partial class CellName
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
            this.comboBoxCell = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCell
            // 
            this.comboBoxCell.FormattingEnabled = true;
            this.comboBoxCell.Items.AddRange(new object[] {
            "Undifferentiated cells",
            "Transient amplifying cells",
            "Differentiated cells",
            "Deviated cells"});
            this.comboBoxCell.Location = new System.Drawing.Point(59, 0);
            this.comboBoxCell.Name = "comboBoxCell";
            this.comboBoxCell.Size = new System.Drawing.Size(158, 20);
            this.comboBoxCell.TabIndex = 1;
            this.comboBoxCell.TextChanged += new System.EventHandler(this.ComboBoxCell_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cell name";
            // 
            // CellName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCell);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CellName";
            this.Size = new System.Drawing.Size(220, 23);
            this.Load += new System.EventHandler(this.CellName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCell;
        private System.Windows.Forms.Label label1;
    }
}
