using CellBehaviorSimulator.CellBehaviors;
using CellBehaviorSimulator.CultureEnvironments;
using System;
using System.Collections.Generic;

namespace CellBehaviorSimulator
{
    public partial class CellData
    {
        public CellData(sbyte cellT = 0)
        {
            Cell_N = new List<int>() { -1 };
            Cell_S = Division.GetCellState(cellT);
            Cell_T = cellT;
            Dir_am = Direction.DIR.C_1;
            Dir_pm = new List<Direction.DIR>();
            Dir_pd = new List<Direction.DIR>();
            BasicConnectionEnergy.Initialize(this);
            E_max = Common.Emax[cellT] * Migration.Get_FlucRate(cellT);
            Index = -1;
            Location = new Point3D(-1, -1, -1);
            THETA = new int[20];
            Time_age = -AfterSeeding.Get_AdherentTime_Stochastic(Cell_T);
            Time_d = InitializeTime_d_c(Cell_T);
            Time_m = InitializeTime_m_c(Cell_T);
        }

        public CellData(CellData c)
        {
            Cell_N = new List<int>(c.Cell_N);
            Cell_S = c.Cell_S;
            Cell_T = c.Cell_T;
            Dir_am = c.Dir_am;
            Dir_pm = new List<Direction.DIR>(c.Dir_pm);
            Dir_pd = new List<Direction.DIR>(c.Dir_pd);
            E_AJ = c.E_AJ;
            E_TJ = c.E_TJ;
            E_cs = c.E_cs;
            E_max = c.E_max;
            Index = c.Index;
            Location = new Point3D(c.Location);
            THETA = new int[20];
            Array.Copy(c.THETA, THETA, 20);
            Time_age = c.Time_age;
            Time_d = c.Time_d;
            Time_dev_act = c.Time_dev_act;
            Time_dev_total = c.Time_dev_total;
            Time_m = c.Time_m;
            V_m = c.V_m;
        }

        private static double InitializeTime_d_c(int Cell_T)
        {
            return AfterSeeding.Get_t_lag(Cell_T) + Division.Get_t_g(Cell_T) * Common.Rand_NextDouble();
        }

        public static double InitializeTime_m_c(int Cell_T)
        {
            return CultureSpace.Size_lc / Migration.Get_V_m_free(Cell_T)
                * (Migration.Get_flag(Cell_T) ? 1 : 0) * Common.Rand_NextDouble();
        }

        public static CellData[] CellsPre { get; set; }

        #region property
        internal int Index { get; set; }
        internal Point3D Location { get; set; }
        internal STATE Cell_S { get; set; }
        internal sbyte Cell_T { get; set; }
        internal List<int> Cell_N { get; set; }
        internal double Time_age { get; set; }
        internal double E_AJ { get; set; }
        internal double E_TJ { get; set; }
        internal double E_cs { get; set; }
        internal double E_max { get; set; }
        internal int[] THETA { get; set; }
        internal double Time_d { get; set; }
        internal double Time_m { get; set; }
        internal double V_m { get; set; }
        internal Direction.DIR Dir_am { get; set; }
        internal List<Direction.DIR> Dir_pm { get; set; }
        internal List<Direction.DIR> Dir_pd { get; set; }
        internal int Time_dev_act { get; set; }
        internal int Time_dev_total { get; set; }
        #endregion

        internal enum STATE
        {
            Block = 0,
            Proliferative = 1,
            Quiescent = 2,
            Nonproliferative = 3,
            Dead = 4,
        }

        internal CellData Clone()
        {
            return Clone(this);
        }

        internal static CellData Clone(CellData c)
        {
            return c == null ? null : new CellData(c);
        }

        internal static CellData Find(List<CellData> cells, int index)
        {
            return cells[index];
        }

        internal static int FindIndex(List<CellData> cells, int index)
        {
            return index;
        }

        internal static bool IsDeadCell(List<CellData> cells, int index) => cells[index] == null;
        internal static bool IsDeadCell(CellData c) => c == null;
    }
}
