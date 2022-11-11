using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BPSE
{
    public partial class VisualizationUsingHexagons : UserControl
    {
        public VisualizationUsingHexagons()
        {
            InitializeComponent();
        }

        private void ButtonBackgroundColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pictureBoxBackgroudColor.BackColor;
            if (colorDialog1.ShowDialog()== DialogResult.OK)
            {
                pictureBoxBackgroudColor.BackColor = colorDialog1.Color;
            }
        }
        private void ButtonBoundaryColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pictureBoxBoundaryColor.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxBoundaryColor.BackColor = colorDialog1.Color;
            }
        }
        private void CheckBoxBoundaryColor_CheckedChanged(object sender, EventArgs e)
        {
            if (DrawBoundary)
            {
                buttonBoundaryColor.Enabled = true;
                labelPenWidth.Enabled = true;
                numPenWidth.Enabled = true;
            }
            else
            {
                buttonBoundaryColor.Enabled = false; 
                labelPenWidth.Enabled = false;
                numPenWidth.Enabled = false;
            }
        }
        private void NumZsize_ValueChanged(object sender, EventArgs e)
        {
            NumSpecZ.Maximum = NumDepth.Value - 2;
        }
        private void CheckBoxSpecZ_CheckedChanged(object sender, EventArgs e)
        {
            if (SpecZ)
            { NumSpecZ.Enabled = true; }
            else
            { NumSpecZ.Enabled = false; }
        }

        /// <summary>
        /// 六角格子座標から実座標へのy軸の補正係数Correction factor: sqrt(3)/2
        /// </summary>
        private readonly double cf = Math.Sqrt(3) / 2.0;

        public double X => (double)NumX.Value;
        public double Y => (double)NumY.Value;
        public int Xsize => (int)NumWidth.Value;
        public int Ysize => (int)NumHeight.Value;
        public int Zsize => (int)NumDepth.Value;
        public int Magnification => (int)NumMag.Value;
        private int Z => (int)NumSpecZ.Value;
        private bool SpecZ => checkBoxSpecZ.Checked;
        private bool DrawBoundary => checkBoxBoundaryColor.Checked;
        private Color GetBackColor => pictureBoxBackgroudColor.BackColor;

        /// <summary>
        /// 描画用のBitmapクラス配列を初期化します。
        /// </summary>
        /// <returns></returns>
        public Bitmap[] InitializeBitmap()
        {
            try
            {
                int x = (int)Math.Ceiling((Xsize + 0.5) * Magnification);
                int y = (int)Math.Ceiling(((Ysize - 1.0) * cf + 1.0 / cf) * Magnification);
                Bitmap[] bmp = new Bitmap[SpecZ ? 1 : (Zsize - 2)];
                // ImageオブジェクトのGraphicsオブジェクトを作成する
                for (int j = 0; j < bmp.Length; j++)
                {
                    bmp[j] = new Bitmap(x, y);
                    using (Graphics gra = Graphics.FromImage(bmp[j]))
                    {
                        // 全体を塗りつぶす
                        gra.FillRectangle(new SolidBrush(GetBackColor), gra.VisibleClipBounds);
                    }
                }
                return bmp;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("ERROR: The image to save is too large to allocate memory.\n\n" +
                    "width(px)  : " + (int)Math.Ceiling((Xsize + 0.5) * Magnification) +
                    "\nheight(px) : " + (int)Math.Ceiling(((Ysize - 1.0) * cf + 1.0) * Magnification) +
                    "\ndepth(px)  : " + (Zsize - 2));
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// 六角形を描画します。
        /// </summary>
        /// <param name="canvas"></param>
        /// <param name="hexX"></param>
        /// <param name="hexY"></param>
        /// <param name="hexZ"></param>
        /// <param name="color"></param>
        public void SetHexagon(Bitmap[] canvas, int hexX, int hexY, int hexZ, Color color)
        {
            int dep = 0;
            if (SpecZ)
            {
                if (hexZ != Z) { return; }
            }
            else
            {
                dep = hexZ - 1;
                if (dep >= canvas.Length) { return; }
            }
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            using (Graphics g = Graphics.FromImage(canvas[dep]))
            //Brushオブジェクトの作成
            using (SolidBrush b = new SolidBrush(color))
            {
                Point[] points = SetPoints(hexX, hexY);
                //作成したブラシを使って描画する
                g.FillClosedCurve(b, points, FillMode.Alternate, 0.0F);
                if (DrawBoundary)
                {
                    Pen p = new Pen(pictureBoxBoundaryColor.BackColor, (int)numPenWidth.Value);
                    g.DrawPolygon(p, points);
                    p.Dispose();
                }
            }
        }
        private Point[] SetPoints(int hexX, double hexY)
        {
            // 六角形の一辺の長さ
            double a = Magnification / cf * 0.5;
            Point[] points = new Point[6];
            double cenX = (hexX - X * 2.0 + 1.0) * Magnification * 0.5;
            double cenY = (hexY - Y) * Magnification * cf + a;
            points[0] = new Point((int)cenX, (int)(cenY - a));
            points[1] = new Point((int)(cenX + Magnification * 0.5), (int)(cenY - a * 0.5));
            points[2] = new Point((int)(cenX + Magnification * 0.5), (int)(cenY + a * 0.5));
            points[3] = new Point((int)cenX, (int)(cenY + a));
            points[4] = new Point((int)(cenX - Magnification * 0.5), (int)(cenY + a * 0.5));
            points[5] = new Point((int)(cenX - Magnification * 0.5), (int)(cenY - a * 0.5));
            return points;
        }

        /// <summary>
        /// 画像をdir方向に結合する
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dir"></param>
        /// <returns></returns>
        public Bitmap CombineImage(Bitmap[] src, PlacementDirection dir, bool border = true)
        {
            if (SpecZ) return src[0];
            Bitmap bmp;
            switch (dir)
            {
                case PlacementDirection.HORIZONTAL:
                    bmp = ImageCombineH(src);
                    if (border)
                    {
                        using (Graphics gra = Graphics.FromImage(bmp))
                        {
                            // 層の境界線を描画（色は背景の補色）
                            using (Pen pen = new Pen(Color.FromArgb(GetBackColor.ToArgb() ^ 0xFFFFFF)))
                            {
                                for (int i = 1; i < Zsize - 2; i++)
                                {
                                    int w = (int)(i * bmp.Width / (Zsize - 2.0));
                                    gra.DrawLine(pen, w, 0, w, bmp.Height - 1);
                                }
                                return bmp;
                            }
                        }
                    }
                    else
                    {
                        return bmp;
                    }
                case PlacementDirection.VERTICAL:
                    bmp = ImageCombineV(src);
                    if (border)
                    {
                        using (Graphics gra = Graphics.FromImage(bmp))
                        {
                            // 層の境界線を描画（色は背景の補色）
                            using (Pen pen = new Pen(Color.FromArgb(GetBackColor.ToArgb() ^ 0xFFFFFF)))
                            {
                                for (int i = 1; i < Zsize - 2; i++)
                                {
                                    int h = (int)(i * bmp.Height / (Zsize - 2.0));
                                    gra.DrawLine(pen, 0, h, bmp.Width - 1, h);
                                }
                                return bmp;
                            }
                        }
                    }
                    else
                    {
                        return bmp;
                    }
                default:
                    return null;
            }
        }

        public enum PlacementDirection
        {
            HORIZONTAL,
            VERTICAL,
        }

        /// <summary>
        /// 画像を縦に結合する
        /// </summary>
        /// <param name="src">結合するBitmapの配列</param>
        /// <returns>結合されたBitmapオブジェクト</returns>
        private Bitmap ImageCombineV(Bitmap[] src)
        {
            // 結合後のサイズを計算
            int dstWidth = 0, dstHeight = 0;
            System.Drawing.Imaging.PixelFormat dstPixelFormat = System.Drawing.Imaging.PixelFormat.Format8bppIndexed;

            for (int i = 0; i < src.Length; i++)
            {
                if (dstWidth < src[i].Width) dstWidth = src[i].Width;
                dstHeight += src[i].Height;

                // 最大のビット数を検索
                if (Bitmap.GetPixelFormatSize(dstPixelFormat)
                    < Bitmap.GetPixelFormatSize(src[i].PixelFormat))
                {
                    dstPixelFormat = src[i].PixelFormat;
                }
            }

            var dst = new Bitmap(dstWidth, dstHeight, dstPixelFormat);
            var dstRect = new Rectangle();

            using (var g = Graphics.FromImage(dst))
            {
                for (int i = 0; i < src.Length; i++)
                {
                    dstRect.Width = src[i].Width;
                    dstRect.Height = src[i].Height;

                    // 描画
                    g.DrawImage(src[i], dstRect, 0, 0, src[i].Width, src[i].Height, GraphicsUnit.Pixel);

                    // 次の描画先
                    dstRect.Y = dstRect.Bottom;
                }
            }
            return dst;
        }

        /// <summary>
        /// 画像を横に結合する
        /// </summary>
        /// <param name="src">結合するBitmapの配列</param>
        /// <returns>結合されたBitmapオブジェクト</returns>
        private Bitmap ImageCombineH(Bitmap[] src)
        {
            // 結合後のサイズを計算
            int dstWidth = 0, dstHeight = 0;
            System.Drawing.Imaging.PixelFormat dstPixelFormat = System.Drawing.Imaging.PixelFormat.Format8bppIndexed;

            for (int i = 0; i < src.Length; i++)
            {
                dstWidth += src[i].Width;
                if (dstHeight < src[i].Height) dstHeight = src[i].Height;

                // 最大のビット数を検索
                if (Image.GetPixelFormatSize(dstPixelFormat)
                    < Image.GetPixelFormatSize(src[i].PixelFormat))
                {
                    dstPixelFormat = src[i].PixelFormat;
                }
            }

            var dst = new Bitmap(dstWidth, dstHeight, dstPixelFormat);
            var dstRect = new Rectangle();

            using (var g = Graphics.FromImage(dst))
            {
                for (int i = 0; i < src.Length; i++)
                {
                    dstRect.Width = src[i].Width;
                    dstRect.Height = src[i].Height;

                    // 描画
                    g.DrawImage(src[i], dstRect, 0, 0, src[i].Width, src[i].Height, GraphicsUnit.Pixel);

                    // 次の描画先
                    dstRect.X = dstRect.Right;
                }
            }
            return dst;
        }
    }
}
