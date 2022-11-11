using System.Windows.Forms;

namespace CellBehaviorSimulator.CultureOperations
{
    public partial class Operations : UserControl
    {
        public Operations()
        {
            InitializeComponent();
        }

        internal void SetParameter()
        {
            seeding1.SetParameter();
        }
        internal static void WriteParameter(System.IO.StreamWriter sw)
        {
            sw.WriteLine("# Definition of culture operation parameters");
            Seeding.WriteParameter(sw);
        }
        public static bool ReadParameter(string strName, string strValue)
        {
            if (Seeding.ReadParameter(strName, strValue))
            { return true; }
            return false;
        }
        internal static void ClearParameter()
        {
            Seeding.ClearParameter();
        }
    }
}
