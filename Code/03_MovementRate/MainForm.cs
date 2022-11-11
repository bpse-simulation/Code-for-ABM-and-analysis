using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace MovementRate
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        #region EventHandler
        private void Main_Load(object sender, EventArgs e)
        {
            inter = (double)num_interval_t.Value;
            path = "";
            lc = (double)Num_lc.Value;
            hc = (double)Num_hc.Value;
            Xsize = (int)NumXsize.Value;
            Ysize = (int)NumYsize.Value;
            dt = (double)Num_delta_t.Value;
        }
        private void TextDirCellsData_TextChanged(object sender, EventArgs e)
        { path = textDirCellsData.Text; }
        private void Num_interval_t_ValueChanged(object sender, EventArgs e)
        { inter = (double)num_interval_t.Value; }
        private void Num_delta_t_ValueChanged(object sender, EventArgs e)
        { dt = (double)Num_delta_t.Value; }
        private void Num_lc_ValueChanged(object sender, EventArgs e)
        { lc = (double)Num_lc.Value; }
        private void Num_hc_ValueChanged(object sender, EventArgs e)
        { hc = (double)Num_hc.Value; }
        private void NumXsize_ValueChanged(object sender, EventArgs e)
        { Xsize = (int)NumXsize.Value; }
        private void NumYsize_ValueChanged(object sender, EventArgs e)
        { Ysize = (int)NumYsize.Value; }
        private void ButtonDirLoad_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select CellsData folder.";
            if (Directory.Exists(path))
            {
                folderBrowserDialog1.SelectedPath = path;
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;
                textDirCellsData.Text = path;
            }
        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (textDirCellsData.Text == "")
            {
                MessageBox.Show("Select CellsData folder.");
            }
            else if (SaveFolderPath.Text == "")
            {
                MessageBox.Show("Selsect save folder path.");
            }
            else
            {
                RunAsync();
            }
        }
        private void SelectSaveFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();
            fbDialog.Description = "Selsect save folder path!";
            if (Directory.Exists(savefolder))
            {
                fbDialog.SelectedPath = savefolder;
            }
            if (fbDialog.ShowDialog() == DialogResult.OK)
            {
                savefolder = fbDialog.SelectedPath;
                SaveFolderPath.Text = savefolder;
            }
        }
        private void SaveFolderPath_TextChanged(object sender, EventArgs e)
        {
            savefolder = SaveFolderPath.Text;
        }
        private void SaveFolderPath_Leave(object sender, EventArgs e)
        {
            if (SaveFolderPath.Text != "")
            {
                if (Directory.Exists(SaveFolderPath.Text))
                { savefolder = SaveFolderPath.Text; }
                else
                {
                    DialogResult dr = MessageBox.Show("The given path does not refer to an existing directory on disk.\nCreate a new folder : " + SaveFolderPath.Text, "Caution", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            Directory.CreateDirectory(SaveFolderPath.Text);
                            savefolder = SaveFolderPath.Text;
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
        private void Num_interval_t_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^A");
        }
        private void Num_delta_t_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^A");
        }
        private void Num_lc_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^A");
        }
        private void Num_hc_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^A");
        }
        private void NumXsize_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^A");
        }
        private void NumYsize_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^A");
        }
        #endregion

        private double inter, dt;
        private string path, savefolder;
        private int Xsize, Ysize;
        private double lc, hc;

        private string[] outfolder;

        // longitudinal magnification 縦の倍率
        private readonly double Lm = Math.Sqrt(3) / 2.0;

        private static readonly object _lockObj = new object();

        private async void RunAsync()
        {
            panel1.Enabled = false;
            ProgressBar1.Visible = true;
            StatusLabel1.Visible = true;
            StatusLabel1.Text = "0%";
            var progress = new Progress<int>(OnProgressChanged);
            await Task.Run(() => DoWork(progress));
            panel1.Enabled = true;
            ProgressBar1.Visible = false;
            StatusLabel1.Visible = false;
        }

        private void DoWork(IProgress<int> iProgress)
        {
            outfolder = Directory.GetDirectories(path);
            if (checkParallel.Checked)
            {
                int num = 0;
                Parallel.For(0, outfolder.Length, i =>
                {
                    // Report progress
                    Interlocked.Increment(ref num); // numberに1を足す
                    iProgress.Report((int)(100.0 * num / outfolder.Length));
                    Run(i);
                });
            }
            else
            {
                for (int i = 0; i < outfolder.Length; i++)
                {
                    // Report progress
                    iProgress.Report((int)(100.0 * (i + 1) / outfolder.Length));
                    Run(i);
                }
            }
        }

        private void Run(int i)
        {
            string sfolder = outfolder[i];
            sfolder = Path.GetFileName(sfolder) == "CellsData" ? sfolder : Path.Combine(sfolder, "CellsData");
            if (Directory.Exists(sfolder))
            {
                string[] openfiles = Directory.GetFiles(sfolder, textPattern.Text);
                if (openfiles.Length > 0)
                {
                    // Sort
                    Array.Sort(openfiles, new LogicalStringComparer());
                    Run(openfiles, outfolder[i]);
                    return;
                }
            }
            string str = Path.Combine(savefolder, "ERROR.csv");
            lock (_lockObj)
            {
                using (StreamWriter sw = new StreamWriter(File.Open(str, FileMode.Append), Encoding.GetEncoding("Shift_JIS")))
                using (TextWriter tw = TextWriter.Synchronized(sw))
                {
                    // エラー出力
                    sw.WriteLine(outfolder[i].Replace(',', '_'));
                }
            }
        }

        private void Run(string[] openfiles, string sfolder)
        {
            // 解析時にトラッキングするファイル数を決定する
            double inter_t = inter;
            int ni = 0; // 初期のファイル間隔
            int n0 = 0;
            for (int i = 0; i < openfiles.Length; i++)
            {
                string name = Path.GetFileNameWithoutExtension(openfiles[i]);
                string[] ss = name.Split('_');
                if (i == 0)
                { n0 = int.Parse(ss[ss.Length - 1]); }
                if ((int)Math.Round(inter_t / dt) == int.Parse(ss[ss.Length - 1]) - n0)
                {
                    ni = i;
                    break;
                }
            }

            string outputfilepath = Path.Combine(savefolder, "out_MovRate_" + Path.GetFileName(sfolder));
            if (checkBoxSaveList.Checked)
            {
                if (!Directory.Exists(outputfilepath))
                { Directory.CreateDirectory(outputfilepath); }
            }
            string str = outputfilepath + ".csv";
            using (StreamWriter sw = new StreamWriter(File.Open(str, FileMode.Create)))
            {
                if (File.Exists(openfiles[0]))
                {
                    sw.WriteLine("step_[t0-dt]-[t0],mean,variance,cell count,1st quartile,2nd quartile (median),3rd quartile");
                    List<List<int>> indLens = new List<List<int>>(ni);
                    List<List<double>> Lengths = new List<List<double>>(ni);
                    List<List<bool>> fLayers = new List<List<bool>>(ni);
                    List<List<bool>> fSingle = !checkBoxSingleCell.Checked ? null : new List<List<bool>>(ni);

                    // 時刻tにおける細胞数のサイズを持つ配列
                    List<int> Ind_before = new List<int>();
                    List<int> X_before = new List<int>();
                    List<int> Y_before = new List<int>();
                    List<int> Z_before = new List<int>();

                    // t=0のCellDataファイルの読み込み
                    List<double> epcc_before = //!checkBoxSingleCell.Checked ? null : // 2021.04.09
                        ReadCellData(openfiles[0], Ind_before, X_before, Y_before, Z_before);
                    if (checkBoxSingleCell.Checked && epcc_before == null)
                    {
                        MessageBox.Show("CellsData に 「E_cc (ng um^2 h^(-2))」 が保存されていません。");
                        return;
                    }

                    // 時刻tにおける細胞数のサイズを持つ配列
                    List<int> indLen = new List<int>(); // 細胞ごとのインデックス
                    List<double> Len = new List<double>(); // 細胞ごとに移動した距離
                    List<bool> fBasal = new List<bool>(); // 細胞が基底層にいるかどうか
                    List<bool> singCell = !checkBoxSingleCell.Checked ? null : new List<bool>(); // 単細胞が一度でも存在したかどうか

                    List<double> SumVc = new List<double>();

                    // 配列の初期化
                    for (int i = 0; i < Ind_before.Count; i++)
                    {
                        indLen.Add(Ind_before[i]);
                        Len.Add(0);
                        fBasal.Add(false);
                        if (checkBoxSingleCell.Checked) singCell.Add(false);
                        SumVc.Add(0);
                    }

                    for (int t0 = 1, t1 = t0 - ni; t0 < openfiles.Length; t0++, t1++)
                    {
                        if (File.Exists(openfiles[t0]))
                        {
                            List<int> Ind_after = new List<int>();
                            List<int> X_after = new List<int>();
                            List<int> Y_after = new List<int>();
                            List<int> Z_after = new List<int>();

                            // t0のCellDataファイルの読み込み
                            List<double> epcc_after = //!checkBoxSingleCell.Checked ? null : // 2021.04.09
                                ReadCellData(openfiles[t0], Ind_after, X_after, Y_after, Z_after);
                            if (checkBoxSingleCell.Checked && epcc_after == null)
                            {
                                MessageBox.Show("CellsData に 「E_cc (ng um^2 h^(-2))」 が保存されていません。");
                                return;
                            }

                            int count = Ind_before.Count;

                            // リストの一番下の細胞が死細胞になってしまっていた場合の死細胞への対応についての例外処理 20191113
                            if (count > Ind_after.Count)
                            {
                                int i = count - 1;
                                while (Ind_before[i] > Ind_after[Ind_after.Count - 1])
                                {
                                    Ind_before.RemoveAt(i);
                                    X_before.RemoveAt(i);
                                    Y_before.RemoveAt(i);
                                    Z_before.RemoveAt(i);
                                    if (checkBoxSingleCell.Checked) epcc_before.RemoveAt(i);
                                    for (int j = 0; j < indLens.Count; j++)
                                    {
                                        // 時刻t0に死細胞が存在していたら
                                        if (indLens[j].Count > i)
                                        {
                                            indLens[j].RemoveAt(i);
                                            Lengths[j].RemoveAt(i);
                                            fLayers[j].RemoveAt(i);
                                            if (checkBoxSingleCell.Checked) fSingle[j].RemoveAt(i);
                                        }
                                    }
                                    indLen.RemoveAt(i);
                                    Len.RemoveAt(i);
                                    fBasal.RemoveAt(i);
                                    if (checkBoxSingleCell.Checked) singCell.RemoveAt(i);
                                    SumVc.RemoveAt(i);
                                    i--;
                                    count--;
                                }
                            }

                            for (int i = 0; i < count; i++)
                            {
                                // 死細胞への対応 -> 期間中に細胞死する細胞は速度計算から除外
                                if (Ind_before[i] != Ind_after[i])
                                {
                                    Ind_before.RemoveAt(i);
                                    X_before.RemoveAt(i);
                                    Y_before.RemoveAt(i);
                                    Z_before.RemoveAt(i);
                                    if (checkBoxSingleCell.Checked) epcc_before.RemoveAt(i);
                                    for (int j = 0; j < indLens.Count; j++)
                                    {
                                        // 時刻t0に死細胞が存在していたら
                                        if (indLens[j].Count > i)
                                        {
                                            indLens[j].RemoveAt(i);
                                            Lengths[j].RemoveAt(i);
                                            fLayers[j].RemoveAt(i);
                                            if (checkBoxSingleCell.Checked) fSingle[j].RemoveAt(i);
                                        }
                                    }
                                    indLen.RemoveAt(i);
                                    Len.RemoveAt(i);
                                    fBasal.RemoveAt(i);
                                    if (checkBoxSingleCell.Checked) singCell.RemoveAt(i);
                                    SumVc.RemoveAt(i);
                                    i--;
                                    count--;
                                    continue;
                                }

                                double dx = (X_after[i] - X_before[i]) / 2.0;
                                int dy = Y_after[i] - Y_before[i];
                                int dz = Z_after[i] - Z_before[i];
                                // 周期境界条件で計算
                                if (checkPeriodic.Checked)
                                {
                                    double x2 = (Xsize - 2) / 2.0;
                                    double y2 = (Ysize - 2) / 2.0;
                                    if (x2 < dx) { dx -= Xsize - 2; }
                                    else if (dx < -x2) { dx += Xsize - 2; }
                                    if (y2 < dy) { dy -= Ysize - 2; }
                                    else if (dy < -y2) { dy += Ysize - 2; }
                                }
                                // 距離を計算
                                Len[i] = Math.Sqrt(lc * lc * dx * dx
                                    + lc * lc * dy * dy * Lm * Lm
                                    + hc * hc * dz * dz);
                                SumVc[i] += Len[i];
                                // 基底層にいるときにはTRUE
                                fBasal[i] = Z_after[i] == 1;
                                // 単細胞になっていたらTRUE
                                if (checkBoxSingleCell.Checked) singCell[i] = epcc_after[i] == 0;
                            }
                            indLens.Add(indLen);
                            Lengths.Add(Len);
                            fLayers.Add(fBasal);
                            if (checkBoxSingleCell.Checked) fSingle.Add(singCell);

                            // beforeにafterをコピー
                            Ind_before = Ind_after;
                            X_before = X_after;
                            Y_before = Y_after;
                            Z_before = Z_after;
                            if (checkBoxSingleCell.Checked) epcc_before = epcc_after;

                            indLen = new List<int>(Ind_after.Count);
                            Len = new List<double>(Ind_after.Count);
                            fBasal = new List<bool>(Ind_after.Count);
                            if (checkBoxSingleCell.Checked) singCell = new List<bool>(Ind_after.Count);
                            for (int i = 0; i < Ind_after.Count; i++)
                            {
                                indLen.Add(Ind_after[i]);
                                Len.Add(0);
                                fBasal.Add(false);
                                if (checkBoxSingleCell.Checked) singCell.Add(false);
                            }
                            int a = Ind_after.Count - SumVc.Count;
                            for (int i = 0; i < a; i++)
                            {
                                SumVc.Add(0);
                            }

                            if (t0 >= ni)
                            {
                                // 保存
                                int cnt = 0;
                                double avera = 0;
                                double sigma = 0;
                                List<double> quantile = new List<double>();
                                List<double> quantileSingle = new List<double>();
                                List<int> index = new List<int>();
                                List<int> indexSingle = new List<int>();
                                int ind = 0;
                                for (int i = 0; i < indLens[0].Count; i++)
                                {
                                    if (checkBoxSingleCell.Checked)
                                    {
                                        // TRUEなら期間中に一度も単細胞にならない細胞
                                        bool flagNoSingle = true;
                                        for (int j = 0; j < ni; j++)
                                        {
                                            flagNoSingle &= !fSingle[j][i];
                                        }
                                        if (radioAllCell.Checked) // 全細胞
                                        {
                                            if (flagNoSingle)
                                            {
                                                avera += SumVc[i];
                                                cnt++;
                                                quantile.Add(SumVc[i] / inter_t);
                                                index.Add(ind++);
                                            }
                                            else
                                            {
                                                quantileSingle.Add(SumVc[i] / inter_t);
                                                indexSingle.Add(ind++);
                                            }
                                        }
                                        else
                                        {
                                            // TUREなら期間中に一度も基底上層に存在していない細胞
                                            bool flagBasal = true;
                                            // TUREなら期間中に一度も基底層に存在していない細胞
                                            bool flagSupra = true;
                                            for (int j = 0; j < ni; j++)
                                            {
                                                flagBasal &= fLayers[j][i];
                                                flagSupra &= !fLayers[j][i];
                                            }
                                            if (radioFirstLayer.Checked) // 1層目の細胞
                                            {
                                                if (flagBasal) // 20200109
                                                {
                                                    if (flagNoSingle)
                                                    {
                                                        avera += SumVc[i];
                                                        cnt++;
                                                        quantile.Add(SumVc[i] / inter_t);
                                                        index.Add(ind++);
                                                    }
                                                    else
                                                    {
                                                        quantileSingle.Add(SumVc[i] / inter_t);
                                                        indexSingle.Add(ind++);
                                                    }
                                                }
                                                else
                                                {
                                                    ind++;
                                                }
                                            }
                                            else if (radioSuprabasalLayer.Checked)
                                            {
                                                if (flagSupra)
                                                {
                                                    if (flagNoSingle)
                                                    {
                                                        avera += SumVc[i];
                                                        cnt++;
                                                        quantile.Add(SumVc[i] / inter_t);
                                                        index.Add(ind++);
                                                    }
                                                    else
                                                    {
                                                        quantileSingle.Add(SumVc[i] / inter_t);
                                                        indexSingle.Add(ind++);
                                                    }
                                                }
                                                else
                                                {
                                                    ind++;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (radioAllCell.Checked) // 全細胞
                                        {
                                            avera += SumVc[i];
                                            cnt++;
                                            quantile.Add(SumVc[i] / inter_t);
                                            index.Add(ind++);
                                        }
                                        else
                                        {
                                            // TUREなら期間中に一度も基底上層に存在していない細胞
                                            bool flagBasal = true;
                                            // TUREなら期間中に一度も基底層に存在していない細胞
                                            bool flagSupra = true;
                                            for (int j = 0; j < ni; j++)
                                            {
                                                flagBasal &= fLayers[j][i];
                                                flagSupra &= !fLayers[j][i];
                                            }
                                            if (radioFirstLayer.Checked) // 1層目の細胞
                                            {
                                                if (flagBasal) // 20200109
                                                {
                                                    avera += SumVc[i];
                                                    cnt++;
                                                    quantile.Add(SumVc[i] / inter_t);
                                                    index.Add(ind++);
                                                }
                                                else
                                                {
                                                    ind++;
                                                }
                                            }
                                            else if (radioSuprabasalLayer.Checked)
                                            {
                                                if (flagSupra)
                                                {
                                                    avera += SumVc[i];
                                                    cnt++;
                                                    quantile.Add(SumVc[i] / inter_t);
                                                    index.Add(ind++);
                                                }
                                                else
                                                {
                                                    ind++;
                                                }
                                            }
                                        }
                                    }
                                }

                                string st0 = Path.GetFileNameWithoutExtension(openfiles[t0]);
                                string st1 = Path.GetFileNameWithoutExtension(openfiles[t1]);
                                string[] ss0 = st0.Split('_');
                                string[] ss1 = st1.Split('_');
                                string filename = "step_" + ss1[ss1.Length - 1] + "-" + ss0[ss0.Length - 1];

                                if (checkBoxSaveList.Checked)
                                {
                                    string savelistpath = Path.Combine(outputfilepath, filename) + ".csv";
                                    using (FileStream fswList = new FileStream(savelistpath, FileMode.Create, FileAccess.Write, FileShare.Write))
                                    using (StreamWriter swList = new StreamWriter(fswList, Encoding.GetEncoding("Shift_JIS")))
                                    {
                                        swList.WriteLine("index,movement rate (um/h)");
                                        for (int q = 0; q < quantile.Count; q++)
                                        {
                                            swList.WriteLine(indLen[index[q]] + "," + quantile[q]);
                                        }
                                        if (checkBoxSingleCell.Checked)
                                        {
                                            swList.WriteLine();
                                            swList.WriteLine("Single cell");
                                            swList.WriteLine("index,movement rate (um/h)");
                                            for (int q = 0; q < quantileSingle.Count; q++)
                                            {
                                                swList.WriteLine(indLen[indexSingle[q]] + "," + quantileSingle[q]);
                                            }
                                        }
                                    }
                                }


                                double q1 = 0; // 第1四分位数
                                double q2 = 0; // 第2四分位数 (median)
                                double q3 = 0; // 第3四分位数
                                if (cnt > 0)
                                {
                                    // 平均
                                    avera /= cnt * inter_t;
                                    // 分散
                                    for (int i = 0; i < indLens[0].Count; i++)
                                    {
                                        if (radioAllCell.Checked) // 全細胞
                                        {
                                            sigma += (SumVc[i] / inter_t - avera) * (SumVc[i] / inter_t - avera);
                                        }
                                        else
                                        {
                                            // TUREなら期間中に一度も基底上層に存在していない細胞
                                            bool flagBasal = true;
                                            // TUREなら期間中に一度も基底層に存在していない細胞
                                            bool flagSupra = true;
                                            for (int j = 0; j < ni; j++)
                                            {
                                                flagBasal &= fLayers[j][i];
                                                flagSupra &= !fLayers[j][i];
                                            }
                                            if (radioFirstLayer.Checked) // 1層目の細胞
                                            {
                                                if (flagBasal) // 20200109
                                                {
                                                    sigma += (SumVc[i] / inter_t - avera) * (SumVc[i] / inter_t - avera);
                                                }
                                            }
                                            else if (radioSuprabasalLayer.Checked)
                                            {
                                                if (flagSupra)
                                                {
                                                    sigma += (SumVc[i] / inter_t - avera) * (SumVc[i] / inter_t - avera);
                                                }
                                            }
                                        }
                                    }
                                    sigma /= cnt;
                                    sigma = Math.Sqrt(sigma);
                                    // 四分位数
                                    quantile.Sort();
                                    q1 = quantile[quantile.Count / 4];
                                    q2 = quantile[quantile.Count / 2];
                                    q3 = quantile[quantile.Count * 3 / 4];
                                }

                                sw.WriteLine(filename
                                    + "," + avera.ToString() + "," + sigma.ToString()
                                    + "," + cnt + "," + q1 + "," + q2 + "," + q3);

                                // 配列の0番目の要素を差分
                                for (int i = 0; i < Lengths[0].Count; i++)
                                {
                                    SumVc[i] -= Lengths[0][i];
                                }
                                indLens.RemoveAt(0);
                                Lengths.RemoveAt(0);
                                fLayers.RemoveAt(0);
                                if (checkBoxSingleCell.Checked) fSingle.RemoveAt(0);
                            }
                        }
                    }
                }
            }
        }

        private static List<double> ReadCellData(string fileName, List<int> Ind_List, List<int> X_List, List<int> Y_List, List<int> Z_List)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("Shift_JIS")))
            {
                // ヘッダー行の読み飛ばし
                string[] header = sr.ReadLine().Split(',');
                // インデックスが保存されている列の番号を探す
                int Ind_hexX = Array.FindIndex(header, s => s == "hexX");
                int Ind_hexY = Array.FindIndex(header, s => s == "hexY");
                int Ind_hexZ = Array.FindIndex(header, s => s == "hexZ");
                int Ind_epcc = Array.FindIndex(header, s => s == "E_cc (ng um^2 h^(-2))");
                if (Ind_hexX == -1 || Ind_hexY == -1 || Ind_hexZ == -1)
                { return null; }

                List<double> epcc = Ind_epcc == -1 ? null : new List<double>();
                while (!sr.EndOfStream)
                {
                    string[] strs = sr.ReadLine().Split(',');
                    if (int.TryParse(strs[0], out int ind))
                    {
                        Ind_List.Add(ind);
                        X_List.Add(int.Parse(strs[Ind_hexX]));
                        Y_List.Add(int.Parse(strs[Ind_hexY]));
                        Z_List.Add(int.Parse(strs[Ind_hexZ]));
                        if (Ind_epcc != -1 && double.TryParse(strs[Ind_epcc], out double val))
                        {
                            epcc.Add(val);
                        }
                    }
                }
                return epcc;
            }
        }

        private void OnProgressChanged(int count)
        {
            ProgressBar1.Value = count;
            StatusLabel1.Text = count.ToString() + "%";
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
