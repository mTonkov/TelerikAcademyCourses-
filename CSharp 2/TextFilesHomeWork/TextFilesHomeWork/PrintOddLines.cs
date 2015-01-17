using System;
using System.IO;
//Write a program that reads a text file and prints on the console its odd lines.


namespace PrintOddLines
{
    class PrintOddLines
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\lines.txt");

            using (reader)
            {
                int lineCount = 0;
                string lines = reader.ReadLine();

                while (lines != null)
                {
                    if (lineCount % 2 != 0)
                    {
                        Console.WriteLine("Odd line: {0}", lines);
                    }
                    lines = reader.ReadLine();
                    lineCount++;
                }
            }
        }
    }
}
