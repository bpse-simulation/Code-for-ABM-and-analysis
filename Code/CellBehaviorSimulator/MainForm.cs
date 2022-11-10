using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CellBehaviorSimulator.CellBehaviors;
using CellBehaviorSimulator.CultureOperations;
using CellBehaviorSimulator.CultureEnvironments;

namespace CellBehaviorSimulator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private const string date = "June 14, 2022";
        private const string version = "Version 2.12.1";

        #region EventHandler
        private void MainForm_Load(object sender, EventArgs e)
        {
            parameters1.SetMainForm(this);
        }
        private async void ButtonStart_Click(object sender, EventArgs e)
        {
            var progress = new Progress<int>(OnProgressChanged);
            if (checkConsecutive.Checked)
            {
                var progressFL = new Progress<string>(OnProgressFLChanged);
                GUI_Change(true);
                FileList.Instance.VisibleChange(true);
                Display.RunSW = true;
                await Task.Run(() => ConsecutiveSimulation_Run(progress, progressFL));
                GUI_Change(false);
                FileList.Instance.VisibleChange(false);
                Display.RunSW = false;
            }
            else
            {
                if (parameters1.TabControl_SelectedIndex <= parameters1.TabControl_TabCount - 3)
                {
                    parameters1.TabControl_SelectedIndex++;
                    return;
                }
                parameters1.TabControl_SelectedIndex = parameters1.TabControl_TabCount - 1;
                GUI_Change(true);
                Display.RunSW = true;
                parameters1.Display_AutoReload();
                int result = await Task.Run(() => Simulation_Run(true, progress));
                if (result == 0)
                { MessageBox.Show("Invalid map creation", "ERROR"); }
                else if (result == -1)
                { MessageBox.Show("Invalid output file path", "ERROR"); }
                else if (result == -2)
                { MessageBox.Show("Seeding ERROR!"); }
                else
                { parameters1.Display_DrawImage(); }
                GUI_Change(false);
                parameters1.TabControl_SelectedIndex = parameters1.TabControl_TabCount - 1;
                buttonStart.Text = "Start";
                Display.RunSW = false;
            }
        }
        private void CheckConsecutive_CheckedChanged(object sender, EventArgs e)
        {
            if (checkConsecutive.Checked)
            {
                parameters1.Enabled = false;
                buttonStart.Text = "Start";
                FileList.Instance.Show();
            }
            else
            {
                FileList.Instance.Close();
                parameters1.Enabled = true;
                buttonStart.Text = "Next";
            }
        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "initialize";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (InputParameter.ReadParameter(openFileDialog1.FileName))
                {
                    parameters1.SetParameter();
                }
            }
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "initialize";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Common.CalcEmax();
                BasicConnectionEnergy.EpsilonToEnergy(Common.Emax);
                InputParameter.SaveParameter(saveFileDialog1.FileName);
            }
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = "Cell Behavior Simulator - Cell Placement Model";
            string update = "Last Updated on " + date + "\n" + version;
            string rights = "© 2019 Kino-oka Lab., Osaka Univ.\nAll rights reserved.";
            MessageBox.Show(name + "\n" + update + "\n\n" + rights, "About CBS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ParameterFileCreatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParameterFileCreator.Instance.ShowDialog();
            ParameterFileCreator.Instance.Dispose();
        }
        private void DebugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DebugFlag)
            {
                debugToolStripMenuItem.Text = "Debug mode : ON";
                DebugFlag = true;
            }
            else
            {
                debugToolStripMenuItem.Text = "Debug mode : OFF";
                DebugFlag = false;
            }
        }
        #endregion

        private bool DebugFlag = false;
        public string StartButton { set { buttonStart.Text = value; } }
        public bool State { get { return buttonStart.Enabled; } }

        private void GUI_Change(bool b)
        {
            parameters1.Parameters_Enabled = !b;
            toolStripProgressBar1.Visible = b;
            toolStripProgressBar1.Value = 0;
            toolStripStatusLabel1.Visible = b;
            toolStripStatusLabel1.Text = "0%";
            buttonStart.Enabled = !b;
            checkConsecutive.Enabled = !b;
            parameterFileCreatorToolStripMenuItem.Enabled = !b;
            openToolStripMenuItem.Enabled = !b;
            saveToolStripMenuItem.Enabled = !b;
        }

        private void OnProgressChanged(int count)
        {
            if (!IsDisposed)
            {
                int val = (int)(100.0 * count / Common.PartitionNum);
                toolStripProgressBar1.Value = val;
                toolStripStatusLabel1.Text = count.ToString() + " / " + Common.PartitionNum.ToString() + " : " + val.ToString() + "%";
            }
        }
        private void OnProgressFLChanged(string path)
        {
            FileList.Instance.OnProgressChanged(path);
        }
        private void ERROR(string dir, string folder, string message)
        {
            using (StreamWriter sw = new StreamWriter(
                File.Open(Path.Combine(dir, "ERROR.csv"), FileMode.Append), new UTF8Encoding(true)))
            {
                sw.WriteLine(folder + "," + message);
            }
        }

        private bool ConsecutiveSimulation_Run(Progress<int> progress, Progress<string> progressFL)
        {
            string dir = FileList.Instance.OutputDirectory;
            int itr = FileList.Instance.N_trial;
            while (true)
            {
                string path = FileList.Instance.GetInitializeFileName();
                if (path == "") { break; }
                for (int i = 0; i < itr; i++)
                {
                    FileList.Instance.SetProgress(progressFL, path, i);
                    string folder;
                    if (itr == 1)
                    { folder = Path.GetFileNameWithoutExtension(path).Replace(',', '_'); }
                    else
                    { folder = Path.GetFileNameWithoutExtension(path).Replace(',', '_') + "{n=" + i + "}"; }
                    Output.Set_OutputPath(Path.Combine(dir, folder));
                    if (InputParameter.ReadParameter(path))
                    {
                        int result = Simulation_Run(false, progress);
                        if (result == 0)
                        { ERROR(dir, folder, "Invalid map creation"); }
                        else if (result == -1)
                        { ERROR(dir, folder, "Invalid output file path"); }
                        else if (result == -2)
                        { ERROR(dir, folder, "Invalid seeding module"); }
                    }
                    else
                    { ERROR(dir, folder, "ReadParameter"); }
                }
            }
            return true;
        }

        private int Simulation_Run(bool newRun, Progress<int> progress)
        {
            Common.Preparation(newRun);
            if (!CultureSpace.MapCreation())
            { return 0; }
            SubstrateAbility.Initialize();
            if (!Output.SaveInitialFile(version, date))
            { return -1; }
            if (!Seeding.Run(out List<CellData> cells))
            { return -2; }
            CellMovement.Initialize(cells.Count);
            TimeLoop(cells, progress);
            return 1;
        }

        private void TimeLoop(List<CellData> cells, IProgress<int> iProgress)
        {
            int initstep = CultureTime.GetInitialTimeStep();

            for (int t = 0; t < Common.PartitionNum; t++)
            {
                iProgress.Report(t + 1);
                Output.Run(cells, t + initstep);
                Environments.Run(cells);
                Behaviors.CellLoop(cells);
                GravitySettling.Run(cells);
                Common.MaintainStates(cells);
                Debug(cells);
            }

            Output.Run(cells, Common.PartitionNum);

            iProgress.Report(0);
        }

        private void Debug(List<CellData> cells)
        {
            if (DebugFlag)
            {
                string err = "";
                for (int i = 0; i < cells.Count; i++)
                {
                    if (cells[i] != null)
                    {
                        if (!CultureSpace.IsCorrect(cells, i, out int val))
                        {
                            err += "i = " + i + ", Index = " + cells[i].Index + ", Debug: MapVal = " + val + "\n";
                        }
                    }
                }
                if (err != "")
                { MessageBox.Show(err); }
                err = "";
                for (int k = 0; k < CultureSpace.Zsize; k++)
                {
                    for (int j = 0; j < CultureSpace.Ysize; j++)
                    {
                        for (int i = 0; i < CultureSpace.Xsize; i++)
                        {
                            int val = CultureSpace.GetMap(i * 2, j, k);
                            if (val >= 0)
                            {
                                Point3D pnt = CellData.Find(cells, val).Location;
                                int ii;
                                if (j % 2 == 0) { ii = i * 2; }
                                else { ii = i * 2 + 1; }
                                if (ii != pnt.X || j != pnt.Y || k != pnt.Z)
                                {
                                    err += "Debug: i=" + ii + " x=" + pnt.X + " j=" + j + " y=" + pnt.Y + " k=" + k + " z=" + pnt.Z + "\n";
                                }
                            }
                        }
                    }
                }
                if (err != "")
                { MessageBox.Show(err); }
            }
        }

        private void analyze8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Analysis.FactorClassification analyze = new Analysis.FactorClassification())
            {
                analyze.ShowDialog();
            }
        }
    }
}
