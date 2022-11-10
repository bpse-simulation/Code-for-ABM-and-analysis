using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CellBehaviorSimulator.CellBehaviors
{
    public partial class Behaviors : UserControl
    {
        public Behaviors()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void Input_Load(object sender, EventArgs e)
        {
            Maximum = (int)num_NumOfCellT.Value;
            Cell_T = (int)num_CellT.Value;
            for (int i = 0; i < BehaviorList.Items.Count; i++)
            {
                if (BehaviorList.GetItemChecked(i))
                { flowLayoutPanel1.Controls[i].Visible = true; }
                else
                { flowLayoutPanel1.Controls[i].Visible = false; }
            }
        }
        private void BehaviorList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int i = BehaviorList.SelectedIndex;
            if (!BehaviorList.GetItemChecked(i))
            { flowLayoutPanel1.Controls[i].Visible = true; }
            else
            { flowLayoutPanel1.Controls[i].Visible = false; }
        }
        private void Num_NumOfCellT_ValueChanged(object sender, EventArgs e)
        {
            int indT = (int)num_NumOfCellT.Value;
            if (Maximum < indT)
            {
                CellularBehaviorModules_Add();
            }
            else if (Maximum > indT)
            {
                CellularBehaviorModules_RemoveAt();
            }
            Maximum = indT;
            if (hScrollBar1.Value > indT)
            { hScrollBar1.Value = indT - 1; }
            hScrollBar1.Maximum = indT - 1;
            num_CellT.Maximum = num_NumOfCellT.Value - 1;
            hScrollBar1.Visible = indT > 1;

            CellularBehaviorModules_Changed();
        }
        private void Num_CellT_ValueChanged(object sender, EventArgs e)
        {
            if (Cell_T < Maximum)
            {
                CellularBehaviorModules_Register();
            }

            hScrollBar1.Value = (int)num_CellT.Value;
            Cell_T = (int)num_CellT.Value;
            CellularBehaviorModules_Changed();
        }
        private void HScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            num_CellT.Value = hScrollBar1.Value;
        }
        #endregion

        public static int Maximum { get; private set; }
        public static int Cell_T { get; private set; }

        public static void SetMaximum(int value)
        { Maximum = value; }
        public void SetParameter()
        {
            num_NumOfCellT.Value = Maximum;
            num_CellT.Value = 0;
            cellName1.SetParameter();
            basicConnectionEnergy1.SetParameter();
            for (int i = 0; i < BehaviorList.Items.Count; i++)
            {
                BehaviorList.SelectedIndex = i;
                switch (BehaviorList.Items[i])
                {
                    case "Cell-cell connection":
                        BehaviorList.SetItemChecked(i, cellCellConnection1.SetParameter());
                        break;
                    case "Cell-substrate connection":
                        BehaviorList.SetItemChecked(i, cellSubstConnection1.SetParameter());
                        break;
                    case "Just after seeding":
                        BehaviorList.SetItemChecked(i, justAfterSeeding1.SetParameter());
                        break;
                    case "Division":
                        BehaviorList.SetItemChecked(i, division1.SetParameter());
                        break;
                    case "Migration":
                        BehaviorList.SetItemChecked(i, migration1.SetParameter());
                        break;
                    case "Differentiation: Epithelium":
                        BehaviorList.SetItemChecked(i, differentiation_Epithelium1.SetParameter());
                        break;
                    case "Deviation: hiPSC":
                        BehaviorList.SetItemChecked(i, deviation_hiPSC1.SetParameter());
                        break;
                    case "Cell death":
                        BehaviorList.SetItemChecked(i, cellDeath1.SetParameter());
                        break;
                    case "Area weighting":
                        BehaviorList.SetItemChecked(i, areaWeighting1.SetParameter());
                        break;
                    default:
                        break;
                }
            }
            BehaviorList.SelectedIndex = -1;
        }
        public static void WriteParameter(System.IO.StreamWriter sw)
        {
            sw.WriteLine("# Definition of cell behavior parameters");
            for (int i = 0; i < Maximum; i++)
            {
                sw.WriteLine("# Cell_T=" + i + "");
                CellName.WriteParameter(sw, i);
                BasicConnectionEnergy.WriteParameter(sw, i);
                CellCellConnection.WriteParameter(sw, i);
                CellSubstrateConnection.WriteParameter(sw, i);
                AfterSeeding.WriteParameter(sw, i);
                Division.WriteParameter(sw, i);
                Migration.WriteParameter(sw, i);
                CellDeath.WriteParameter(sw, i);
                Differentiation_Epithelium.WriteParameter(sw, i);
                Deviation_hiPSC.WriteParameter(sw, i);
                AreaWeighting.WriteParameter(sw, i);
            }
        }
        public static bool ReadParameter(string strName, int typeNum, string strValue)
        {
            if (Maximum < typeNum + 1)
            { Maximum = typeNum + 1; }
            if (CellName.ReadParameter(strName, typeNum, strValue))
            { return true; }
            if (BasicConnectionEnergy.ReadParameter(strName, typeNum, strValue))
            { return true; }
            if (CellCellConnection.ReadParameter(strName, typeNum, strValue))
            { return true; }
            if (CellSubstrateConnection.ReadParameter(strName, typeNum, strValue))
            { return true; }
            if (AfterSeeding.ReadParameter(strName, typeNum, strValue))
            { return true; }
            if (Division.ReadParameter(strName, typeNum, strValue))
            { return true; }
            if (Migration.ReadParameter(strName, typeNum, strValue))
            { return true; }
            if (CellDeath.ReadParameter(strName, typeNum, strValue))
            { return true; }
            if (Differentiation_Epithelium.ReadParameter(strName, typeNum, strValue))
            { return true; }
            if (Deviation_hiPSC.ReadParameter(strName, typeNum, strValue))
            { return true; }
            if (AreaWeighting.ReadParameter(strName, typeNum, strValue))
            { return true; }
            return false;
        }
        public static void AdjustParameter()
        {
            CellName.AdjustParameter();
            BasicConnectionEnergy.AdjustParameter();
            CellCellConnection.AdjustParameter();
            CellSubstrateConnection.AdjustParameter();
            AfterSeeding.AdjustParameter();
            Division.AdjustParameter();
            Migration.AdjustParameter();
            CellDeath.AdjustParameter();
            Differentiation_Epithelium.AdjustParameter();
            Deviation_hiPSC.AdjustParameter();
            AreaWeighting.AdjustParameter();
        }
        public static void ClearParameter()
        {
            SetMaximum(0);
            CellName.ClearParameter();
            BasicConnectionEnergy.ClearParameter();
            CellCellConnection.ClearParameter();
            CellSubstrateConnection.ClearParameter();
            AfterSeeding.ClearParameter();
            Division.ClearParameter();
            Migration.ClearParameter();
            CellDeath.ClearParameter();
            Differentiation_Epithelium.ClearParameter();
            Deviation_hiPSC.ClearParameter();
            AreaWeighting.ClearParameter();
        }

        private void CellularBehaviorModules_Add()
        {
            cellName1.ParamAdd();
            areaWeighting1.ParamAdd();
            basicConnectionEnergy1.ParamAdd();
            cellCellConnection1.ParamAdd();
            cellSubstConnection1.ParamAdd();
            cellDeath1.ParamAdd();
            division1.ParamAdd();
            differentiation_Epithelium1.ParamAdd();
            deviation_hiPSC1.ParamAdd();
            justAfterSeeding1.ParamAdd();
            migration1.ParamAdd();
        }
        private void CellularBehaviorModules_Changed()
        {
            cellName1.ParamChanged();
            areaWeighting1.ParamChanged();
            basicConnectionEnergy1.ParamChanged();
            cellCellConnection1.ParamChanged();
            cellSubstConnection1.ParamChanged();
            cellDeath1.ParamChanged();
            division1.ParamChanged();
            differentiation_Epithelium1.ParamChanged();
            deviation_hiPSC1.ParamChanged();
            justAfterSeeding1.ParamChanged();
            migration1.ParamChanged();
        }
        private void CellularBehaviorModules_RemoveAt()
        {
            cellName1.ParamRemoveAt(Cell_T);
            areaWeighting1.ParamRemoveAt(Cell_T);
            basicConnectionEnergy1.ParamRemoveAt(Cell_T);
            cellCellConnection1.ParamRemoveAt(Cell_T);
            cellSubstConnection1.ParamRemoveAt(Cell_T);
            cellDeath1.ParamRemoveAt(Cell_T);
            division1.ParamRemoveAt(Cell_T);
            differentiation_Epithelium1.ParamRemoveAt(Cell_T);
            deviation_hiPSC1.ParamRemoveAt(Cell_T);
            justAfterSeeding1.ParamRemoveAt(Cell_T);
            migration1.ParamRemoveAt(Cell_T);
        }
        private void CellularBehaviorModules_Register()
        {
            cellName1.RegisterParameters(Cell_T);
            areaWeighting1.RegisterParameters(Cell_T);
            basicConnectionEnergy1.RegisterParameters(Cell_T);
            cellCellConnection1.RegisterParameters(Cell_T);
            cellSubstConnection1.RegisterParameters(Cell_T);
            cellDeath1.RegisterParameters(Cell_T);
            division1.RegisterParameters(Cell_T);
            differentiation_Epithelium1.RegisterParameters(Cell_T);
            deviation_hiPSC1.RegisterParameters(Cell_T);
            justAfterSeeding1.RegisterParameters(Cell_T);
            migration1.RegisterParameters(Cell_T);
        }

        public static void CellLoop(List<CellData> cells)
        {
            int[] ind = Common.RandomlySort(cells);

            CellCellConnection.Run(cells, ind);
            CellSubstrateConnection.Run(cells, ind);
            CellDeath.Run(cells, ind);
            Migration.Run(cells, ind);
            Division.Run6(cells, ind);
            Differentiation_Epithelium.Run2(cells, ind);
            Deviation_hiPSC.Run(cells);
        }
    }}
