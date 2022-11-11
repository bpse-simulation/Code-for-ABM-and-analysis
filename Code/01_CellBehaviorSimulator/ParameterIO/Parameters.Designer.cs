namespace CellBehaviorSimulator.ParameterIO
{
    partial class Parameters
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEnvironment = new System.Windows.Forms.TabPage();
            this.environment1 = new CellBehaviorSimulator.CultureEnvironments.Environments();
            this.tabPageBehavior = new System.Windows.Forms.TabPage();
            this.behavior1 = new CellBehaviorSimulator.CellBehaviors.Behaviors();
            this.tabPageOperation = new System.Windows.Forms.TabPage();
            this.operation1 = new CellBehaviorSimulator.CultureOperations.Operations();
            this.tabPageOutput = new System.Windows.Forms.TabPage();
            this.output1 = new CellBehaviorSimulator.Output();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.display1 = new CellBehaviorSimulator.Display();
            this.tabControl1.SuspendLayout();
            this.tabPageEnvironment.SuspendLayout();
            this.tabPageBehavior.SuspendLayout();
            this.tabPageOperation.SuspendLayout();
            this.tabPageOutput.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageEnvironment);
            this.tabControl1.Controls.Add(this.tabPageBehavior);
            this.tabControl1.Controls.Add(this.tabPageOperation);
            this.tabControl1.Controls.Add(this.tabPageOutput);
            this.tabControl1.Controls.Add(this.tabDisplay);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 420);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPageEnvironment
            // 
            this.tabPageEnvironment.AutoScroll = true;
            this.tabPageEnvironment.Controls.Add(this.environment1);
            this.tabPageEnvironment.Location = new System.Drawing.Point(4, 22);
            this.tabPageEnvironment.Name = "tabPageEnvironment";
            this.tabPageEnvironment.Size = new System.Drawing.Size(482, 394);
            this.tabPageEnvironment.TabIndex = 0;
            this.tabPageEnvironment.Text = "Environment";
            this.tabPageEnvironment.UseVisualStyleBackColor = true;
            // 
            // environment1
            // 
            this.environment1.AutoSize = true;
            this.environment1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.environment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.environment1.Location = new System.Drawing.Point(0, 0);
            this.environment1.Name = "environment1";
            this.environment1.Size = new System.Drawing.Size(482, 394);
            this.environment1.TabIndex = 1;
            // 
            // tabPageBehavior
            // 
            this.tabPageBehavior.AutoScroll = true;
            this.tabPageBehavior.Controls.Add(this.behavior1);
            this.tabPageBehavior.Location = new System.Drawing.Point(4, 22);
            this.tabPageBehavior.Name = "tabPageBehavior";
            this.tabPageBehavior.Size = new System.Drawing.Size(482, 394);
            this.tabPageBehavior.TabIndex = 0;
            this.tabPageBehavior.Text = "Cell behaviors";
            this.tabPageBehavior.UseVisualStyleBackColor = true;
            // 
            // behavior1
            // 
            this.behavior1.AutoSize = true;
            this.behavior1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.behavior1.Dock = System.Windows.Forms.DockStyle.Top;
            this.behavior1.Location = new System.Drawing.Point(0, 0);
            this.behavior1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.behavior1.Name = "behavior1";
            this.behavior1.Size = new System.Drawing.Size(465, 403);
            this.behavior1.TabIndex = 0;
            // 
            // tabPageOperation
            // 
            this.tabPageOperation.Controls.Add(this.operation1);
            this.tabPageOperation.Location = new System.Drawing.Point(4, 22);
            this.tabPageOperation.Name = "tabPageOperation";
            this.tabPageOperation.Size = new System.Drawing.Size(482, 394);
            this.tabPageOperation.TabIndex = 2;
            this.tabPageOperation.Text = "Operations";
            this.tabPageOperation.UseVisualStyleBackColor = true;
            // 
            // operation1
            // 
            this.operation1.AutoSize = true;
            this.operation1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.operation1.Dock = System.Windows.Forms.DockStyle.Top;
            this.operation1.Location = new System.Drawing.Point(0, 0);
            this.operation1.Name = "operation1";
            this.operation1.Size = new System.Drawing.Size(482, 134);
            this.operation1.TabIndex = 1;
            // 
            // tabPageOutput
            // 
            this.tabPageOutput.Controls.Add(this.output1);
            this.tabPageOutput.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutput.Name = "tabPageOutput";
            this.tabPageOutput.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutput.Size = new System.Drawing.Size(482, 394);
            this.tabPageOutput.TabIndex = 1;
            this.tabPageOutput.Text = "Output";
            this.tabPageOutput.UseVisualStyleBackColor = true;
            // 
            // output1
            // 
            this.output1.AutoScroll = true;
            this.output1.AutoSize = true;
            this.output1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.output1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output1.Location = new System.Drawing.Point(3, 3);
            this.output1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.output1.Name = "output1";
            this.output1.Size = new System.Drawing.Size(476, 388);
            this.output1.TabIndex = 0;
            // 
            // tabDisplay
            // 
            this.tabDisplay.Controls.Add(this.display1);
            this.tabDisplay.Location = new System.Drawing.Point(4, 22);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisplay.Size = new System.Drawing.Size(482, 394);
            this.tabDisplay.TabIndex = 3;
            this.tabDisplay.Text = "Display";
            this.tabDisplay.UseVisualStyleBackColor = true;
            // 
            // display1
            // 
            this.display1.AutoSize = true;
            this.display1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.display1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display1.Location = new System.Drawing.Point(3, 3);
            this.display1.Name = "display1";
            this.display1.Size = new System.Drawing.Size(476, 388);
            this.display1.TabIndex = 4;
            // 
            // Parameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Parameters";
            this.Size = new System.Drawing.Size(490, 420);
            this.Load += new System.EventHandler(this.Parameters_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageEnvironment.ResumeLayout(false);
            this.tabPageEnvironment.PerformLayout();
            this.tabPageBehavior.ResumeLayout(false);
            this.tabPageBehavior.PerformLayout();
            this.tabPageOperation.ResumeLayout(false);
            this.tabPageOperation.PerformLayout();
            this.tabPageOutput.ResumeLayout(false);
            this.tabPageOutput.PerformLayout();
            this.tabDisplay.ResumeLayout(false);
            this.tabDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageEnvironment;
        private CultureEnvironments.Environments environment1;
        private System.Windows.Forms.TabPage tabPageBehavior;
        private CellBehaviors.Behaviors behavior1;
        private System.Windows.Forms.TabPage tabPageOperation;
        private CultureOperations.Operations operation1;
        private System.Windows.Forms.TabPage tabPageOutput;
        private Output output1;
        private System.Windows.Forms.TabPage tabDisplay;
        private Display display1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}
