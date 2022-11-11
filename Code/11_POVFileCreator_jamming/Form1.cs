using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPSE;

namespace MQOFileCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void Form1_Load(object sender, EventArgs e)
        {
            // 入力パラメータ
            Xsize = (int)numXsize.Value;
            Ysize = (int)numYsize.Value;
            Column = (int)numColumn.Value;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ver20220124");
        }

        private void ButtonOpenFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select folder (CellsData, MovementRate, etc.)";
            if (Directory.Exists(openfolder))
            { folderBrowserDialog1.SelectedPath = openfolder; }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxOpenFolderPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void TextOpenFolderPath_TextChanged(object sender, EventArgs e)
        {
            openfolder = textBoxOpenFolderPath.Text;
        }
        private void ButtonOpenFolderSubstrate_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select folder (Substrate)";
            if (Directory.Exists(openfolderSub))
            { folderBrowserDialog1.SelectedPath = openfolderSub; }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxOpenFolderPathSubstrate.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void TextBoxOpenFolderPathSubstrate_TextChanged(object sender, EventArgs e)
        {
            openfolderSub = textBoxOpenFolderPathSubstrate.Text;
        }
        private void ButtonSaveFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "保存先のフォルダを選ぶ。";
            if (Directory.Exists(savefolder))
            { folderBrowserDialog1.SelectedPath = savefolder; }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxSaveFolderPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void TextSaveFolderPath_TextChanged(object sender, EventArgs e)
        {
            savefolder = textBoxSaveFolderPath.Text;
        }
        private void TextSaveFolderPath_Leave(object sender, EventArgs e)
        {
            if (textBoxSaveFolderPath.Text != "")
            {
                if (Directory.Exists(textBoxSaveFolderPath.Text))
                { savefolder = textBoxSaveFolderPath.Text; }
                else
                {
                    DialogResult dr = MessageBox.Show("The given path does not refer to an existing directory on disk.\nCreate a new folder : "
                        + textBoxSaveFolderPath.Text, "Caution", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            Directory.CreateDirectory(textBoxSaveFolderPath.Text);
                            savefolder = textBoxSaveFolderPath.Text;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Can not create a new folder.");
                            textBoxSaveFolderPath.Focus();
                            textBoxSaveFolderPath.SelectAll();
                        }
                    }
                    else
                    {
                        textBoxSaveFolderPath.Focus();
                        textBoxSaveFolderPath.SelectAll();
                    }
                }
            }
        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (cell && textBoxOpenFolderPath.Text == "")
            {
                MessageBox.Show("Select open folder path.");
            }
            else if (cell && !Directory.Exists(openfolder))
            {
                MessageBox.Show("Error: " + openfolder);
            }
            else if (substrate && textBoxOpenFolderPathSubstrate.Text == "")
            {
                MessageBox.Show("Select open substrate folder path.");
            }
            else if (substrate && !Directory.Exists(openfolderSub))
            {
                MessageBox.Show("Error: " + openfolderSub);
            }
            else if (textBoxSaveFolderPath.Text == "")
            {
                MessageBox.Show("Selsect save folder path.");
            }
            else if (!Directory.Exists(savefolder))
            {
                MessageBox.Show("Error: " + savefolder);
            }
            else
            {
                RunAsync();
            }
        }
        private void CheckBoxCellsData_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCellsData.Enabled = checkBoxCellsData.Checked;
            cell = checkBoxCellsData.Checked;
        }
        private void CheckBoxSubstrate_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxSubstrate.Enabled = checkBoxSubstrate.Checked;
            substrate = checkBoxSubstrate.Checked;
        }
        private void numXsize_ValueChanged(object sender, EventArgs e)
        {
            Xsize = (int)numXsize.Value;
        }
        private void numYsize_ValueChanged(object sender, EventArgs e)
        {
            Ysize = (int)numYsize.Value;
        }
        private void numColumn_ValueChanged(object sender, EventArgs e)
        {
            Column = (int)numColumn.Value;
        }
        #endregion

        private string openfolder = "", openfolderSub = "", savefolder = "";
        private bool cell, substrate;
        private int Xsize, Ysize, Column;
        private Color contourColor;

        private async void RunAsync()
        {
            contourColor = colorDialog1.Color;

            panel1.Enabled = false;
            buttonStart.Enabled = false;
            ProgressBar1.Visible = true;
            StatusLabel1.Visible = true;
            ProgressBar1.Value = 0;
            StatusLabel1.Text = "";
            var progress = new Progress<int>(OnProgressChanged);
            await Task.Run(() => DoWork(progress));
            panel1.Enabled = true;
            buttonStart.Enabled = true;
            ProgressBar1.Visible = false;
            StatusLabel1.Visible = false;
        }

        private void CheckBoxTransparent_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownTargetCellIndex.Enabled = checkBoxHighlight.Checked;
            labelTargetCellIndex.Enabled = checkBoxHighlight.Checked;
        }

        private void OnProgressChanged(int count)
        {
            ProgressBar1.Value = count;
            StatusLabel1.Text = count + " %";
        }

        private void DoWork(IProgress<int> iProgress)
        {
            string[] filesCell = Directory.Exists(openfolder) ? Directory.GetFiles(openfolder, "*.csv") : null;
            string[] filesSub = Directory.Exists(openfolderSub) ? Directory.GetFiles(openfolderSub, "*.csv") : null;

            int len = GetFileLength(filesCell, filesSub);
            if (len == 0)
            { return; }

            // 保存ファイル名
            string fileNameini = Path.Combine(savefolder, "povray.ini");
            // iniファイル作成
            using (StreamWriter sw = new StreamWriter(File.Open(fileNameini, FileMode.Create)))
            {
                sw.WriteLine("Width = 1600");
                sw.WriteLine("Height = 1200");
                sw.WriteLine("Antialias = Off");
                sw.WriteLine("+ua");
            }

            // 時間経過のループ
            for (int p = 0; p < len; p++) 
            {
                // Report progress
                iProgress.Report((int)(100.0 * (p + 1) / len));

                string filenameCell = filesCell != null ? Path.GetFileName(filesCell[p]) : "";
                string pathCell = Path.Combine(openfolder, filenameCell);
                string filenameSub = filesSub != null ? Path.GetFileName(filesSub[p]) : "";
                string pathSub = Path.Combine(openfolderSub, filenameSub);
                if (cell && substrate)
                {
                    // 保存ファイル名
                    string fileName = Path.Combine(savefolder, Path.GetFileNameWithoutExtension(filenameSub) + "_" + Path.GetFileNameWithoutExtension(filenameCell) + ".pov");
                    // データ読み書き
                    using (StreamWriter sw = new StreamWriter(File.Open(fileName, FileMode.Create)))
                    {
                        sw.WriteLine(textBoxHeader.Text);

                        sw.WriteLine(POVConverter.Start());
                        ReadWriteSubstrate(sw, pathSub);
                        ReadWriteCell(sw, pathCell);
                        //sw.WriteLine(POVConverter.End());
                    }
                }
                else if (cell && !substrate)
                {
                    // 保存ファイル名
                    string fileName = Path.Combine(savefolder, Path.GetFileNameWithoutExtension(filenameCell) + ".pov");
                    // データ読み書き
                    using (StreamWriter sw = new StreamWriter(File.Open(fileName, FileMode.Create)))
                    {
                        sw.WriteLine(textBoxHeader.Text);

                        sw.WriteLine(POVConverter.Start());
                        // 基質の代わりのものを描画
                        sw.Write(POVConverter.Polygon(Xsize, Ysize, Color.Gray));

                        ReadWriteCell(sw, pathCell);
                        //sw.WriteLine(POVConverter.End());
                    }
                }
                else if (!cell && substrate)
                {
                    // 保存ファイル名
                    string fileName = Path.Combine(savefolder, Path.GetFileNameWithoutExtension(filenameSub) + ".pov");
                    // データ読み書き
                    using (StreamWriter sw = new StreamWriter(File.Open(fileName, FileMode.Create)))
                    {
                        sw.WriteLine(textBoxHeader.Text);

                        sw.WriteLine(POVConverter.Start());
                        ReadWriteSubstrate(sw, pathSub);
                        //sw.WriteLine(POVConverter.End());
                    }
                }
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void ReadWriteCell(StreamWriter sw, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (StreamReader sr = new StreamReader(fs))
            {
                // ヘッダー行の読み飛ばし
                string[] header = sr.ReadLine().Split(',');
                // インデックスが保存されている列の番号を探す
                int xNum = Array.FindIndex(header, s => s == "hexX");
                int yNum = Array.FindIndex(header, s => s == "hexY");
                int zNum = Array.FindIndex(header, s => s == "hexZ");
                // 読み込み可能であれば
                if (!(xNum == -1 || yNum == -1 || zNum == -1 || header.Length <= Column))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] s = sr.ReadLine().Split(',');
                        if (!int.TryParse(s[0], out int i)) { break; }
                        if (!int.TryParse(s[xNum], out int x)) { break; }
                        if (!int.TryParse(s[yNum], out int y)) { break; }
                        if (!int.TryParse(s[zNum], out int z)) { break; }
                        if (!double.TryParse(s[Column], out double val)) { break; }
                        {
                            if(val==0)
                            {
                                sw.Write(POVConverter.Prism(x, y, z, 0.98, Color.FromArgb(0, 0, 255)));
                                sw.Write(POVConverter.AddContour(x, y, z, 0.98, Color.FromArgb(100, 100, 100), 0.02));
                            }
                            else if (val == 1)
                            {
                                sw.Write(POVConverter.Prism(x, y, z, 0.98, Color.FromArgb(255, 255, 255)));
                                sw.Write(POVConverter.AddContour(x, y, z, 0.98, Color.FromArgb(100, 100, 100), 0.02));
                            }
                            else if (val == 2)
                            {
                                sw.Write(POVConverter.Prism(x, y, z, 0.98, Color.FromArgb(255, 255, 255)));
                                sw.Write(POVConverter.AddContour(x, y, z, 0.98, Color.FromArgb(100, 100, 100), 0.02));
                            }
                            else if (val == 3)
                            {
                                sw.Write(POVConverter.Prism(x, y, z, 0.98, Color.FromArgb(0, 0, 255)));
                                sw.Write(POVConverter.AddContour(x, y, z, 0.98, Color.FromArgb(100, 100, 100), 0.02));
                            }
                            else if (val == 4)
                            {
                                sw.Write(POVConverter.Prism(x, y, z, 0.98, Color.FromArgb(255, 255, 255)));
                                sw.Write(POVConverter.AddContour(x, y, z, 0.98, Color.FromArgb(0, 255, 0), 0.02));
                            }
                            else if (val == 5)
                            {
                                sw.Write(POVConverter.Prism(x, y, z, 0.98, Color.FromArgb(0, 0, 255)));
                                sw.Write(POVConverter.AddContour(x, y, z, 0.98, Color.FromArgb(100, 100, 100), 0.02));
                            }
                            else if (val == 6)
                            {
                                sw.Write(POVConverter.Prism(x, y, z, 0.98, Color.FromArgb(255, 255, 255)));
                                sw.Write(POVConverter.AddContour(x, y, z, 0.98, Color.FromArgb(255, 0, 0), 0.02));
                            }

                        }
                    }
                }
            }
        }

        private void ReadWriteSubstrate(StreamWriter sw, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (StreamReader sr = new StreamReader(fs))
            {
                // ヘッダー行の読み飛ばし
                string[] header = sr.ReadLine().Split(',');
                // インデックスが保存されている列の番号を探す
                int xNum = Array.FindIndex(header, s => s == "hexX");
                int yNum = Array.FindIndex(header, s => s == "hexY");
                int zNum = Array.FindIndex(header, s => s == "hexZ");
                int e_s = Array.FindIndex(header, s => s == "e_s");
                // 読み込み可能であれば
                if (!(xNum == -1 || yNum == -1 || zNum == -1 || e_s == -1))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] s = sr.ReadLine().Split(',');
                        if (!int.TryParse(s[0], out int i)) { break; }
                        if (!int.TryParse(s[xNum], out int x)) { break; }
                        if (!int.TryParse(s[yNum], out int y)) { break; }
                        if (!int.TryParse(s[zNum], out int z)) { break; }
                        if (!double.TryParse(s[e_s], out double val)) { break; }
                        sw.Write(POVConverter.Prism(x, y, z, 1, colorMapSubstrate.GetColor(val)));
                    }
                }
            }
        }

        private static int GetFileLength(string[] filesCell, string[] filesSub)
        {
            int len;
            if (filesCell != null)
            {
                if (filesSub != null)
                {
                    len = filesCell.Length == filesSub.Length ? filesCell.Length : 0;
                }
                else
                {
                    len = filesCell.Length;
                }
            }
            else
            {
                len = filesSub != null ? filesSub.Length : 0;
            }
            return len;
        }
    }
}
