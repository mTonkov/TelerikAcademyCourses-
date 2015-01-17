using System;
using System.Collections.Generic;
/* 11. Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
		x2 + 5 = 1x2 + 0x + 5 
12. Extend the program to support also subtraction and multiplication of polynomials*/

namespace SumSubtractMultiplyPolinomials
{
    class SumSubtractMultiplyPolinomials
    {
        static void Main(string[] args)
        {
            int[] firstPolinomCoeff = { 1, 0, 5 }; //coefficients are given starting from the highest priority in polinom e.g. x^2, x^1, x^0
            int[] secondPolinomCoeff = { 3, 5, 0, 1, 7 }; // x^4, x^3, x^2, x^1, x^0

            Console.WriteLine("Choose operation for polynoms: \'+\',\'-\' or \'*\' ?");
            string input = Console.ReadLine();

            int[] biggerArr;
            int[] smallerArr;
            if (firstPolinomCoeff.Length > secondPolinomCoeff.Length)
            {
                biggerArr = firstPolinomCoeff;
                smallerArr = secondPolinomCoeff;
            }
            else
            {
                biggerArr = secondPolinomCoeff;
                smallerArr = firstPolinomCoeff;
            }


            if (input == "+")
            {
                int[] sum = SumArrays(biggerArr, smallerArr);
                Console.WriteLine("Summed polynom coefficients:");
                Print(sum);
            }
            else if (input == "-")
            {
                SubtractArrays(biggerArr, smallerArr);
            }
            else if (input == "*")
            {
                Multiply(biggerArr, smallerArr);
            }
        }

        static int[] SumArrays(int[] biggerArray, int[] smallerArray)
        {
            if (biggerArray.Length < smallerArray.Length) // this check is repeated, because the method is called in the 
            {                                               //Multiply method, and the check is needed there
                biggerArray = smallerArray;
                smallerArray = biggerArray;
            }

            Array.Reverse(biggerArray); // to start summing from the coefficients of x^0
            Array.Reverse(smallerArray);

            int[] sum = (int[])biggerArray.Clone(); //an array sum[] with values of the bigger array, to which the smaller will be added
            for (int i = 0; i < smallerArray.Length; i++)
            {
                sum[i] += smallerArray[i]; //sums elements in both arrays
            }
            return sum;
        }

        static void SubtractArrays(int[] biggerArray, int[] smallerArray)
        {//same as the previous one
            Array.Reverse(biggerArray);
            Array.Reverse(smallerArray);

            int[] result = (int[])biggerArray.Clone();
            for (int i = 0; i < smallerArray.Length; i++)
            {
                result[i] -= smallerArray[i];
            }
            Console.WriteLine("Subtracted polynom coefficients:");
            Print(result);
        }

        static void Multiply(int[] biggerArray, int[] smallerArray)
        {
            Array.Reverse(biggerArray);
            Array.Reverse(smallerArray);

            int[] product = (int[])biggerArray.Clone();

            for (int i = 0; i < product.Length; i++)
            {
                product[i] = product[i] * smallerArray[0];
            }

            int[] currentProduct = new int[product.Length];
            for (int j = 1; j < smallerArray.Length; j++)
            {
                for (int i = 0; i < product.Length; i++)
                {
                    currentProduct[i] = biggerArray[i] * smallerArray[j];
                }
                product = SumArrays(product, currentProduct);
            }
            Console.WriteLine("Multiplied polynom coefficients:");
            Print(product);
        }

        static void Print(int[] arr)
        {
            Array.Reverse(arr);
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
