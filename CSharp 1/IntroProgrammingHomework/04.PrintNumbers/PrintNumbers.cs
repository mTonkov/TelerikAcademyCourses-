using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbers
{
    class PrintNumbers
    {
        static void Main()
        {
            //Write a program to print the numbers 1, 101 and 1001

            int ten = 10;
            Console.WriteLine(ten / ten);
            double hundred = Math.Pow(ten, 2);
            Console.WriteLine(++hundred);
            double thousand = Math.Pow(ten, 3);
            Console.WriteLine(++thousand);
        }
    }
}
