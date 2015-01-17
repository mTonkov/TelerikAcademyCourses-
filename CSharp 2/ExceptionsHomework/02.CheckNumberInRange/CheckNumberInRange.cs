using System;
using System.Collections.Generic;
//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//If an invalid number or non-number text is entered, the method should throw an exception. 
//Using this method write a program that enters 10 numbers:			a1, a2, … a10, such that 1 < a1 < … < a10 < 100


namespace CheckNumberInRange
{
    class CheckNumberInRange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter start of the range");
            try
            {
                int start = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter end of the range");
                int end = int.Parse(Console.ReadLine());

                ReadNumber(start, end);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ReadNumber(int start, int end)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number {0}: ", i+1);
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    if (input > end || input < start)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number! Input is not a number");
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Invalid number! \n {0}", e.Message);
                }
            }
        }
    }
}
