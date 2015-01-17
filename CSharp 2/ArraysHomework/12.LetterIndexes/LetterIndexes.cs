using System;
using System.Collections.Generic;
//Write a program that creates an array containing all letters from the alphabet (A-Z). 
//Read a word from the console and print the index of each of its letters in the array

    class LetterIndexes
    {
        static void Main(string[] args)
        {
            List<char> alphabet = new List<char>();

            for (int i = 97; i <= 122; i++)
            {
                alphabet.Add((char) i);
            }

            char[] alphabetCapitals = new char[26];
            for (int i = 0; i < 26; i++)
            {
                alphabetCapitals[i] = (char)(i + 65);
            }

            Console.WriteLine("Please enter a word");
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (word[i] == alphabet[j] || word[i] == alphabetCapitals[j])
                    {
                        Console.WriteLine(@"The letter '{0}' from ""{1}"" has an array index of: {2}", word[i], word, j );
                    } // j+1 will give the position in the alphabet
                }
            }
        }
    }
