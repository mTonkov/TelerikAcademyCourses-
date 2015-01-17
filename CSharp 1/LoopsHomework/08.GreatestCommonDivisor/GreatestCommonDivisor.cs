using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main(string[] args)
        { //Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
            //Use the Euclidean algorithm (find it in Internet).

            Console.WriteLine("Enter the first number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the first number");
            int b = int.Parse(Console.ReadLine());

            int divisor = 0;
            // the common divisor can't be bigger than the smaller of the input numbers.
            //so, I define which the inputs is the smaller one
            if (a<b)
            {
                divisor = a;
            }
            if (b<a)
            {
                divisor = b;
            }
            // the check for the GCD will be performed from the biggest posible to 1, and the first common divisor will be the GCD
            for (int i = divisor; i >= 1; i--)
            {
                if ((a % i == 0) && (b % i == 0))
                {
                    Console.WriteLine("The GCD of {0} and {1} is: {2}", a, b, i);
                    break;

                }
            }
        }
    }
}
