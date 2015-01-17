using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.TrailingZerosInNFactorial
{
    class Program
    {
        static void Main(string[] args)
        { //* Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
	        //N = 10 -> N! = 3628800 -> 2
	        //N = 20 -> N! = 2432902008176640000 -> 4

            Console.WriteLine("Please enter N");
            int n = int.Parse(Console.ReadLine());
            BigInteger nFactorial = 1;

            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }

            var factorial = nFactorial.ToString();
            int lengthOfFactorial = factorial.Length - 1;
            char currentChar = factorial[lengthOfFactorial];

            bool haszeros = false;
            int counter = 0;
            while (currentChar == '0')
            {
                currentChar = factorial[--lengthOfFactorial];
                haszeros = true;
                counter++;
            }


            if (haszeros)
            {
                Console.WriteLine("There are {0} Zeros", counter);
            }

            // And a slower solution, when N=50 000:

            //int counter = 0;
            //while (nFactorial%10==0)
            //{
            //    counter++;
            //    nFactorial /=10;
            //    if (nFactorial%10 != 0)
            //    {
            //        Console.WriteLine("There are {0} Zeros", counter);
            //        break;
            //    }
            //}
        }
    }
}
