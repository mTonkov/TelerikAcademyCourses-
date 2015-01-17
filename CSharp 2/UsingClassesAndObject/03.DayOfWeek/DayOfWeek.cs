using System;
//Write a program that prints to the console which day of the week is today. Use System.DateTime

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string today = DateTime.Today.DayOfWeek.ToString();
            Console.WriteLine("Today is: {0}", today);
        }
    }
}
