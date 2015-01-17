using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideNAndKFactorials
{
    class DivideNAndKFactorials
    {
        static void Main(string[] args)
        { //Write a program that calculates N!/K! for given N and K (1<K<N).
           
            ulong n, k;

            while (true)
            {
                Console.WriteLine("Enter a value for N. Mind the condition (1<K<N) ");
             n = ulong.Parse(Console.ReadLine());

             Console.WriteLine("Enter a value for K. Mind the condition (1<K<N) ");
             k = ulong.Parse(Console.ReadLine());

                if (k>1 && k<n)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Your inputs must meet the condition (1<K<N)");
                }
            }


            ulong nFactorial = 1;
            ulong kFactorial = 1;

            for (ulong i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }

            for (ulong i = 1; i <= k; i++)
            {
                kFactorial *= i;
            }

            Console.WriteLine("The result of N!/K! is {0}", nFactorial/kFactorial);
        }
    }
}
