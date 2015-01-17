using System;
using System.Collections.Generic;
//Write a program to convert binary numbers to hexadecimal numbers (directly).

namespace ConvertBinaryToHexadecimal
{
    class ConvertBinaryToHexadecimal
    {
        static void Main(string[] args)
        {
            string binaryNum = "1110010100"; // pretend it is an input with Console.ReadLine(); output: 394
            while (binaryNum.Length%4 != 0)
            {
                binaryNum = "0" + binaryNum; // concatenates '0' with the rest of the binary sequence, in order to get a divisible by four length
            }
            
            char[] fourDigitArray = new char[4];
            int fourDigits = 0;
            for (int i = 0; i < binaryNum.Length - 3; i += 4)
            {
                for (int j = i; j < i + 4; j++)         // the two "for" loops get sets of four digits. Each 4-digit set is converted to hexadecimal digit
                {
                    fourDigitArray[j - i] = binaryNum[j];
                }
                fourDigits = int.Parse(string.Join("", fourDigitArray)); // holds the each set of binary digits as an integer number
                
                int decimalNumber = BinaryToDecimal(fourDigits);
                ConvertToHexadecimal(decimalNumber); // a 4-digit set is converted to hexadecimal number
            }
            Console.WriteLine();
        }

        static int BinaryToDecimal(int intBinary)
        {
            int sum = 0;
            for (int i = 0; i < intBinary.ToString().Length; i++)
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
            return sum;
        }

        static void ConvertToHexadecimal(int decimalNum)
        {
            List<int> getHex = new List<int>();

            while (decimalNum > 0)
            {
                getHex.Add(decimalNum % 16);
                decimalNum /= 16;
            }

            string[] hexadecimal = new string[getHex.Count];

            for (int i = 0; i < getHex.Count; i++)
            {
                if (getHex[i] > 9)
                {
                    hexadecimal[i] = GetHexSymbol(getHex[i]);
                }
                else
                {
                    hexadecimal[i] = getHex[i].ToString();
                }
            }
            Console.Write(string.Join("", hexadecimal));
        }

        static string GetHexSymbol(int number)
        {
            string symbol = null;

            switch (number)
            {
                case 10: symbol = "A";
                    break;
                case 11: symbol = "B";
                    break;
                case 12: symbol = "C";
                    break;
                case 13: symbol = "D";
                    break;
                case 14: symbol = "E";
                    break;
                case 15: symbol = "F";
                    break;
                default:
                    break;
            }
            return symbol;
        }
    }
}

