using System;



namespace CalculateNNumbers
{
    class ProgCalculateNNumbersram
    {
        static void Main()
        {
            //Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum.

            Console.WriteLine("How many numbers you want to sum:");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter a number to sum");
                int sumNumber = int.Parse(Console.ReadLine());

                sum += sumNumber;
            }

            Console.WriteLine("The sum of the entered numbers is {0}", sum);

        }
    }
}
