namespace CellBehaviorSimulator.CellBehaviors
{
    partial class Deviation_hiPSC
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
            this.components = new System.ComponentModel.Container();
            this.checkModuleAvailable = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_CellType_devAct = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.num_t_de_crit_app = new System.Windows.Forms.NumericUpDown();
            this.num_t_de_crit_act = new System.Windows.Forms.NumericUpDown();
            this.num_V_de_app = new System.Windows.Forms.NumericUpDown();
            this.num_V_de_act = new System.Windows.Forms.NumericUpDown();
            this.num_CellType_devApparent = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_CellType_devAct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_t_de_crit_app)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_t_de_crit_act)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_V_de_app)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_V_de_act)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CellType_devApparent)).BeginInit();
            this.SuspendLayout();
            // 
            // checkModuleAvailable
            // 
            this.checkModuleAvailable.AutoSize = true;
            this.checkModuleAvailable.Location = new System.Drawing.Point(6, 0);
            this.checkModuleAvailable.Name = "checkModuleAvailable";
            this.checkModuleAvailable.Size = new System.Drawing.Size(109, 16);
            this.checkModuleAvailable.TabIndex = 0;
            this.checkModuleAvailable.Text = "Deviation: hiPSC";
            this.checkModuleAvailable.UseVisualStyleBackColor = true;
            this.checkModuleAvailable.CheckedChanged += new System.EventHandler(this.CheckModuleAvailable_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.num_CellType_devAct);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.num_t_de_crit_app);
            this.groupBox1.Controls.Add(this.num_t_de_crit_act);
            this.groupBox1.Controls.Add(this.num_V_de_app);
            this.groupBox1.Controls.Add(this.num_V_de_act);
            this.groupBox1.Controls.Add(this.num_CellType_devApparent);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 180);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "t_{de,crit,app} (h)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "V_{de,app} (um/h)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "t_{de,crit,act} (h)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "V_{de,act} (um/h)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cell type fate (-)\r\n (apparent)";
            // 
            // num_CellType_devAct
            // 
            this.num_CellType_devAct.Location = new System.Drawing.Point(109, 18);
            this.num_CellType_devAct.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_CellType_devAct.Name = "num_CellType_devAct";
            this.num_CellType_devAct.Size = new System.Drawing.Size(60, 19);
            this.num_CellType_devAct.TabIndex = 1;
            this.num_CellType_devAct.ValueChanged += new System.EventHandler(this.Num_CellTypeAct_ValueChanged);
            this.num_CellType_devAct.VisibleChanged += new System.EventHandler(this.Num_CellTypeMax_VisibleChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cell type fate (-)\r\n (active migration)";
            // 
            // num_t_de_crit_app
            // 
            this.num_t_de_crit_app.DecimalPlaces = 1;
            this.num_t_de_crit_app.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_t_de_crit_app.Location = new System.Drawing.Point(109, 143);
            this.num_t_de_crit_app.Name = "num_t_de_crit_app";
            this.num_t_de_crit_app.Size = new System.Drawing.Size(60, 19);
            this.num_t_de_crit_app.TabIndex = 11;
            this.num_t_de_crit_app.ValueChanged += new System.EventHandler(this.Num_t_de_crit_total_ValueChanged);
            // 
            // num_t_de_crit_act
            // 
            this.num_t_de_crit_act.DecimalPlaces = 1;
            this.num_t_de_crit_act.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_t_de_crit_act.Location = new System.Drawing.Point(109, 118);
            this.num_t_de_crit_act.Name = "num_t_de_crit_act";
            this.num_t_de_crit_act.Size = new System.Drawing.Size(60, 19);
            this.num_t_de_crit_act.TabIndex = 9;
            this.num_t_de_crit_act.ValueChanged += new System.EventHandler(this.Num_t_de_crit_act_ValueChanged);
            // 
            // num_V_de_app
            // 
            this.num_V_de_app.DecimalPlaces = 1;
            this.num_V_de_app.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_V_de_app.Location = new System.Drawing.Point(109, 93);
            this.num_V_de_app.Name = "num_V_de_app";
            this.num_V_de_app.Size = new System.Drawing.Size(60, 19);
            this.num_V_de_app.TabIndex = 7;
            this.num_V_de_app.ValueChanged += new System.EventHandler(this.Num_V_de_total_ValueChanged);
            // 
            // num_V_de_act
            // 
            this.num_V_de_act.DecimalPlaces = 1;
            this.num_V_de_act.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_V_de_act.Location = new System.Drawing.Point(109, 68);
            this.num_V_de_act.Name = "num_V_de_act";
            this.num_V_de_act.Size = new System.Drawing.Size(60, 19);
            this.num_V_de_act.TabIndex = 5;
            this.num_V_de_act.ValueChanged += new System.EventHandler(this.Num_V_de_act_ValueChanged);
            // 
            // num_CellType_devApparent
            // 
            this.num_CellType_devApparent.Location = new System.Drawing.Point(109, 43);
            this.num_CellType_devApparent.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_CellType_devApparent.Name = "num_CellType_devApparent";
            this.num_CellType_devApparent.Size = new System.Drawing.Size(60, 19);
            this.num_CellType_devApparent.TabIndex = 3;
            this.num_CellType_devApparent.ValueChanged += new System.EventHandler(this.Num_CellTypeTotoal_ValueChanged);
            // 
            // Deviation_hiPSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.checkModuleAvailable);
            this.Controls.Add(this.groupBox1);
            this.Name = "Deviation_hiPSC";
            this.Size = new System.Drawing.Size(175, 180);
            this.Load += new System.EventHandler(this.Deviation_hiPSC_Load);
            this.VisibleChanged += new System.EventHandler(this.Deviation_hiPSC_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_CellType_devAct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_t_de_crit_app)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_t_de_crit_act)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_V_de_app)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_V_de_act)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CellType_devApparent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkModuleAvailable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown num_V_de_act;
        private System.Windows.Forms.NumericUpDown num_CellType_devApparent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_CellType_devAct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_V_de_app;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_t_de_crit_app;
        private System.Windows.Forms.NumericUpDown num_t_de_crit_act;
    }
}
