using System;
//Write a program that generates and prints to the console 10 random values in the range [100, 200].


namespace RandomNumbersInRange
{
    class RandomNumbersInRange
    {
        static void Main(string[] args)
        {
            Random randm = new Random();

            for (int i = 0; i < 10; i++)
            {
                int number = randm.Next(100,200);
                Console.WriteLine(number);
            }
        }
    }
}
