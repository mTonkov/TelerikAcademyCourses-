using System;


namespace CompareNumbersNoIf
{
    class CompareNumbersNoIf
    {
        static void Main()
        {//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

            Console.WriteLine("Please enter the first positive integer number of the interval");
            double firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second positive integer number of the interval");
            double secondNum = double.Parse(Console.ReadLine());

            while (firstNum > secondNum)
            {
                Console.WriteLine("The greater number is: " + firstNum);
                break;
            }

            while (firstNum < secondNum)
            {
                Console.WriteLine("The greater number is: " + secondNum);
                break;
            }

            while (firstNum == secondNum)
            {
                Console.WriteLine("The two numbers are equal");
                break;
            }
        }
    }
}
