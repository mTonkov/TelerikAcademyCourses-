using System;
using System.IO;
using System.Text.RegularExpressions;
//Modify the solution of the previous problem to replace only whole words (not substrings).


namespace Task07WithWholeWords
{
    class Task07WithWholeWords
    {
        static void Main(string[] args)
        {
            StreamReader read = new StreamReader(@"..\..\exchange.txt");

            string readLine = read.ReadLine();
            using (read)
            {
                StreamWriter write = new StreamWriter(@"..\..\temp.txt");
                string pattern = @"\b(start)\b";
                Regex rgx = new Regex(pattern);

                while (readLine != null)
                {
                    string newLine = rgx.Replace(readLine, "finish");
                    write.WriteLine(newLine);
                    readLine = read.ReadLine();
                }
                write.Close();
            }
            File.Delete(@"..\..\exchange.txt");
            File.Move(@"..\..\temp.txt", @"..\..\exchange.txt");
        }
    }
}
