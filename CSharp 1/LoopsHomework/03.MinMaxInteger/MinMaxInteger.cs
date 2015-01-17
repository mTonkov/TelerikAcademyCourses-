using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxInteger
{
    class MinMaxInteger
    {
        static void Main(string[] args)
        { //Write a program that reads from the console a sequence of N integer 
            //numbers and returns the minimal and maximal of them.

            Console.WriteLine("Enter a range of numbers");
            int n = int.Parse(Console.ReadLine());

            int min = 0;
            int max = 0;

            for (int i = 1; i <= n ; i++)
            {
                Console.WriteLine("Enter a number");
                int num = int.Parse(Console.ReadLine());

                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }                
            }

            Console.WriteLine("The minimal number is {0} and the maximal is {1}", min, max);

        }
    }
}
