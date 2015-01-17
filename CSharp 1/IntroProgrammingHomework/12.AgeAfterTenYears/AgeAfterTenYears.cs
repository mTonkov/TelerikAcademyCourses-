using System;

namespace AgeAfterTenYears
{
    class AgeAfterTenYears
    {
        static void Main()
        {
            //Write a program to read your age from the console and print how old you will be after 10 years.

            Console.WriteLine("How old are you?");
            uint age = uint.Parse(Console.ReadLine());
            age += 10;
            Console.WriteLine("Your age after ten years will be:" + age);

        }
    }
}
