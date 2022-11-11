using System;
using System.IO;
using System.Text;


namespace Classification_jam_unjam
{
    class Program
    {
        static void Main(string[] args)
        {
            //input file
            string[] str = Directory.GetFiles(args[0], "*.csv");

            for (int i = 0; i < str.Length; i++)
            {
                //output folder
                string output1 = Path.Combine(args[1], (i+1).ToString("00000") + ".csv");


                using (FileStream fsw1 = new FileStream(output1, FileMode.Create, FileAccess.Write, FileShare.Write))
                using (StreamWriter sw1 = new StreamWriter(fsw1))
                {
                    sw1.WriteLine("Index,hexX,hexY,hexZ,Class_EpB_min,jam1_unjam0");


                    using (FileStream fs0 = new FileStream(str[i], FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (StreamReader sr0 = new StreamReader(fs0))
                    {
                        string[] aaa0 = sr0.ReadLine().Split(',');
                        while (!sr0.EndOfStream)
                        {
                            string s0 = sr0.ReadLine();
                            string[] ss0 = s0.Split(',');

                            int z = Convert.ToInt32(ss0[4]);
                            if (z == 0)
                            {
                                sw1.WriteLine(ss0[0] + "," + ss0[1] + "," + ss0[2] + "," + ss0[3] + "," + ss0[4] + "," + "1");
                            }

                            else if (z == 1)
                            {
                                sw1.WriteLine(ss0[0] + "," + ss0[1] + "," + ss0[2] + "," + ss0[3] + "," + ss0[4] + "," + "0"); 
                            }

                            else if (z == 2)
                            {
                                sw1.WriteLine(ss0[0] + "," + ss0[1] + "," + ss0[2] + "," + ss0[3] + "," + ss0[4] + "," + "0");
                            }

                            else if (z == 3)
                            {
                                sw1.WriteLine(ss0[0] + "," + ss0[1] + "," + ss0[2] + "," + ss0[3] + "," + ss0[4] + "," + "1");
                            }

                            else if (z == 4)
                            {
                                sw1.WriteLine(ss0[0] + "," + ss0[1] + "," + ss0[2] + "," + ss0[3] + "," + ss0[4] + "," + "0");
                            }

                            else if (z == 5)
                            {
                                sw1.WriteLine(ss0[0] + "," + ss0[1] + "," + ss0[2] + "," + ss0[3] + "," + ss0[4] + "," + "1");
                            }

                            else if (z == 6)
                            {
                                sw1.WriteLine(ss0[0] + "," + ss0[1] + "," + ss0[2] + "," + ss0[3] + "," + ss0[4] + "," + "0");
                            }
                        }

                    }

                }

                Console.WriteLine(i+1 + "/" + str.Length);

            }

        }
    }
}