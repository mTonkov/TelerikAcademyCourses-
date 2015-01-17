using System;
using System.Net;
//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. 
//Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block

namespace DownloadingFileFromWeb
{
    class DownloadingFileFromWeb
    {
        static void Main(string[] args)
        {
            string path = @"http://www.devbg.org/img/Logo-BASD.jpg";
            int fileNameStart = path.LastIndexOfAny(new char[] { '/', '\\' });
            string filename = path.Substring(fileNameStart+1);

            try
            {
                using (WebClient downloader = new WebClient())
                {
                    downloader.DownloadFile(path, filename);
                }
            }
            catch (FieldAccessException)
            {
                Console.WriteLine("File Cannot be accessed");
            }
            catch (HttpListenerException)
            {
                Console.WriteLine("File cannot be accessed");
            }
            catch (MissingFieldException)
            {
                Console.WriteLine("Sorry, You are trying to access a non-existing destination");
            }
            catch (UriFormatException)
            {
                Console.WriteLine("The path to the wanted file is invalid");
            }
        }
    }
}
