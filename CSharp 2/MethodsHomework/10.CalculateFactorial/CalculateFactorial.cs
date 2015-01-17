using System;
using System.Collections.Generic;
//Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number

namespace CalculateFactorial
{
    class CalculateFactorial
    {
        static void Main(string[] args)
        {                               //!!! Works only for [1...9]. There is a bug, but I couldn't fix it!!!
            int[] factorialResult = { 1 };
            for (int n = 1; n <= 15; n++)
            {
                factorialResult = NFactorial(factorialResult, NumberInArray(n));
                Console.WriteLine(string.Join("", factorialResult));
            }
        }

        static int[] NFactorial(int[] result, int[] number)
        {
            if (result.Length > number.Length)
            {
                return MultiplyArrays(result, number);
            }
            else
            {
                return MultiplyArrays(number, result);
            }

        }

        static int[] NumberInArray(int num)
        {
            int[] numInArray = new int[num.ToString().Length];
            for (int i = 0; i < numInArray.Length; i++)
            {
                numInArray[i] = num % 10;
                num /= 10;
            }
            Array.Reverse(numInArray);
            return numInArray;
        }

        static int[] MultiplyArrays(int[] biggerArr, int[] smallerArr)
        {
            Array.Reverse(biggerArr);   //arrays are reversed because when multiplying two numbers manually,  
            Array.Reverse(smallerArr);  //we start from the righmost digit
            List<int> productsByDigits = new List<int>();
            //each element in the List will hold the product of one digit from the biggerArr with every digit of the smallerArr. Later the elements in the List should be summed
            for (int i = 0; i < biggerArr.Length; i++)
            {
                int product = 0;
                for (int j = 0; j < smallerArr.Length; j++)
                {
                    product = biggerArr[i] * smallerArr[j];
                }
                productsByDigits.Add(product);
            }

            int[] sumOfProducts = new int[productsByDigits[0].ToString().Length];
            // the multiplication has to be done by summing products of "digit-by-number" multiplication
            int productsByDigitsTemp = productsByDigits[0];
            for (int i = 0; i < sumOfProducts.Length; i++)
            {    //initially the sum holds the value of the first product of "digit-by-number" multiplication and has to be turned into Array in order to be summed
                sumOfProducts[i] = productsByDigitsTemp % 10;
                productsByDigitsTemp /= 10;
            }

            for (int i = 1; i < productsByDigits.Count; i++) // converting the next product of "digit-by-number" multiplication, which will be added to the sum using the "SumArrays" Method
            {
                int[] nextProductToSum = new int[productsByDigits[i].ToString().Length + i];
                int k = 0;
                for (; k < i; k++)
                {
                    nextProductToSum[k] = 0;
                }

                int productsByDigitsNextTemp = productsByDigits[i];
                for (int j = i; j < nextProductToSum.Length; j++)
                {
                    nextProductToSum[j] = productsByDigitsNextTemp % 10;
                    productsByDigitsNextTemp /= 10;
                }

                if (sumOfProducts.Length > nextProductToSum.Length)
                {
                    sumOfProducts = SumArrays(sumOfProducts, nextProductToSum);
                }
                else
                {
                    sumOfProducts = SumArrays(nextProductToSum, sumOfProducts);
                }
            }
            Array.Reverse(sumOfProducts);
            return sumOfProducts;
        }

        static int[] SumArrays(int[] biggerArray, int[] smallerArray)
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
            return sum;
        }
    }
}
