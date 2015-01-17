using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWords
{
    class MagicWords
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> words = new List<string>();

            for (int i = 0; i < n; i++)
            {
                words.Add(Console.ReadLine());            
            }

            string buffer;
            int newPos = 0;
            for (int i = 0; i < n; i++)
            {
                buffer = words[i];
                newPos = buffer.Length % (n + 1);
                words.Insert(newPos, buffer);
                if (newPos<i)
                {
                    words.RemoveAt(i + 1);
                }
                else
                {
                    words.RemoveAt(i);
                }
            }

            //print
            int maxWordLength = 0;
            foreach (var word in words)
            {
                if (word.Length>maxWordLength)
                {
                    maxWordLength = word.Length;
                }
            }

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < maxWordLength; i++)
            {
                foreach (var word in words)
                {
                    if (i<word.Length)
                    {
                        result.Append(word[i]);
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
