using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNFactorialXPoweredByN
{
    class SumNFactorialXPoweredByN
    {
        static void Main(string[] args)
        { //Write a program that, for a given two integer numbers N and X, 
            //calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

            Console.WriteLine("Please enter an integer value for N");
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine("Please enter an integer value for X");
            long x = long.Parse(Console.ReadLine());

            decimal sum = 1m;
            for (long i = 1; i <= n; i++)
            {
                decimal nFactorial = 1m; // these two variables are declared here, because calculations for 
                decimal xPow = 1m;       // factorial and grade of x should start from '1'

                for (long j = 1; j <= i; j++) // finds the current 'n' factorial and the grade of X
                {
                    nFactorial *= j;
                    xPow *= x;
                }
                sum += (nFactorial / xPow);

            }

            Console.WriteLine("Sum:" + sum);
        }
    }
}
