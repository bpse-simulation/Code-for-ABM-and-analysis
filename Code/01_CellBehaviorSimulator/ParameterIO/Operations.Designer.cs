namespace CellBehaviorSimulator.CultureOperations
{
    partial class Operations
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
            this.seeding1 = new CellBehaviorSimulator.CultureOperations.Seeding();
            this.SuspendLayout();
            // 
            // seeding1
            // 
            this.seeding1.AutoSize = true;
            this.seeding1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.seeding1.Location = new System.Drawing.Point(3, 3);
            this.seeding1.Name = "seeding1";
            this.seeding1.Size = new System.Drawing.Size(262, 128);
            this.seeding1.TabIndex = 0;
            // 
            // Operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.seeding1);
            this.Name = "Operation";
            this.Size = new System.Drawing.Size(268, 134);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CultureOperations.Seeding seeding1;
    }
}
