using System;
using System.Collections.Generic;
//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).


namespace SignOfShortNumber
{
    class SignOfShortNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 16-bit signed integer number");
            short number = short.Parse(Console.ReadLine());

            if (number<0)
            {
                number = Math.Abs(number);
                string binaryNum = DecimalToBinary(number);
                int index=0;
                for (int i = binaryNum.Length-1; i >= 0 ; i--) //looks, in the binary representation of the input number, for the first
                {                                              // lower-order bit which has value '1' and keeps the index
                    if (binaryNum[i] == '1')                   // I do this, because if you check the Windows Calculator in Programmer mode,
                    {                                          // exchange of bit values(1 <-> 0) appears after the first lower order bit
                        index = i;                             // with value '1' up to the last higher order bit. Exanple: 
                        break;                                 // 4 = 0000 0000 0000 0100; -4 = 1111 1111 1111 1100;
                    }
                }

                char[] negativeBinary = binaryNum.ToCharArray();
                for (int i = 0; i < index; i++)
                {
                    negativeBinary[i] = '1';
                }
                Console.WriteLine(string.Join("",negativeBinary));
            }
            else
            {
                Console.WriteLine(DecimalToBinary(number));
            }

        }
        static string DecimalToBinary(int decimalNum) //the method is from the solution of the 01 task
        {
            List<int> getBinary = new List<int>();
            while (decimalNum > 0)
            {
                getBinary.Add(decimalNum % 2);
                decimalNum /= 2;
            }

            for (int i = getBinary.Count; i < 16; i++) // creaqting the sequence up to 16 bits
            {
                getBinary.Add(0);
            }
            getBinary.Reverse();
            return string.Join("", getBinary);
        }
    }
}
