using System;
//Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

class GetMaxNumber
{
    static void Main(string[] args)
    {   // first part of the program with 2(two) numbers
        Console.WriteLine("Please enter 2 integers to compare and press \"Enter\" after each input");
        int firstInput = int.Parse(Console.ReadLine());
        int secondInput = int.Parse(Console.ReadLine());

        PrintResult(GetMax(firstInput, secondInput));

        // second part of the program with 3(three) numbers
        Console.WriteLine("Please enter 3 integers to compare and press \"Enter\" after each input");
        firstInput = int.Parse(Console.ReadLine());
        secondInput = int.Parse(Console.ReadLine());
        int thirdInput = int.Parse(Console.ReadLine());

        int biggerFirstSecond = GetMax(firstInput, secondInput);//finds the bigger from the first two numbers
        PrintResult(GetMax(biggerFirstSecond, thirdInput));
        //finds and prints the bigger between the third and the bigger from the first and second numbers

    }

    static int GetMax(int firstNum, int secondNum)
    {
        int max = firstNum;
        if (secondNum > firstNum)
        {
            max = secondNum;
        }

        return max;
    }

    static void PrintResult(int result)
    {
        Console.WriteLine("The bigger number is {0}", result);
        Console.WriteLine();
        Console.WriteLine();
    }
}

