using System;
using System.Security.Cryptography;

namespace CellBehaviorSimulator
{
    public class RandomBoxMuller
    {
        public static double Next(double mu = 0.0, double sigma = 1.0, bool getCos = true)
        {
            if (getCos)
            {
                double rand;
                while ((rand = Common.Rand_NextDouble()) == 0.0) ;
                double rand2 = Common.Rand_NextDouble();
                double normrand = Math.Sqrt(-2.0 * Math.Log(rand)) * Math.Cos(2.0 * Math.PI * rand2);
                normrand = normrand * sigma + mu;
                return normrand;
            }
            else
            {
                double rand;
                while ((rand = Common.Rand_NextDouble()) == 0.0) ;
                double rand2 = Common.Rand_NextDouble();
                double normrand = Math.Sqrt(-2.0 * Math.Log(rand)) * Math.Sin(2.0 * Math.PI * rand2);
                normrand = normrand * sigma + mu;
                return normrand;
            }
        }

        public static double GetRandom()
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] bs = new byte[sizeof(int)];
                rng.GetBytes(bs);
                int iR = BitConverter.ToInt32(bs, 0);
                return (double)iR / int.MaxValue;
            }
        }

        public static double GetNormRandom()
        {
            double dR1 = Math.Abs(GetRandom());
            double dR2 = Math.Abs(GetRandom());
            return Math.Sqrt(-2 * Math.Log(dR1, Math.E)) * Math.Cos(2 * Math.PI * dR2);
        }
    }
}
