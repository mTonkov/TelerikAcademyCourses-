using System;
using System.Collections.Generic;
//You are given a sequence of positive integer values written into a string, separated by spaces. 
//Write a function that reads these values from given string and calculates their sum. Example:
//string = "43 68 9 23 318" -> result = 461


namespace ReadValuesFromString
{
    class ReadValuesFromString
    {
        static void Main(string[] args)
        {
            string sequence = "43 68 9 23 318";
            string[] numbers = sequence.Split(' ');

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += int.Parse(numbers[i]);
            }

            Console.WriteLine("The sum of the sequence is {0}", sum);
        }
    }
}
