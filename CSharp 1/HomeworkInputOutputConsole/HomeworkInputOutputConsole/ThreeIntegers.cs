using System;


namespace ThreeIntegers
{
    class ThreeIntegers
    {
        static void Main()
        {   //Write a program that reads 3 integer numbers from the console and prints their sum.

            Console.Write("Please enter the first integer number:");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second integer number:");
            int second = int.Parse(Console.ReadLine());

            Console.Write("Please enter the third integer number:");
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum of {0}, {1} and {2} is: {3}", first, second, third, first + second + third);

        }
    }
}
