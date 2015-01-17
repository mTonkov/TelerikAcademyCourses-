using System;
using System.IO;
//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.

namespace LinesWithNumbersIntoNewFile
{
    class LinesWithNumbersIntoNewFile
    {
        static void Main(string[] args)
        {
            int lineNumber = 0;
            StreamWriter writeNew = new StreamWriter(@"..\..\result.txt");

            using (writeNew)
            {
                StreamReader readFile = new StreamReader(@"..\..\lines.txt");
                using (readFile)
                {
                    string line = readFile.ReadLine();

                    while (line != null)
                    {
                        writeNew.WriteLine("{0}: \t{1}", lineNumber, line);
                        line = readFile.ReadLine();
                        lineNumber++;
                    }
                }
            }
        }
    }
}
