using System;
using System.Collections.Generic;
using System.IO;
//Write a program that extracts from given XML file all the text without the tags

namespace TextWithoutTags
{
    class TextWithoutTags
    {
        static void Main(string[] args)
        {
            StreamReader read = new StreamReader(@"..\..\XMLtext.txt");
            StreamWriter write = new StreamWriter(@"..\..\extracted text.txt");
            string xml = read.ReadToEnd();
            bool betweenTags = false;
            char symbol;
            List<char> toPrint = new List<char>();

            for (int i = 0; i < xml.Length; i++)
            {
                symbol = xml[i];
                if (symbol == '>')
                {
                    betweenTags = true;
                }
                else if (symbol == '<' && betweenTags)
                {
                    betweenTags = false;
                    if (toPrint.Count > 0)
                    {
                        write.WriteLine(string.Join("", toPrint));
                        toPrint.Clear();
                    }
                }
                else if (betweenTags)
                {
                    toPrint.Add(symbol);
                }
            }
            read.Close();
            write.Close();
        }
    }
}
