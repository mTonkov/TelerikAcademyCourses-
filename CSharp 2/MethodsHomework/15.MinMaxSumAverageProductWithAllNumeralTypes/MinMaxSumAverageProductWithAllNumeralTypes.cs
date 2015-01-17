using System;
using System.Collections.Generic;
//* Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.). 

namespace MinMaxSumAverageProductWithAllNumeralTypes
{
    class MinMaxSumAverageProductWithAllNumeralTypes
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Max of sequence: {0}", Max(2, 3, 5, 4));
            Console.WriteLine("Min of sequence: {0}", Min(8, 5, 9, 6, 4, -6, 10, -55));
            Console.WriteLine("Average of sequence: {0:0.00}", Average(2.5, 1.5, 1, 10, 15, 40));
            Console.WriteLine("Sum of sequence: {0}", Sum(1, 8, 15, 32));
            Console.WriteLine("Product of sequence: {0}", Product(1, 2, 3, 4, 5));
        }

        static T Min<T>(params T[] numbers)
        {
            dynamic min = int.MaxValue;
            foreach (var number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }

        static T Max<T>(params T[] numbers)
        {
            dynamic max = int.MinValue;
            foreach (var number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }

        static T Average<T>(params T[] numbers)
        {
            dynamic sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Length;
        }

        static T Sum<T>(params T[] numbers)
        {
            dynamic sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        static T Product<T>(params T[] numbers)
        {
            dynamic product = 1;
            foreach (var number in numbers)
            {
                product *= number;
            }
            return product;
        }
    }
}

