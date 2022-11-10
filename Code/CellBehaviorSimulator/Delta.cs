using System;

namespace CellBehaviorSimulator
{
    public class Delta
    {
        public Delta(int dx, int dy, int dz)
        { DX = dx; DY = dy; DZ = dz; }

        public int DX { get; set; }
        public int DY { get; set; }
        public int DZ { get; set; }
        public static readonly double Cf_y = Math.Sqrt(3) / 2.0;

        public static Delta Copy(Delta src)
        {
            return new Delta(src.DX, src.DY, src.DZ);
        }
        public static void Copy(Delta src, Delta dsc)
        {
            dsc.DX = src.DX;
            dsc.DY = src.DY;
            dsc.DZ = src.DZ;
        }
        public Delta Copy() => new Delta(DX, DY, DZ);

        public static Delta GetDelta(Direction.DIR dir)
        {
            switch (dir)
            {
                case Direction.DIR.UL2: return new Delta(-1, -1, 1);
                case Direction.DIR.UR2: return new Delta(1, -1, 1);
                case Direction.DIR.L_2: return new Delta(-2, 0, 1);
                case Direction.DIR.C_2: return new Delta(0, 0, 1);
                case Direction.DIR.R_2: return new Delta(2, 0, 1);
                case Direction.DIR.LL2: return new Delta(-1, 1, 1);
                case Direction.DIR.LR2: return new Delta(1, 1, 1);
                case Direction.DIR.UL1: return new Delta(-1, -1, 0);
                case Direction.DIR.UR1: return new Delta(1, -1, 0);
                case Direction.DIR.L_1: return new Delta(-2, 0, 0);
                case Direction.DIR.C_1: return new Delta(0, 0, 0);
                case Direction.DIR.R_1: return new Delta(2, 0, 0);
                case Direction.DIR.LL1: return new Delta(-1, 1, 0);
                case Direction.DIR.LR1: return new Delta(1, 1, 0);
                case Direction.DIR.UL0: return new Delta(-1, -1, -1);
                case Direction.DIR.UR0: return new Delta(1, -1, -1);
                case Direction.DIR.L_0: return new Delta(-2, 0, -1);
                case Direction.DIR.C_0: return new Delta(0, 0, -1);
                case Direction.DIR.R_0: return new Delta(2, 0, -1);
                case Direction.DIR.LL0: return new Delta(-1, 1, -1);
                case Direction.DIR.LR0: return new Delta(1, 1, -1);
                default: return null;
            }
        }
        public static Delta GetDelta(int i)
        {
            return GetDelta((Direction.DIR)i);
        }
        public static Delta GetDelta(Point3D from, Point3D to)
        {
            return new Delta(to.X - from.X, to.Y - from.Y, to.Z - from.Z);
        }

        public static double GetLength_pow2(Delta d)
        {
            return d.DX * d.DX / 4.0 + d.DY * d.DY * Cf_y * Cf_y + d.DZ * d.DZ;
        }
        public static double GetLength(Delta d)
        {
            return Math.Sqrt(GetLength_pow2(d));
        }
        public static double DistanceFromPointToLine(Delta distance, Delta point)
        {
            double xx = distance.DX * distance.DX / 4.0;
            double yy = distance.DY * distance.DY * Cf_y * Cf_y;
            double zz = distance.DZ * distance.DZ;
            double dxpy = distance.DX * point.DY / 2.0 * Cf_y;
            double dxpz = distance.DX * point.DZ / 2.0;
            double dypx = distance.DY * point.DX / 2.0 * Cf_y;
            double dypz = distance.DY * point.DZ * Cf_y;
            double dzpx = distance.DZ * point.DX / 2.0;
            double dzpy = distance.DZ * point.DY * Cf_y;
            double xy = dxpy - dypx;
            double yz = dypz - dzpy;
            double zx = dzpx - dxpz;
            double d = xy * xy + yz * yz + zx * zx;
            return d / (xx + yy + zz);
        }

#region operator
        public static Delta operator -(Delta left, Delta right)
        {
            return new Delta(left.DX - right.DX, left.DY - right.DY, left.DZ - right.DZ);
        }
        public static Delta operator +(Delta left, Delta right)
        {
            return new Delta(left.DX + right.DX, left.DY + right.DY, left.DZ + right.DZ);
        }
        public static Delta operator -(Delta d)
        {
            return new Delta(-d.DX, -d.DY, -d.DZ);
        }
#endregion

    }
}
