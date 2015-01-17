using System;


namespace StringsWithAndWithoutQuotation
{
    class StringsWithAndWithoutQuotation
    {
        static void Main()
        {
                //Declare two string variables and assign them with following value: 
                //The "use" of quotations causes difficulties.
                //Do the above in two different ways: with and without using quoted strings.
            string quotedStrng = "The \"use\" of quotations causes difficulties.";
            string nonQuoted = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(quotedStrng);
            Console.WriteLine(nonQuoted);

        }
    }
}
