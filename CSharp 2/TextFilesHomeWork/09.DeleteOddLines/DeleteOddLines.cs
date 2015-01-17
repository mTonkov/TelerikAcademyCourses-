using System;
using System.IO;
//Write a program that deletes from given text file all odd lines. The result should be in the same file.

namespace DeleteOddLines
{
    class DeleteOddLines
    {
        static void Main(string[] args)
        {
            StreamReader read = new StreamReader(@"..\..\lines.txt");
            int lineNumber = 0;

            using (read)
            {
                string line = read.ReadLine();
                StreamWriter write = new StreamWriter(@"..\..\temp.txt");
                using (write)
                {
                    while (line != null)
                    {
                        if (lineNumber%2==0)
                        {
                            write.WriteLine(line);
                        }
                        line = read.ReadLine();
                        lineNumber++;
                    }
                }
            }
            File.Delete(@"..\..\lines.txt");
            File.Move(@"..\..\temp.txt", @"..\..\lines.txt");
        }
    }
}
