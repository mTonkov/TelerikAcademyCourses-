using System;
//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
//Print the result string into the console

namespace TwentyCharactersLongString
{
    class TwentyCharacters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string with max length of 20 characters");
            string input = Console.ReadLine();

            if (input.Length>20)
            {
                Console.WriteLine("Input is longer than 20 characters!");
            }
            else
            {
                Console.WriteLine(input.PadRight(20, '*'));
            }
        }
    }
}
