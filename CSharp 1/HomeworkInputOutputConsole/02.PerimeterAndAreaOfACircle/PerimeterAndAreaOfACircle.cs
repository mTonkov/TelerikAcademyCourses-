using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeterAndAreaOfACircle
{
    class PerimeterAndAreaOfACircle
    {
        static void Main()
        {   //Write a program that reads the radius r of a circle and prints its perimeter and area.

            Console.WriteLine("Please enter the radius of a circle!");
            decimal radius = decimal.Parse(Console.ReadLine());

            Console.WriteLine("A circle with {0}cm radius has an area of {1:F2} square cm and a perimeter of {2:F2} cm", radius,(decimal)Math.PI*(radius*radius), (decimal)Math.PI*2*radius);
        }
    }
}
