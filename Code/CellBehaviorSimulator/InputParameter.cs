using System.Text;
using System.Windows.Forms;
using System.IO;
using CellBehaviorSimulator.CellBehaviors;
using CellBehaviorSimulator.CultureEnvironments;
using CellBehaviorSimulator.CultureOperations;

namespace CellBehaviorSimulator
{
    public class InputParameter
    {
        public static void SaveParameter(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(File.Open(fileName, FileMode.Create), new UTF8Encoding(true)))
            {
                Behaviors.WriteParameter(sw);
                Environments.WriteParameter(sw);
                Operations.WriteParameter(sw);
                Output.WriteParameter(sw);
            }
        }

        public static bool ReadParameter(string fileName)
        {
            if (File.Exists(fileName))
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (StreamReader sr = new StreamReader(fs, new UTF8Encoding(true)))
                {
                    ClearParameter();
                    int cnt = 0;
                    while (!sr.EndOfStream)
                    {
                        string[] strs = sr.ReadLine().Split(',');
                        if (strs.Length > 0)
                        {
                            if (strs[0] == ":")
                            {
                                if (ReadParameter(strs[1], strs[2]))
                                { cnt++; }
                                else
                                {
                                    if (DialogResult.No == MessageBox.Show(
                                        fileName + "\n\n" + strs[1] + " = " + strs[2] + "\n\nIgnore parameter value?",
                                        "ERROR: InputParameter.ReadParameter(string fileName)",
                                        MessageBoxButtons.YesNo))
                                    {
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                    if (cnt == 0)
                    { return false; }
                    AdjustParameter();
                    return true;
                }
            }
            return false;
        }

        private static void AdjustParameter()
        {
            Behaviors.AdjustParameter();
        }

        private static void ClearParameter()
        {
            Behaviors.ClearParameter();
            Environments.ClearParameter();
            Operations.ClearParameter();
            Output.ClearParameter();
        }

        private static bool ReadParameter(string strName, string strValue)
        {
            string[] s1 = strName.Split('(');
            if (s1.Length > 1)
            {
                strName = s1[0];
                string sType = s1[1].Split(')')[0];
                if (int.TryParse(sType, out int typeNum))
                {
                    return Behaviors.ReadParameter(strName, typeNum, strValue);
                }
            }
            else
            {
                if (Environments.ReadParameter(strName, strValue))
                { return true; }
                if (Operations.ReadParameter(strName, strValue))
                { return true; }
                if (Output.ReadParameter(strName, strValue))
                { return true; }
            }
            return false;
        }
    }
}
