using CellBehaviorSimulator.CultureEnvironments;
using System;
using System.Collections.Generic;

namespace CellBehaviorSimulator.CellBehaviors
{
    public class BasicConnectionEnergy : BasicConnectionEnergyRate
    {
        #region Parameter setting
        public void SetParameter()
        {
            Common.CalcEmax();
            SetParameter_Ep_AJ0();
            SetParameter_Ep_TJ0();
            SetParameter_Ep_cs0();
            SetParameter_tau_TJ_Ep();
            SetParameter_CadType_Ep();
        }
        private void SetParameter_Ep_AJ0()
        {
            for (int i = 0; i < Behaviors.Maximum; i++)
            {
                double ep = E_AJ0[i] / Common.Emax[i];
                if (Common.Emax[i] == 0)
                {
                    ep = E_AJ0[i];
                }
                if (double.IsNaN(ep))
                {
                    Ep_AJ0[i] = E_AJ0[i];
                    Ep_AJ0_E[i] = 0;
                }
                else if (ep > 1)
                {
                    int cnt = 0;
                    while (true)
                    {
                        if (ep * Math.Pow(10, -cnt) <= 1)
                        { break; }
                        else
                        { cnt++; }
                    }
                    Ep_AJ0[i] = ep * Math.Pow(10, -cnt);
                    Ep_AJ0_E[i] = cnt;
                }
                else if (ep == 0)
                {
                    Ep_AJ0[i] = 0;
                    Ep_AJ0_E[i] = 0;
                }
                else
                {
                    int cnt = 0;
                    while (true)
                    {
                        if (ep * Math.Pow(10, cnt) > 0.999)
                        { break; }
                        else
                        { cnt++; }
                    }
                    Ep_AJ0[i] = ep * Math.Pow(10, cnt);
                    Ep_AJ0_E[i] = -cnt;
                }
            }
            num_EpAJ0.Value = (decimal)Ep_AJ0[Behaviors.Cell_T];
            num_EpAJ0_E.Value = (decimal)Ep_AJ0_E[Behaviors.Cell_T];
        }
        private void SetParameter_Ep_TJ0()
        {
            for (int i = 0; i < Behaviors.Maximum; i++)
            {
                double ep = E_TJ0[i] / Common.Emax[i];
                if (Common.Emax[i] == 0)
                {
                    ep = E_TJ0[i];
                }
                if (double.IsNaN(ep))
                {
                    Ep_TJ0[i] = E_TJ0[i];
                    Ep_TJ0_E[i] = 0;
                }
                else if (ep > 1)
                {
                    int cnt = 0;
                    while (true)
                    {
                        if (ep * Math.Pow(10, -cnt) <= 1)
                        { break; }
                        else
                        { cnt++; }
                    }
                    Ep_TJ0[i] = ep * Math.Pow(10, -cnt);
                    Ep_TJ0_E[i] = cnt;
                }
                else if (ep == 0)
                {
                    Ep_TJ0[i] = 0;
                    Ep_TJ0_E[i] = 0;
                }
                else
                {
                    int cnt = 0;
                    while (true)
                    {
                        if (ep * Math.Pow(10, cnt) > 0.999)
                        { break; }
                        else
                        { cnt++; }
                    }
                    Ep_TJ0[i] = ep * Math.Pow(10, cnt);
                    Ep_TJ0_E[i] = -cnt;
                }
            }
            num_EpTJ0.Value = (decimal)Ep_TJ0[Behaviors.Cell_T];
            num_EpTJ0_E.Value = (decimal)Ep_TJ0_E[Behaviors.Cell_T];
        }
        private void SetParameter_Ep_cs0()
        {
            for (int i = 0; i < Behaviors.Maximum; i++)
            {
                double ep = E_cs0[i] / Common.Emax[i];
                if (Common.Emax[i] == 0)
                {
                    ep = E_cs0[i];
                }
                if (double.IsNaN(ep))
                {
                    Ep_cs0[i] = E_cs0[i];
                    Ep_cs0_E[i] = 0;
                }
                else if (ep > 1)
                {
                    int cnt = 0;
                    while (true)
                    {
                        if (ep * Math.Pow(10, -cnt) <= 1)
                        { break; }
                        else
                        { cnt++; }
                    }
                    Ep_cs0[i] = ep * Math.Pow(10, -cnt);
                    Ep_cs0_E[i] = cnt;
                }
                else if (ep == 0)
                {
                    Ep_cs0[i] = 0;
                    Ep_cs0_E[i] = 0;
                }
                else
                {
                    int cnt = 0;
                    while (true)
                    {
                        if (ep * Math.Pow(10, cnt) > 0.999)
                        { break; }
                        else
                        { cnt++; }
                    }
                    Ep_cs0[i] = ep * Math.Pow(10, cnt);
                    Ep_cs0_E[i] = -cnt;
                }
            }
            num_Epcs0.Value = (decimal)Ep_cs0[Behaviors.Cell_T];
            num_Epcs0_E.Value = (decimal)Ep_cs0_E[Behaviors.Cell_T];
        }
        private void SetParameter_tau_TJ_Ep()
        {
            num_tauTJ.Value = (decimal)Tau_TJ[Behaviors.Cell_T];
        }
        private void SetParameter_CadType_Ep()
        {
            numCadType.Value = CadType[Behaviors.Cell_T];
        }
        #endregion
        public const string Str_E_AJ0 = "E_AJ0";
        public const string Str_E_TJ0 = "E_TJ0";
        public const string Str_E_cs0 = "E_cs0";
        public const string Str_tau_TJ = "tau_TJ";
        public const string Str_CadType = "CadherinType";
        #region Parameter definitions
        public static void WriteParameter(System.IO.StreamWriter sw, int i)
        {
            sw.WriteLine(":," + Str_E_AJ0 + "(" + i + ")," + E_AJ0[i] + ",ng um^2 h^(-2)");
            sw.WriteLine(":," + Str_E_TJ0 + "(" + i + ")," + E_TJ0[i] + ",ng um^2 h^(-2)");
            sw.WriteLine(":," + Str_E_cs0 + "(" + i + ")," + E_cs0[i] + ",ng um^2 h^(-2)");
            sw.WriteLine(":," + Str_tau_TJ + "(" + i + ")," + Tau_TJ[i] + ",h");
            sw.WriteLine(":," + Str_CadType + "(" + i + ")," + CadType[i] + ",#0:E-cad 1:N-cad");
        }
        public static bool ReadParameter(string strName, int typeNum, string strValue)
        {
            switch (strName)
            {
                case Str_E_AJ0:
                    return SetParameter_E_AJ0(typeNum, strValue);
                case Str_E_TJ0:
                    return SetParameter_E_TJ0(typeNum, strValue);
                case Str_E_cs0:
                    return SetParameter_E_cs0(typeNum, strValue);
                case Str_tau_TJ:
                    return SetParameter_tau_TJ(typeNum, strValue);
                case Str_CadType:
                    return SetParameter_CadType(typeNum, strValue);
                default: return false;
            }
        }
        public static void AdjustParameter()
        {
            if (E_AJ0 == null)
            {
                E_AJ0 = new double[1];
                E_TJ0 = new double[1];
                E_cs0 = new double[1];
                Ep_AJ0 = new List<double>();
                Ep_TJ0 = new List<double>();
                Ep_cs0 = new List<double>();
                Tau_TJ = new List<double>();
                CadType = new List<int>();
                Ep_AJ0_E = new List<double>();
                Ep_TJ0_E = new List<double>();
                Ep_cs0_E = new List<double>();
            }
            if (E_AJ0.Length <= Behaviors.Maximum)
            {
                double[] tmp1 = new double[Behaviors.Maximum];
                Array.Copy(E_AJ0, tmp1, E_AJ0.Length);
                E_AJ0 = tmp1;
                double[] tmp2 = new double[Behaviors.Maximum];
                Array.Copy(E_TJ0, tmp2, E_TJ0.Length);
                E_TJ0 = tmp2;
                double[] tmp3 = new double[Behaviors.Maximum];
                Array.Copy(E_cs0, tmp3, E_cs0.Length);
                E_cs0 = tmp3;
                while (Ep_AJ0.Count < Behaviors.Maximum)
                {
                    Ep_AJ0.Add(0);
                    Ep_TJ0.Add(0);
                    Ep_cs0.Add(0);
                    Ep_AJ0_E.Add(0);
                    Ep_TJ0_E.Add(0);
                    Ep_cs0_E.Add(0);
                }
            }
            if (Tau_TJ == null)
            { Tau_TJ = new List<double>(); }
            while (Tau_TJ.Count < Behaviors.Maximum)
            { Tau_TJ.Add(0); }
            if (CadType == null)
            { CadType = new List<int>(); }
            while (CadType.Count < Behaviors.Maximum)
            { CadType.Add(0); }
        }
        public static void ClearParameter()
        {
            if (Ep_AJ0 != null)
            { Ep_AJ0.Clear(); }
            if (Ep_TJ0 != null)
            { Ep_TJ0.Clear(); }
            if (Ep_cs0 != null)
            { Ep_cs0.Clear(); }
            if (Ep_AJ0_E != null)
            { Ep_AJ0_E.Clear(); }
            if (Ep_TJ0_E != null)
            { Ep_TJ0_E.Clear(); }
            if (Ep_cs0_E != null)
            { Ep_cs0_E.Clear(); }
            if (Tau_TJ != null)
            { Tau_TJ.Clear(); }
            if (CadType != null)
            { CadType.Clear(); }
            E_AJ0 = null;
            E_TJ0 = null;
            E_cs0 = null;
        }

        private static bool SetParameter_E_AJ0(int typeNum, string strVal)
        {
            if (E_AJ0 == null)
            {
                E_AJ0 = new double[1];
            }
            if (E_AJ0.Length <= typeNum)
            {
                double[] tmp = new double[typeNum + 1];
                Array.Copy(E_AJ0, tmp, E_AJ0.Length);
                E_AJ0 = tmp;
            }
            return double.TryParse(strVal, out E_AJ0[typeNum]);
        }
        private static bool SetParameter_E_TJ0(int typeNum, string strVal)
        {
            if (E_TJ0 == null)
            {
                E_TJ0 = new double[1];
            }
            if (E_TJ0.Length <= typeNum)
            {
                double[] tmp = new double[typeNum + 1];
                Array.Copy(E_TJ0, tmp, E_TJ0.Length);
                E_TJ0 = tmp;
            }
            return double.TryParse(strVal, out E_TJ0[typeNum]);
        }
        private static bool SetParameter_E_cs0(int typeNum, string strVal)
        {
            if (E_cs0 == null)
            {
                E_cs0 = new double[1];
            }
            if (E_cs0.Length <= typeNum)
            {
                double[] tmp = new double[typeNum + 1];
                Array.Copy(E_cs0, tmp, E_cs0.Length);
                E_cs0 = tmp;
            }
            return double.TryParse(strVal, out E_cs0[typeNum]);
        }
        #endregion

        public static double[] E_AJ0 { get; private set; }
        public static double[] E_TJ0 { get; private set; }
        public static double[] E_cs0 { get; private set; }

        public static void EpsilonToEnergy(double[] Emax)
        {
            int max = Behaviors.Maximum;
            E_AJ0 = new double[max];
            E_TJ0 = new double[max];
            E_cs0 = new double[max];
            for (int i = 0; i < max; i++)
            {
                E_AJ0[i] = Ep_AJ0[i] * Math.Pow(10, Ep_AJ0_E[i]) * Emax[i];
                E_TJ0[i] = Ep_TJ0[i] * Math.Pow(10, Ep_TJ0_E[i]) * Emax[i];
                E_cs0[i] = Ep_cs0[i] * Math.Pow(10, Ep_cs0_E[i]) * Emax[i];
            }
        }
        public static void Initialize(CellData c)
        {
            c.E_AJ = E_AJ0[c.Cell_T];
            c.E_TJ = E_TJ0[c.Cell_T];
            c.E_cs = E_cs0[c.Cell_T];
        }
        public static double CalcEcsmax()
        {
            int len = Behaviors.Maximum;
            double Ecsmax = 0;
            for (int i = 0; i < len; i++)
            {
                if (Ecsmax < E_cs0[i])
                { Ecsmax = E_cs0[i]; }
            }
            return Ecsmax;
        }
        public static double CalcEc(List<CellData> cells, int index, out double Ecc, out double Ecs)
        {
            CellData c = CellData.Find(cells, index);
            Ecc = 0.0;
            Ecs = 0.0;
            for (int dir = 0; dir < 20; dir++)
            {
                Point3D p = c.Location + Delta.GetDelta(dir);
                int val = CultureSpace.GetMap(p);
                if (val >= 0)
                {
                    CellData c2 = CellData.Find(cells, val);
                    Ecc += GetEcc(c, c2, c.THETA[dir]);
                }
                else if (val == -3)
                {
                    Ecs += GetEcs(c);
                }
            }
            return Ecc + Ecs;
        }
        public static double GetEcc(CellData ci, CellData cj, double durTime)
        {
            if (CadType[ci.Cell_T] == CadType[cj.Cell_T])
            {
                double EAJ = Math.Min(ci.E_AJ, cj.E_AJ);
                double ETJ = 0;
                double ETJmax = Math.Min(ci.E_TJ, cj.E_TJ);
                if (ETJmax > 0)
                {
                    double tauTJ = Math.Max(Tau_TJ[ci.Cell_T], Tau_TJ[cj.Cell_T]);
                    double expTJ = 1.0 - Math.Exp(-durTime / tauTJ);
                    ETJ = ETJmax * expTJ;
                }
                return EAJ + ETJ;
            }
            else
            {
                return 0;
            }
        }
        public static (double, double) GetE_AJ_TJ(CellData ci, CellData cj, double durTime)
        {
            if (CadType[ci.Cell_T] == CadType[cj.Cell_T])
            {
                double EAJ = Math.Min(ci.E_AJ, cj.E_AJ);
                double ETJ = 0;
                double ETJmax = Math.Min(ci.E_TJ, cj.E_TJ);
                if (ETJmax > 0)
                {
                    double tauTJ = Math.Max(Tau_TJ[ci.Cell_T], Tau_TJ[cj.Cell_T]);
                    double expTJ = 1.0 - Math.Exp(-durTime / tauTJ);
                    ETJ = ETJmax * expTJ;
                }
                return (EAJ, ETJ);
            }
            else
            {
                return (0, 0);
            }
        }
        public static double GetEcs(CellData c)
        {
            return Math.Min(c.E_cs, Common.Ecsmax
                * SubstrateAbility.Get_e_s(c.Location + new Delta(0, 0, -1)));
        }
        public static double GetEcs(CellData c, Delta delta)
        {
            return Math.Min(c.E_cs, Common.Ecsmax
                * SubstrateAbility.Get_e_s(c.Location + delta));
        }

    }
}
