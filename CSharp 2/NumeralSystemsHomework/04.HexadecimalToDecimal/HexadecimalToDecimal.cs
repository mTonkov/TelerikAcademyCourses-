using System;
using System.Collections.Generic;
//Write a program to convert hexadecimal numbers to their decimal representation.


namespace HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main(string[] args)
        {
            string hexadecimalNumber = "4AFE"; // output: 19,198
            int sum = 0;

            for (int i = 0; i < hexadecimalNumber.Length; i++)
            {
                string hexDigit = hexadecimalNumber[hexadecimalNumber.Length - 1 - i].ToString();
                // gets the elements of the hexadecimal number starting from the last(in this case "E")

                int digit = 0;
                if (int.TryParse(hexDigit, out digit))
                {
                }
                else
                {
                    digit = GetDecimalOfHexSymbol(hexDigit);
                }

                int poweredBase = 1;
                if (i > 0)
                {
                    for (int j = 0; j < i; j++)
                    {
                        poweredBase *= 16;
                    }
                }
                sum += (digit * poweredBase);
            }

            Console.WriteLine("The decimal representation of {0} is: {1}", hexadecimalNumber, sum);
        }
        static int GetDecimalOfHexSymbol(string number)
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

    }
}
