using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToText
{
    class NumbersToText
    {
        static void Main(string[] args)
        { /** Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
	0 - "Zero"
	273 - "Two hundred seventy three"
	400 - "Four hundred"
	501 - "Five hundred and one"
	711 - "Seven hundred and eleven"
*/

            Console.WriteLine("Enter a number in the interval 0-999");
            string input = Console.ReadLine();

            int ones = 0;
            int teens = 0;
            int tens = 0;
            int hundreds = 0;

            bool isOnes = false;
            bool isTeens = false;
            bool isTens = false;
            bool isHundreds = false;

            if (input.Length == 1)
            {
                ones = int.Parse(input);
                isOnes = true;
            }

            if (input.Length == 2)
            {
                int check = int.Parse(input[0].ToString());
                if (check == 0)
                {
                    ones = int.Parse(input);
                    isOnes = true;
                }
                else if (check == 1)
                {
                    teens = int.Parse(input);
                    isTeens = true;
                }
                else if (check > 1)
                {
                    check = int.Parse(input[1].ToString());
                    if (check == 0)
                    {
                        tens = int.Parse(input[0].ToString());
                        isTens = true;
                    }
                    else if (check > 0)
                    {
                        tens = int.Parse(input[0].ToString());
                        isTens = true;
                        ones = int.Parse(input[1].ToString());
                        isOnes = true;
                    }
                }
            }

            if (input.Length == 3)
            {
                int check = int.Parse(input[0].ToString());
                if (check > 0)
                {
                    hundreds = check;
                    isHundreds = true;
                    check = int.Parse(input[1].ToString());
                    if (check == 0)
                    {
                        check = int.Parse(input[2].ToString());
                        if (check > 0)
                        {
                            ones = int.Parse(input[2].ToString());
                            isOnes = true;
                        }
                    }
                    else if (check == 1)
                    {
                        teens = (int.Parse(input)) - (hundreds * 100);
                        isTeens = true;
                    }
                    else
                    {
                        tens = int.Parse(input[1].ToString());
                        isTens = true;
                        check = int.Parse(input[2].ToString());
                        if (check > 0)
                        {
                            ones = check = int.Parse(input[2].ToString());
                            isOnes = true;
                        }
                    }
                }
                else
                {
                    check = int.Parse(input[1].ToString());
                    if (check == 0)
                    {
                        ones = int.Parse(input);//int.Parse(input[2].ToString());
                        isOnes = true;
                    }
                    else if (check == 1)
                    {
                        teens = int.Parse(input);
                        isTeens = true;
                    }
                    else
                    {
                        check = int.Parse(input[2].ToString());
                        if (check == 0)
                        {
                            tens = int.Parse(input[1].ToString());
                            isTens = true;
                        }
                        else
                        {
                            tens = int.Parse(input[1].ToString());
                            isTens = true;
                            ones = int.Parse(input[2].ToString());
                            isOnes = true;
                        }
                    }
                }

            }

            if (isHundreds)
            {
                switch (hundreds)
                {
                    case 1:
                        Console.Write("One hundred and  ");
                        break;
                    case 2:
                        Console.Write("Two hundred and ");
                        break;
                    case 3:
                        Console.Write("Three hundred and ");
                        break;
                    case 4:
                        Console.Write("Four hundred and ");
                        break;
                    case 5:
                        Console.Write("Five hundred and ");
                        break;
                    case 6:
                        Console.Write("Six hundred and ");
                        break;
                    case 7:
                        Console.Write("Seven hundred and ");
                        break;
                    case 8:
                        Console.Write("Eight hundred and ");
                        break;
                    case 9:
                        Console.Write("Nine hundred and ");
                        break;
                    default:
                        break;
                }
            }
            if (isTeens)
            {
                switch (teens)
                {
                    case 10:
                        Console.Write("Ten");
                        break;
                    case 11:
                        Console.Write("Eleven");
                        break;
                    case 12:
                        Console.Write("Twelve");
                        break;
                    case 13:
                        Console.Write("Thirteen");
                        break;
                    case 14:
                        Console.Write("Forteen");
                        break;
                    case 15:
                        Console.Write("Fifteen");
                        break;
                    case 16:
                        Console.Write("Sixteen");
                        break;
                    case 17:
                        Console.Write("Seventeen");
                        break;
                    case 18:
                        Console.Write("Eighteen");
                        break;
                    case 19:
                        Console.Write("Nineteen");
                        break;
                    default:
                        Console.WriteLine("No such number or out of range");
                        break;
                }
            }

            if (isTens)
            {
                switch (tens)
                {
                    case 2:
                        Console.Write("Twenty ");
                        break;
                    case 3:
                        Console.Write("Thirty ");
                        break;
                    case 4:
                        Console.Write("Forty ");
                        break;
                    case 5:
                        Console.Write("Fifty ");
                        break;
                    case 6:
                        Console.Write("Sixty ");
                        break;
                    case 7:
                        Console.Write("Seventy ");
                        break;
                    case 8:
                        Console.Write("Eighty ");
                        break;
                    case 9:
                        Console.Write("Ninety ");
                        break;
                    default:
                        Console.WriteLine("No such number or out of range");
                        break;
                }
            }

            if (isOnes)
            {
                switch (ones)
                {
                    case 0:
                        Console.Write("Zero ");
                        break;
                    case 1:
                        Console.Write("One ");
                        break;
                    case 2:
                        Console.Write("Two ");
                        break;
                    case 3:
                        Console.Write("Three ");
                        break;
                    case 4:
                        Console.Write("Four ");
                        break;
                    case 5:
                        Console.Write("Five ");
                        break;
                    case 6:
                        Console.Write("Six ");
                        break;
                    case 7:
                        Console.Write("Seven ");
                        break;
                    case 8:
                        Console.Write("Eight ");
                        break;
                    case 9:
                        Console.Write("Nine ");
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine();
        }
    }
}
