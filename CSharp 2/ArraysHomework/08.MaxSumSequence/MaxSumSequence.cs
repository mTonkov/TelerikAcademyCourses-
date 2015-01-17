using System;
using System.Collections.Generic;

//Write a program that finds the sequence of maximal sum in given array

class MaxSumSequence
    {
        static void Main(string[] args)
        {
            int sum = 0; 
            int start = 0;
            int end = 0;
            int maxSum = 0;

            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            for (int i = 0; i < array.Length; i++)
            {   //the loop goes through the array only once and sums every element until the sum is <=0. 
                
                sum += array[i];

                if (sum > maxSum)      
                {
                    maxSum = sum;
                    end = i;
                }
                else if (sum <= 0) //If sum <=0, sum starts over from the next element.
                {                            
                    sum = 0;                 
                    start = i + 1;
                    continue;
                }
            }

            for (int i = start; i <= end; i++)
            {
                Console.Write("{0}, ", array[i]);
            }
            Console.WriteLine("--->>> sum={0}", maxSum);
        }
    }
