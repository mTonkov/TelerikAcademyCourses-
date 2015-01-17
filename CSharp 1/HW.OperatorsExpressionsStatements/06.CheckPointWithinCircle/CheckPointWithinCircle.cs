using System;


namespace CheckPointWithinCircle
{
    class CheckPointWithinCircle
    {
        static void Main()
        {//Write an expression that checks if given point (x,  y) is within a circle K(O, 5)
            double circleX = 0;
            double circleY = 0;
            double circleRadius = 5;

            Console.WriteLine("Please enter the X coordinate of a point: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Y coordinate of a point: ");
            double y = double.Parse(Console.ReadLine());

            double squareOfA = (x - circleX) * (x - circleX);
            double squareOfB = (y - circleY) * (y - circleY);
            bool check = squareOfA + squareOfB < circleRadius * circleRadius;
            /*the comparison represents the Pythagoras theorem - a^2+b^2=c^2.
             * In this case a,b and c are the sides of a triangle with a 90 degrees angle.
             * Here we represent this triangle with the x and y coordinates, 
             * as its sides, and the radius as its basis. 
             * If this equation (a^2 + b^2 = c^2) is true, then the point is on the circle.
             * So, we need it to be (a^2 + b^2 < c^2)*/

            Console.WriteLine("The point, which coordinates you just entered is in the circle: ->" + check);
        }
    }
}
