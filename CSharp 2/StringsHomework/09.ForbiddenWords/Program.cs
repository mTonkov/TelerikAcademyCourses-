﻿using System;
using System.Text;
/*We are given a string containing a list of forbidden words and a text containing some of these words. Write a program that replaces the forbidden words with asterisks. Example:
Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
		Words: "PHP, CLR, Microsoft"
		The expected result:
 * ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
*/

namespace ForbiddenWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            StringBuilder newText = new StringBuilder(text);

            string[] words = new string[] { "PHP", "CLR", "Microsoft" };

            for (int i = 0; i < words.Length; i++)
            {
                string asterisks = new string('*',words[i].Length);
                newText.Replace(words[i], asterisks);
            }

            Console.WriteLine("Changed text: \n {0}", newText);
        }
    }
}
