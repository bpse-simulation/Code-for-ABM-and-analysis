using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellBehaviorSimulator.CultureEnvironments
{
    public partial class GravitySettling : UserControl
    {
        public GravitySettling()
        {
            InitializeComponent();
        }

        #region EventHandler
        private void GravitySettling_Load(object sender, EventArgs e)
        {
            Flag = checkGravitySettling.Checked;
        }
        private void CheckGravitySettling_CheckedChanged(object sender, EventArgs e)
        {
            Flag = checkGravitySettling.Checked;
        }
        #endregion
        #region Parameter setting
        internal void SetParameter()
        {
            checkGravitySettling.Checked = Flag;
        }
        #endregion
        #region Parameter definitions
        public static void WriteParameter(System.IO.StreamWriter sw)
        {
            if (Flag)
            {
                sw.WriteLine(":,GravitySettling," + Flag);
            }
        }
        public static bool ReadParameter(string strName, string strValue)
        {
            return strName == "GravitySettling" ? SetParameter_GravitySettling(strValue) : false;
        }
        public static void ClearParameter()
        { Flag = false; }
        public static bool SetParameter_GravitySettling(string strVal)
        {
            if (bool.TryParse(strVal, out bool val))
            {
                Flag = val;
                return true;
            }
            return false;
        }
        #endregion

        private static bool Flag { get; set; }

        public static void Run(List<CellData> cells)
        {
            if (Flag)
            {
                List<int> basal = new List<int>();

                int[] Label = new int[cells.Count];
                int labelNum = 0;
                int labelCnt = 0;
                while (true)
                {
                    for (int i = 0; i < cells.Count; i++)
                    {
                        if (cells[i] != null && Label[i] == 0)
                        {
                            Queue<Point3D> queue = new Queue<Point3D>();
                            queue.Enqueue(cells[i].Location);
                            labelNum++;
                            labelCnt++;
                            Label[i] = labelNum;

                            object _lockObj1 = new object();
                            object _lockObj2 = new object();
                            object _lockObj3 = new object();

                            bool flag = false;
                            int lab = 0;

                            while (queue.Count > 0)
                            {
                                Point3D pnt = queue.Dequeue();
                                Parallel.For(0, 20, dir =>
                                {
                                    if (Common.GetW(dir))
                                    {
                                        Point3D pnt2 = pnt + Delta.GetDelta(dir);
                                        int val = CultureSpace.GetMap(pnt2);
                                        if (val >= 0)
                                        {
                                            int index = CellData.FindIndex(cells, val);
                                            if (Label[index] == 0)
                                            {
                                                Label[index] = labelNum;
                                                lock (_lockObj1) queue.Enqueue(pnt2);
                                            }
                                            else if (Label[index] != labelNum)
                                            {
                                                lock (_lockObj3)
                                                {
                                                    if (lab < Label[index])
                                                    {
                                                        flag = true;
                                                        lab = Label[index];
                                                    }
                                                }
                                            }
                                        }
                                        else if (val == -3)
                                        {
                                            lock (_lockObj2)
                                            {
                                                if (basal.Count == 0)
                                                { basal.Add(labelNum); }
                                                else if (basal[basal.Count - 1] < labelNum)
                                                { basal.Add(labelNum); }
                                            }
                                        }
                                    }
                                });
                            }
                            if (flag)
                            {
                                Parallel.For(0, cells.Count, j =>
                                {
                                    if (Label[j] == labelNum)
                                    { Label[j] = lab; }
                                });
                                labelCnt--;
                            }
                        }
                    }
                    if (basal.Count < labelCnt)
                    {
                        List<(Point3D, int, int)> points = new List<(Point3D, int, int)>();
                        object _lockObj1 = new object();
                        Parallel.For(0, Label.Length, i =>
                        {
                            if (cells[i] != null)
                            {
                                if (!basal.Exists(delegate (int j) { return j == Label[i]; }))
                                {
                                    lock (_lockObj1)
                                    {
                                        points.Add((cells[i].Location + new Delta(0, 0, -1), cells[i].Index, i));
                                    }
                                    CultureSpace.SetMap(cells[i].Location, -1);
                                    Label[i] = 0;
                                }
                                else
                                {
                                    Label[i] = 1;
                                }
                            }
                        });
                        Parallel.For(0, points.Count, i =>
                        {
                            (Point3D p, int value, int ind) = points[i];
                            CultureSpace.SetMap(p, value);
                            cells[ind].Location = p;
                        });
                        labelNum = 1;
                        labelCnt = 1;
                        basal.Clear();
                        basal.Add(1);
                    }
                    else { break; }
                }
            }
        }
    }
}
