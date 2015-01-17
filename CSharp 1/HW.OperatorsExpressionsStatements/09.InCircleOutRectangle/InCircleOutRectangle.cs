using System;


namespace InCircleOutRectangle
{
    class InCircleOutRectangle
    {
        static void Main()
        {
            //Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) 
            //and out of the rectangle R(top=1, left=-1, width=6, height=2).

            int kX = 1;
            int kY = 1;
            int kR = 3;
            int rectTop = 1;
            int rectLeft = -1;
            int rectWidth = 6;
            int rectHeight = 2;

            Console.WriteLine("Please enter X coordinate of a point: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Y coordinate of the same point: ");
            double y = double.Parse(Console.ReadLine());

            bool inCircle = (x - kX) * (x - kX) + (y - kY) * (y - kY) < kR * kR; //Pythagoras theorem
            bool outCircle = (x - kX) * (x - kX) + (y - kY) * (y - kY) > kR * kR; //Pythagoras theorem
            bool outRectangleX = (x < rectLeft) || (x > rectLeft + rectWidth); 
                // checks if the X coordinate of the point is out of the rectangle's width
            
            bool outRectangleY = (y > rectTop) || (y < rectTop - rectHeight);
                // checks if the X coordinate of the point is out of the rectangle's width

            bool outRectangle = outRectangleX || outRectangleY;
            //the point is out of the rectangle even if only one of X or Y is out of the rectangle

            string inOutCircle;

            if (inCircle)
            {
                 inOutCircle = "inside";
            }
            else if (outCircle)
            {
                 inOutCircle = "outside";
            }
            else
            {
                 inOutCircle = "on";
            }

            string inOutRect;
            if (outRectangle)
            {
                 inOutRect = "outside";
            }
            else
            {
                inOutRect = "within";
            }

            Console.WriteLine("The Point is {0} the circle K and {1} the rectangle R!", inOutCircle, inOutRect);
        }
    }
}
