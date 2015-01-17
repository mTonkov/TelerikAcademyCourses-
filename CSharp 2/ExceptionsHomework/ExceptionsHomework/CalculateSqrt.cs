using System;
//Write a program that reads an integer number and calculates and prints its square root. 
//If the number is invalid or negative, print "Invalid number". 
//In all cases finally print "Good bye". Use try-catch-finally

namespace CalculateSqrt
{
    class CalculateSqrt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find its square root:");

            try
            {
                int input = int.Parse(Console.ReadLine());
                if (input < 0)
                {
                    throw new ArgumentException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
