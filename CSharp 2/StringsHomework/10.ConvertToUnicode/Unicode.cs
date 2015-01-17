using System;
using System.Text;
/*Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 
 * Sample input:
Hi!
		Expected output:
\u0048\u0069\u0021
*/

namespace ConvertToUnicode
{
    class Unicode
    {
        static void Main(string[] args)
        {
            string input = "Hi!";
            StringBuilder uni = new StringBuilder();

            foreach (var ch in input)
            {
                uni.Append("\\u");
                uni.Append(((int)ch).ToString("X4"));
            }

            Console.WriteLine(uni);
        }
    }
}
