using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FindSubstrings.Library
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class FindSubstring : IFindSubstring
    {
        public int SubstringCount(string substring, string fullString)
        {
            int count = 0;

            int foundSubstringIndex = -1;
            do
            {
                foundSubstringIndex = fullString.IndexOf(substring, foundSubstringIndex + 1);
                if (foundSubstringIndex >= 0)
                {
                    count++;
                }
            } while (foundSubstringIndex >= 0);

            return count;
        }
    }
}
