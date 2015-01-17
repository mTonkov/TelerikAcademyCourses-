using System;
using System.Text;
using System.Threading.Tasks;
/*Write a program that extracts from a given text all sentences containing given word.
		Example: The word is "in". The text is:
We are living in a yellow submarine. We don't have anything else. 
 * Inside the submarine is very tight. 
 * So we are drinking all the day. 
 * We will move out of it in 5 days.
		The expected result is:
We are living in a yellow submarine.
We will move out of it in 5 days
		Consider that the sentences are separated by "." and the words – by non-letter symbols*/

namespace ExtractSentences
{
    class Sentences
    {
        static void Main(string[] args)
        {
            string sentences = @"We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string currentSentence = String.Empty;
            StringBuilder extracted = new StringBuilder();

            int start = 0;
            int end = 0;

            while (start<sentences.Length && end>=0)
            {
                end = sentences.IndexOf('.', start);
                currentSentence = sentences.Substring(start, (end - start)+1);
                if (currentSentence.Contains(" in "))
                {
                    extracted.AppendLine(currentSentence);
                }

                start = end+1;
            }

            Console.WriteLine("Sentences containing \"in\" : \n {0}", extracted);
        }
    }
}
