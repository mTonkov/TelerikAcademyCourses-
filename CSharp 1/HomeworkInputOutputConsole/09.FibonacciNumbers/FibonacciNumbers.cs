using System;
using System.Numerics;
namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            //Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

            Console.WriteLine("Enter the length of the Fibonacci numbers' sequence, which you want to print");
            int length = int.Parse(Console.ReadLine());

            //each number in a Fibonacci sequence is the sum of the previous two. '0' and '1' are the first two numbers by default
            BigInteger firstNum = 0;
            BigInteger secondNum = 1;
            BigInteger currentSum;     //this is the sum of previous two numbers, which will be print as part of the sequence
            
            Console.WriteLine("The first {0} members of the Fibonacci sequence are:", length);
            Console.Write("0, 1");
            for (int i = 1 ; i <= length; i++)
            {
                currentSum = firstNum + secondNum;
                Console.Write(", {0}", currentSum);
                firstNum = secondNum;       // the following two rows assign the next values of the previous numbers, which are before the current
                secondNum = currentSum;
            }
            Console.WriteLine();
        }
    }
}
