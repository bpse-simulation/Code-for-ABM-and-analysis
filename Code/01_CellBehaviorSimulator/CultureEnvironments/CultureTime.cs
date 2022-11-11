using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellBehaviorSimulator.CultureEnvironments
{
    public partial class CultureTime : UserControl
    {
        public CultureTime()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void CultureTime_Load(object sender, EventArgs e)
        {
            TotalCultureTime = (int)num_TotalTime.Value;
            Time_step = (double)num_t_step.Value;
            InitialStartTime = (double)num_t_init.Value;
        }

        private void NumUpDnTotalTime_ValueChanged(object sender, EventArgs e)
        {
            TotalCultureTime = (int)num_TotalTime.Value;
        }
        private void NumUpDnDeltaT_ValueChanged(object sender, EventArgs e)
        {
            Time_step = (int)(num_t_step.Value * 100) / 100.0;
        }
        private void Num_t_init_ValueChanged(object sender, EventArgs e)
        {
            InitialStartTime = (double)num_t_init.Value;
        }
        #endregion
        #region Parameter setting
        internal void SetParameter()
        {
            num_TotalTime.Value = TotalCultureTime;
            num_t_step.Value = (decimal)Time_step;
            num_t_init.Value = (decimal)InitialStartTime;
        }
        #endregion
        #region Parameter definitions
        public const string Str_t_total = "t_total";
        public const string Str_t_step = "t_step";
        public const string Str_t_init = "t_init";
        public static void WriteParameter(System.IO.StreamWriter sw)
        {
            sw.WriteLine(":," + Str_t_total + "," + TotalCultureTime + ",h");
            sw.WriteLine(":," + Str_t_step + "," + Time_step + ",h");
            sw.WriteLine(":," + Str_t_init + "," + InitialStartTime + ",h");
        }
        public static bool ReadParameter(string strName, string strValue)
        {
            switch (strName)
            {
                case Str_t_total: return SetParameter_t_total(strValue);
                case "delta_t":
                case Str_t_step: return SetParameter_t_step(strValue);
                case Str_t_init: return SetParameter_t_init(strValue);
                default: return false;
            }
        }
        public static void ClearParameter()
        {
            TotalCultureTime = 0;
            Time_step = 0.1;
            InitialStartTime = 0;
        }
        private static bool SetParameter_t_total(string strVal)
        {
            if (int.TryParse(strVal, out int val))
            {
                TotalCultureTime = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_t_step(string strVal)
        {
            if (double.TryParse(strVal, out double val))
            {
                Time_step = val;
                return true;
            }
            return false;
        }
        private static bool SetParameter_t_init(string strVal)
        {
            if (double.TryParse(strVal, out double val))
            {
                InitialStartTime = val;
                return true;
            }
            return false;
        }
#endregion

        private static int TotalCultureTime { get; set; }
        internal static double Time_step { get; private set; }
        private static double InitialStartTime { get; set; }

        internal static int Get_PartitionNumber()
        { return (int)(TotalCultureTime / Time_step); }
        
        internal static int GetInitialTimeStep()
        { return (int)Math.Round(InitialStartTime / Time_step); }

        public static void Run(List<CellData> cells)
        {
            _ = Parallel.For(0, cells.Count, i =>
            {
                CellData c = cells[i];
                if (!Common.IsDeadCell(c))
                {
                    RenewCellAge(c);
                    if (c.Time_age >= 0.0)
                    {
                        RenewWaitingTime(c);
                        RenewDulationTime(c);
                    }
                    else
                    {
                        c.Time_age = c.Time_age < 0 ? c.Time_age : 0.0;
                    }
                }
            });
        }

        private static void RenewCellAge(CellData c)
        {
            c.Time_age += Time_step;
        }

        private static void RenewWaitingTime(CellData c)
        {
            c.Time_d = TimeRun_Minus(c.Time_d);
            c.Time_m = TimeRun_Minus(c.Time_m);
            if (c.Time_m <= 0)
            {
                c.V_m = 0;
                c.Dir_am = Direction.DIR.C_1;
            }
            c.Dir_am = Direction.DIR.C_1;
            c.Dir_pd = new List<Direction.DIR>();
            c.Dir_pm = new List<Direction.DIR>();
        }

        private static double TimeRun_Minus(double t, bool limitNegativeValues = false)
        {
            if (t > 0)
            {
                t -= Time_step;
            }
            return limitNegativeValues ? (t < 0 ? 0 : t) : t;
        }

        private static void RenewDulationTime(CellData c)
        {
            for (int dir = 0; dir < 20; dir++)
            {
                if (Common.GetW(dir))
                {
                    Point3D p1 = c.Location + Delta.GetDelta(dir);
                    int val1 = CultureSpace.GetMap(p1);
                    if (val1 >= 0 || val1 == -3)
                    {
                        c.THETA[dir]++;
                    }
                }
            }
        }

        public static void RenewDulationTime(List<CellData> cells)
        {
            _ = Parallel.For(0, CellData.CellsPre.Length, i =>
            {
                CellData c = cells[i];
                if (c != null)
                {
                    RenewDulationTime(c);
                }
            });
        }

    }
}
