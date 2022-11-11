using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BPSE
{
    public partial class ColorMap : UserControl
    {
        public ColorMap()
        {
            InitializeComponent();
        }

        public ColorMap(LUT lut, int min, int max)
        {
            lutR = new byte[256];
            lutG = new byte[256];
            lutB = new byte[256];
            var table = new System.Collections.Generic.Dictionary<LUT, string>
            { { LUT.Gray, "Gray" }, { LUT.Red, "Red" }, { LUT.Green, "Green" }, { LUT.Blue, "Blue" }, { LUT.PseudoColor, "Pseudo color" } };
            SetLUT(table[lut]);
            lutMax = max;
            lutMin = min;
        }

        public enum LUT
        {
            Gray,
            Red,
            Green,
            Blue,
            PseudoColor,
        };

        #region EventHandler
        private void ColorMap_Load(object sender, EventArgs e)
        {
            TextMax_TextChanged(sender, e);
            TextMin_TextChanged(sender, e);
            lutR = new byte[256];
            lutG = new byte[256];
            lutB = new byte[256];
            lutPath = "";
            SetLUTPath();
            InitializeLUTList();
        }
        private void ComboBoxLUT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string p = Path.Combine(lutPath, comboBoxLUT.SelectedItem.ToString() + extension);
            if (File.Exists(p))
            {
                FileInfo file = new FileInfo(p);
                long size = file.Length;
                if (size == 768) //バイナリデータ
                {
                    using (FileStream fs = new FileStream(p, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        for (int i = 0; i <= byte.MaxValue; i++)
                        {
                            lutR[i] = br.ReadByte();
                        }
                        for (int i = 0; i <= byte.MaxValue; i++)
                        {
                            lutG[i] = br.ReadByte();
                        }
                        for (int i = 0; i <= byte.MaxValue; i++)
                        {
                            lutB[i] = br.ReadByte();
                        }
                    }
                }
                else //if (size == 2438) 
                {
                    using (FileStream fs = new FileStream(p, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string s = sr.ReadLine();
                        if (s.Split('\t')[0] == "Index")
                        {
                            //テキストデータ（タブ）
                            for (int i = 0; i <= byte.MaxValue; i++)
                            {
                                string[] ss = sr.ReadLine().Split('\t');
                                byte.TryParse(ss[1], out lutR[i]);
                                byte.TryParse(ss[2], out lutG[i]);
                                byte.TryParse(ss[3], out lutB[i]);
                            }
                        }
                        else
                        {
                            string[] ss = s.Split(' ');
                            if (ss.Length == 3)
                            {
                                byte.TryParse(ss[0], out lutR[0]);
                                byte.TryParse(ss[1], out lutG[0]);
                                byte.TryParse(ss[2], out lutB[0]);
                                //テキストデータ（スペース）
                                for (int i = 1; i <= byte.MaxValue; i++)
                                {
                                    ss = sr.ReadLine().Split(' ');
                                    byte.TryParse(ss[0], out lutR[i]);
                                    byte.TryParse(ss[1], out lutG[i]);
                                    byte.TryParse(ss[2], out lutB[i]);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                SetLUT(comboBoxLUT.SelectedItem.ToString());
            }
        }
        /// <summary>
        /// LUT最大値変更
        /// </summary>
        private void TextMax_TextChanged(object sender, EventArgs e)
        {
            if (textMax.Text == "")
            { textMax.Text = "0"; }
            else if (double.TryParse(textMax.Text, out double value))
            { lutMax = value; }
            else
            { textMax.Text = lutMax.ToString(); }
        }
        /// <summary>
        /// LUT最小値変更
        /// </summary>
        private void TextMin_TextChanged(object sender, EventArgs e)
        {
            if (textMax.Text == "")
            { textMax.Text = "0"; }
            else if (double.TryParse(textMin.Text, out double value))
            { lutMin = value; }
            else
            { textMin.Text = lutMin.ToString(); }
        }
        private void TextMin_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^A");
        }
        private void TextMax_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("^A");
        }
        private void ButtonGetLUT_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfDialog = new SaveFileDialog())
            {
                sfDialog.Title = "Save LUT sample image";
                sfDialog.DefaultExt = ".bmp";
                sfDialog.Filter = "BMP|*.bmp|JPG|*.jpg";
                sfDialog.FileName = "LUT (" + comboBoxLUT.Items[comboBoxLUT.SelectedIndex] + ")";
                if (sfDialog.ShowDialog() == DialogResult.OK)
                {
                    using (Bitmap bmp = new Bitmap(256, 32))
                    {
                        for (int j = 0; j < 32; j++)
                        {
                            for (int i = 0; i < 256; i++)
                            {
                                bmp.SetPixel(i, j, Color.FromArgb(lutR[i], lutG[i], lutB[i]));
                            }
                        }
                        bmp.Save(sfDialog.FileName);
                    }
                }
            }
        }
        private void ButtonReload_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = lutPath;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lutPath = folderBrowserDialog1.SelectedPath;
                // 自分自身の実行ファイルのパスを取得する
                string dir = Environment.CurrentDirectory;
                string path = Path.Combine(dir, "config.txt");
                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
                using (StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("Shift_JIS")))
                {
                    sw.WriteLine(lutPath);
                    InitializeLUTList();
                }
            }
        }
        #endregion

        private readonly string extension = ".lut";
        private string lutPath;
        private byte[] lutR, lutG, lutB;
        private double lutMin, lutMax;

        private void SetLUTPath()
        {
            // 自分自身の実行ファイルのパスを取得する
            string dir = Environment.CurrentDirectory;
            string path = Path.Combine(dir, "config.txt");
            // configファイルが存在しているなら
            if (File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("Shift_JIS")))
                {
                    lutPath = sr.ReadLine();
                }
                // lutPathが存在していなければconfigファイルを削除
                if (!Directory.Exists(lutPath))
                {
                    File.Delete(path);
                }
            }
        }
        private void SetLUT(string lut)
        {
            if (lut == "Pseudo color")
            {
                for (int i = 0; i <= byte.MaxValue; i++)
                {
                    // 疑似カラー
                    PseudoColor_byte(i, out lutR[i], out lutG[i], out lutB[i]);
                }
            }
            else if (lut == "Red")
            {
                for (int i = 0; i <= byte.MaxValue; i++)
                {
                    lutR[i] = (byte)i;
                    lutG[i] = 0;
                    lutB[i] = 0;
                }
            }
            else if (lut == "Green")
            {
                for (int i = 0; i <= byte.MaxValue; i++)
                {
                    lutR[i] = 0;
                    lutG[i] = (byte)i;
                    lutB[i] = 0;
                }
            }
            else if (lut == "Blue")
            {
                for (int i = 0; i <= byte.MaxValue; i++)
                {
                    lutR[i] = 0;
                    lutG[i] = 0;
                    lutB[i] = (byte)i;
                }
            }
            else// if (lut == "Grays")
            {
                for (int i = 0; i <= byte.MaxValue; i++)
                {
                    lutR[i] = (byte)i;
                    lutG[i] = (byte)i;
                    lutB[i] = (byte)i;
                }
            }
        }
        private void InitializeLUTList()
        {
            comboBoxLUT.Items.Clear();
            comboBoxLUT.Items.Add("Grays");
            comboBoxLUT.Items.Add("Red");
            comboBoxLUT.Items.Add("Green");
            comboBoxLUT.Items.Add("Blue");
            if (Directory.Exists(lutPath))
            {
                string[] lutPaths = Directory.GetFiles(lutPath);
                foreach (var item in lutPaths)
                {
                    string str = Path.GetFileNameWithoutExtension(item);
                    if (Path.GetExtension(item) == extension)
                    {
                        comboBoxLUT.Items.Add(str);
                    }
                }
            }
            comboBoxLUT.Items.Add("Pseudo color");
            comboBoxLUT.SelectedIndex = 0;
            for (int i = 0; i < comboBoxLUT.Items.Count; i++)
            {
                if ((string)comboBoxLUT.Items[i] == "physics")
                {
                    comboBoxLUT.SelectedIndex = i;
                    break;
                }
            }
        }

        /// <summary>
        /// 最大値、最小値からvalueの値をbyte形式に変換して出力します。
        /// </summary>
        /// <param name="value">入力値</param>
        /// <returns>出力値</returns>
        public byte GetValue(double value)
        {
            double dval = (value - lutMin) / (lutMax - lutMin) * 255.0;
            if (dval >= 255)
            { return 255; }
            else if (dval <= 0)
            { return 0; }
            else
            { return (byte)dval; }
        }
        /// <summary>
        /// valueに対応するRGBそれぞれの要素の色情報をbyte形式で出力します。
        /// </summary>
        /// <param name="value">0-255</param>
        /// <param name="red">0-255</param>
        /// <param name="green">0-255</param>
        /// <param name="blue">0-255</param>
        public void GetColor(int value, out byte red, out byte green, out byte blue)
        {
            red = lutR[value];
            green = lutG[value];
            blue = lutB[value];
        }
        public Color GetColor(double value)
        {
            byte val = GetValue(value);
            return Color.FromArgb(lutR[val], lutG[val], lutB[val]);
        }
        /// <summary>
        /// valueに対応するRGBそれぞれの要素の色情報の最大値を1に正規化して出力します。
        /// </summary>
        /// <param name="value">0-255</param>
        /// <param name="red">0-1</param>
        /// <param name="green">0-1</param>
        /// <param name="blue">0-1</param>
        public void GetColor(int value, out double red, out double green, out double blue)
        {
            red = lutR[value] / (double)byte.MaxValue;
            green = lutG[value] / (double)byte.MaxValue;
            blue = lutB[value] / (double)byte.MaxValue;
        }

        /// <summary>
        /// 疑似カラー(byte)
        /// </summary>
        /// <param name="value"></param>
        /// <param name="Red"></param>
        /// <param name="Gre"></param>
        /// <param name="Blu"></param>
        private static void PseudoColor_byte(double value, out byte Red, out byte Gre, out byte Blu)
        {
            if (value >= 0.0 && value < 63.0)
            {
                Red = 0;
                Gre = (byte)(255.0 * value / 63.0);
                Blu = 255;
            }
            else if (value >= 63.0 && value < 127.0)
            {
                Red = 0;
                Gre = 255;
                Blu = (byte)(255.0 - 255.0 * (value - 63.0) / 64.0);
            }
            else if (value >= 127.0 && value < 191.0)
            {
                Red = (byte)(255.0 * (value - 127.0) / 64.0);
                Gre = 255;
                Blu = 0;
            }
            else if (value >= 191.0 && value <= 255.0)
            {
                Red = 255;
                Gre = (byte)(255.0 - 255.0 * (value - 191.0) / 64.0);
                Blu = 0;
            }
            else
            {
                Red = 0;
                Gre = 0;
                Blu = 0;
            }
        }
    }
}
