using System;
using System.Collections.Generic;
//Write a program to convert decimal numbers to their hexadecimal representation

namespace DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            int decimalNum = 86;
            List<int> getHex = new List<int>();

            Console.WriteLine("The number {0} in hexadecimal numeral system is:", decimalNum);//this is printed, before "decimalNum" is modified

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

            Array.Reverse(hexadecimal); // make the hexadecimal number in a correct order
            Console.WriteLine(string.Join("",hexadecimal));

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
