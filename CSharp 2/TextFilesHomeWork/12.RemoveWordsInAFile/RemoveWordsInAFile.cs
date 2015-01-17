using System;
using System.IO;
using System.Text.RegularExpressions;
//Write a program that removes from a text file all words listed in given another text file. 
//Handle all possible exceptions in your methods

namespace RemoveWordsInAFile
{
    class RemoveWordsInAFile
    {
        static void Main(string[] args)
        {
            string textDestination = @"..\..\text to modify.txt";
            string wordsDestination = @"..\..\words to remove.txt";

            try
            {
                string[] wordsToDelete = GetWords(wordsDestination);
                DeleteWords(textDestination, wordsToDelete);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid File destination");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File Not Found");
            }
            catch  (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static string[] GetWords(string path)
        {
            StreamReader readWord = new StreamReader(path);
            using (readWord)
            {
                string words = readWord.ReadToEnd();
                string[] wordsArr = words.Split(new char[] { '\r', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                return wordsArr;
            }
        }

        static void DeleteWords(string textReadPath, string[] words)
        {
            StreamReader readText = new StreamReader(textReadPath);
            StreamWriter write = new StreamWriter(@"..\..\temp.txt");
            string line = readText.ReadLine();
            while (line != null)
            {
                for (int i = 0; i < words.Length; i++) // loops {number of words} times
                {

                    Regex deleteWord = new Regex(" " + words[i] + " "); // takes the word to remove + blank spaces before and after
                    line = deleteWord.Replace(line, " ");
                }
                write.WriteLine(line);
                line = readText.ReadLine();
            }
            readText.Close();
            write.Close();

            File.Delete(@"..\..\text to modify.txt");
            File.Move(@"..\..\temp.txt", @"..\..\text to modify.txt");
        }
    }
}
