using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartTwo
{
    static class ThreeDPoints // task 03
    {
        public static int X { get; set; }
        public static int Y { get; set; }
        public static int Z { get; set; }

        static double Distance(Point3D first, Point3D second)
        {
            X = Math.Abs(first.X - second.X);
            Y = Math.Abs(first.Y - second.Y);
            Z = Math.Abs(first.Z - second.Z);
            //http://quiz.uprm.edu/visual3d/manual/coor_sys/dist_two_points.html formula for distance between two 3D points
            return Math.Sqrt(X*X+Y*Y+Z*Z);
        }
    }
}
