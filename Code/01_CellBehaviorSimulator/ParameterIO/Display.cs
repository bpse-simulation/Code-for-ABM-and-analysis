using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using CellBehaviorSimulator.CultureEnvironments;

namespace CellBehaviorSimulator
{
    public partial class Display : UserControl
    {
        public Display()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void RadioIndex_CheckedChanged(object sender, EventArgs e)
        {
            mod = Mode.Index;
        }
        private void RadioCellType_CheckedChanged(object sender, EventArgs e)
        {
            mod = Mode.CellType;
        }
        private void RadioCellState_CheckedChanged(object sender, EventArgs e)
        {
            mod = Mode.CellState;
        }
        private void CheckAutoReload_CheckedChanged(object sender, EventArgs e)
        {
            buttonReload.Enabled = !checkAutoReload.Checked;
            label1.Enabled = checkAutoReload.Checked;
            numInterval.Enabled = checkAutoReload.Checked;
            if (checkAutoReload.Checked)
            {
                AutoReload();
            }
        }
        private void NumZ_ValueChanged(object sender, EventArgs e)
        {
            numZ.Maximum = CultureSpace.Zsize - 1;
        }
        private void ButtonReload_Click(object sender, EventArgs e)
        {
            DrawImage();
        }
        #endregion

        public void DrawImage()
        {
            if (CultureSpace.MapEnabled)
            {
                if (mod == Mode.Index)
                {
                    while (indexColor.Count < CellData.CellsPre.Length)
                    {
                        indexColor.Add(random.Next(256));
                    }
                }
                int dep = (int)numZ.Value;
                if (dep >= CultureSpace.Zsize)
                { dep = CultureSpace.Zsize - 1; }
                Bitmap image = new Bitmap(CultureSpace.Xsize * 2, CultureSpace.Ysize);
                for (int j = 0; j < CultureSpace.Ysize; j++)
                {
                    for (int i = 0; i < CultureSpace.Xsize; i++)
                    {
                        int val = CultureSpace.MapPre[dep, j, i];
                        Color color = SetColor(val);
                        if (j % 2 == 0)
                        {
                            image.SetPixel(i * 2, j, color);
                        }
                        else
                        {
                            int val1 = CultureSpace.MapPre[dep, j, (i * 2 - 1) / 2];
                            Color color1 = SetColor(val1);
                            image.SetPixel(i * 2, j, color1);
                        }
                        image.SetPixel(i * 2 + 1, j, color);
                    }
                }
                int w = pictureBox1.Width;
                int h = pictureBox1.Height;
                if ((double)w / h < (double)CultureSpace.Xsize / CultureSpace.Ysize * Delta.Cf_y)
                { h = (int)(w * CultureSpace.Ysize * Delta.Cf_y / CultureSpace.Xsize); }
                else { w = (int)(h * CultureSpace.Xsize / (CultureSpace.Ysize * Delta.Cf_y)); }
                Bitmap canvas = new Bitmap(w, h);
                using (Graphics g = Graphics.FromImage(canvas))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                    g.DrawImage(image, 0, 0, w, h);
                    pictureBox1.Image = canvas;
                }
                image.Dispose();
            }
        }

        public async void AutoReload()
        {
            await Task.Run(() => {
                while (checkAutoReload.Checked && RunSW)
                {
                    try
                    {
                        DrawImage();
                        System.Threading.Thread.Sleep(1000 * (int)numInterval.Value);
                    }
                    catch (Exception)
                    {
                        break;
                    }
                }
            });
        }

        private enum Mode
        {
            Index = 0,
            CellType = 1,
            CellState = 2,
        }
        private static Mode mod;
        private static readonly Random random = new Random(0);
        private static readonly List<int> indexColor = new List<int>();

        public static bool RunSW { get; set; }

        private static Color SetColor(int val)
        {
            byte red, green, blue;
            if (val == -1) { red = green = blue = 0; }
            else if (val == -2) { red = green = blue = 128; }
            else if (val == -3) { red = green = blue = 64; }
            else
            {
                double value = 0;
                try
                {
                    switch (mod)
                    {
                        case Mode.Index:
                            value = indexColor[val];
                            break;
                        case Mode.CellType:
                            value = CellBehaviors.Behaviors.Maximum == 1
                                ? 128
                                : (double)CellData.CellsPre[val].Cell_T / (CellBehaviors.Behaviors.Maximum - 1) * 127.0 + 128.0;
                            break;
                        case Mode.CellState:
                            value = (double)(CellData.CellsPre[val].Cell_S - 1) / 2.0 * 255.0;
                            break;
                        default:
                            break;
                    }
                    PseudoColor_byte(value, out red, out green, out blue);
                }
                catch (Exception)
                {
                    if (exCnt++ < 10)
                    { return SetColor(val); }
                    else
                    {
                        exCnt = 0;
                        return Color.FromArgb(0, 0, 0);
                    }
                }
            }
            exCnt = 0;
            return Color.FromArgb(red, green, blue);
        }
        private static int exCnt = 0;

        private static void PseudoColor_byte(double value, out byte red, out byte green, out byte blue)
        {
            if (value >= 0.0 && value < 63.0)
            {
                red = 0;
                green = (byte)(255.0 * value / 63.0);
                blue = 255;
            }
            else if (value >= 63.0 && value < 127.0)
            {
                red = 0;
                green = 255;
                blue = (byte)(255.0 - 255.0 * (value - 63.0) / 64.0);
            }
            else if (value >= 127.0 && value < 191.0)
            {
                red = (byte)(255.0 * (value - 127.0) / 64.0);
                green = 255;
                blue = 0;
            }
            else if (value >= 191.0 && value <= 255.0)
            {
                red = 255;
                green = (byte)(255.0 - 255.0 * (value - 191.0) / 64.0);
                blue = 0;
            }
            else
            {
                red = 0;
                green = 0;
                blue = 0;
            }
        }

    }
}
