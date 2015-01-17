using System;
using System.IO;
//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

namespace ReadAndSortStrings
{
    class ReadAndSortStrings
    {
        static void Main(string[] args)
        {
            StreamReader read = new StreamReader(@"..\..\names.txt");

            string[] names = read.ReadToEnd().Split(new char[] {'\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
            read.Close();

            Array.Sort(names);

            StreamWriter write = new StreamWriter(@"..\..\sorted Names.txt");
            using (write)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    write.WriteLine(names[i]);
                }
            }
        }
    }
}
