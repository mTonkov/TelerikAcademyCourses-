using System;

namespace PlusMinusSequence
{
    class PlusMinusSequence
    {
        static void Main()
        {
            /*Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ... */

            Console.WriteLine("Please, insert the first number of the sequence with consecutive positive and negative numbers! Number 2 is expected:"); //It should be 2, according to the task
            int  firstNumber = int .Parse(Console.ReadLine());
            Console.WriteLine("Please, insert the range of the sequence! 10 is expected:"); // It is 10, according to the task
            int  range = int .Parse(Console.ReadLine());
            Console.WriteLine();
            for (int  number = firstNumber; number < (firstNumber + range); number++) 
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
                else
                {
                    Console.WriteLine(number * -1);
                }
            }
        }
    }
}
