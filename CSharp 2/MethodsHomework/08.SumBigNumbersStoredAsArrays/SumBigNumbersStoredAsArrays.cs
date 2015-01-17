using System;
using System.Collections.Generic;
//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; 
//the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.


namespace SumBigNumbersStoredAsArrays
{
    class SumBigNumbersStoredAsArrays
    {
        static void Main(string[] args)
        {//the description of the task says that the numbers are stored as arrays and the first element of an array keeps the 
            //last digit of the number
            int[] firstArray = { 1, 5, 9, 3, 2 }; //number "23 951"
            int[] secondArray = { 0, 6, 6, 9, 8, 9, 1, 2 }; //number "21 989 660"

            if (firstArray.Length > secondArray.Length)
            {
                SumArrays(firstArray, secondArray);
            }
            else
            {
                SumArrays(secondArray, firstArray);
            }
        }

        static void SumArrays(int[] biggerArray, int[] smallerArray)
        {
            int[] sum = (int[])biggerArray.Clone(); //an array sum[] with values of the bigger array, to which the smaller will be added
            for (int i = 0; i < smallerArray.Length; i++)
            {
                sum[i] += smallerArray[i]; //sums elements in both arrays
                if (sum[i] >= 10)
                { //if sum is >= 10, current sum is the rightmost digit, and the "one in mind" is moved to the next position
                    sum[i] %= 10;
                    sum[i + 1] += 1;
                }
            }
            for (int i = 0; i < sum.Length; i++)       //Checks if there is a sum on a position 'i' between the 
            {                                               //[smallerArrLength:biggerArrLength] in the sum[], which is >= 10
                if (i < sum.Length - 1 && sum[i] >= 10)      //and finishes the calculation. Check the case with the given arrays
                {
                    sum[i] %= 10;
                    sum[i + 1] += 1;
                }
            }
            Array.Reverse(sum);
            Console.WriteLine("The sum is:" + string.Join("", sum));
        }
    }
}
