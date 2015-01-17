namespace CohesionAndCoupling
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class GeometricFiguresUtils
    {
        public static double Width { get; set; }

        public static double Height { get; set; }

        public static double Depth { get; set; }

        public static double CalculateVolume()
        {
            double volume = Width * Height * Depth;
            return volume;
        }

        public static double CalculateDiagonalXYZ()
        {
            double distance = GeometricDistanceUtils.CalculateDistance3D(0, 0, 0, Width, Height, Depth);
            return distance;
        }

        public static double CalculateDiagonalXY()
        {
            double distance = GeometricDistanceUtils.CalculateDistance2D(0, 0, Width, Height);
            return distance;
        }

        public static double CalculateDiagonalXZ()
        {
            double distance = GeometricDistanceUtils.CalculateDistance2D(0, 0, Width, Depth);
            return distance;
        }

        public static double CalculateDiagonalYZ()
        {
            double distance = GeometricDistanceUtils.CalculateDistance2D(0, 0, Height, Depth);
            return distance;
        }


    }
}
