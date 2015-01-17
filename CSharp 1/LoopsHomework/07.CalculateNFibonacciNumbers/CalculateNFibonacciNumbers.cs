using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;
using System.Threading;

namespace CalculateNFibonacciNumbers
{
    class CalculateNFibonacciNumbers
    {
        
        static void Main(string[] args)
        { /*Write a program that reads a number N and calculates the sum of the first N members of the sequence of 
           * Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
           * Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members*/


            Console.WriteLine("Please enter length of Fibonacci sequence");
            int n = int.Parse(Console.ReadLine());

            BigInteger firstNum = 0;
            BigInteger secondNum = 1;
            BigInteger nextNum; //this is the sum of previous two numbers, which will be print as part of the sequence
            BigInteger sum = 1;

            if (n>2)
            {
                for (int i = 2; i < n; i++)
                {
                    nextNum = firstNum + secondNum;
                    sum += nextNum;
                    firstNum = secondNum; // the following two rows assign the next values of the previous numbers, which are before the current
                    secondNum = nextNum;
                }
                Console.WriteLine("The sum of the first {0} Fibonacci numbers is {1:N0}", n, sum);
            }
            else if (n==2)
            {
                Console.WriteLine("The sum of the first {0} Fibonacci numbers is {1}", n, sum);
            }
            else
            {
                Console.WriteLine("The sum is '0'");
            }
            
        }
    }
}
