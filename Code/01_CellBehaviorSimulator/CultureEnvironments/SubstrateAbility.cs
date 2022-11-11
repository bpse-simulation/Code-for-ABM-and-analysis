using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellBehaviorSimulator.CultureEnvironments
{
    public partial class SubstrateAbility : UserControl
    {
        public SubstrateAbility()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void SubstrateAbility_Load(object sender, EventArgs e)
        {
            Flag = checkModuleAvailable.Checked;
            if (!Flag) { groupBox1.Enabled = false; }
        }
        private void CheckModuleAvailable_CheckedChanged(object sender, EventArgs e)
        {
            Flag = checkModuleAvailable.Checked;
            if (checkModuleAvailable.Checked)
            { groupBox1.Enabled = true; }
            else
            { groupBox1.Enabled = false; }
        }

        private void Num_e_s_min_ValueChanged(object sender, EventArgs e)
        {
            e_s_min = (double)num_e_s_min.Value;
        }

        private void Num_k_s_ValueChanged(object sender, EventArgs e)
        {
            k_s = (double)num_k_s.Value;
        }
        #endregion
        #region Parameter setting
        internal void SetParameter()
        {
            checkModuleAvailable.Checked = Flag;
            if (Flag)
            {
                num_e_s_min.Value = (decimal)e_s_min;
                num_k_s.Value = (decimal)k_s;
            }
        }
        #endregion
        #region Parameter definitions
        public static void WriteParameter(System.IO.StreamWriter sw)
        {
            if (Flag)
            {
                sw.WriteLine(":,e_s_min," + e_s_min);
                sw.WriteLine(":,k_s," + k_s);
            }
        }
        public static bool ReadParameter(string strName, string strValue)
        {
            switch (strName)
            {
                case "e_s_min": return SetParameter_e_s_min(strValue);
                case "k_s": return SetParameter_k_s(strValue);
                default: return false;
            }
        }
        public static void ClearParameter()
        { Flag = false; e_s_min = 1; k_s = 0; }
        private static bool SetParameter_e_s_min(string strVal)
        {
            if (double.TryParse(strVal, out double val))
            {
                e_s_min = val;
                Flag = true;
                return true;
            }
            return false;
        }
        private static bool SetParameter_k_s(string strVal)
        {
            if (double.TryParse(strVal, out double val))
            {
                k_s = val;
                Flag = true;
                return true;
            }
            return false;
        }
#endregion

        public static bool Flag { get; private set; }

        private static double e_s_min;
        private static double k_s;
        private static double[,] e_s;

        public static double Get_e_s(Point3D p)
        {
            if (p.Z == 0)
            {
                if (Flag) { return e_s[p.Y, p.X / 2]; }
                else { return 1; }
            }
            else { return 0; }
        }

        public static void Initialize()
        {
            if (Flag)
            {
                e_s = new double[CultureSpace.Ysize, CultureSpace.Xsize];
                for (int j = 0; j < CultureSpace.Ysize; j++)
                {
                    for (int i = 0; i < CultureSpace.Xsize; i++)
                    {
                        e_s[j, i] = 1.0;
                    }
                }
            }
        }

        public static void Run()
        {
            if (Flag)
            {
                _ = Parallel.For(0, CultureSpace.Xsize * CultureSpace.Ysize, k =>
                {
                    int j = k / CultureSpace.Xsize;
                    int i = k % CultureSpace.Xsize;
                    for (int dir = 0; dir < 7; dir++)
                    {
                        Delta d = Delta.GetDelta(dir);
                        int ii = j % 2 == 0 ? i * 2 : i * 2 + 1;
                        Point3D p = new Point3D(ii, j, 0) + d;
                        if (CultureSpace.GetMap(p) >= 0)
                        {
                            if (Common.GetW(dir))
                            {
                                if (e_s_min < e_s[j, i])
                                {
                                    e_s[j, i] = Math.Max(e_s_min, e_s[j, i] - k_s * CultureTime.Time_step);
                                    break;
                                }
                            }
                        }
                    }
                });
            }
        }
    }
}
