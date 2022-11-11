using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CellBehaviorSimulator.CultureEnvironments;

namespace CellBehaviorSimulator.CellBehaviors
{
    public partial class CellDeath : UserControl
    {
        public CellDeath()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void CellDeath_Load(object sender, EventArgs e)
        {
            flag = new List<bool>() { checkModuleAvailable.Checked };
            if (radioCC.Checked)
            { f_dead = new List<CC_CS>() { CC_CS.CC }; }
            else if (radioCS.Checked)
            { f_dead = new List<CC_CS>() { CC_CS.CS }; }
            else if (radioCCorCS.Checked)
            { f_dead = new List<CC_CS>() { CC_CS.CCorCS }; }
            else if (radioCCandCS.Checked)
            { f_dead = new List<CC_CS>() { CC_CS.CCandCS }; }
            if (!flag[0]) { groupBox1.Enabled = false; }
        }

        private void CheckModuleAvailable_CheckedChanged(object sender, EventArgs e)
        {
            flag[Behaviors.Cell_T] = checkModuleAvailable.Checked;
            if (checkModuleAvailable.Checked)
            {
                groupBox1.Enabled = true;
                ParamChanged();
            }
            else
            { groupBox1.Enabled = false; }
        }
        private void RadioCC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            {
                if (radioCC.Checked)
                { f_dead[Behaviors.Cell_T] = CC_CS.CC; }
            }
        }
        private void RadioCS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            {
                if (radioCS.Checked)
                { f_dead[Behaviors.Cell_T] = CC_CS.CS; }
            }
        }
        private void RadioCCorCS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            {
                if (radioCCorCS.Checked)
                { f_dead[Behaviors.Cell_T] = CC_CS.CCorCS; }
            }
        }
        private void RadioCCandCS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkModuleAvailable.Checked)
            {
                if (radioCCandCS.Checked)
                { f_dead[Behaviors.Cell_T] = CC_CS.CCandCS; }
            }
        }
        private void CellDeath_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                checkModuleAvailable.Checked = false;
                for (int i = 0; i < flag.Count; i++)
                { flag[i] = false; }
            }
        }
        #endregion
        #region Parameter setting
        internal void ParamChanged()
        {
            checkModuleAvailable.Checked = flag[Behaviors.Cell_T];
            if (checkModuleAvailable.Checked)
            {
                if (f_dead[Behaviors.Cell_T] == CC_CS.CC)
                { radioCC.Checked = true; }
                else if (f_dead[Behaviors.Cell_T] == CC_CS.CS)
                { radioCS.Checked = true; }
                else if (f_dead[Behaviors.Cell_T] == CC_CS.CCorCS)
                { radioCCorCS.Checked = true; }
                else
                { radioCCandCS.Checked = true; }
            }
        }
        internal void ParamAdd()
        {
            flag.Add(checkModuleAvailable.Checked);
            if (radioCC.Checked)
            { f_dead.Add(CC_CS.CC); }
            else if (radioCS.Checked)
            { f_dead.Add(CC_CS.CS); }
            else if (radioCCorCS.Checked)
            { f_dead.Add(CC_CS.CCorCS); }
            else if (radioCCandCS.Checked)
            { f_dead.Add(CC_CS.CCandCS); }
        }

        internal void ParamRemoveAt(int index)
        {
            flag.RemoveAt(index);
            f_dead.RemoveAt(index);
        }
        internal bool SetParameter()
        {
            ParamChanged();
            for (int i = 0; i < Behaviors.Maximum; i++)
            {
                if (flag[i])
                {
                    return true;
                }
            }
            return false;
        }
        internal void RegisterParameters(int cellT)
        {
            flag[cellT] = checkModuleAvailable.Checked;
            if (flag[cellT])
            {
                if (radioCC.Checked)
                { f_dead[cellT] = CC_CS.CC; }
                else if (radioCS.Checked)
                { f_dead[cellT] = CC_CS.CS; }
                else if (radioCCorCS.Checked)
                { f_dead[cellT] = CC_CS.CCorCS; }
                else if (radioCCandCS.Checked)
                { f_dead[cellT] = CC_CS.CCandCS; }
            }
        }
        #endregion
        public const string Str_f_dead = "f_dead";
        #region Parameter definitions
        public static void WriteParameter(System.IO.StreamWriter sw, int i)
        {
            if (flag[i])
            {
                sw.WriteLine(":," + Str_f_dead + "(" + i + ")," + (int)f_dead[i] + ",# 0 -> CC; 1 -> CS; 2 -> CC and CS; 3 -> CC or CS;");
            }
        }
        public static bool ReadParameter(string strName, int typeNum, string strValue)
        {
            switch (strName)
            {
                case Str_f_dead: return SetParameter_f_dead(typeNum, strValue);
                default: return false;
            }
        }
        public static void AdjustParameter()
        {
            if (flag == null)
            { flag = new List<bool>(); }
            while (flag.Count < Behaviors.Maximum)
            { flag.Add(false); }
            if (f_dead == null)
            { f_dead = new List<CC_CS>(); }
            while (f_dead.Count < Behaviors.Maximum)
            { f_dead.Add(0); }
        }
        public static void ClearParameter()
        {
            if (flag != null)
            {
                flag.Clear();
                f_dead.Clear();
            }
        }
        public static bool SetParameter_f_dead(int typeNum, string strVal)
        {
            Common.InitializeParameter<CC_CS>(typeNum, flag, 0, f_dead);
            if (int.TryParse(strVal, out int val))
            {
                f_dead[typeNum] = (CC_CS)val;
                flag[typeNum] = true;
                return true;
            }
            return false;
        }
        #endregion

        private static List<bool> flag;
        private static List<CC_CS> f_dead;
        public enum CC_CS
        {
            CC = 0,
            CS = 1,
            CCandCS = 2,
            CCorCS = 3
        }

        public static void Run(List<CellData> cells, int[] ind)
        {
            foreach (int index in ind)
            {
                Run(cells, index);
            }
        }

        private static void Run(List<CellData> cells, int index)
        {
            CellData c = CellData.Find(cells, index);
            if (Common.IsDeadCell(c)) { return; }
            if (flag[c.Cell_T])
            {
                BasicConnectionEnergy.CalcEc(cells, index, out double Ed_cc, out double Ed_cs);
                bool f_d = false;
                if (f_dead[c.Cell_T] == CC_CS.CC)
                { if (Ed_cc == 0) { f_d = true; } }
                else if (f_dead[c.Cell_T] == CC_CS.CS)
                { if (Ed_cs == 0) { f_d = true; } }
                else if (f_dead[c.Cell_T] == CC_CS.CCorCS)
                { if (Ed_cc == 0 || Ed_cs == 0) { f_d = true; } }
                else if (f_dead[c.Cell_T] == CC_CS.CCandCS)
                { if (Ed_cc == 0 && Ed_cs == 0) { f_d = true; } }
                if (f_d)
                {
                    CultureSpace.SetMap(c.Location, -1);
                    cells[index] = null;
                }
            }
        }
    }
}
