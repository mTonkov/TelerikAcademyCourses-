using System;
//Write a method that returns the last digit of given integer as an English word. 
//Examples: 512 -> "two", 1024 ->"four", 12309 -> "nine".
class LastDigitInEnglish
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter an integer number");
        int input = int.Parse(Console.ReadLine());

        GetLastDigitName(input);
    }

    static void GetLastDigitName(int number)
    {
        int digit = number % 10;
        Console.Write("Last digit of {0} is -> ", number);

        switch (digit)
        {
            case 0:
                Console.WriteLine("Zero");
                break;
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("Eight");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;

            default:
                Console.WriteLine("No such digit!");
                break;
        }
    }
}

