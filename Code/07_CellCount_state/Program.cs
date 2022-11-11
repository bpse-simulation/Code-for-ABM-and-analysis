using System;
using System.IO;
using System.Text;


namespace CellCount_state
{
    class Program
    {
        static void Main(string[] args)
        {
            //input fileの入ったfolderの指定
            string[] str = Directory.GetFiles(args[0], "*.csv");

            //output fileの名前
            string outputdir0 = args[1] + @"\Cell_state_all.csv";
            string outputdir1 = args[1] + @"\Cell_state_basal.csv";
            string outputdir2 = args[1] + @"\Cell_state_supra.csv";
            string outputdir3 = args[1] + @"\Cell_state_error.csv";

            //File 書き込み
            using (FileStream fsw0 = new FileStream(outputdir0, FileMode.Create, FileAccess.Write, FileShare.Write))
            using (StreamWriter sw0 = new StreamWriter(fsw0))
            using (FileStream fsw1 = new FileStream(outputdir1, FileMode.Create, FileAccess.Write, FileShare.Write))
            using (StreamWriter sw1 = new StreamWriter(fsw1))
            using (FileStream fsw2 = new FileStream(outputdir2, FileMode.Create, FileAccess.Write, FileShare.Write))
            using (StreamWriter sw2 = new StreamWriter(fsw2))
            using (FileStream fsw3 = new FileStream(outputdir3, FileMode.Create, FileAccess.Write, FileShare.Write))
            using (StreamWriter sw3 = new StreamWriter(fsw3))

            {
                sw0.WriteLine("File name,0,1,2,3,4,5,6");
                sw1.WriteLine("File name,0,1,2,3,4,5,6");
                sw2.WriteLine("File name,0,1,2,3,4,5,6");
                sw3.WriteLine("File name,0,1,2,3,4,5,6");

                for (int i = 0; i < str.Length; i++)
                {
                    //File 読み込み
                    using (FileStream fs0 = new FileStream(str[i], FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (StreamReader sr0 = new StreamReader(fs0))
                    {
                        string[] aaa0 = sr0.ReadLine().Split(',');

                        int[] count0 = new int[7];
                        int[] count1 = new int[7];
                        int[] count2 = new int[7];
                        int[] count3 = new int[7];

                        while (!sr0.EndOfStream)
                        {
                            string s0 = sr0.ReadLine();
                            string[] ss0 = s0.Split(',');
                            if (int.TryParse(ss0[4], out int a))
                            {
                                if (int.TryParse(ss0[3], out int b))
                                {
                                    if (b == 1)
                                    {
                                        count0[a]++;
                                        count1[a]++;
                                    }
                                    else
                                    {
                                        count0[a]++;
                                        count2[a]++;
                                    }
                                                                                                      
                                }
                                else
                                {
                                    count3[a]++;
                                }

                            }
                            else
                            {
                                count3[a]++;
                            }    
                            


                        }

                        string st0 = str[i];
                        string st1 = str[i];
                        string st2 = str[i];
                        string st3 = str[i];

                        for (int j = 0; j < count0.Length; j++)
                        {
                            st0 += "," + count0[j];
                            st1 += "," + count1[j];
                            st2 += "," + count2[j];
                            st3 += "," + count3[j];
                        }
                        sw0.WriteLine(st0);
                        sw1.WriteLine(st1);
                        sw2.WriteLine(st2);
                        sw3.WriteLine(st3);

                        Console.WriteLine(i + "/" + str.Length);


                    }
                }
            }


        }
    }
}
