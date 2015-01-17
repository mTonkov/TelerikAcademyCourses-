using System;
using System.IO;
//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
//Ensure it will work with large files (e.g. 100 MB)

namespace ExchangeStartWithFinish
{
    class ExchangeStartWithFinish
    {
        static void Main(string[] args)
        {
            StreamReader read = new StreamReader(@"..\..\exchange.txt");

            string start = "start";
            string finish = "finish";
            string readLine = read.ReadLine();
            using (read)
            {
                StreamWriter write = new StreamWriter(@"..\..\temp.txt");
                while (readLine != null)
                {
                    string newLine = readLine.Replace(start, finish);
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
