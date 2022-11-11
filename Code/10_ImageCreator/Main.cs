using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCreator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] strs = Enum.GetNames(typeof(Extension));
            for (int i = 0; i < strs.Length; i++)
            {
                comboBoxExtension.Items.Add(strs[i] + " (*" + GetExtension((Extension)i) + ")");
            }
            comboBoxExtension.SelectedIndex = 0;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ver. 20211005", "About ImageCreator", MessageBoxButtons.OK);
        }
        private void ButtonOpenFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select folder (CellsData, MovementRate, etc.)";
            if (Directory.Exists(Openfolder))
            { folderBrowserDialog1.SelectedPath = Openfolder; }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxOpenFolderPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void ButtonSaveFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "保存先のフォルダを選ぶ。";
            if (Directory.Exists(Savefolder))
            { folderBrowserDialog1.SelectedPath = Savefolder; }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxSaveFolderPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void TextBoxSaveFolderPath_Leave(object sender, EventArgs e)
        {
            if (textBoxSaveFolderPath.Text != "")
            {
                if (!Directory.Exists(textBoxSaveFolderPath.Text))
                {
                    DialogResult dr = MessageBox.Show("The given path does not refer to an existing directory on disk.\nCreate a new folder : "
                        + textBoxSaveFolderPath.Text, "Caution", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            Directory.CreateDirectory(textBoxSaveFolderPath.Text);
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
            if (textBoxOpenFolderPath.Text == "")
            {
                MessageBox.Show("Select open folder path.");
            }
            else if (!Directory.Exists(Openfolder))
            {
                MessageBox.Show("Error: " + Openfolder);
            }
            else if (textBoxSaveFolderPath.Text == "")
            {
                MessageBox.Show("Selsect save folder path.");
            }
            else if (!Directory.Exists(Savefolder))
            {
                MessageBox.Show("Error: " + Savefolder);
            }
            else
            {
                RunAsync();
            }
        }
        private void ComboBoxExtension_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedExtension = comboBoxExtension.SelectedIndex;
        }
        #endregion
        private enum Extension
        {
            JPEG,
            BMP,
            PNG,
            TIFF,
        }
        private static string GetExtension(Extension extension)
        {
            string[] strs = { ".jpg", ".bmp", ".png", ".tif" };
            return strs[(int)extension];
        }
        private string Openfolder => textBoxOpenFolderPath.Text;
        private string Savefolder => textBoxSaveFolderPath.Text;
        private int Column => (int)numColumn.Value;
        private int StartNum => (int)numStart.Value;
        private int StepNum => (int)numStep.Value;
        private bool SaveRaw => checkBoxSaveRAW.Checked;
        private bool XYZ => radioButtonXYZ.Checked;
        private int SelectedExtension;
        private bool CancelFlag;
        private bool CombineImageV => radioButtonCombineImageV.Checked;
        private async void RunAsync()
        {
            CancelFlag = true;
            panel1.Enabled = false;
            buttonStart.Enabled = false;
            ProgressBar1.Visible = true;
            StatusLabel1.Visible = true;
            ProgressBar1.Value = 0;
            StatusLabel1.Text = "";
            cancelToolStripMenuItem.Enabled = true;
            var progress = new Progress<int>(OnProgressChanged);
            await Task.Run(() => DoWork(progress));
            panel1.Enabled = true;
            buttonStart.Enabled = true;
            ProgressBar1.Visible = false;
            StatusLabel1.Visible = false;
            cancelToolStripMenuItem.Enabled = false;
            Cursor = Cursors.Default;
        }

        private void OnProgressChanged(int count)
        {
            ProgressBar1.Value = count;
            StatusLabel1.Text = count + "%";
        }
        private void DoWork(IProgress<int> iProgress)
        {
            string[] files = Directory.Exists(Openfolder) ? Directory.GetFiles(Openfolder, "*.csv") : null;
            string ext = GetExtension((Extension)SelectedExtension);
            for (int t = StartNum; t < files.Length; t += StepNum)
            {
                // Report progress
                iProgress.Report((int)(100.0 * (t + 1) / files.Length));

                if (!CancelFlag) // キャンセル処理
                { return; }

                // データ読み書き
                using (FileStream fs = new FileStream(files[t], FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (StreamReader sr = new StreamReader(fs))
                {
                    string savefilename = Path.GetFileNameWithoutExtension(files[t]);
                    if (SaveRaw) // RAWデータとして保存
                    {
                        SaveRawImage(sr, savefilename);
                    }
                    else
                    {
                        SaveHexagonalImage(sr, savefilename, ext);
                    }
                }
            }
        }

        private void SaveRawImage(StreamReader sr, string savefilename)
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
                int Xsize = visualizationUsingHexagons1.Xsize;
                int Ysize = visualizationUsingHexagons1.Ysize;
                int Zsize = visualizationUsingHexagons1.Zsize;
                bool[,,] cellExist = new bool[Zsize, Ysize, Xsize]; // 細胞の有無
                double[,,] img = new double[Zsize, Ysize, Xsize];
                while (!sr.EndOfStream)
                {
                    string[] s = sr.ReadLine().Split(',');
                    if (!int.TryParse(s[0], out int i)) { break; }
                    if (!int.TryParse(s[xNum], out int x)) { break; }
                    if (!int.TryParse(s[yNum], out int y)) { break; }
                    if (!int.TryParse(s[zNum], out int z)) { break; }
                    if (!double.TryParse(s[Column], out double val)) { break; }

                    int xx = x / 2;
                    if (xx < Xsize && y < Ysize)
                    {
                        cellExist[z, y, xx] = true;
                        img[z, y, xx] += val;
                    }
                }
                // 保存ファイル名
                string filename = Path.Combine(Savefolder, savefilename + ".raw");
                using (BinaryWriter br = new BinaryWriter(File.OpenWrite(filename)))
                {
                    if (XYZ)
                    {
                        for (int k = 0; k < Zsize; k++)
                        {
                            for (int j = 0; j < Ysize; j++)
                            {
                                for (int i = 0; i < Xsize; i++)
                                {
                                    if (j % 2 == 0)
                                    {
                                        if (cellExist[k, j, i])
                                        { br.Write(img[k, j, i] + 1); br.Write(img[k, j, i] + 1); }
                                        else
                                        { br.Write(double.NaN); br.Write(double.NaN); }
                                    }
                                    else
                                    {
                                        if (i > 0)
                                        {
                                            if (cellExist[k, j, i - 1])
                                            { br.Write(img[k, j, i - 1] + 1); }
                                            else
                                            { br.Write(double.NaN); }
                                        }
                                        else
                                        { br.Write(double.NaN); }
                                        if (cellExist[k, j, i])
                                        { br.Write(img[k, j, i] + 1); }
                                        else
                                        { br.Write(double.NaN); }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < Ysize; j++)
                        {
                            for (int k = 0; k < Zsize; k++)
                            {
                                for (int i = 0; i < Xsize; i++)
                                {
                                    if (j % 2 == 0)
                                    {
                                        if (cellExist[k, j, i])
                                        { br.Write(img[k, j, i] + 1); br.Write(img[k, j, i] + 1); }
                                        else
                                        { br.Write(double.NaN); br.Write(double.NaN); }
                                    }
                                    else
                                    {
                                        if (i > 0)
                                        {
                                            if (cellExist[k, j, i - 1])
                                            { br.Write(img[k, j, i - 1] + 1); }
                                            else
                                            { br.Write(double.NaN); }
                                        }
                                        else
                                        { br.Write(double.NaN); }
                                        if (cellExist[k, j, i])
                                        { br.Write(img[k, j, i] + 1); }
                                        else
                                        { br.Write(double.NaN); }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void SaveHexagonalImage(StreamReader sr, string savefilename, string ext)
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
                Bitmap[] bmp = visualizationUsingHexagons1.InitializeBitmap();
                if (bmp != null)
                {
                    while (!sr.EndOfStream)
                    {
                        string[] s = sr.ReadLine().Split(',');
                        if (!int.TryParse(s[0], out int i)) { break; }
                        if (!int.TryParse(s[xNum], out int x)) { break; }
                        if (!int.TryParse(s[yNum], out int y)) { break; }
                        if (!int.TryParse(s[zNum], out int z)) { break; }
                        if (!double.TryParse(s[Column], out double val)) { break; }
                        visualizationUsingHexagons1.SetHexagon(bmp, x, y, z, colorMap1.GetColor(val));
                    }
                    var d = CombineImageV
                        ? BPSE.VisualizationUsingHexagons.PlacementDirection.VERTICAL
                        : BPSE.VisualizationUsingHexagons.PlacementDirection.HORIZONTAL;
                    using (Bitmap dst = visualizationUsingHexagons1.CombineImage(bmp, d))
                    {
                        // 保存ファイル名
                        string filename = Path.Combine(Savefolder, savefilename + ext);
                        dst.Save(filename);
                    }
                }
                for (int i = 0; i < bmp.Length; i++)
                {
                    bmp[i].Dispose();
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelFlag = false;
            // カーソルを待機カーソルに変更
            Cursor = Cursors.WaitCursor;
        }

        private void CheckBoxSaveRAW_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSaveRAW.Checked)
            {
                label2.Enabled = false;
                comboBoxExtension.Enabled = false;
                radioButtonXYZ.Enabled = true;
                radioButtonXZY.Enabled = true;
                colorMap1.Enabled = false;
                groupBoxCombineImage.Enabled = false;
            }
            else
            {
                label2.Enabled = true;
                comboBoxExtension.Enabled = true;
                radioButtonXYZ.Enabled = false;
                radioButtonXZY.Enabled = false;
                colorMap1.Enabled = true;
                groupBoxCombineImage.Enabled = true;
            }
        }
    }
}
