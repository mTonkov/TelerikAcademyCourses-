using System;
using System.Collections.Generic;
//Write a program to convert decimal numbers to their binary representation

namespace DecimalToBin
{
    class DecimalToBin
    {
        static void Main(string[] args)
        {
            int decimalNum = 143;
            List<int> getBinary = new List<int>();

            Console.WriteLine("The number {0} in binary numeral system is:", decimalNum);//this is printed, before "decimalNum" is modified

            while (decimalNum > 0)
            {
                // keeps the bits of the binary number, starting from the lower-order bits of the number
                getBinary.Add(decimalNum % 2);
                decimalNum /= 2;
            }

            int[] binaryFinal = new int[32];
            //an array, representing 32-bit binary sequence is created to hold the bits in Little-Endian representation

            for (int i = 0; i < getBinary.Count; i++)
            {// send the bits stored in the List to the array
                binaryFinal[i] = getBinary[i];
            }
            Array.Reverse(binaryFinal); // convert the array to view the binary number in 32-bit Big-Endian representation            
            Console.WriteLine(string.Join("", binaryFinal));
        }
    }
}
