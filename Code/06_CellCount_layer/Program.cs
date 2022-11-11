using System;
using System.IO;
using System.Text;


namespace CellCount_layer
{
    class Program
    {
        static void Main(string[] args)
        {
            //input file
            string[] str = Directory.GetFiles(args[0], "*.csv");

            //output folder
            string outputdir0 = args[1] + @"\layer_cell_count.csv";

            using (FileStream fsw0 = new FileStream(outputdir0, FileMode.Create, FileAccess.Write, FileShare.Write))
            using (StreamWriter sw0 = new StreamWriter(fsw0))


            {
                sw0.WriteLine("File name,0,1,2,3,4,5,6,7,8,9,10");


                for (int i = 0; i < str.Length; i++)
                {
                    using (FileStream fs0 = new FileStream(str[i], FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (StreamReader sr0 = new StreamReader(fs0))
                    {
                        string[] aaa0 = sr0.ReadLine().Split(',');

                        int[] count0 = new int[20];
                        int[] count1 = new int[20];
                        int[] count2 = new int[20];

                        while (!sr0.EndOfStream)
                        {
                            string s0 = sr0.ReadLine();
                            string[] ss0 = s0.Split(',');
                            if (int.TryParse(ss0[3], out int layer))
                                count0[layer]++;

                        }

                        sw0.WriteLine(str[i] + "," + count0[0] + "," + count0[1] + "," + count0[2] + "," + count0[3] + "," + count0[4] + "," + count0[5] + "," + count0[6] + "," + count0[7] + "," + count0[8] + "," + count0[9] + "," + count0[10]);
                        
                        Console.WriteLine(i + "/" + str.Length);


                    }
                }
            }


        }
    }
}
