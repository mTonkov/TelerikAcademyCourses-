using System;
//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
//Write a program to test this method

class PrintName
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string input = Console.ReadLine();

        if (IsInputValid(input))
        {
            PrintUserName(input);
        }
        else
        {
            Console.WriteLine("Invalid name!");
        }
    }

    static void PrintUserName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }

    static bool IsInputValid(string input)
    {
        bool check = true;
        foreach (var character in input)
        {
            check = char.IsLetter(character); //check for characters different from letters
            if (!check)
            //when a non-letter character is found, execution of the method is stopped and it is assigned "false"
            {
                return check; //returns "false" and stops method
            }
        }
        return check; // returns "true" after all characters are checked and they are all letters
    }
}
