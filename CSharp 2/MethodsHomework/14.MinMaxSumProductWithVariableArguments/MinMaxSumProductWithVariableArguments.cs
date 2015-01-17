using System;
using System.Collections.Generic;
//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments


namespace MinMaxAverageSumProductWithVariableArguments
{
    class MinMaxSumProductWithVariableArguments
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Max of sequence: {0}", Max(2,3,5,4));
            Console.WriteLine("Min of sequence: {0}", Min(8, 5, 9, 6, 4, -6, 10, -55));
            Console.WriteLine("Average of sequence: {0:0.00}", Average(5,10,15,40));
            Console.WriteLine("Sum of sequence: {0}", Sum(1,8,15,32));
            Console.WriteLine("Product of sequence: {0}", Product(1,2,3,4,5));
        }

        static int Min(params int[] numbers)
        {
            int min = int.MaxValue;
            foreach (var number in numbers)
            {
                if (number < min)
                {
                    min = number;                    
                }
            }
            return min;
        }

        static int Max(params int[] numbers)
        {
            int max = int.MinValue;
            foreach (var number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }

        static decimal Average(params int[] numbers)
        {
            decimal sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum/numbers.Length;
        }

        static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        static long Product(params long[] numbers)
        {
            long product = 1;
            foreach (var number in numbers)
            {
                product *= number;
            }
            return product;
        }
    }
}
