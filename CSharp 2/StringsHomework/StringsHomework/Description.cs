using System;
//Describe the strings in C#. What is typical for the string data type? Describe the most important methods of the String class

namespace StringsHomework
{
    class DescribeStrings
    {
        static void Main(string[] args)
        {
            //"string" can be associated with an array of characters. 
            //It is an immutable(the data kept in a variable of string cannot be change) and reference(the variable points to an object in the memory)

            //string.Empty;             sets an empty(not null) value to the variable
            //string variable = "";     just initializing a variable to get methods below:
            //variable.CompareTo();     the "variable" will be compared to another string and result {1} says "variable" is lexicografically smaller
                                                                                         //{-1} says the string in brackets is lexicografically smaller
                                                                                        //{0} means equality
            //variable.IndexOf();       gets an integer value for index(starting from 0) of the first occurrence of the character in brackets
            //variable.Length;          gets the number of characters in the string(starting from 1)
            //variable.Split();         returns a string[] of strings from "variable" separated by given conditions(characters) 
            //variable.Substring();     gets a substring from "variable" with a pointed starting position 
            //variable.ToCharArray();   converts the string to char[] and returns its reference
            //variable.ToLower();       all letters are converted to small letters
            //variable.ToUpper();       all letters are converted to CAPITAL letters
            //variable.Trim();          removes all blank(white) spaces before and after the string
            //variable.TrimEnd();       removes blank(white) spaces after the string
            //variable.TrimStart();     removes blank(white) spaces before the string
            

        }
    }
}
