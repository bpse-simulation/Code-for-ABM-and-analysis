using CellBehaviorSimulator.CellBehaviors;
using CellBehaviorSimulator.CultureEnvironments;
using CellBehaviorSimulator.CultureOperations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellBehaviorSimulator.Analysis
{
    public partial class FactorClassification : Form
    {
        public FactorClassification()
        {
            InitializeComponent();
        }

        private string FolderSrc, TargetFilename, FileDst;
        private bool CancelFlag;

        private void CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelFlag = false;
            Cursor = Cursors.WaitCursor;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Text);
        }

        private void TextBoxFolderSrc_Leave(object sender, EventArgs e)
        {
            if (textBoxFolderSrc.Text != "")
            {
                if (!Directory.Exists(textBoxFolderSrc.Text))
                {
                    MessageBox.Show("The given path does not refer to an existing directory on disk.\n" + textBoxFolderSrc.Text, "Caution");
                    textBoxFolderSrc.Focus();
                    textBoxFolderSrc.SelectAll();
                }
            }
        }

        private void TextBoxFolderSrc_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(textBoxFolderSrc.Text))
            {
                FolderSrc = textBoxFolderSrc.Text;
            }
        }

        private void ButtonFolderSrc_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(FolderSrc))
            { folderBrowserDialog1.SelectedPath = FolderSrc; }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                FolderSrc = folderBrowserDialog1.SelectedPath;
                textBoxFolderSrc.Text = FolderSrc;
            }
        }

        private void TextBoxFileDst_TextChanged(object sender, EventArgs e)
        {
            FileDst = textBoxFileDst.Text;
        }

        private void ButtonFileDst_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileDst = saveFileDialog1.FileName;
                textBoxFileDst.Text = FileDst;
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (textBoxFolderSrc.Text == "")
            {
                MessageBox.Show("Select open folder path.");
            }
            else if (!Directory.Exists(FolderSrc))
            {
                MessageBox.Show("Error: " + FolderSrc);
            }
            else
            {
                RunAsync();
            }
        }

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
            TargetFilename = comboBoxTargetFilename.Text;
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
            string file_init = Path.Combine(Path.GetDirectoryName(FolderSrc), "initialize.csv");
            if (InputParameter.ReadParameter(file_init))
            {
                Common.Preparation(false);
                double area = GetSurfaceArea();
                string[] files = Directory.Exists(FolderSrc)
                    ? Directory.GetFiles(FolderSrc, TargetFilename, SearchOption.AllDirectories) : null;

                using (FileStream fsw = new FileStream(FileDst, FileMode.Create, FileAccess.Write, FileShare.Write))
                using (StreamWriter sw = new StreamWriter(fsw, new UTF8Encoding(true)))
                {
                    string savefolder = Path.Combine(Path.GetDirectoryName(FileDst), "CellsData Factor classification");
                    if (!Directory.Exists(savefolder))
                    {
                        Directory.CreateDirectory(savefolder);
                    }
                    int zSize = CultureSpace.Zsize;

                    int cluster = 7;

                    string header = "";
                    for (int k = 1; k < zSize - 1; k++)
                    {
                        for (int i = 0; i < cluster; i++)
                        {
                            header += ",Layer" + k + " Class:" + i;
                        }
                    }
                    header += ",surface area (mm^2) =," + area;
                    sw.WriteLine(header);

                    {
                        if (!CultureSpace.MapCreation())
                        { return; }
                        List<CellData> cells = Seeding.InputCellsData(files[0]);
                        Common.MaintainStates(cells);
                    }

                    List<double> EpB_min_pre = new List<double>();
                    string classStr = "";
                    classStr += ",0: EpB_min is greater than 1";
                    classStr += ",1: EpB_min has never been greater than 1";
                    classStr += ",2: Class 1 with position change";
                    classStr += ",3: EpB_min is less than 1 due to degradation of connection energy";
                    classStr += ",4: Class 3 with position change";
                    classStr += ",5: EpB_min is less than 1 due to the collapse of connection energy caused by the change in position of neighboring cells";
                    classStr += ",6: Class 5 with position change";

                    List<int> state = new List<int>();
                    int[] state_pre = new int[0];
                    List<int> mitizure = new List<int>();

                    for (int f = 1; f < files.Length; f++)
                    {
                        iProgress.Report((int)(100.0 * (f + 1) / files.Length));
                        if (!CancelFlag)
                        { return; }

                        if (!CultureSpace.MapCreation())
                        { return; }
                        List<CellData> cells = Seeding.InputCellsData(files[f]);

                        int[,] cnts = new int[zSize, cluster];

                        List<int> ind_wo = new List<int>();
                        List<int> ind_mov = new List<int>();

                        for (int i = 0; i < cells.Count; i++)
                        {
                            CellData c = CellData.Find(cells, i);
                            if (c != null)
                            {
                                double[] Prms = Migration.MigrationPrm(cells, c, out double[] EpBs);
                                for (int dir = 0; dir < 20; dir++)
                                {
                                    if (EpBs[dir] < 1 && Prms[dir] == 0)
                                    {
                                        EpBs[dir] = double.PositiveInfinity;
                                    }
                                }
                                double EpB_min = EpBs.Min();
                                if (EpB_min_pre.Count > i)
                                {
                                    if (c.Dir_am == Direction.DIR.C_1 &&
                                        c.Dir_pm.Count == 0 &&
                                        c.Dir_pd.Count == 0 &&
                                        c.Location.X == CellData.CellsPre[i].Location.X &&
                                        c.Location.Y == CellData.CellsPre[i].Location.Y &&
                                        c.Location.Z == CellData.CellsPre[i].Location.Z)
                                    {
                                        if (EpB_min_pre[i] >= 1 && EpB_min < 1)
                                        {
                                            bool flag = true;
                                            int mi = 0;
                                            for (int dir = 0; dir < 20; dir++)
                                            {
                                                Point3D pnt = c.Location + Delta.GetDelta(dir);
                                                int n1 = CultureSpace.GetMap(pnt);
                                                int n0 = CultureSpace.MapPre[pnt.Z, pnt.Y, pnt.X / 2];
                                                if (n0 >= 0 && n1 != n0)
                                                {
                                                    flag = false;
                                                    mi = Math.Max(mi, mitizure[n0]);
                                                }
                                            }
                                            if (flag)
                                            {
                                                state[i] = 3;
                                                cnts[c.Location.Z, 3]++;
                                                mitizure[i] = 1;
                                            }
                                            else
                                            {
                                                ind_wo.Add(c.Index);
                                                mitizure[i] = mi + 1;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (c.Time_d > CellData.CellsPre[i].Time_d)
                                        {
                                            state[i] = 1;
                                            cnts[c.Location.Z, 1]++;
                                        }
                                        else if (EpB_min_pre[i] >= 1)
                                        {
                                            bool flag = true;
                                            int mi = 0;
                                            for (int dir = 0; dir < 20; dir++)
                                            {
                                                Point3D pnt = CellData.CellsPre[c.Index].Location + Delta.GetDelta(dir);
                                                int n1 = CultureSpace.GetMap(pnt);
                                                int n0 = CultureSpace.MapPre[pnt.Z, pnt.Y, pnt.X / 2];
                                                if (n0 >= 0 && n1 != n0)
                                                {
                                                    flag = false;
                                                    mi = Math.Max(mi, mitizure[n0]);
                                                }
                                            }
                                            if (flag)
                                            {
                                                state[i] = 4;
                                                cnts[c.Location.Z, 4]++;
                                                mitizure[i] = 1;
                                            }
                                            else
                                            {
                                                ind_mov.Add(c.Index);
                                                mitizure[i] = mi + 1;
                                            }
                                        }
                                        else if (state[i] % 2 == 1)
                                        {
                                            int ss = state[i] + 1;
                                            state[i] = ss;
                                            cnts[c.Location.Z, ss]++;
                                        }
                                    }
                                    EpB_min_pre[i] = EpB_min;
                                }
                                else
                                {
                                    EpB_min_pre.Add(EpB_min);
                                    state.Add(1);
                                    cnts[c.Location.Z, 1]++;
                                    mitizure.Add(1);
                                }
                                if (EpB_min >= 1)
                                {
                                    state[i] = 0;
                                    cnts[c.Location.Z, 0]++;
                                    mitizure[i] = 0;
                                }
                            }
                            else if (EpB_min_pre.Count <= i)
                            {
                                EpB_min_pre.Add(double.NaN);
                                state.Add(1);
                                cnts[c.Location.Z, 1]++;
                                mitizure.Add(1);
                            }
                        }

                        if (!CultureSpace.MapCreation())
                        { return; }
                        cells = Seeding.InputCellsData(files[f - 1]);
                        CultureTime.Run(cells);
                        int[] ind = Common.RandomlySort(cells);
                        CellCellConnection.Run(cells, ind);
                        CultureTime.RenewDulationTime(cells);

                        for (int i = 0; i < ind_wo.Count; i++)
                        {
                            CellData c = CellData.Find(cells, ind_wo[i]);
                            if (c != null)
                            {
                                double[] Prms = Migration.MigrationPrm(cells, c, out double[] EpBs);
                                for (int dir = 0; dir < 20; dir++)
                                {
                                    if (EpBs[dir] < 1 && Prms[dir] == 0)
                                    {
                                        EpBs[dir] = double.PositiveInfinity;
                                    }
                                }
                                double EpBs_min = EpBs.Min();
                                if (EpBs_min < 1)
                                {
                                    state[ind_wo[i]] = 3;
                                    cnts[c.Location.Z, 3]++;
                                    mitizure[ind_wo[i]] = 1;
                                }
                                else
                                {
                                    state[ind_wo[i]] = 5;
                                    cnts[c.Location.Z, 5]++;
                                }
                            }
                        }
                        for (int i = 0; i < ind_mov.Count; i++)
                        {
                            CellData c = CellData.Find(cells, ind_mov[i]);
                            if (c != null)
                            {
                                double[] Prms = Migration.MigrationPrm(cells, c, out double[] EpBs);
                                for (int dir = 0; dir < 20; dir++)
                                {
                                    if (EpBs[dir] < 1 && Prms[dir] == 0)
                                    {
                                        EpBs[dir] = double.PositiveInfinity;
                                    }
                                }
                                double EpBs_min = EpBs.Min();
                                if (EpBs_min < 1)
                                {
                                    state[ind_mov[i]] = 4;
                                    cnts[c.Location.Z, 4]++;
                                    mitizure[ind_mov[i]] = 1;
                                }
                                else
                                {
                                    state[ind_mov[i]] = 6;
                                    cnts[c.Location.Z, 6]++;
                                }
                            }
                        }

                        if (!CultureSpace.MapCreation())
                        { return; }
                        cells = Seeding.InputCellsData(files[f]);
                        Common.MaintainStates(cells);

                        state_pre = new int[state.Count];
                        state.CopyTo(state_pre);

                        string name = Path.GetFileNameWithoutExtension(files[f]);

                        string filename = Path.Combine(savefolder, name + ".csv");
                        using (FileStream fsw1 = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.Write))
                        using (StreamWriter sw1 = new StreamWriter(fsw1, new UTF8Encoding(true)))
                        {
                            sw1.WriteLine("Index,hexX,hexY,hexZ,Class,EpB_min,Number of chain migration" + classStr);
                            for (int i = 0; i < cells.Count; i++)
                            {
                                CellData c = CellData.Find(cells, i);
                                if (c != null)
                                {
                                    double[] Prms = Migration.MigrationPrm(cells, c, out double[] EpBs);
                                    for (int dir = 0; dir < 20; dir++)
                                    {
                                        if (EpBs[dir] < 1 && Prms[dir] == 0)
                                        {
                                            EpBs[dir] = double.PositiveInfinity;
                                        }
                                    }
                                    double EpBs_min = EpBs.Min();
                                    string s = i + "," + c.Location.X + "," + c.Location.Y + "," + c.Location.Z;
                                    s += "," + state[i];
                                    s += "," + EpBs_min;
                                    s += "," + mitizure[i];

                                    sw1.WriteLine(s);
                                }
                            }
                        }

                        string str = name;
                        for (int k = 1; k < zSize - 1; k++)
                        {
                            for (int i = 0; i < cluster; i++)
                            {
                                str += "," + cnts[k, i];
                            }
                        }
                        sw.WriteLine(str);
                    }
                }
            }
        }

        private static double GetSurfaceArea()
        {
            if (CultureSpace.MapCreation())
            {
                int cnt = 0;
                for (int j = 0; j < CultureSpace.Ysize; j++)
                {
                    for (int i = 0; i < CultureSpace.Xsize; i++)
                    {
                        int ii = j % 2 == 0 ? i * 2 : i * 2 + 1;
                        int n = CultureSpace.GetMap(new Point3D(ii, j, 1));
                        if (n == -1) { cnt++; }
                    }
                }
                return cnt * 0.5 * Math.Sqrt(3) * CultureSpace.Size_lc * CultureSpace.Size_lc * 1E-6;
            }
            else return 0;
        }
    }
}
