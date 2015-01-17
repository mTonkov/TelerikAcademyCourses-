using System;
//Write a method that counts how many times given number appears in given array. 
//Write a test program to check if the method is working correctly.

namespace CountGivenNumber
{
    public class CountNumber
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = { 5, 4, 2, 3, 65, 3, 5, 4, 4, 8, 9, 7, 5, 5, 7, 7, 633, 4, 5, 1, 2, 23, 2, 1, 4, 2, 3 };

            Console.WriteLine("Please enter the number which appearance in the array you want to count");
            int number = int.Parse(Console.ReadLine());

            int counted = CountNumberAppearance(number, arrayOfNumbers);
            Console.WriteLine("The number {0} appears in the array {1} times", number, counted);
        }

        public static int CountNumberAppearance(int input, int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == input)
                {
                    count++;
                }
            }

            return count;
        }
    }
}

