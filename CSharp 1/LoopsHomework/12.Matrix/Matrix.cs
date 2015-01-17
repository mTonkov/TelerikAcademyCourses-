using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {
        static void Main(string[] args)
        { //Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix

            Console.WriteLine("Please enter matrix size");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) // counts rows
            {
                for (int j = 1; j <= n; j++) // counts columns and prints numbers in columns(positions on rows)
                {
                    Console.Write((j+i)+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
