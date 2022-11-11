using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCreator_Ecc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string savefolder;
        private string[] files;
        private int Xsize, Ysize, Zsize;
        private bool srd;

        private void SelectCellsData_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog()
            {
                Filter = "CSV|*.csv",
                Multiselect = true
            };
            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                files = ofDialog.FileNames;
                // Sort
                Array.Sort(files, new LogicalStringComparer());
                FilePaths.Items.Clear();
                for (int i = 0; i < files.Length; i++)
                {
                    FilePaths.Items.Add(files[i]);
                }
            }
        }
        private void SelectSaveFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDialog = new FolderBrowserDialog
            {
                Description = "Select a folder to save the file."
            };
            if (SaveFolderPath.Text != "")
            {
                fbDialog.SelectedPath = SaveFolderPath.Text;
            }
            if (fbDialog.ShowDialog() == DialogResult.OK)
            {
                savefolder = fbDialog.SelectedPath;
                SaveFolderPath.Text = savefolder;
            }
        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            Xsize = (int)NumXsize.Value;
            Ysize = (int)NumYsize.Value;
            Zsize = (int)NumZsize.Value;

            for (int i = 0; i < FilePaths.Items.Count; i++)
            { files[i] = FilePaths.Items[i].ToString(); }
            savefolder = SaveFolderPath.Text;

            srd = SaveRawData.Checked;

            RunAsync();
        }
        private void SaveFolderPath_Leave(object sender, EventArgs e)
        {
            if (SaveFolderPath.Text != "")
            {
                if (!Directory.Exists(SaveFolderPath.Text))
                {
                    DialogResult dr = MessageBox.Show("The given path does not refer to an existing directory on disk.\nCreate a new folder : " + SaveFolderPath.Text, "Caution", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            Directory.CreateDirectory(SaveFolderPath.Text);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Can not create a new folder.");
                            SaveFolderPath.Focus();
                            SaveFolderPath.SelectAll();
                        }
                    }
                    else
                    {
                        SaveFolderPath.Focus();
                        SaveFolderPath.SelectAll();
                    }
                }
            }
        }
        private void SaveFolderPath_TextChanged(object sender, EventArgs e)
        {
            savefolder = SaveFolderPath.Text;
        }
        private void SaveRawData_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveRawData.Checked)
            { colorMap1.Enabled = false; }
            else
            { colorMap1.Enabled = true; }
        }

        private async void RunAsync()
        {
            ProgressBar1.Visible = true;
            StatusLabel1.Visible = true;
            var progress = new Progress<int>(OnProgressChanged);
            await Task.Run(() => DoWork(progress));
            ProgressBar1.Visible = false;
            StatusLabel1.Visible = false;
        }

        private void OnProgressChanged(int count)
        {
            ProgressBar1.Value = count;
            StatusLabel1.Text = count.ToString() + " %";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxBGColor.BackColor = colorDialog1.Color;
            }
        }

        /// <summary>
        /// 実処理
        /// </summary>
        /// <param name="iProgress"></param>
        private void DoWork(IProgress<int> iProgress)
        {
            int column = (int)numColumn.Value;
            for (int p = 0; p < files.Length; p++)
            {
                string textBoxColumn = "";
                string name = files[p];
                // Report progress
                iProgress.Report((int)(100.0 * (p + 1) / files.Length));

                string[] ss = Path.GetFileNameWithoutExtension(name).Split('_');
                string s0 = ss[ss.Length - 1];
                if (double.TryParse(s0, out double t))
                {
                    double[,,] map = new double[Zsize, Ysize, Xsize];
                    bool[,,] bMap = new bool[Zsize, Ysize, Xsize];

                    using (FileStream fs = new FileStream(name, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        // ヘッダー行の読み飛ばし
                        string[] header = sr.ReadLine().Split(',');
                        // インデックスが保存されている列の番号を探す
                        int xNum = Array.FindIndex(header, s => s == "hexX");
                        int yNum = Array.FindIndex(header, s => s == "hexY");
                        int zNum = Array.FindIndex(header, s => s == "hexZ");
                        // 読み込み可能であれば
                        if (!(xNum == -1 || yNum == -1 || zNum == -1 || header.Length <= column))
                        {
                            textBoxColumn = header[column];
                            while (!sr.EndOfStream)
                            {
                                string[] tmp = sr.ReadLine().Split(',');
                                double.TryParse(tmp[xNum], out double hx);
                                double.TryParse(tmp[yNum], out double hy);
                                double.TryParse(tmp[zNum], out double hz);
                                double.TryParse(tmp[column], out double value);
                                if (hz < Zsize && hy < Ysize && hx / 2 < Xsize)
                                {
                                    map[(int)hz, (int)hy, (int)(hx / 2)] = value;
                                    bMap[(int)hz, (int)hy, (int)(hx / 2)] = true;
                                }
                            }
                        }
                    }

                    if (radioButtonXY.Checked)
                    {
                        double[,] map_xy = new double[Ysize, Xsize];
                        bool[,] bMap_xy = new bool[Ysize, Xsize];
                        for (int j = 0; j < Ysize; j++)
                        {
                            for (int i = 0; i < Xsize; i++)
                            {
                                double val = 0;
                                int cnt = 0;
                                for (int k = 0; k < Zsize; k++)
                                {
                                    if (bMap[k, j, i])
                                    {
                                        if (radioButtonMax.Checked)
                                        {
                                            val = Math.Max(val, map[k, j, i]);
                                        }
                                        else
                                        {
                                            val += map[k, j, i];
                                            cnt++;
                                        }
                                        bMap_xy[j, i] = true;
                                    }
                                }
                                if (radioButtonMean.Checked)
                                { map_xy[j, i] = val / cnt; }
                                else
                                { map_xy[j, i] = val; }
                            }
                        }

                        string m = "";
                        if (radioButtonMean.Checked)
                        { m = "Mean_"; }
                        else if (radioButtonMax.Checked)
                        { m = "Max_"; }
                        else if (radioButtonTotal.Checked)
                        { m = "Total_"; }
                        string c = "[" + textBoxColumn.Split(' ')[0] + "]";
                        using (StreamWriter sw = new StreamWriter(File.OpenWrite(Path.Combine(savefolder, Path.GetFileNameWithoutExtension(name) + "_" + m + c + ".csv"))))
                        {
                            sw.WriteLine("Index,hexX,hexY,hexZ," + m + textBoxColumn);
                            int ind = 0;
                            for (int j = 0; j < Ysize; j++)
                            {
                                for (int i = 0; i < Xsize; i++)
                                {
                                    if (bMap_xy[j, i])
                                    {
                                        byte val = colorMap1.GetValue(map_xy[j, i]);
                                        int ii = j % 2 == 0 ? i * 2 : i * 2 + 1;
                                        sw.WriteLine(ind++ + "," + ii + "," + j + ",1," + map_xy[j, i]);
                                    }
                                }
                            }
                        }
                    }
                    else if (radioButtonYZ.Checked)
                    {
                        double[,] map_yz = new double[Zsize, Ysize];
                        bool[,] bMap_yz = new bool[Zsize, Ysize];
                        for (int k = 0; k < Zsize; k++)
                        {
                            for (int j = 0; j < Ysize; j++)
                            {
                                double val = 0;
                                int cnt = 0;
                                for (int i = 0; i < Xsize; i++)
                                {
                                    if (bMap[k, j, i])
                                    {
                                        if (radioButtonMax.Checked)
                                        {
                                            val = Math.Max(val, map[k, j, i]);
                                        }
                                        else
                                        {
                                            val += map[k, j, i];
                                            cnt++;
                                        }
                                        bMap_yz[k, j] = true;
                                    }
                                }
                                if (radioButtonMean.Checked)
                                { map_yz[k, j] = val / cnt; }
                                else
                                { map_yz[k, j] = val; }
                            }
                        }

                        string c = "[" + textBoxColumn.Split(' ')[0] + "]";
                        if (srd)
                        {
                            using (BinaryWriter bw = new BinaryWriter(File.OpenWrite(Path.Combine(savefolder, Path.GetFileNameWithoutExtension(name) + "_" + c + "_yz_64-bit-Real_" + Ysize + "x" + Zsize + ".raw"))))
                            {
                                for (int k = 0; k < Zsize; k++)
                                {
                                    for (int j = 0; j < Ysize; j++)
                                    {
                                        bw.Write(map_yz[Zsize - k - 1, j]);
                                    }
                                }
                            }
                        }
                        else
                        {
                            using (Bitmap bmp = new Bitmap(Ysize, Zsize))
                            {
                                for (int k = 0; k < Zsize; k++)
                                {
                                    for (int j = 0; j < Ysize; j++)
                                    {
                                        if (bMap_yz[k, j])
                                        {
                                            byte val = colorMap1.GetValue(map_yz[k, j]);
                                            colorMap1.GetColor(val, out byte lutR, out byte lutG, out byte lutB);
                                            bmp.SetPixel(j, Zsize - k - 1, Color.FromArgb(lutR, lutG, lutB));
                                        }
                                        else
                                        {
                                            bmp.SetPixel(j, Zsize - k - 1, pictureBoxBGColor.BackColor);
                                        }
                                    }
                                }
                                bmp.Save(Path.Combine(savefolder, Path.GetFileNameWithoutExtension(name) + "_" + c + "_yz.bmp"));
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 大文字小文字を区別せずに、
        /// 文字列内に含まれている数字を考慮して文字列を比較します。
        /// </summary>
        private class LogicalStringComparer :
            System.Collections.IComparer, IComparer<string>
        {
            [System.Runtime.InteropServices.DllImport("shlwapi.dll",
                CharSet = System.Runtime.InteropServices.CharSet.Unicode,
                ExactSpelling = true)]
            private static extern int StrCmpLogicalW(string x, string y);

            public int Compare(string x, string y)
            { return StrCmpLogicalW(x, y); }

            public int Compare(object x, object y)
            { return Compare(x.ToString(), y.ToString()); }
        }
    }
}
