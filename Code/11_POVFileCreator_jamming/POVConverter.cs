using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace BPSE
{
    class POVConverter
    {
        /// <summary>
        /// 六角格子座標から実座標へのy軸の補正係数Correction factor: sqrt(3)/2
        /// </summary>
        private static readonly double cf = Math.Sqrt(3) / 2.0;

        public static string Start()
        {
            return @"
#declare a = 1.0 / sqrt(3);
#declare cf = sqrt(3) / 2.0;";
        }

        /// <summary>
        /// 六角柱を作成する
        /// </summary>
        /// <param name="hexX">x座標</param>
        /// <param name="hexY">y座標</param>
        /// <param name="hexZ">z座標</param>
        /// <param name="color">rgb</param>
        /// <param name="f">filter</param>
        /// <param name="t">transmit</param>
        /// <returns></returns>
        public static string Prism(int hexX, int hexY, int hexZ, double scale, Color color, double f = 0.0, double t = 0.0)
        {
            double x = hexX / 2.0;
            double y = hexY * cf;
            double z = hexZ;
            double r = color.R / 255.0;
            double g = color.G / 255.0;
            double b = color.B / 255.0;

            string s = @"
prism {
    0.5, -0.5, 7,
    <0, -a>, < 0.5, -0.5*a>, < 0.5,  0.5*a>,
    <0,  a>, <-0.5,  0.5*a>, <-0.5, -0.5*a>,
    <0, -a>
    pigment { rgbft <" + r + ", " + g + ", " + b + ", " + f + ", " + t + @"> }
    scale " + scale + @"
    rotate x*90
    translate <" + x + ", " + y + ", " + z + @">
}";

            return s;
        }
        /// <summary>
        /// 輪郭を作成する
        /// </summary>
        /// <param name="hexX">x座標</param>
        /// <param name="hexY">y座標</param>
        /// <param name="hexZ">z座標</param>
        /// <param name="scale">倍率</param>
        /// <param name="color">rgb</param>
        /// <param name="thickness">輪郭線の太さ</param>
        /// <returns></returns>
        public static string AddContour(int hexX, int hexY, int hexZ, double scale, Color color, double thickness = 0.05)
        {
            double r = color.R / 255.0;
            double g = color.G / 255.0;
            double b = color.B / 255.0;

            string col = "<" + r + ", " + g + ", " + b + ">";
            string tra = "<" + hexX + "*0.5, " + hexY + "*cf, " + hexZ + ">";
            return @"
sphere_sweep {
    linear_spline,
    24,
    < 0.0,     -a,  0.5>, " + thickness + @"
    < 0.5, -0.5*a,  0.5>, " + thickness + @"
    < 0.5, -0.5*a, -0.5>, " + thickness + @"
    < 0.5,  0.5*a, -0.5>, " + thickness + @"
    < 0.5,  0.5*a,  0.5>, " + thickness + @"
    < 0.0,      a,  0.5>, " + thickness + @"
    < 0.0,      a, -0.5>, " + thickness + @"
    <-0.5,  0.5*a, -0.5>, " + thickness + @"
    <-0.5,  0.5*a,  0.5>, " + thickness + @"
    <-0.5, -0.5*a,  0.5>, " + thickness + @"
    <-0.5, -0.5*a, -0.5>, " + thickness + @"
    < 0.0,     -a, -0.5>, " + thickness + @"
    < 0.0,     -a,  0.5>, " + thickness + @"

    <-0.5, -0.5*a,  0.5>, " + thickness + @"
    <-0.5, -0.5*a, -0.5>, " + thickness + @"
    <-0.5,  0.5*a, -0.5>, " + thickness + @"
    <-0.5,  0.5*a,  0.5>, " + thickness + @"
    < 0.0,      a,  0.5>, " + thickness + @"
    < 0.0,      a, -0.5>, " + thickness + @"
    < 0.5,  0.5*a, -0.5>, " + thickness + @"
    < 0.5,  0.5*a,  0.5>, " + thickness + @"
    < 0.5, -0.5*a,  0.5>, " + thickness + @"
    < 0.5, -0.5*a, -0.5>, " + thickness + @"
    < 0.0,     -a, -0.5>, " + thickness + @"

    pigment { rgbft " + col + @" }
    scale " + scale + @"
    translate " + tra + @"
}";
        }

        public static string Polygon(int Xsize, int Ysize, Color color)
        {
            double r = color.R / 255.0;
            double g = color.G / 255.0;
            double b = color.B / 255.0;

            return @"
    polygon {
        4,
        <0, 0, 0.5>,
        <" + Xsize + ", 0, 0.5" + @">,
        <" + Xsize + ", " + (Ysize * cf) + @", 0.5>,
        <0, " + (Ysize * cf) + @", 0.5>
        pigment { rgb <" + r + ", " + g + ", " + b + @"> }
    }
";
        }
    }
}
