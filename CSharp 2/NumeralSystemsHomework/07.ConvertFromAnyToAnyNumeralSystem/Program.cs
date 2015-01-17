using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromAnyToAnyNumeralSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number to convert:");
            string number = Console.ReadLine();
            Console.WriteLine("Please enter the base of the numeric system in which your number is in:");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Which is the new numeric system for your number?");
            int d = int.Parse(Console.ReadLine());

            int toDec = SBaseToDecimal(number, s);
            DecimalToBaseD(toDec, d);

        }
        static void DecimalToBaseD(int decimalNum, int baseD)
        {
            List<string> getDBaseNumber = new List<string>();

            while (decimalNum > 0)
            {
                if (baseD > 10)
                {
                    getDBaseNumber.Add(ConvertDecimalToHexadecimal(decimalNum % baseD)); //if the numeric system is >10 and requires letters
                }
                else
                {
                    getDBaseNumber.Add((decimalNum % baseD).ToString());
                }

                decimalNum /= baseD;
            }
            getDBaseNumber.Reverse(); // convert the array to view the binary number in 32-bit Big-Endian representation            
            Console.WriteLine(string.Join("", getDBaseNumber));
        }
        static int SBaseToDecimal(string number, int baseS)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int digit = 0;
                if (baseS > 10)
                {
                    digit = ConvertHexadecimalToDecimal(number[number.Length - 1 - i].ToString());
                }
                else
                {
                    digit = int.Parse(number[number.Length - 1 - i].ToString());
                }
                
                int poweredBase = 1; //the base of the numeral system, powered by '0'
                if (i > 0)
                {//when we get the first digit(first one in the right), the base has power of "0" and the digit is multiplied by "1"
                    for (int j = 0; j < i; j++)//every next base hase the next power e.g. [ 1,2...binaryNumber.Length-1 ]
                    {
                        poweredBase *= baseS;
                    }
                }
                sum += (digit * poweredBase);
            }
            return sum;
        }
        static string ConvertDecimalToHexadecimal(int decimalNum)
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
            return string.Join("", hexadecimal);
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
        static int ConvertHexadecimalToDecimal(string hexadecimalNumber)
        {
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
            return sum;
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
