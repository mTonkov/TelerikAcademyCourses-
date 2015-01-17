using System;
 

namespace TrapezoidArea
{
    class TrapezoidArea
    {
        static void Main( )
        {
            //Write an expression that calculates trapezoid's area by given sides a and b and height h.

            Console.WriteLine("Enter trapezoid's side A");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter trapezoid's side B");
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter trapezoid's height");
            double h = double.Parse(Console.ReadLine());

            double area = ((sideA + sideB) / 2) * h; //formula for trapezoid's area
            Console.WriteLine("Trapezoid's area is: " + area);

        }
    }
}
