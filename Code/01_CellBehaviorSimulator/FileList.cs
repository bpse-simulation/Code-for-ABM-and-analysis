using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CellBehaviorSimulator
{
    public partial class FileList : Form
    {
        public FileList()
        {
            InitializeComponent();
        }

        private static FileList _instance;
        public static FileList Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FileList();
                }
                return _instance;
            }
        }

        #region EventHandler
        private void FileList_Load(object sender, EventArgs e)
        {
            InputParamList = new List<string>();
            textBox1.Text = "Folder :";
            N_trial = (int)numTrial.Value;
        }

        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                await Task.Run(() =>
                {
                    string[] strs = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.csv");
                    Array.Sort(strs, new LogicalStringComparer());
                    for (int i = 0; i < strs.Length; i++)
                    {
                        InputParamList.Add(strs[i]);
                    }
                });
                textBox1.Text = "Folder : " + folderBrowserDialog1.SelectedPath;
                label3.Text = "Number of target files : " + InputParamList.Count;
                N_total = (InputParamList.Count + 1) * N_trial;
            }
        }

        private void ButtonAllClear_Click(object sender, EventArgs e)
        {
            if (InputParamList.Count > 0)
            {
                N_total -= (InputParamList.Count + 1) * N_trial;
                InputParamList.Clear();
                toolStripProgressBar1.Value = 100;
                toolStripStatusLabel1.Text = N_total.ToString() + "/" + N_total.ToString() + " : " + toolStripProgressBar1.Value.ToString() + "%";
                textBox1.Text = "Folder :";
                label3.Text = "Number of target files : " + N_total;
            }
        }

        private void ButtonOutDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxOutDir.Text = folderBrowserDialog1.SelectedPath;
                OutputDirectory = folderBrowserDialog1.SelectedPath;
            }
        }

        private void TextBoxOutDir_TextChanged(object sender, EventArgs e)
        {
            OutputDirectory = textBoxOutDir.Text;
        }

        private void TextBoxOutDir_Leave(object sender, EventArgs e)
        {
            if (textBoxOutDir.Text != "")
            {
                if (!Directory.Exists(textBoxOutDir.Text))
                {
                    string dir;
                    if (Path.IsPathRooted(OutputDirectory))
                    { dir = OutputDirectory; }
                    else
                    {
                        dir = Path.Combine(System.Environment.CurrentDirectory, OutputDirectory);
                    }
                    DialogResult dr = MessageBox.Show("The given path does not refer to an existing directory on disk.\nCreate a new folder : " + dir, "Caution", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            Directory.CreateDirectory(dir);
                            textBoxOutDir.Text = dir;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Can not create a new folder.");
                            textBoxOutDir.Select();
                            textBoxOutDir.SelectAll();
                        }
                    }
                    else
                    {
                        textBoxOutDir.Select();
                        textBoxOutDir.SelectAll();
                    }
                }
            }
        }

        private void NumTrial_ValueChanged(object sender, EventArgs e)
        {
            N_trial = (int)numTrial.Value;
        }
        #endregion

        private int N_total;
        private List<string> InputParamList;
        public int N_trial { get; private set; }
        public string OutputDirectory { get; private set; }

        public string GetInitializeFileName()
        {
            if (InputParamList.Count > 0)
            {
                string path = InputParamList[0];
                InputParamList.RemoveAt(0);
                return path;
            }
            return "";
        }

        public void SetProgress(IProgress<string> iProgress, string path, int itr)
        {
            N_total = (InputParamList.Count + 1) * N_trial - (itr + 1);
            if (N_trial == 1)
            { iProgress.Report(path); }
            else
            { iProgress.Report(path + " n=" + itr); }
        }

        public void VisibleChange(bool flag)
        {
            toolStripProgressBar1.Visible = flag;
            toolStripStatusLabel1.Visible = flag;
            if (!flag)
            {
                textBox1.Text = "Folder :";
                label3.Text = "Number of target files : 0";
            }
        }

        public void OnProgressChanged(string path)
        {
            listBox1.Items.Add(path);
            int N = listBox1.Items.Count;
            toolStripProgressBar1.Value = (int)(100.0 * N / (N + N_total));
            toolStripStatusLabel1.Text = N.ToString() + " / " + (N + N_total).ToString() + " : " + toolStripProgressBar1.Value.ToString() + "%";
            label3.Text = "Number of remaining target files : " + N_total / N_trial;
        }

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
