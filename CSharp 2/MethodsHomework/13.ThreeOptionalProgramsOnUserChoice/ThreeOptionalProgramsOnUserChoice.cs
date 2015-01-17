using System;
using System.Collections.Generic;
/*Write a program that can solve these tasks:
    Reverses the digits of a number
    Calculates the average of a sequence of integers
    Solves a linear equation a * x + b = 0
Create appropriate methods. Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
    The decimal number should be non-negative
    The sequence should not be empty
    'a' should not be equal to 0 */

namespace ThreeOptionalProgramsOnUserChoice
{
    class ThreeOptionalProgramsOnUserChoice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To reverse digits of a number, press '1'");
            Console.WriteLine("To calculate the average of a sequence of integers, press '2'");
            Console.WriteLine("To solve a linear equation of type {a * x + b = 0}, press '3'");
            string input = Console.ReadLine();

            if (input == "1")
            {
                while (true)
                {
                    Console.WriteLine("Enter a number to reverse");
                    decimal n = decimal.Parse(Console.ReadLine());
                    if (n<0)
                    {
                        Console.WriteLine("The decimal number should be non-negative!");
                    }
                    else
                    {
                        ReverseNumber(n);
                        break;
                    }
                }                
            }
            else if (input == "2")
            {
                while (true)
                {
                    Console.WriteLine("Enter number of elements in the sequence");
                    int n = int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.WriteLine("Invalid length of sequence!");
                    }
                    else
                    {
                        CalculateAverage(n);
                        break;
                    }
                }
            }
            else if (input == "3")
            {
                while (true)
                {
                    Console.WriteLine("Enter value for 'a'");
                    int a = int.Parse(Console.ReadLine());
                    if (a == 0)
                    {
                        Console.WriteLine("'a' cannot be '0'. Division by '0' is not allowed!");
                    }
                    else
                    {
                        Console.WriteLine("Enter value for 'b'");
                        int b = int.Parse(Console.ReadLine());
                        SolveEquation(a,b);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect choice!");
            }

        }

        static void ReverseNumber(decimal number)// Code is the same used in task 7.
        {
            string input = number.ToString();
            List<char> decimalNum = new List<char>();
            for (int i = 0; i < input.Length; i++) 
            {
                decimalNum.Add(input[i]);
            }
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

        static void Reverse(List<char> number, char floatingPoint)// Code is the same used in task 7.
        {// method overload with floating point
            int floatingPointIndex = number.IndexOf(floatingPoint); //finds the index of the floating point
            number.RemoveAt(floatingPointIndex);
            number.Reverse();
            number.Insert(floatingPointIndex, floatingPoint); // place the floating point on its place in the reversed number
            Console.WriteLine(string.Join("", number));
        }

        static void Reverse(List<char> number)// Code is the same used in task 7.
        {// method overload without floating point
            number.Reverse();
            Console.WriteLine(string.Join("", number));
        }

        static void CalculateAverage(int number)
        {
            int[] numbers = new int[number];
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Please insert integer {0} = ", i);
                numbers[i - 1] = int.Parse(Console.ReadLine());
                sum += numbers[i - 1];
            }
            Console.WriteLine("The average of the sequence you just entered is: {0}", sum/number);
        }

        static void SolveEquation(int a, int b)
        {
            int x = -b / a;
            Console.WriteLine("x= {0}", x);
        }
    }
}
