using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllNumbersOneToN
{
    class AllNumbersOneToN
    {
        static void Main(string[] args)
        { //Write a program that prints all the numbers from 1 to N.
            Console.WriteLine("Enter a range of numbers");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
