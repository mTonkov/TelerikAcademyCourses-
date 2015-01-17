using System;
using System.IO;
using System.Text.RegularExpressions;
//Write a program that deletes from a text file all words that start with the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.


namespace DeleteWordsWithPrefix
{
    class DeleteWordsWithPrefix
    {
        static void Main(string[] args)
        {
            StreamReader read = new StreamReader(@"..\..\Test words.txt");
            string line = read.ReadLine();

            StreamWriter write = new StreamWriter(@"..\..\deleted test words.txt");

            Regex rgx = new Regex(@"\b(test)\w");

            while (line != null)
            {
                write.WriteLine(rgx.Replace(line, " "));
                line = read.ReadLine();
            }
            read.Close();
            write.Close();
        }
    }
}
