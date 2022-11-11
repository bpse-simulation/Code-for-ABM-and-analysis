using System.Collections.Generic;
using System.Windows.Forms;

namespace CellBehaviorSimulator.CultureEnvironments
{
    public partial class Environments : UserControl
    {
        public Environments()
        {
            InitializeComponent();
        }

        internal void SetParameter()
        {
            timeSetting1.SetParameter();
            mapSetting1.SetParameter();
            boundaryConditions1.SetParameter();
            connectability1.SetParameter();
            gravitySettling1.SetParameter();
            substrateAbility1.SetParameter();
        }
        public static void WriteParameter(System.IO.StreamWriter sw)
        {
            sw.WriteLine("# Definition of culture environment parameters");
            CultureTime.WriteParameter(sw);
            CultureSpace.WriteParameter(sw);
            BoundaryConditions.WriteParameter(sw);
            Connectability.WriteParameter(sw);
            GravitySettling.WriteParameter(sw);
            SubstrateAbility.WriteParameter(sw);
        }
        public static bool ReadParameter(string strName, string strValue)
        {
            if (CultureTime.ReadParameter(strName, strValue))
            { return true; }
            if (CultureSpace.ReadParameter(strName, strValue))
            { return true; }
            if (BoundaryConditions.ReadParameter(strName, strValue))
            { return true; }
            if (Connectability.ReadParameter(strName, strValue))
            { return true; }
            if (GravitySettling.ReadParameter(strName, strValue))
            { return true; }
            if (SubstrateAbility.ReadParameter(strName, strValue))
            { return true; }
            return false;
        }
        public static void ClearParameter()
        {
            CultureTime.ClearParameter();
            CultureSpace.ClearParameter();
            BoundaryConditions.ClearParameter();
            Connectability.ClearParameter();
            GravitySettling.ClearParameter();
            SubstrateAbility.ClearParameter();
        }
        internal static void Run(List<CellData> cells)
        {
            CultureTime.Run(cells);
            SubstrateAbility.Run();
        }
    }
}
