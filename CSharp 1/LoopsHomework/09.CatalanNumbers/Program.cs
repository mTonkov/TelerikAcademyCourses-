using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        { //In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
            //Cn = ((2n)!) / ((n+1)!*n!)
          //Write a program to calculate the Nth Catalan number by given N.

            Console.WriteLine("Please enter the index of the Nth Catalan number");
            ulong n = ulong.Parse(Console.ReadLine());

            ulong divident = 1; // (2n)!
            ulong divisorOne = 1; // (n+1)!
            ulong divisorTwo = 1; // n!

            for (ulong i = 1; i <= (2*n); i++)
            {
                divident *= i;
            }

            for (ulong i = 1; i <= (n+1); i++)
            {
                divisorOne *= i;
                
                if (i <= n) /* using the "if", keeps me from using one more loop, by using the current, 
                             * but assigning "divisorTwo" up to 'n'*/
                { 
                    divisorTwo *= i; 
                }
            }

            Console.WriteLine("Cn = {0}", (divident / (divisorOne * divisorTwo)));

        }
    }
}
