namespace CellBehaviorSimulator.CultureEnvironments
{
    partial class Environments
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
            this.substrateAbility1 = new CellBehaviorSimulator.CultureEnvironments.SubstrateAbility();
            this.gravitySettling1 = new CellBehaviorSimulator.CultureEnvironments.GravitySettling();
            this.connectability1 = new CellBehaviorSimulator.CultureEnvironments.Connectability();
            this.boundaryConditions1 = new CellBehaviorSimulator.CultureEnvironments.BoundaryConditions();
            this.mapSetting1 = new CellBehaviorSimulator.CultureEnvironments.CultureSpace();
            this.timeSetting1 = new CellBehaviorSimulator.CultureEnvironments.CultureTime();
            this.SuspendLayout();
            // 
            // substrateAbility1
            // 
            this.substrateAbility1.AutoSize = true;
            this.substrateAbility1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.substrateAbility1.Location = new System.Drawing.Point(237, 153);
            this.substrateAbility1.Name = "substrateAbility1";
            this.substrateAbility1.Size = new System.Drawing.Size(155, 80);
            this.substrateAbility1.TabIndex = 6;
            // 
            // gravitySettling1
            // 
            this.gravitySettling1.AutoSize = true;
            this.gravitySettling1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gravitySettling1.Location = new System.Drawing.Point(237, 125);
            this.gravitySettling1.Name = "gravitySettling1";
            this.gravitySettling1.Size = new System.Drawing.Size(112, 19);
            this.gravitySettling1.TabIndex = 5;
            // 
            // connectability1
            // 
            this.connectability1.AutoSize = true;
            this.connectability1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connectability1.Location = new System.Drawing.Point(237, 60);
            this.connectability1.Name = "connectability1";
            this.connectability1.Size = new System.Drawing.Size(150, 56);
            this.connectability1.TabIndex = 4;
            // 
            // boundaryConditions1
            // 
            this.boundaryConditions1.AutoSize = true;
            this.boundaryConditions1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boundaryConditions1.Location = new System.Drawing.Point(237, 3);
            this.boundaryConditions1.Name = "boundaryConditions1";
            this.boundaryConditions1.Size = new System.Drawing.Size(186, 48);
            this.boundaryConditions1.TabIndex = 3;
            // 
            // mapSetting1
            // 
            this.mapSetting1.AutoSize = true;
            this.mapSetting1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mapSetting1.Location = new System.Drawing.Point(3, 114);
            this.mapSetting1.Name = "mapSetting1";
            this.mapSetting1.Size = new System.Drawing.Size(196, 181);
            this.mapSetting1.TabIndex = 2;
            // 
            // timeSetting1
            // 
            this.timeSetting1.AutoSize = true;
            this.timeSetting1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.timeSetting1.Location = new System.Drawing.Point(3, 3);
            this.timeSetting1.Name = "timeSetting1";
            this.timeSetting1.Size = new System.Drawing.Size(225, 105);
            this.timeSetting1.TabIndex = 0;
            // 
            // Environments
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.substrateAbility1);
            this.Controls.Add(this.gravitySettling1);
            this.Controls.Add(this.connectability1);
            this.Controls.Add(this.boundaryConditions1);
            this.Controls.Add(this.mapSetting1);
            this.Controls.Add(this.timeSetting1);
            this.Name = "Environments";
            this.Size = new System.Drawing.Size(426, 298);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CellBehaviorSimulator.CultureEnvironments.BoundaryConditions boundaryConditions1;
        private CellBehaviorSimulator.CultureEnvironments.CultureSpace mapSetting1;
        private CellBehaviorSimulator.CultureEnvironments.CultureTime timeSetting1;
        private CultureEnvironments.Connectability connectability1;
        private CultureEnvironments.GravitySettling gravitySettling1;
        private CultureEnvironments.SubstrateAbility substrateAbility1;
    }
}
