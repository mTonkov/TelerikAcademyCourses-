namespace HCPC_NamingIdentifiers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Printer
    {
        private const int MAX_COUNT = 6;

        public static void Main()
        {
            Printer.BooleanPrinter printer = new Printer.BooleanPrinter();

            printer.PrintBooleanValue(true);
        }

        public class BooleanPrinter
        {
            public void PrintBooleanValue(bool booleanVariable)
            {
                string booleanValueAsString = booleanVariable.ToString();

                Console.WriteLine(booleanValueAsString);
            }
        }
    }
}