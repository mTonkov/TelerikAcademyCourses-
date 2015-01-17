using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. 
 * Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure 
 * (height*width for rectangle and height*width/2 for triangle). 
 * Define class Circle and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method. 
 * Write a program that tests the behavior of  the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored in an array.*/
namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
            {
                new Triangle(2,3),
                new Rectangle(2,3),
                new Circle(3),
                new Triangle(4,2)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0:F3}", shape.CalculateSurface());
            }
        }
    }
}
