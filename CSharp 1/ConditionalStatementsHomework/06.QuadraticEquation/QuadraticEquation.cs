using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        { /*Write a program that enters the coefficients a, b and c of a quadratic equation
		a*x2 + b*x + c = 0
		and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots*/

            double a, b, c;

            Console.WriteLine("Please enter the first coefficient 'a' of a quadratic equation");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second coefficient 'b' of a quadratic equation");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the third coefficient 'c' of a quadratic equation");
            c = double.Parse(Console.ReadLine());


            double x1, x2, Discriminant;

            Discriminant = Math.Sqrt(b * b - 4 * a * c);
            // finding the Discriminant is part of the rule for solving quadratic equations

            if (Discriminant > 0) //A quadratic equation has two different roots if Discriminant > 0
            {
                x1 = ((-b) + Discriminant) / (2 * a); // This is the formula to find the real roots
                x2 = ((-b) - Discriminant) / (2 * a);

                Console.WriteLine("The real roots of the equation ax2+bx+c=0, are x1={0:0.00} and x2={1:0.00}", x1, x2);
            }
            else if (Discriminant == 0) //When Discriminant is equal to '0', there is only one real root -> x1=x2= -b / (2 * a)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("Discriminant=0, so x1=x2= {0}", x1);
            }
            else  // If Discriminant < 0, there are no roots
            {
                Console.WriteLine("The quadratic equation has no real roots!");
            }

        }
    }
}
