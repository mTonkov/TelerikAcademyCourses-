using System;
/*Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
		Example: The target substring is "in". The text is as follows:
We are living in an yellow submarine. We don't have anything else. 
 * Inside the submarine is very tight. 
 * So we are drinking all the day. 
 * We will move out of it in 5 days.
	The result is: 9.
*/

namespace CountSubstring
{
    class Substring
    {
        static void Main(string[] args)
        {
            string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string checkFor = "in";
            int count = 0;
            int index = 0;

            text = text.ToLower();
            checkFor = checkFor.ToLower();
            while (true)
            {
                index = text.IndexOf(checkFor, index);
                if (index >= 0)
                {
                    index = index + 1;
                    count++;
                }
                else
                {
                    break;
                }
            }

            if (count > 0)
            {
                Console.WriteLine("The searched substring \"{0}\" is contained {1} times", checkFor, count);
            }
            else
            {
                Console.WriteLine("There is no such substring in the text");
            }

        }
    }
}
