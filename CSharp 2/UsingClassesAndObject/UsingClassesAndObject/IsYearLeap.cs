using System;
//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

namespace UsingClassesAndObject
{
    class IsYearLeap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the year you want to check if it is leap or not");
            int year = int.Parse(Console.ReadLine());

            bool isLeap = DateTime.IsLeapYear(year);

            if (isLeap)
            {
                Console.WriteLine("The year {0} is Leap", year);
            }
            else
            {
                Console.WriteLine("The year {0} is NOT Leap", year);
            }
        }
    }
}
