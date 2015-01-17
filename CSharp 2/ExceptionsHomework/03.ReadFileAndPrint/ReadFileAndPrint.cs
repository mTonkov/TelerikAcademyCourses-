using System;
using System.IO;
//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. 
//Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all possible exceptions and print user-friendly error messages

namespace ReadFileAndPrint
{
    class ReadFileAndPrint
    {
        static void Main(string[] args)
        {
            try
            {
                string file = File.ReadAllText(@"C:\WINDOWS\win.ini");
                Console.WriteLine(file);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The specified file was not found in the specified directory");
            }
            catch (FileLoadException)
            {
                Console.WriteLine("The specified file cannot be loaded");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("The file you are trying to read and write on the console is too big");
            }
        }
    }
}
