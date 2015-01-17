using System;
using System.IO;
//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

namespace CompareStringLines
{
    class CompareStringLines
    {
        static void Main(string[] args)
        {
            StreamReader read = new StreamReader(@"..\..\lines.txt");
            StreamReader readShuffled = new StreamReader(@"..\..\linesShuffled.txt");

            string lines = read.ReadLine();
            string shuffledLines = readShuffled.ReadLine();
            int sameLines = 0;
            int differentLines = 0;
            
            while (lines != null)
            {
                if (lines.Equals(shuffledLines))
                {
                    sameLines++;
                }
                else
                {
                    differentLines++;
                }
                lines = read.ReadLine();
                shuffledLines = readShuffled.ReadLine();
            }
            read.Close();
            readShuffled.Close();

            Console.WriteLine("Same lines: {0}", sameLines);
            Console.WriteLine("Different lines: {0}", differentLines);
        }
    }
}
