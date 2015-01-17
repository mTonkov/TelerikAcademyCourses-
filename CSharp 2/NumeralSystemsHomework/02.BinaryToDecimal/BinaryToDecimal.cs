using System;
using System.Collections.Generic;
//Write a program to convert binary numbers to their decimal representation

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            string binaryNumber = "1101001"; //105
            int intBinary = int.Parse(binaryNumber);
            int sum = 0;

            for (int i = 0; i < binaryNumber.Length; i++)
            {
                int digit = intBinary % 10; //gets last digit in the current condition of "intBinary"
                intBinary /= 10; //removes the last, which we get in the prevois operation

                int poweredBase = 1; //the base of the numeral system, powered by '0'
                if (i > 0)
                {//when we get the first digit(first one in the right), the base has power of "0" and the digit is multiplied by "1"
                    for (int j = 0; j < i; j++)//every next base hase the next power e.g. [ 1,2...binaryNumber.Length-1 ]
                    {
                        poweredBase *= 2;
                    }
                }
                sum += (digit * poweredBase);
            }
            Console.WriteLine("The decimal representation of {0} is: {1}", binaryNumber, sum);
        }
    }
}
