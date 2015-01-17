using System;


namespace Hw03RectangleArea
{
    class RectangleArea
    {
        static void Main()
        {
            //Write an expression that calculates rectangle’s area by given width and height.

            Console.WriteLine("Please enter rectangle's width: ");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter rectangle's height: ");
            double height = double.Parse(Console.ReadLine());

            double rectangleArea = height * width;

            Console.WriteLine("Rectangle's area is: {0:0.00}", rectangleArea);

        }
    }
}
