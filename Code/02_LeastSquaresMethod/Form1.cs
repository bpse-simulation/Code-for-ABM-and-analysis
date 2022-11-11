using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LeastSquaresMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int N;
        private double t_step, t_init, lc_cm, area;
        private List<string> listCellsData;

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            Run();
        }

        private void OnProgressChanged(int count)
        {
            ProgressBar1.Value = count;
            StatusLabel1.Text = count.ToString() + "%";
        }

        private async void Run()
        {
            ProgressBar1.Visible = true;
            StatusLabel1.Visible = true;
            panel1.Enabled = false;
            var progress = new Progress<int>(OnProgressChanged);
            t_step = (double)numTime_dt.Value;
            t_init = (double)numTimeInit.Value;
            N = (int)numN.Value;
            if (radioMovRate.Checked)
            {
                await Task.Run(() => Run_MovRate(progress));
            }
            else
            {
                if (radioDensity.Checked)
                {
                    lc_cm = (double)numLatticeSize.Value / 10000;
                    area = lc_cm * lc_cm * (double)(numXsize.Value * numYsize.Value); // unit:cm^2
                    if (radioHex.Checked)
                    {
                        area *= Math.Sqrt(3) / 2.0;
                    }
                }
                else //if (radioNumber.Checked)
                {
                    area = 1;
                }
                if (radioLogRSS.Checked)
                {
                    await Task.Run(() => Run_LogRSS(progress));
                }
                else if (radioRSS.Checked)
                {
                    await Task.Run(() => Run_RSS(progress));
                }
            }
            ProgressBar1.Visible = false;
            StatusLabel1.Visible = false;
            panel1.Enabled = true;
        }

        private void Run_MovRate(IProgress<int> iProgress)
        {
            List<string> time = new List<string>();
            List<double> vitro = new List<double>();
            using (FileStream fs = new FileStream(textDataPath.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (StreamReader sr = new StreamReader(fs))
            {
                while (!sr.EndOfStream)
                {
                    string[] strs = sr.ReadLine().Split(',');
                    time.Add(strs[0]);
                    vitro.Add(double.Parse(strs[1]));
                }
            }

            int cnt = time.Count;

            try
            {
                using (StreamWriter sw = new StreamWriter(File.Open(textSavePath.Text, FileMode.Create)))
                {
                    sw.WriteLine("Folder name,RSS,Mean,StandardDeviation");
                    for (int k = 0; k < listCellsData.Count / N; k++)
                    {
                        // Report progress
                        iProgress.Report((int)(100.0 * k / (listCellsData.Count / N)));

                        double[] silico = new double[cnt];
                        for (int j = 0; j < N; j++)
                        {
                            using (FileStream fs = new FileStream(listCellsData[k * N + j], FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                            using (StreamReader sr = new StreamReader(fs))
                            {
                                sr.ReadLine(); 
                                while (!sr.EndOfStream)
                                {
                                    string[] strs = sr.ReadLine().Split(',');
                                    string[] t_ = strs[0].Split('_')[1].Split('-');
                                    double t0 = double.Parse(t_[0]) * t_step + t_init;
                                    double t1 = double.Parse(t_[1]) * t_step + t_init;
                                    for (int i = 0; i < cnt; i++)
                                    {
                                        if (time[i] == t0.ToString() + "-" + t1.ToString())
                                        {
                                            silico[i] += double.Parse(strs[1]) / N;
                                        }
                                    }
                                }
                            }
                        }
                        double ep = 0.0; 
                        double[] eps = new double[cnt];
                        for (int i = 0; i < cnt; i++)
                        {
                            //Normal_RSS
                            double val = Math.Pow(vitro[i] - silico[i], 2);
                            ep += val;
                            eps[i] = val;
                        }
                        double m = ep / cnt, s = 0.0;
                        for (int i = 0; i < cnt; i++)
                        {
                            s += (eps[i] - m) * (eps[i] - m);
                        }
                        s /= cnt;
                        s = Math.Sqrt(s);
                        string str = Path.GetFileNameWithoutExtension(listCellsData[k * N]).Replace(",", "_");
                        sw.WriteLine(str + "," + ep.ToString());
                    }
                }
            }
            catch (IOException ex)
            {
                if (MessageBox.Show(ex.Message, "IOException", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    Run_MovRate(iProgress);
                }
                //throw;
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message, "Save file path exception");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Run_LogRSS(IProgress<int> iProgress)
        {
            Get_vitro_data(out List<double> time, out List<int> col, out List<double> vitro);

            int cnt = time.Count;

            try 
            {
                using (StreamWriter sw = new StreamWriter(File.Open(textSavePath.Text, FileMode.Create)))
                {
                    sw.WriteLine("Folder name,Log RSS,Mean,StandardDeviation");
                    for (int k = 0; k < listCellsData.Count / N; k++)
                    {
                        // Report progress
                        iProgress.Report((int)(100.0 * k / (listCellsData.Count / N)));

                        double[] silico = new double[cnt];
                        for (int j = 0; j < N; j++)
                        {
                            using (FileStream fs = new FileStream(listCellsData[k * N + j], FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                            using (StreamReader sr = new StreamReader(fs))
                            {
                                sr.ReadLine();
                                while (!sr.EndOfStream)
                                {
                                    string[] strs = sr.ReadLine().Split(',');
                                    double t = double.Parse(strs[0]) * t_step + t_init;
                                    for (int i = 0; i < cnt; i++)
                                    {
                                        if (time[i] == t)
                                        {
                                            silico[i] += double.Parse(strs[col[i]]) / N;
                                        }
                                    }
                                }
                            }
                        }
                        double ep = 0.0; 
                        double[] eps = new double[cnt];
                        for (int i = 0; i < cnt; i++)
                        {
                            silico[i] /= area;
                            //log(RSS)
                            double val = Math.Pow(Math.Log(vitro[i]) - Math.Log(silico[i]), 2);
                            ep += val;
                            eps[i] = val;
                        }
                        double m = ep / cnt, s = 0.0;
                        for (int i = 0; i < cnt; i++)
                        {
                            s += (eps[i] - m) * (eps[i] - m);
                        }
                        s /= cnt;
                        s = Math.Sqrt(s);
                        sw.WriteLine(Path.GetFileName(Path.GetDirectoryName(listCellsData[k * N])) + "," + ep.ToString()
                            + "," + m + "," + s);
                    }
                }
            }
            catch (IOException ex)
            {
                if (MessageBox.Show(ex.Message, "IOException", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    Run_LogRSS(iProgress);
                }
                //throw;
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message, "Save file path exception");
            }
        }
        private void Run_RSS(IProgress<int> iProgress)
        {
            Get_vitro_data(out List<double> time, out List<int> col, out List<double> vitro);

            int cnt = time.Count;

            try
            {
                using (StreamWriter sw = new StreamWriter(File.Open(textSavePath.Text, FileMode.Create)))
                {
                    sw.WriteLine("Folder name,RSS,Mean,StandardDeviation");
                    for (int k = 0; k < listCellsData.Count / N; k++)
                    {
                        // Report progress
                        iProgress.Report((int)(100.0 * k / (listCellsData.Count / N)));

                        double[] silico = new double[cnt];
                        for (int j = 0; j < N; j++)
                        {
                            using (FileStream fs = new FileStream(listCellsData[k * N + j], FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                            using (StreamReader sr = new StreamReader(fs))
                            {
                                sr.ReadLine();
                                while (!sr.EndOfStream)
                                {
                                    string[] strs = sr.ReadLine().Split(',');
                                    double t = double.Parse(strs[0]) * t_step + t_init;
                                    for (int i = 0; i < cnt; i++)
                                    {
                                        if (time[i] == t)
                                        {
                                            silico[i] += double.Parse(strs[col[i]]) / N;
                                        }
                                    }
                                }
                            }
                        }
                        double ep = 0.0;
                        double[] eps = new double[cnt];
                        for (int i = 0; i < cnt; i++)
                        {
                            silico[i] /= area;
                            //Normal_RSS
                            double val = Math.Pow(vitro[i] - silico[i], 2);
                            ep += val;
                            eps[i] = val;
                        }
                        double m = ep / cnt, s = 0.0;
                        for (int i = 0; i < cnt; i++)
                        {
                            s += (eps[i] - m) * (eps[i] - m);
                        }
                        s /= cnt;
                        s = Math.Sqrt(s);
                        sw.WriteLine(Path.GetFileName(Path.GetDirectoryName(listCellsData[k * N])) + "," + ep.ToString()
                            + "," + m + "," + s);
                    }
                }
            }
            catch (IOException ex)
            {
                if (MessageBox.Show(ex.Message, "IOException", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    Run_RSS(iProgress);
                }
                //throw;
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message, "Save file path exception");
            }
        }

        private bool Get_vitro_data(out List<double> time, out List<int> col, out List<double> vitro)
        {
            time = new List<double>();
            col = new List<int>();
            vitro = new List<double>();
            if (File.Exists(textDataPath.Text))
            {
                using (FileStream fs = new FileStream(textDataPath.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] strs = sr.ReadLine().Split(',');
                        if (double.TryParse(strs[0], out double t) &&
                            int.TryParse(strs[1], out int c) &&
                            double.TryParse(strs[2], out double v))
                        {
                            time.Add(t);
                            col.Add(c);
                            vitro.Add(v);
                        }
                    }
                }
                return true;
            }
            return false;
        }

        private async void ButtonOpen_Click(object sender, EventArgs e)
        {
            if (fbDialog.ShowDialog() == DialogResult.OK)
            {
                string folder = fbDialog.SelectedPath;
                string pat = "*.csv";
                if (comboBoxFileNamePattern.Text != "")
                {
                    pat = comboBoxFileNamePattern.Text;
                }
                else
                {
                    comboBoxFileNamePattern.Text = pat;
                }
                string[] files = null;
                buttonStart.Enabled = false;
                buttonOpen.Enabled = false;
                Cursor = Cursors.WaitCursor;
                await Task.Run(() =>
                {
                    files = Directory.GetFiles(folder, pat, SearchOption.AllDirectories);
                    Array.Sort(files);
                    listCellsData = new List<string>();
                    listCellsData.AddRange(files);
                });
                textBoxSelectedFolder.Text = folder;
                labelNumOfTargetFiles.Text = "Number of target files : " + files.Length;
                buttonStart.Enabled = true;
                buttonOpen.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            listCellsData.Clear();
            textBoxSelectedFolder.Text = "";
            labelNumOfTargetFiles.Text = "Number of target files :";
        }


        private void RadioDensity_CheckedChanged(object sender, EventArgs e)
        {
            SpaceParam.Enabled = true;
            radioLogRSS.Enabled = true;
        }

        private void RadioNumber_CheckedChanged(object sender, EventArgs e)
        {
            SpaceParam.Enabled = false;
            radioLogRSS.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listCellsData = new List<string>();
        }

        private void RadioMovRate_CheckedChanged(object sender, EventArgs e)
        {
            SpaceParam.Enabled = false;
            radioLogRSS.Enabled = false;
            radioRSS.Checked = true;
        }

        private void ButtonDataPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog
            {
                Filter = "CSV|*.csv"
            };
            if (ofDialog.ShowDialog()== DialogResult.OK)
            {
                textDataPath.Text = ofDialog.FileName;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfDialog = new SaveFileDialog
            {
                Filter = "CSV|*.csv"
            };
            if (sfDialog.ShowDialog() == DialogResult.OK)
            {
                textSavePath.Text = sfDialog.FileName;
            }
        }

    }
}
