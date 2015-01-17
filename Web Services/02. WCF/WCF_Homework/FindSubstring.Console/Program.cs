using FindSubstring.ConsoleClient.FindSubstringsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSubstring.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            FindSubstringClient client = new FindSubstringClient();

            var substr = "tiho";
            var fullStr = "stihotvorenie";
            var count = client.SubstringCount(substr, fullStr);

            Console.WriteLine(count);
        }
    }
}
