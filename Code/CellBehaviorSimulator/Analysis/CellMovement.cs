using System;
using System.Collections.Generic;
using CellBehaviorSimulator.CultureEnvironments;
using CellBehaviorSimulator.CellBehaviors;

namespace CellBehaviorSimulator
{
    public class CellMovement
    {
        public static void Initialize(int length)
        {
            if (Deviation_hiPSC.Get_flag())
            {
                for (int i = 0; i < length; i++)
                {
                    _len_apparent.Add(0);
                    _len_act_mig.Add(0);
                    _len_pas_mig.Add(0);
                    _len_pas_div.Add(0);
                    _t_act_mig.Add(0);
                    _t_pas_mig.Add(0);
                    _t_pas_div.Add(0);
                }
            }
        }
        public static void Initialize()
        {
            if (Deviation_hiPSC.Get_flag())
            {
                _len_apparent = new List<double>();
                _len_act_mig = new List<double>();
                _len_pas_mig = new List<double>();
                _len_pas_div = new List<double>();
                _t_act_mig = new List<int>();
                _t_pas_mig = new List<int>();
                _t_pas_div = new List<int>();
            }
        }
        public static void SetValue(double len_app = 0, double len_act = 0, double len_pas = 0, double len_div = 0, int t_act = 0, int t_pas = 0, int t_div = 0)
        {
            if (Deviation_hiPSC.Get_flag())
            {
                _len_apparent.Add(len_app);
                _len_act_mig.Add(len_act);
                _len_pas_mig.Add(len_pas);
                _len_pas_div.Add(len_div);
                _t_act_mig.Add(t_act);
                _t_pas_mig.Add(t_pas);
                _t_pas_div.Add(t_div);
            }
        }

        private static List<double> _len_apparent;
        private static List<double> _len_act_mig;
        private static List<double> _len_pas_mig;
        private static List<double> _len_pas_div;

        private static List<int> _t_act_mig;
        private static List<int> _t_pas_mig;
        private static List<int> _t_pas_div;

        public double Length_apparent_c { get; set; }
        public double Length_act_mig_c { get; set; }
        public double Length_pas_mig_c { get; set; }
        public double Length_pas_div_c { get; set; }

        public int Time_apparent_c { get; set; }
        public int Time_act_mig_c { get; set; }
        public int Time_pas_mig_c { get; set; }
        public int Time_pas_div_c { get; set; }

        public double GetMovementRate_apparent()
        { return Length_apparent_c / Time_apparent_c / CultureTime.Time_step; }
        public double GetMovementRate_active_mig()
        { return Length_act_mig_c / Time_act_mig_c / CultureTime.Time_step; }
        public double GetMovementRate_passive_mig()
        { return Length_pas_mig_c / Time_pas_mig_c / CultureTime.Time_step; }
        public double GetMovementRate_passive_div()
        { return Length_pas_div_c / Time_pas_div_c / CultureTime.Time_step; }

        public static void Run(List<CellData> cells)
        {
            if (Deviation_hiPSC.Get_flag())
            {
                while (_len_apparent.Count < cells.Count)
                {
                    int cnt = _len_apparent.Count;
                    int mInd = cells[cnt].Cell_N[cells[cnt].Cell_N.Count - 1];
                    _len_apparent.Add(_len_apparent[mInd]);
                    _len_act_mig.Add(_len_act_mig[mInd]);
                    _len_pas_mig.Add(_len_pas_mig[mInd]);
                    _len_pas_div.Add(_len_pas_div[mInd]);
                    _t_act_mig.Add(_t_act_mig[mInd]);
                    _t_pas_mig.Add(_t_pas_mig[mInd]);
                    _t_pas_div.Add(_t_pas_div[mInd]);
                }
            }
        }

        public static CellMovement Renew(List<CellData> cells, int index)
        {
            CellData c = CellData.Find(cells, index);
            if (Common.IsDeadCell(c)) { return null; }

            _t_act_mig[c.Index]++;
            _t_pas_mig[c.Index]++;
            _t_pas_div[c.Index]++;

            double l_act_mig = GetLength_active_mig(c);
            double l_pas_mig = GetLength_passive_mig(c);
            double l_pas_div = GetLength_passive_div(c);
            double l_app = l_act_mig + l_pas_mig + l_pas_div;

            CellMovement vals = new CellMovement();

            if (l_app > 0)
            {
                vals.Length_apparent_c = _len_apparent[c.Index];
                vals.Time_apparent_c = Math.Min(Math.Min(_t_act_mig[c.Index], _t_pas_mig[c.Index]), _t_pas_div[c.Index]);
                _len_apparent[c.Index] = l_app;

                Renew_act_mig(c.Index, l_act_mig, vals);
                Renew_pas_mig(c.Index, l_pas_mig, vals);
                Renew_pas_div(c.Index, l_pas_div, vals);
            }
            else
            {
                vals.Length_apparent_c = 0;
                vals.Length_act_mig_c = 0;
                vals.Length_pas_mig_c = 0;
                vals.Length_pas_div_c = 0;
                vals.Time_apparent_c = 0;
                vals.Time_act_mig_c = 0;
                vals.Time_pas_mig_c = 0;
                vals.Time_pas_div_c = 0;
            }

            return vals;
        }
        private static void Renew_act_mig(int ind, double len, CellMovement vals)
        {
            if (len > 0)
            {
                vals.Length_act_mig_c = _len_act_mig[ind];
                vals.Time_act_mig_c = _t_act_mig[ind];
                _len_act_mig[ind] = len;
                _t_act_mig[ind] = 0;
            }
            else
            {
                vals.Length_act_mig_c = 0;
                vals.Time_act_mig_c = 0;
            }
        }
        private static void Renew_pas_mig(int ind, double len, CellMovement vals)
        {
            if (len > 0)
            {
                vals.Length_pas_mig_c = _len_pas_mig[ind];
                vals.Time_pas_mig_c = _t_pas_mig[ind];
                _len_pas_mig[ind] = len;
                _t_pas_mig[ind] = 0;
            }
            else
            {
                vals.Length_pas_mig_c = 0;
                vals.Time_pas_mig_c = 0;
            }
        }
        private static void Renew_pas_div(int ind, double len, CellMovement vals)
        {
            if (len > 0)
            {
                vals.Length_pas_div_c = _len_pas_div[ind];
                vals.Time_pas_div_c = _t_pas_div[ind];
                _len_pas_div[ind] = len;
                _t_pas_div[ind] = 0;
            }
            else
            {
                vals.Length_pas_div_c = 0;
                vals.Time_pas_div_c = 0;
            }
        }

        private static double GetLength_active_mig(CellData c)
        {
            double len = GetLength(Delta.GetDelta(c.Dir_am));
            return len;
        }
        private static double GetLength_passive_mig(CellData c)
        {
            double len = 0;
            for (int i = 0; i < c.Dir_pm.Count; i++)
            { len += GetLength(Delta.GetDelta(c.Dir_pm[i])); }
            return len;
        }
        private static double GetLength_passive_div(CellData c)
        {
            double len = 0;
            for (int i = 0; i < c.Dir_pd.Count; i++)
            { len += GetLength(Delta.GetDelta(c.Dir_pd[i])); }
            return len;
        }
        private static double GetLength(Delta d)
        {
            return Math.Sqrt(
                d.DX * CultureSpace.Size_lc / 2.0 *
                d.DX * CultureSpace.Size_lc / 2.0 +
                d.DY * CultureSpace.Size_lc * Delta.Cf_y *
                d.DY * CultureSpace.Size_lc * Delta.Cf_y +
                d.DZ * CultureSpace.Size_hc *
                d.DZ * CultureSpace.Size_hc);
        }

        public static (double, double, double, double, int, int, int) GetData(int index)
        {
            return (
                _len_apparent[index],
                _len_act_mig[index],
                _len_pas_mig[index],
                _len_pas_div[index],
                _t_act_mig[index],
                _t_pas_mig[index],
                _t_pas_div[index]);
        }
    }
}
