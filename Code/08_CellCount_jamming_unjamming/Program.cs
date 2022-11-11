using System;
using System.IO;
using System.Text;


namespace CellCount_jamming_unjamming
{
    class Program
    {
        static void Main(string[] args)
        {
            //input fileの入ったfolderの指定
            string[] str = Directory.GetFiles(args[0], "*.csv");

            //output folderの名前
            string outputdir0 = args[1] + @"\count.csv";


            //File 書き込み
            using (FileStream fsw0 = new FileStream(outputdir0, FileMode.Create, FileAccess.Write, FileShare.Write))
            using (StreamWriter sw0 = new StreamWriter(fsw0))


            {
                sw0.WriteLine("File name,1_jam,1_unjam,2_jam,2_unjam,3_jam,3_unjam,4_jam,4_unjam,5_jam,5_unjam,6-jam,6-unjam");


                for (int i = 0; i < str.Length; i++)
                {
                    //File 読み込み
                    using (FileStream fs0 = new FileStream(str[i], FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (StreamReader sr0 = new StreamReader(fs0))
                    {
                        string[] aaa0 = sr0.ReadLine().Split(',');

                        int[] count0 = new int[30];

                        while (!sr0.EndOfStream)
                        {
                            string s0 = sr0.ReadLine();
                            string[] ss0 = s0.Split(',');
                            if (int.TryParse(ss0[3], out int layer))
                            {
                                if (int.TryParse(ss0[5], out int jam))
                                {
                                    count0[2 * layer - jam - 1]++;

                                }


                            }
                            
                        }

                        sw0.WriteLine(str[i] + "," + count0[0] + "," + count0[1] + "," + count0[2] + "," + count0[3] + "," + count0[4] + "," + count0[5] + "," + count0[6] + "," + count0[7] + "," + count0[8] + "," + count0[9] + "," + count0[10] + "," + count0[11]);

                        Console.WriteLine(i + "/" + str.Length);


                    }
                }
            }


        }
    }
}

