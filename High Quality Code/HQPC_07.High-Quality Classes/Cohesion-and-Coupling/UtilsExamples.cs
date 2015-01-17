namespace CohesionAndCoupling
{
    using System;

    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(FileUtils.GetFileExtension("example"));
            Console.WriteLine(FileUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
              GeometricDistanceUtils.CalculateDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                GeometricDistanceUtils.CalculateDistance3D(5, 2, -1, 3, -6, 4));

            GeometricFiguresUtils.Width = 3;
            GeometricFiguresUtils.Height = 4;
            GeometricFiguresUtils.Depth = 5;
            Console.WriteLine("Volume = {0:f2}", GeometricFiguresUtils.CalculateVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", GeometricFiguresUtils.CalculateDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", GeometricFiguresUtils.CalculateDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", GeometricFiguresUtils.CalculateDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", GeometricFiguresUtils.CalculateDiagonalYZ());
        }
    }
}
