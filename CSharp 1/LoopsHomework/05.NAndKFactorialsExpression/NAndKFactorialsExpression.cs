using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAndKFactorialsExpression
{
    class NAndKFactorialsExpression
    {
        static void Main(string[] args)
        { //Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

            ulong n, k;

            while (true)
            {
                Console.WriteLine("Enter a value for N. Mind the condition (1<N<K) ");
                n = ulong.Parse(Console.ReadLine());

                Console.WriteLine("Enter a value for K. Mind the condition (1<N<K) ");
                k = ulong.Parse(Console.ReadLine());

                if (n > 1 && k > n)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Your inputs must meet the condition (1<N<K)");
                }
            }

            ulong nFactorial = 1;
            ulong kFactorial = 1;
            ulong kNDifferenceFactorial = 1;

            for (ulong i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }

            for (ulong i = 1; i <= k; i++)
            {
                kFactorial *= i;
            }

            for (ulong i = 1; i <= (k - n); i++)
            {
                kNDifferenceFactorial *= i;
            }

            ulong result = (nFactorial * kFactorial) / kNDifferenceFactorial;

            Console.WriteLine("The result of N!*K! / (K-N)! is {0}", result);

        }
    }
}
