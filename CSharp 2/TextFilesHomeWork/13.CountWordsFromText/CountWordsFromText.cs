using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;


//Write a program that reads a list of words from a file words.txt and finds how many times each of the words is contained in another file test.txt. 
//The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order. 
//Handle all possible exceptions in your methods


namespace CountWordsFromText
{
    class CountWordsFromText
    {
        static void Main(string[] args)
        {
            string wordsPath = @"..\..\words.txt";
            string testPath = @"..\..\test.txt";
            string resultPath = @"..\..\result.txt";

            try
            {
                var words = GetWords(wordsPath);
                var collection = CountWords(words, testPath);
                WriteSorted(collection, resultPath);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static string[] GetWords(string path)
        {
            StreamReader readWords = new StreamReader(path);
            using (readWords)
            {
                string words = readWords.ReadToEnd();
                string[] wordsArr = words.Split(new char[] { '\r', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                return wordsArr;
            }
        }

        static Dictionary<string, int> CountWords(string[] words, string path)
        {
            StreamReader readTest = new StreamReader(path);
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            foreach (var word in words)
            {
                wordsCount.Add(word, 0);
            }
            using (readTest)
            {
                string testLine = readTest.ReadLine();

                while (testLine != null)                            // on each line in test.txt
                {                                                   //...
                    foreach (var word in words)                     //look for the given words in words.txt
                    {
                        int count = 0;
                        int index = testLine.IndexOf(word, 0);
                        while (index != -1)
                        {
                            count++;
                            index = testLine.IndexOf(word, index + 1);
                        }
                        wordsCount[word] += count;                  // count appearance of word from words.txt in test.txt
                    }
                    testLine = readTest.ReadLine();
                }
            }
            return wordsCount;
        }

        static void WriteSorted(Dictionary<string, int> countWords, string path)
        {
            StreamWriter write = new StreamWriter(path);

            var countWordsSorted = from entry in countWords orderby entry.Value descending select entry;

            using (write)
            {
                foreach (var set in countWordsSorted)
                {
                    write.WriteLine(set);
                }
            }
        }
    }
}
