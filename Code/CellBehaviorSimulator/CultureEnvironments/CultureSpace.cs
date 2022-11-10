using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CellBehaviorSimulator.CultureEnvironments
{
    public partial class CultureSpace : UserControl
    {
        public CultureSpace()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void CultureSpace_Load(object sender, EventArgs e)
        {
            comboBoxMap.SelectedIndex = 0;
            _mapType = comboBoxMap.Text;
            _type = TYPE.Square;
            Xsize = (int)numX.Value;
            Ysize = (int)numY.Value;
            Zsize = (int)numZ.Value;
            Map = null;
            Size_lc = (double)num_lc.Value;
            Size_hc = (double)num_hc.Value;
        }

        private void Num_lc_ValueChanged(object sender, EventArgs e)
        {
            Size_lc = (double)num_lc.Value;
            // (Surface area) = 9 cm^2 // "35mm dish"
            if (_mapType == comboBoxMap.Items[2].ToString())
            {
                numX.Value = (int)(35.0 * 1000 / Size_lc + 2);
                numY.Value = (int)(35.0 * 1000 / Size_lc / Delta.Cf_y + 2);
            }
            // (Surface area) = 55 cm^2 // "100mm dish"
            else if (_mapType == comboBoxMap.Items[3].ToString())
            {
                numX.Value = (int)(100.0 * 1000 / Size_lc + 2);
                numY.Value = (int)(100.0 * 1000 / Size_lc / Delta.Cf_y + 2);
            }
            num_hc.Value = num_lc.Value;
        }
        private void Num_hc_ValueChanged(object sender, EventArgs e)
        {
            Size_hc = (double)num_hc.Value;
        }
        private void ComboBoxMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            _mapType = comboBoxMap.Text;
            // (Surface area) = 9 cm^2 // "35mm dish"
            if (_mapType == comboBoxMap.Items[2].ToString())
            {
                numX.Enabled = false;
                numY.Enabled = false;
                numX.Value = (int)(35.0 * 1000 / Size_lc + 2);
                numY.Value = (int)(35.0 * 1000 / Size_lc / Delta.Cf_y + 2);
            }
            // (Surface area) = 55 cm^2 // "100mm dish"
            else if (_mapType == comboBoxMap.Items[3].ToString())
            {
                numX.Enabled = false;
                numY.Enabled = false;
                numX.Value = (int)(100.0 * 1000 / Size_lc + 2);
                numY.Value = (int)(100.0 * 1000 / Size_lc / Delta.Cf_y + 2);
            }
            else
            {
                numX.Enabled = true;
                numY.Enabled = true;
            }
            if (comboBoxMap.SelectedIndex == 0)
            { _type = TYPE.Square; }
            else
            { _type = TYPE.Circle; }
        }
        private void NumX_ValueChanged(object sender, EventArgs e)
        { Xsize = (int)numX.Value; }
        private void NumY_ValueChanged(object sender, EventArgs e)
        { Ysize = (int)numY.Value; }
        private void NumZ_ValueChanged(object sender, EventArgs e)
        { Zsize = (int)numZ.Value; }
        #endregion
        #region Parameter setting
        internal void SetParameter()
        {
            comboBoxMap.SelectedIndex = (int)_type;
            num_lc.Value = (decimal)Size_lc;
            num_hc.Value = (decimal)Size_hc;
            numX.Value = Xsize;
            numY.Value = Ysize;
            numZ.Value = Zsize;
        }
        #endregion
        #region Parameter definitions
        public static void WriteParameter(System.IO.StreamWriter sw)
        {
            sw.WriteLine(":,l_c," + Size_lc);
            sw.WriteLine(":,Xsize," + Xsize);
            sw.WriteLine(":,Ysize," + Ysize);
            sw.WriteLine(":,Zsize," + Zsize);
            sw.WriteLine(":,VesselType," + (int)_type + ",# 0 -> Square; 1 -> Circle");
        }
        public static bool ReadParameter(string strName, string strValue)
        {
            switch (strName)
            {
                case "l_c": return SetParameter_l_c(strValue);
                case "Xsize": return SetParameter_Xsize(strValue);
                case "Ysize": return SetParameter_Ysize(strValue);
                case "Zsize": return SetParameter_Zsize(strValue);
                case "VesselType": return SetParameter_VesselType(strValue);
                default: return false;
            }
        }
        public static void ClearParameter()
        { Size_lc = 1; Xsize = 3; Ysize = 3; Zsize = 3; _type = TYPE.Square; }
        private static bool SetParameter_l_c(string strVal)
        {
            if (double.TryParse(strVal, out double val))
            {
                Size_lc = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_Xsize(string strVal)
        {
            if (int.TryParse(strVal, out int val))
            {
                Xsize = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_Ysize(string strVal)
        {
            if (int.TryParse(strVal, out int val))
            {
                Ysize = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_Zsize(string strVal)
        {
            if (int.TryParse(strVal, out int val))
            {
                Zsize = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_VesselType(string strVal)
        {
            if (int.TryParse(strVal, out int val) && (val == 0 || val == 1))
            {
                _type = (TYPE)val;
                return true;
            }
            return false;
        }
#endregion

        private static string _mapType;
        private static TYPE _type;
        private static int[,,] Map;
        public static int[,,] MapPre;

        internal static double Size_lc { get; private set; }
        internal static double Size_hc { get; private set; }
        internal static int Xsize { get; private set; }
        internal static int Ysize { get; private set; }
        internal static int Zsize { get; private set; }
        internal static bool MapEnabled => Map != null;

        private enum TYPE
        {
            Square = 0,
            Circle = 1,
        }

        public static bool MapCreation()
        {
            switch (_type)
            {
                case TYPE.Square:
                    Creation_Square();
                    return true;
                case TYPE.Circle:
                    Creation_Circle();
                    return true;
                default:
                    return false;
            }
        }

        private static void Creation_Square()
        {
            Map = new int[Zsize, Ysize, Xsize];

            for (int j = 1; j < Ysize - 1; j++)
            {
                for (int i = 1; i < Xsize - 1; i++)
                {
                    SetMap(i * 2, j, Zsize - 1, -2); // block
                }
            }
            for (int k = 1; k < Zsize - 1; k++)
            {
                for (int j = 1; j < Ysize - 1; j++)
                {
                    for (int i = 1; i < Xsize - 1; i++)
                    {
                        SetMap(i * 2, j, k, -1); // empty grid
                    }
                }
            }
            for (int k = 0; k < Zsize; k++)
            {
                for (int j = 0; j < Ysize; j++)
                {
                    SetMap(0, j, k, -2); // block
                    SetMap((Xsize - 1) * 2, j, k, -2); // block
                }
            }
            for (int k = 0; k < Zsize; k++)
            {
                for (int i = 0; i < Xsize; i++)
                {
                    SetMap(i * 2, 0, k, -2); // block
                    SetMap(i * 2, Ysize - 1, k, -2); // block
                }
            }
            for (int j = 0; j < Ysize; j++)
            {
                for (int i = 0; i < Xsize; i++)
                {
                    SetMap(i * 2, j, 0, -3); // substrate
                }
            }
        }
        private static void Creation_Circle()
        {
            Map = new int[Zsize, Ysize, Xsize];

            int y2 = Ysize / 2 - 1;
            double x2 = y2 % 2 == 0 ? Xsize / 2 - 1 : Xsize / 2 - 0.5;
            double y3 = Ysize * Delta.Cf_y / 2.0;
            double r = (y3 < x2 ? y3 : x2) - 1;

            for (int j = 0; j < Ysize; j++)
            {
                for (int i = 0; i < Xsize; i++)
                {
                    double len = j % 2 == 0
                        ? Delta.GetLength(new Delta((int)((i - x2) * 2), j - y2, 0))
                        : Delta.GetLength(new Delta((int)((i - x2) * 2 + 1), j - y2, 0));
                    if (len <= r)
                    {
                        for (int k = 1; k < Zsize - 1; k++)
                        {
                            SetMap(i * 2, j, k, -1); // empty grid
                        }
                    }
                    else
                    {
                        for (int k = 1; k < Zsize - 1; k++)
                        {
                            SetMap(i * 2, j, k, -2); // block
                        }
                    }
                    SetMap(i * 2, j, 0, -3); // substrate
                    SetMap(i * 2, j, Zsize - 1, -2); // block
                }
            }
        }

        internal static int GetMap(int row, int col, int dep)
        {
            return Map[dep, col, row / 2];
        }
        internal static int GetMap(Point3D point)
        {
            return GetMap(point.X, point.Y, point.Z);
        }
        internal static int GetMap(Point3D point, Delta delta)
        {
            return GetMap(point + delta);
        }

        internal static void SetMap(int row, int col, int dep, int value)
        {
            Map[dep, col, row / 2] = value;
        }
        internal static void SetMap(Point3D point, int value)
        {
            SetMap(point.X, point.Y, point.Z, value);
        }

        internal static bool IsCorrect(Point3D point, int ind, out int result)
        {
            result = GetMap(point);
            return result == ind;
        }
        internal static bool IsCorrect(List<CellData> cells, int id, out int result)
        {
            return IsCorrect(cells[id].Location, cells[id].Index, out result);
        }
    }
}
