namespace Normalization
{
    partial class Form1
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxSaveFolder = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonSaveFolder = new System.Windows.Forms.Button();
            this.textBoxOpenFolder = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textPattern = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSaveFolder
            // 
            this.textBoxSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSaveFolder.Location = new System.Drawing.Point(113, 86);
            this.textBoxSaveFolder.Name = "textBoxSaveFolder";
            this.textBoxSaveFolder.Size = new System.Drawing.Size(215, 19);
            this.textBoxSaveFolder.TabIndex = 7;
            this.textBoxSaveFolder.TextChanged += new System.EventHandler(this.TextBoxSaveFolder_TextChanged);
            this.textBoxSaveFolder.Leave += new System.EventHandler(this.TextBoxSaveFolder_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "Open folder";
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFolder.Location = new System.Drawing.Point(334, 61);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(19, 19);
            this.buttonOpenFolder.TabIndex = 5;
            this.buttonOpenFolder.Text = "...";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            this.buttonOpenFolder.Click += new System.EventHandler(this.ButtonOpenFolder_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "Save folder";
            // 
            // buttonSaveFolder
            // 
            this.buttonSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveFolder.Location = new System.Drawing.Point(334, 86);
            this.buttonSaveFolder.Name = "buttonSaveFolder";
            this.buttonSaveFolder.Size = new System.Drawing.Size(19, 19);
            this.buttonSaveFolder.TabIndex = 8;
            this.buttonSaveFolder.Text = "...";
            this.buttonSaveFolder.UseVisualStyleBackColor = true;
            this.buttonSaveFolder.Click += new System.EventHandler(this.ButtonSaveFolder_Click);
            // 
            // textBoxOpenFolder
            // 
            this.textBoxOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOpenFolder.Location = new System.Drawing.Point(113, 61);
            this.textBoxOpenFolder.Name = "textBoxOpenFolder";
            this.textBoxOpenFolder.Size = new System.Drawing.Size(215, 19);
            this.textBoxOpenFolder.TabIndex = 4;
            this.textBoxOpenFolder.TextChanged += new System.EventHandler(this.TextBoxOpenFolder_TextChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(278, 111);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 11;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "exe";
            this.openFileDialog1.FileName = "vidro.exe";
            this.openFileDialog1.Filter = "Executable|*.exe";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "step_0000-0060";
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Reference_Time(tref)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Normalization_MovementRate_RouteDistance(C#)_Output";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "File name pattern";
            // 
            // textPattern
            // 
            this.textPattern.Location = new System.Drawing.Point(113, 36);
            this.textPattern.Name = "textPattern";
            this.textPattern.Size = new System.Drawing.Size(130, 19);
            this.textPattern.TabIndex = 2;
            this.textPattern.Text = "out_MovRate_*.csv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 146);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textPattern);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxSaveFolder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonOpenFolder);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonSaveFolder);
            this.Controls.Add(this.textBoxOpenFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(381, 185);
            this.Name = "Form1";
            this.Text = "Normalization";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSaveFolder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSaveFolder;
        private System.Windows.Forms.TextBox textBoxOpenFolder;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPattern;
    }
}

