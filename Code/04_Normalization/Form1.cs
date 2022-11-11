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

namespace Normalization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string openfolder, savefolder;
        private string[] files;
        private string sTime;

        private void Form1_Load(object sender, EventArgs e)
        {
            sTime = textBox1.Text;
        }

        private void TextBoxOpenFolder_TextChanged(object sender, EventArgs e)
        {
            openfolder = textBoxOpenFolder.Text;
        }

        private void TextBoxSaveFolder_TextChanged(object sender, EventArgs e)
        {
            savefolder = textBoxSaveFolder.Text;
        }

        private void ButtonOpenFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(openfolder))
            {
                folderBrowserDialog1.SelectedPath = openfolder;
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                openfolder = folderBrowserDialog1.SelectedPath;
                textBoxOpenFolder.Text = openfolder;
            }
        }

        private void TextBoxSaveFolder_Leave(object sender, EventArgs e)
        {
            if (textBoxSaveFolder.Text != "")
            {
                if (Directory.Exists(textBoxSaveFolder.Text))
                { savefolder = textBoxSaveFolder.Text; }
                else
                {
                    DialogResult dr = MessageBox.Show("The given path does not refer to an existing directory on disk.\nCreate a new folder : " + textBoxSaveFolder.Text, "Caution", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            Directory.CreateDirectory(textBoxSaveFolder.Text);
                            savefolder = textBoxSaveFolder.Text;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Can not create a new folder.");
                            textBoxSaveFolder.Focus();
                            textBoxSaveFolder.SelectAll();
                        }
                    }
                    else
                    {
                        textBoxSaveFolder.Focus();
                        textBoxSaveFolder.SelectAll();
                    }
                }
            }
        }

        private void ButtonSaveFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(savefolder))
            {
                folderBrowserDialog1.SelectedPath = savefolder;
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                savefolder = folderBrowserDialog1.SelectedPath;
                textBoxSaveFolder.Text = savefolder;
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (textBoxOpenFolder.Text == "")
            {
                MessageBox.Show("Select the folder.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ButtonOpenFolder_Click(sender, e);
            }
            else if (textBoxSaveFolder.Text == "")
            {
                MessageBox.Show("Select the folder.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ButtonSaveFolder_Click(sender, e);
            }
            else
            {
                RunAsync();
            }
        }

        private async void RunAsync()
        {

            await Task.Run(() => Run());

        }
        private void Run()
        {
            files = Directory.GetFiles(openfolder, textPattern.Text);

            for (int i = 0; i < files.Length; i++)
            {


                string openfilename = files[i];
                string filename = Path.GetFileNameWithoutExtension(files[i]);
                string savefilename = Path.Combine(savefolder, filename + "_normalized.csv");
                List<string> name = new List<string>();
                List<double> value = new List<double>();
                double s = double.MinValue;

                using (FileStream fs = new FileStream(openfilename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] strs = sr.ReadLine().Split(',');
                        name.Add(strs[0]);
                        double.TryParse(strs[1], out double v);
                        value.Add(v);
                        if (strs[0] == sTime)
                        {
                            s = v;
                        }
                    }
                }
                using (StreamWriter sw = new StreamWriter(File.OpenWrite(savefilename)))
                {
                    for (int j = 0; j < name.Count; j++)
                    {
                        sw.WriteLine(name[j] + "," + value[j] / s);
                    }
                }
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            sTime = textBox1.Text;
        }

    }
}
