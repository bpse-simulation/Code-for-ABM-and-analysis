namespace BPSE
{
    partial class ColorMap
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
            this.groupBoxLUT = new System.Windows.Forms.GroupBox();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonGetLUT = new System.Windows.Forms.Button();
            this.textMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textMin = new System.Windows.Forms.TextBox();
            this.comboBoxLUT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxLUT.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLUT
            // 
            this.groupBoxLUT.Controls.Add(this.buttonReload);
            this.groupBoxLUT.Controls.Add(this.buttonGetLUT);
            this.groupBoxLUT.Controls.Add(this.textMax);
            this.groupBoxLUT.Controls.Add(this.label3);
            this.groupBoxLUT.Controls.Add(this.textMin);
            this.groupBoxLUT.Controls.Add(this.comboBoxLUT);
            this.groupBoxLUT.Controls.Add(this.label2);
            this.groupBoxLUT.Controls.Add(this.label1);
            this.groupBoxLUT.Location = new System.Drawing.Point(0, 0);
            this.groupBoxLUT.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxLUT.Name = "groupBoxLUT";
            this.groupBoxLUT.Size = new System.Drawing.Size(226, 68);
            this.groupBoxLUT.TabIndex = 0;
            this.groupBoxLUT.TabStop = false;
            this.groupBoxLUT.Text = "Color map";
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(174, 42);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(20, 20);
            this.buttonReload.TabIndex = 6;
            this.buttonReload.Text = "↻";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.ButtonReload_Click);
            // 
            // buttonGetLUT
            // 
            this.buttonGetLUT.Location = new System.Drawing.Point(200, 42);
            this.buttonGetLUT.Name = "buttonGetLUT";
            this.buttonGetLUT.Size = new System.Drawing.Size(20, 20);
            this.buttonGetLUT.TabIndex = 7;
            this.buttonGetLUT.Text = "...";
            this.buttonGetLUT.UseVisualStyleBackColor = true;
            this.buttonGetLUT.Click += new System.EventHandler(this.ButtonGetLUT_Click);
            // 
            // textMax
            // 
            this.textMax.Location = new System.Drawing.Point(133, 17);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(60, 19);
            this.textMax.TabIndex = 3;
            this.textMax.Text = "1";
            this.textMax.TextChanged += new System.EventHandler(this.TextMax_TextChanged);
            this.textMax.Enter += new System.EventHandler(this.TextMax_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "LUT";
            // 
            // textMin
            // 
            this.textMin.Location = new System.Drawing.Point(35, 17);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(60, 19);
            this.textMin.TabIndex = 1;
            this.textMin.Text = "0";
            this.textMin.TextChanged += new System.EventHandler(this.TextMin_TextChanged);
            this.textMin.Enter += new System.EventHandler(this.TextMin_Enter);
            // 
            // comboBoxLUT
            // 
            this.comboBoxLUT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLUT.DropDownWidth = 60;
            this.comboBoxLUT.FormattingEnabled = true;
            this.comboBoxLUT.Location = new System.Drawing.Point(38, 42);
            this.comboBoxLUT.Name = "comboBoxLUT";
            this.comboBoxLUT.Size = new System.Drawing.Size(130, 20);
            this.comboBoxLUT.TabIndex = 5;
            this.comboBoxLUT.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLUT_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Min";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select LUT directory. The folder \"luts\" is located in the folder where the ImageJ" +
    " \".exe\" file exists.";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // ColorMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBoxLUT);
            this.Name = "ColorMap";
            this.Size = new System.Drawing.Size(226, 68);
            this.Load += new System.EventHandler(this.ColorMap_Load);
            this.groupBoxLUT.ResumeLayout(false);
            this.groupBoxLUT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLUT;
        private System.Windows.Forms.Button buttonGetLUT;
        private System.Windows.Forms.TextBox textMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMin;
        private System.Windows.Forms.ComboBox comboBoxLUT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonReload;
    }
}
