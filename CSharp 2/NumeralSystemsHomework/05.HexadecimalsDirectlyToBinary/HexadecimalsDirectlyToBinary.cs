using System;
using System.Collections.Generic;
//Write a program to convert hexadecimal numbers to binary numbers (directly).

namespace HexadecimalsDirectlyToBinary
{
    class HexadecimalsDirectlyToBinary
    {
        static void Main(string[] args)
        {
            string hexadecimalNumber = "ABF"; //-> 1010 1011 1111
            List<string> binary = new List<string>();

            for (int i = 0; i < hexadecimalNumber.Length; i++)
            {
                string hexDigit = hexadecimalNumber[i].ToString();

                int digit = 0;
                if (int.TryParse(hexDigit, out digit))
                {
                    binary.Add(DecimalToBinary(digit));
                }
                else
                {
                    digit = GetDecimalOfHexSymbol(hexDigit);
                    binary.Add(DecimalToBinary(digit));
                }
            }

            Console.WriteLine("Hexadecimal: {0} to Binary: {1}", hexadecimalNumber, string.Join(" ", binary));
        }
        static int GetDecimalOfHexSymbol(string number)//the method is from the solution of 05 task
        {
            int symbol = 0;

            switch (number)
            {
                case "A": symbol = 10;
                    break;
                case "B": symbol = 11;
                    break;
                case "C": symbol = 12;
                    break;
                case "D": symbol = 13;
                    break;
                case "E": symbol = 14;
                    break;
                case "F": symbol = 15;
                    break;
                default:
                    break;
            }
            return symbol;
        }

        static string DecimalToBinary(int decimalNum) //the method is from the solution of the 01 task
        {
            List<int> getBinary = new List<int>();

            while (decimalNum > 0)
            {
                getBinary.Add(decimalNum % 2);
                decimalNum /= 2;
            }

            getBinary.Reverse();

            return string.Join("", getBinary);
        }
    }
}
