using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CellBehaviorSimulator.CellBehaviors;

namespace CellBehaviorSimulator
{
    public partial class CellName : UserControl
    {
        public CellName()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void CellName_Load(object sender, EventArgs e)
        {
            cell_name = new List<string>() { "" };
        }
        private void ComboBoxCell_TextChanged(object sender, EventArgs e)
        {
            cell_name[Behaviors.Cell_T] = comboBoxCell.Text;
        }
        #endregion
        #region Parameter setting
        internal void ParamChanged()
        {
            comboBoxCell.Text = cell_name[Behaviors.Cell_T];
        }
        internal void ParamAdd()
        {
            cell_name.Add("");
        }
        internal void ParamRemoveAt(int index)
        {
            cell_name.RemoveAt(index);
        }
        internal void SetParameter()
        {
            ParamChanged();
        }
        internal void RegisterParameters(int cellT)
        {
            cell_name[cellT] = comboBoxCell.Text;
        }
        #endregion
        public const string Str_Name = "CellName";
        #region Parameter definitions
        public static void WriteParameter(System.IO.StreamWriter sw, int i)
        {
            if (cell_name[i] != "")
            {
                sw.WriteLine(":," + Str_Name + "(" + i + ")," + cell_name[i]);
            }
        }
        public static bool ReadParameter(string strName, int typeNum, string strValue)
        {
            switch (strName)
            {
                case Str_Name:
                    return SetParameter_CellName(typeNum, strValue);
                default: return false;
            }
        }
        public static void AdjustParameter()
        {
            if (cell_name == null)
            { cell_name = new List<string>(); }
            while (cell_name.Count < Behaviors.Maximum)
            { cell_name.Add(""); }
        }
        public static void ClearParameter()
        {
            cell_name.Clear();
        }
        public static bool SetParameter_CellName(int typeNum, string strVal)
        {
            if (cell_name == null)
            {
                cell_name = new List<string>();
            }
            while (cell_name.Count <= typeNum)
            {
                cell_name.Add("");
            }
            cell_name[typeNum] = strVal;
            return true;
        }
        #endregion

        private static List<string> cell_name;
    }
}
