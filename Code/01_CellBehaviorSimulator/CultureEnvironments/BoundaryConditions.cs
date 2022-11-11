using System;
using System.Windows.Forms;

namespace CellBehaviorSimulator.CultureEnvironments
{
    public partial class BoundaryConditions : UserControl
    {
        public BoundaryConditions()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void BoundaryConditions_Load(object sender, EventArgs e)
        {
            PB_X = checkBoxPB_X.Checked;
            PB_Y = checkBoxPB_Y.Checked;
            PB_Z = checkBoxPB_Z.Checked;
        }
        private void CheckBoxPB_X_CheckedChanged(object sender, EventArgs e)
        { PB_X = checkBoxPB_X.Checked; }
        private void CheckBoxPB_Y_CheckedChanged(object sender, EventArgs e)
        { PB_Y = checkBoxPB_Y.Checked; }
        private void CheckBoxPB_Z_CheckedChanged(object sender, EventArgs e)
        { PB_Z = checkBoxPB_Z.Checked; }
        #endregion
        #region Parameter setting
        internal void SetParameter()
        {
            checkBoxPB_X.Checked = PB_X;
            checkBoxPB_Y.Checked = PB_Y;
            checkBoxPB_Z.Checked = PB_Z;
        }
        #endregion
        #region Parameter definitions
        public static void WriteParameter(System.IO.StreamWriter sw)
        {
            if (PB_X)
            { sw.WriteLine(":,PeriodicBoundary_X," + PB_X); }
            if (PB_Y)
            { sw.WriteLine(":,PeriodicBoundary_Y," + PB_Y); }
            if (PB_Z)
            { sw.WriteLine(":,PeriodicBoundary_Z," + PB_Z); }
        }
        public static bool ReadParameter(string strName, string strValue)
        {
            switch (strName)
            {
                case "PeriodicBoundary_X": return SetParameter_PeriodicBoundary_X(strValue);
                case "PeriodicBoundary_Y": return SetParameter_PeriodicBoundary_Y(strValue);
                case "PeriodicBoundary_Z": return SetParameter_PeriodicBoundary_Z(strValue);
                default: return false;
            }
        }
        public static void ClearParameter()
        { PB_X = false; PB_Y = false; PB_Z = false; }
        private static bool SetParameter_PeriodicBoundary_X(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                PB_X = val;
                return true;
            }
            else if (int.TryParse(strVal, out int val2) && val2 == 1)
            {
                PB_X = true;
                return true;
            }
            return false;
        }
        private static bool SetParameter_PeriodicBoundary_Y(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                PB_Y = val;
                return true;
            }
            else if (int.TryParse(strVal, out int val2) && val2 == 1)
            {
                PB_Y = true;
                return true;
            }
            return false;
        }
        private static bool SetParameter_PeriodicBoundary_Z(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                PB_Z = val;
                return true;
            }
            else if (int.TryParse(strVal, out int val2) && val2 == 1)
            {
                PB_Z = true;
                return true;
            }
            return false;
        }
#endregion

        private static bool PB_X { get; set; }
        private static bool PB_Y { get; set; }
        private static bool PB_Z { get; set; }

        private static (int, int) Check(int val, bool pb, int arrSize)
        {
            if (pb)
            {
                arrSize--;
                arrSize--;
                int p = (int)Math.Floor((double)val / arrSize);
                int res = val - arrSize * p;
                if (res == 0) { return (arrSize, p - 1); }
                else { return (res, p); }
            }
            else
            {
                arrSize--;
                if (val > 0)
                {
                    if (arrSize > val) { return (val, 0); }
                    else { return (arrSize, 0); }
                }
                else { return (0, 0); }
            }
        }

        internal static Point3D Check(int x, int y, int z)
        {
            (int outy, int py) = Check(y, PB_Y, CultureSpace.Ysize);
            int x0 = 0;
            if (py != 0 && CultureSpace.Ysize % 2 == 1)
            {
                if (y <= 0 || y > CultureSpace.Ysize - 1)
                { x0 = py; }
            }
            (int outx, _) = Check((int)Math.Floor((x + x0) / 2.0), PB_X, CultureSpace.Xsize);
            (int outz, _) = Check(z, PB_Z, CultureSpace.Zsize);
            if (outy % 2 == 0)
            { return new Point3D(outx * 2, outy, outz); }
            else
            { return new Point3D(outx * 2 + 1, outy, outz); }
        }

        internal static Point3D Check(Point3D point, Delta delta)
        {
            int x = point.X + delta.DX;
            int y = point.Y + delta.DY;
            int z = point.Z + delta.DZ;
            return Check(x, y, z);
        }
    }
}
