using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAllNotDevisible
{
    class PrintAllNotDevisible
    {
        static void Main(string[] args)
        { //Write a program that prints all the numbers from 1 to N, 
            //that are not divisible by 3 and 7 at the same time.

            Console.WriteLine("Enter a range of numbers");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (!(i%3==0 && i%7==0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
