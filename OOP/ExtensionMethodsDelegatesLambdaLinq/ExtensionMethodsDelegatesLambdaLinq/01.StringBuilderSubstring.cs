using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDelegatesLambdaLinq
{
    /*Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and 
     * has the same functionality as Substring in the class String.*/

    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder text, int index, int length)
        {
            var tempStrBuilder = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                tempStrBuilder.Append(text[index]);
                index++;
            }
            return tempStrBuilder;
        }

    }
}
