namespace CellBehaviorSimulator.CellBehaviors
{
    partial class Behaviors
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
            this.label1 = new System.Windows.Forms.Label();
            this.num_NumOfCellT = new System.Windows.Forms.NumericUpDown();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.num_CellT = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cellCellConnection1 = new CellBehaviorSimulator.CellBehaviors.CellCellConnection();
            this.cellSubstConnection1 = new CellBehaviorSimulator.CellBehaviors.CellSubstrateConnection();
            this.justAfterSeeding1 = new CellBehaviorSimulator.CellBehaviors.AfterSeeding();
            this.division1 = new CellBehaviorSimulator.CellBehaviors.Division();
            this.migration1 = new CellBehaviorSimulator.CellBehaviors.Migration();
            this.differentiation_Epithelium1 = new CellBehaviorSimulator.CellBehaviors.Differentiation_Epithelium();
            this.deviation_hiPSC1 = new CellBehaviorSimulator.CellBehaviors.Deviation_hiPSC();
            this.cellDeath1 = new CellBehaviorSimulator.CellBehaviors.CellDeath();
            this.areaWeighting1 = new CellBehaviorSimulator.CellBehaviors.AreaWeighting();
            this.BehaviorList = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.basicConnectionEnergy1 = new CellBehaviorSimulator.CellBehaviors.BasicConnectionEnergy();
            this.cellName1 = new CellBehaviorSimulator.CellName();
            ((System.ComponentModel.ISupportInitialize)(this.num_NumOfCellT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CellT)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of cell types required:";
            // 
            // num_NumOfCellT
            // 
            this.num_NumOfCellT.Location = new System.Drawing.Point(183, 20);
            this.num_NumOfCellT.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_NumOfCellT.Name = "num_NumOfCellT";
            this.num_NumOfCellT.Size = new System.Drawing.Size(40, 19);
            this.num_NumOfCellT.TabIndex = 2;
            this.num_NumOfCellT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_NumOfCellT.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_NumOfCellT.ValueChanged += new System.EventHandler(this.Num_NumOfCellT_ValueChanged);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 0);
            this.hScrollBar1.Maximum = 0;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(459, 17);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Visible = false;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.HScrollBar1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cell type (Cell_T) number to edit:";
            // 
            // num_CellT
            // 
            this.num_CellT.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.num_CellT.Location = new System.Drawing.Point(183, 45);
            this.num_CellT.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.num_CellT.Name = "num_CellT";
            this.num_CellT.Size = new System.Drawing.Size(40, 19);
            this.num_CellT.TabIndex = 4;
            this.num_CellT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_CellT.ValueChanged += new System.EventHandler(this.Num_CellT_ValueChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.cellCellConnection1);
            this.flowLayoutPanel1.Controls.Add(this.cellSubstConnection1);
            this.flowLayoutPanel1.Controls.Add(this.justAfterSeeding1);
            this.flowLayoutPanel1.Controls.Add(this.division1);
            this.flowLayoutPanel1.Controls.Add(this.migration1);
            this.flowLayoutPanel1.Controls.Add(this.differentiation_Epithelium1);
            this.flowLayoutPanel1.Controls.Add(this.deviation_hiPSC1);
            this.flowLayoutPanel1.Controls.Add(this.cellDeath1);
            this.flowLayoutPanel1.Controls.Add(this.areaWeighting1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(229, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(227, 1031);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // cellCellConnection1
            // 
            this.cellCellConnection1.AutoSize = true;
            this.cellCellConnection1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cellCellConnection1.Location = new System.Drawing.Point(3, 3);
            this.cellCellConnection1.Name = "cellCellConnection1";
            this.cellCellConnection1.Size = new System.Drawing.Size(193, 55);
            this.cellCellConnection1.TabIndex = 0;
            // 
            // cellSubstConnection1
            // 
            this.cellSubstConnection1.AutoSize = true;
            this.cellSubstConnection1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cellSubstConnection1.Location = new System.Drawing.Point(3, 64);
            this.cellSubstConnection1.Name = "cellSubstConnection1";
            this.cellSubstConnection1.Size = new System.Drawing.Size(166, 19);
            this.cellSubstConnection1.TabIndex = 1;
            // 
            // justAfterSeeding1
            // 
            this.justAfterSeeding1.AutoSize = true;
            this.justAfterSeeding1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.justAfterSeeding1.Location = new System.Drawing.Point(3, 89);
            this.justAfterSeeding1.Name = "justAfterSeeding1";
            this.justAfterSeeding1.Size = new System.Drawing.Size(204, 105);
            this.justAfterSeeding1.TabIndex = 2;
            // 
            // division1
            // 
            this.division1.AutoSize = true;
            this.division1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.division1.Location = new System.Drawing.Point(3, 200);
            this.division1.Name = "division1";
            this.division1.Size = new System.Drawing.Size(213, 281);
            this.division1.TabIndex = 3;
            // 
            // migration1
            // 
            this.migration1.AutoSize = true;
            this.migration1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.migration1.Location = new System.Drawing.Point(3, 487);
            this.migration1.Name = "migration1";
            this.migration1.Size = new System.Drawing.Size(221, 105);
            this.migration1.TabIndex = 4;
            // 
            // differentiation_Epithelium1
            // 
            this.differentiation_Epithelium1.AutoSize = true;
            this.differentiation_Epithelium1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.differentiation_Epithelium1.Location = new System.Drawing.Point(3, 598);
            this.differentiation_Epithelium1.Name = "differentiation_Epithelium1";
            this.differentiation_Epithelium1.Size = new System.Drawing.Size(171, 55);
            this.differentiation_Epithelium1.TabIndex = 5;
            // 
            // deviation_hiPSC1
            // 
            this.deviation_hiPSC1.AutoSize = true;
            this.deviation_hiPSC1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deviation_hiPSC1.Location = new System.Drawing.Point(3, 659);
            this.deviation_hiPSC1.Name = "deviation_hiPSC1";
            this.deviation_hiPSC1.Size = new System.Drawing.Size(175, 180);
            this.deviation_hiPSC1.TabIndex = 7;
            // 
            // cellDeath1
            // 
            this.cellDeath1.AutoSize = true;
            this.cellDeath1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cellDeath1.Location = new System.Drawing.Point(3, 845);
            this.cellDeath1.Name = "cellDeath1";
            this.cellDeath1.Size = new System.Drawing.Size(165, 122);
            this.cellDeath1.TabIndex = 8;
            // 
            // areaWeighting1
            // 
            this.areaWeighting1.AutoSize = true;
            this.areaWeighting1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.areaWeighting1.Location = new System.Drawing.Point(3, 973);
            this.areaWeighting1.Name = "areaWeighting1";
            this.areaWeighting1.Size = new System.Drawing.Size(137, 55);
            this.areaWeighting1.TabIndex = 9;
            // 
            // BehaviorList
            // 
            this.BehaviorList.CheckOnClick = true;
            this.BehaviorList.FormattingEnabled = true;
            this.BehaviorList.Items.AddRange(new object[] {
            "Cell-cell connection",
            "Cell-substrate connection",
            "Just after seeding",
            "Division",
            "Migration",
            "Differentiation: Epithelium",
            "Deviation: hiPSC",
            "Cell death",
            "Area weighting"});
            this.BehaviorList.Location = new System.Drawing.Point(3, 256);
            this.BehaviorList.Name = "BehaviorList";
            this.BehaviorList.Size = new System.Drawing.Size(220, 130);
            this.BehaviorList.TabIndex = 6;
            this.BehaviorList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.BehaviorList_ItemCheck);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select cell behavior module";
            // 
            // basicConnectionEnergy1
            // 
            this.basicConnectionEnergy1.AutoSize = true;
            this.basicConnectionEnergy1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.basicConnectionEnergy1.Location = new System.Drawing.Point(3, 95);
            this.basicConnectionEnergy1.Name = "basicConnectionEnergy1";
            this.basicConnectionEnergy1.Size = new System.Drawing.Size(217, 155);
            this.basicConnectionEnergy1.TabIndex = 6;
            // 
            // cellName1
            // 
            this.cellName1.AutoSize = true;
            this.cellName1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cellName1.Location = new System.Drawing.Point(5, 68);
            this.cellName1.Margin = new System.Windows.Forms.Padding(1);
            this.cellName1.Name = "cellName1";
            this.cellName1.Size = new System.Drawing.Size(220, 23);
            this.cellName1.TabIndex = 5;
            // 
            // Behaviors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.basicConnectionEnergy1);
            this.Controls.Add(this.BehaviorList);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.num_CellT);
            this.Controls.Add(this.cellName1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_NumOfCellT);
            this.Controls.Add(this.hScrollBar1);
            this.Name = "Behaviors";
            this.Size = new System.Drawing.Size(459, 1054);
            this.Load += new System.EventHandler(this.Input_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_NumOfCellT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CellT)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_NumOfCellT;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.NumericUpDown num_CellT;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckedListBox BehaviorList;
        private CellBehaviorSimulator.CellName cellName1;
        private CellBehaviorSimulator.CellBehaviors.AfterSeeding justAfterSeeding1;
        private CellBehaviorSimulator.CellBehaviors.Division division1;
        private CellBehaviorSimulator.CellBehaviors.Migration migration1;
        private CellBehaviorSimulator.CellBehaviors.Differentiation_Epithelium differentiation_Epithelium1;
        private CellBehaviorSimulator.CellBehaviors.CellDeath cellDeath1;
        private CellBehaviorSimulator.CellBehaviors.CellCellConnection cellCellConnection1;
        private CellBehaviorSimulator.CellBehaviors.CellSubstrateConnection cellSubstConnection1;
        private CellBehaviorSimulator.CellBehaviors.AreaWeighting areaWeighting1;
        private CellBehaviorSimulator.CellBehaviors.BasicConnectionEnergy basicConnectionEnergy1;
        private CellBehaviorSimulator.CellBehaviors.Deviation_hiPSC deviation_hiPSC1;
    }
}
