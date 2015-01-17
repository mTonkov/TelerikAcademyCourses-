using System;
using System.Collections.Generic;
//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.


namespace AreaOfTriangle
{
    class AreaOfTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the data you know and can input to find triangle's surface. Select a number:");
            Console.WriteLine("1. Side and an altitude to it");
            Console.WriteLine("2. Three sides");
            Console.WriteLine("3. Two sides and an angle between them");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                AreaSideAltitude();
            }
            else if (input == 2)
            {
                AreaThreeSides();
            }
            else if (input == 3)
            {
                AreaSidesAngle();
            }

        }
        static void AreaSideAltitude()
        {
            Console.WriteLine("Insert length of side");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert the altitude");
            double h = double.Parse(Console.ReadLine());

            double area = a * h / 2;
            Console.WriteLine("Surface of the triangle is: {0:F2}", area);
        }
        static void AreaThreeSides()
        {
            Console.WriteLine("Insert the length of each of the 3 sides. Press \"Enter\" after each input");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double p = (a + b + c) / 2; //half the perimeter (Heron's Formula)
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Surface of the triangle is: {0:F2}", area);
        }
        static void AreaSidesAngle()
        {
            Console.WriteLine("Length of first side?");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Length of first side?");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Angle?");
            double alpha = double.Parse(Console.ReadLine());
            alpha = Math.PI * alpha / 180;          // the formula below calculates the area but Math.Sin() requires radians as parameter
            double area = a * b * Math.Sin(alpha)/2;

            Console.WriteLine("Surface of the triangle is: {0:F2}", area);

        }
    }
}
