namespace CellBehaviorSimulator.CellBehaviors
{
    partial class CellDeath
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
            this.radioCCandCS = new System.Windows.Forms.RadioButton();
            this.radioCCorCS = new System.Windows.Forms.RadioButton();
            this.radioCS = new System.Windows.Forms.RadioButton();
            this.radioCC = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkModuleAvailable
            // 
            this.checkModuleAvailable.AutoSize = true;
            this.checkModuleAvailable.Location = new System.Drawing.Point(6, 0);
            this.checkModuleAvailable.Name = "checkModuleAvailable";
            this.checkModuleAvailable.Size = new System.Drawing.Size(76, 16);
            this.checkModuleAvailable.TabIndex = 0;
            this.checkModuleAvailable.Text = "Cell death";
            this.checkModuleAvailable.UseVisualStyleBackColor = true;
            this.checkModuleAvailable.CheckedChanged += new System.EventHandler(this.CheckModuleAvailable_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.radioCCandCS);
            this.groupBox1.Controls.Add(this.radioCCorCS);
            this.groupBox1.Controls.Add(this.radioCS);
            this.groupBox1.Controls.Add(this.radioCC);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // radioCCandCS
            // 
            this.radioCCandCS.AutoSize = true;
            this.radioCCandCS.Location = new System.Drawing.Point(6, 66);
            this.radioCCandCS.Name = "radioCCandCS";
            this.radioCCandCS.Size = new System.Drawing.Size(153, 16);
            this.radioCCandCS.TabIndex = 3;
            this.radioCCandCS.Text = "f_{cc,dead} and f_{cs,dead}";
            this.toolTip1.SetToolTip(this.radioCCandCS, "Cell death occurs when cell-cell and cell-substrate connection energy with neighb" +
        "oring prisms is zero");
            this.radioCCandCS.UseVisualStyleBackColor = true;
            this.radioCCandCS.CheckedChanged += new System.EventHandler(this.RadioCCandCS_CheckedChanged);
            // 
            // radioCCorCS
            // 
            this.radioCCorCS.AutoSize = true;
            this.radioCCorCS.Location = new System.Drawing.Point(6, 88);
            this.radioCCorCS.Name = "radioCCorCS";
            this.radioCCorCS.Size = new System.Drawing.Size(145, 16);
            this.radioCCorCS.TabIndex = 4;
            this.radioCCorCS.Text = "f_{cc,dead} or f_{cs,dead}";
            this.toolTip1.SetToolTip(this.radioCCorCS, "Cell death occurs when cell-cell or cell-substrate connection energy with neighbo" +
        "ring prisms is zero");
            this.radioCCorCS.UseVisualStyleBackColor = true;
            this.radioCCorCS.CheckedChanged += new System.EventHandler(this.RadioCCorCS_CheckedChanged);
            // 
            // radioCS
            // 
            this.radioCS.AutoSize = true;
            this.radioCS.Location = new System.Drawing.Point(6, 44);
            this.radioCS.Name = "radioCS";
            this.radioCS.Size = new System.Drawing.Size(75, 16);
            this.radioCS.TabIndex = 2;
            this.radioCS.Text = "f_{cs,dead}";
            this.toolTip1.SetToolTip(this.radioCS, "Cell death occurs when cell-substrate connection energy with neighboring prisms i" +
        "s zero");
            this.radioCS.UseVisualStyleBackColor = true;
            this.radioCS.CheckedChanged += new System.EventHandler(this.RadioCS_CheckedChanged);
            // 
            // radioCC
            // 
            this.radioCC.AutoSize = true;
            this.radioCC.Checked = true;
            this.radioCC.Location = new System.Drawing.Point(6, 22);
            this.radioCC.Name = "radioCC";
            this.radioCC.Size = new System.Drawing.Size(75, 16);
            this.radioCC.TabIndex = 1;
            this.radioCC.TabStop = true;
            this.radioCC.Text = "f_{cc,dead}";
            this.toolTip1.SetToolTip(this.radioCC, "Cell death occurs when cell-cell connection energy with neighboring prisms is zer" +
        "o");
            this.radioCC.UseVisualStyleBackColor = true;
            this.radioCC.CheckedChanged += new System.EventHandler(this.RadioCC_CheckedChanged);
            // 
            // CellDeath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.checkModuleAvailable);
            this.Controls.Add(this.groupBox1);
            this.Name = "CellDeath";
            this.Size = new System.Drawing.Size(165, 122);
            this.Load += new System.EventHandler(this.CellDeath_Load);
            this.VisibleChanged += new System.EventHandler(this.CellDeath_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkModuleAvailable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioCCandCS;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton radioCCorCS;
        private System.Windows.Forms.RadioButton radioCS;
        private System.Windows.Forms.RadioButton radioCC;
    }
}
