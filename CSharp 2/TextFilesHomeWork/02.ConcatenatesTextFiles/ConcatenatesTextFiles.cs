using System;
using System.IO;
//Write a program that concatenates two text files into another text file

namespace ConcatenatesTextFiles
{
    class ConcatenatesTextFiles
    {
        static void Main(string[] args)
        {
            StreamWriter write = new StreamWriter(@"..\..\congrat.txt");
            using (write)
            {
                StreamReader reader = new StreamReader(@"..\..\Hello.txt");
                using (reader)
                {
                    string hello = reader.ReadToEnd();
                    write.Write(hello);
                }

                reader = new StreamReader(@"..\..\CSharp.txt");
                using (reader)
                {
                    string cSharp = reader.ReadToEnd();
                    write.Write(cSharp);
                }                                
            }

            StreamReader read = new StreamReader(@"..\..\congrat.txt");
            string print = read.ReadLine();
            while (print != null)
            {
                Console.WriteLine(print);
                print = read.ReadLine();
            }
        }
    }
}
