using System;
using System.Text.RegularExpressions;
/*Write a program that parses an URL address given in the format:

		and extracts from it the [protocol], [server] and [resource] elements. 
 *       For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
		[protocol] = "http"
		[server] = "www.devbg.org"
		[resource] = "/forum/index.php"
*/

namespace ExtractURL
{
    class ExtractURL
    {
        static void Main(string[] args)
        {
            string url = @"http://www.devbg.org/forum/index.php";

            string protocol;
            string psDivider = "://";
            int psDivideIndex;

            string server;
            string resource;
            string srDivider = "/";
            int srDivideIndex;

            psDivideIndex = url.IndexOf(psDivider);
            protocol = url.Substring(0, psDivideIndex);
            psDivideIndex += 3;
            srDivideIndex = url.IndexOf(srDivider, psDivideIndex);
            server = url.Substring(psDivideIndex, srDivideIndex - psDivideIndex);
            srDivideIndex++;
            resource = url.Substring(srDivideIndex);

            Console.WriteLine("protocol: {0,25}", protocol);
            Console.WriteLine("server:{0,25}",server);
            Console.WriteLine("resource:{0,25}",resource);
        }
    }
}
