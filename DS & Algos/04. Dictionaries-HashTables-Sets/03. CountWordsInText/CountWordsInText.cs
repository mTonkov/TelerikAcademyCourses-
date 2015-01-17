using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CountWordsInText
{/*03. Write a program that counts how many times each word from given text file words.txt appears in it. The character casing differences should be ignored. The result words should be ordered by their number of occurrences in the text. Example:
  
    This is the TEXT. Text, text, text – THIS TEXT! Is this the text?

	is  2
	the  2
	this  3
	text  6
*/
    class CountWordsInText
    {
        static void Main()
        {
            string text = "This is the TEXT. Text, text, text – THIS TEXT! Is this the text?";
            string[] filteredText = text.Split(new char[] { ' ', '–', '!', '?', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            var wordsCounter = new Dictionary<string, int>();

            for (int i = 0; i < filteredText.Length; i++)
            {
                string currentItem = filteredText[i].ToLowerInvariant();
                if (!wordsCounter.ContainsKey(currentItem))
                {
                    wordsCounter[currentItem] = 0;
                }

                wordsCounter[currentItem]++;
            }

            var sorted = (from pair in wordsCounter
                          orderby pair.Value
                          select pair);

            foreach (var pair in sorted)
            {
                Console.WriteLine("{0} -> {1} time(s)", pair.Key, pair.Value);
            }
        }
    }
}
