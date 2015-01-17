using System;


namespace PrintOneToN
{
    class PrintOneToN
    {
        static void Main()
        {   //Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

            Console.WriteLine("Please enter an integer number which will be the the end of a sequence");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}
