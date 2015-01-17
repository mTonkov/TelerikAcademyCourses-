using System;
using System.Text;
//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. 
//The tags cannot be nested
/*Example:
We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
		The expected result:
 * We are living in a YELLOW SUBMARINE. We don't have ANYTHING else
*/

namespace ConvertSpecifiedTextToUpper
{
    class TextToUpper
    {
        static void Main(string[] args)
        {
            string str = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            StringBuilder text = new StringBuilder(str);
            int startSubstring = 0;
            int endSubstring = 0;
            string subStr;
            string newSubStr;
            string starter = "<upcase>";
            string ender = "</upcase>";

            while (startSubstring >= 0 && startSubstring<text.Length)
            {
                startSubstring = str.IndexOf(starter, startSubstring) + starter.Length; // goes to the index where ToUpper has to start
                endSubstring = str.IndexOf(ender, endSubstring);

                newSubStr = str.Substring(startSubstring, endSubstring - startSubstring); //gets the wanted substring and applies "ToUpper"
                subStr = String.Concat(starter, newSubStr, ender);
                newSubStr = newSubStr.ToUpper();

                text = text.Replace(subStr, newSubStr);

                startSubstring = endSubstring + ender.Length; // gets the next indexes where searching should start on next iteration
                endSubstring = startSubstring;
            }

            Console.WriteLine("Changed text: \n{0}", text);
        }
    }
}
