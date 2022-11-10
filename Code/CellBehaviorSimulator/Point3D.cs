using CellBehaviorSimulator.CultureEnvironments;

namespace CellBehaviorSimulator
{
    public class Point3D
    {
        public Point3D(Point3D p) { X = p.X; Y = p.Y; Z = p.Z; }
        public Point3D() { X = 0; Y = 0; Z = 0; }
        public Point3D(int x, int y, int z) { X = x; Y = y; Z = z; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public static bool IsSameLocation(Point3D p1, Point3D p2)
        {
            if (p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z)
            { return true; }
            else
            { return false; }
        }
        public bool IsSameLocation(Point3D p)
        {
            if (X == p.X && Y == p.Y && Z == p.Z)
            { return true; }
            else
            { return false; }
        }
        public static Point3D GetPointWithCheckBoundaryConditions(int x, int y, int z)
        {
            return BoundaryConditions.Check(x, y, z);
        }
        public static Point3D GetPointWithCheckBoundaryConditions(Point3D point, Delta delta)
        {
            return point + delta;
        }
        public static Point3D operator +(Point3D left, Delta right)
        {
            return BoundaryConditions.Check(left, right);
        }
        public static Point3D operator +(Delta left, Point3D right)
        {
            return BoundaryConditions.Check(right, left);
        }

    }
}
