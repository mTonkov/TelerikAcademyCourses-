using System;
//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample" -> "elpmas"

namespace RevereseString
{
    class Reverse
    {
        static void Main(string[] args)
        {
            string str = "sample";
            string rev=null;
            for (int i = str.Length-1; i >= 0; i--)
			{
			    rev += str[i];
			}
            Console.WriteLine("Example:{0} -> {1}",str, rev);
        }
    }
}
