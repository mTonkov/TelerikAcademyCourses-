using System;
using System.Collections.Generic;
//Write a method that reverses the digits of given decimal number. Example: 256 -> 652

namespace ReverseDigits
{
    class ReverseDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a decimal number");
            string input = Console.ReadLine();
            List<char> decimalNum = new List<char>();
            // the reason for using List<char> is the easier work with characters(check for symbol, insert and remove)

            for (int i = 0; i < input.Length; i++) //converts digits and symbols in the number from string to List<char>
            {
                decimalNum.Add(input[i]);
            }

            //as the number is deciaml, it may contain floating point(',' or '.'), which should keep their position
            if (decimalNum.Contains(','))
            {
                Reverse(decimalNum, ',');
            }
            else if (decimalNum.Contains('.'))
            {
                Reverse(decimalNum, '.');
            }
            else
            {
                Reverse(decimalNum);
            }
        }

        static void Reverse(List<char> number, char floatingPoint)// method overload with floating point
        {
            int floatingPointIndex = number.IndexOf(floatingPoint); //finds the index of the floating point
            number.RemoveAt(floatingPointIndex);
            number.Reverse();
            number.Insert(floatingPointIndex, floatingPoint); // place the floating point on its place in the reversed number
            Console.WriteLine(string.Join("", number));
        }

        static void Reverse(List<char> number)// method overload without floating point
        {
            number.Reverse();
            Console.WriteLine(string.Join("", number));
        }
    }
}
