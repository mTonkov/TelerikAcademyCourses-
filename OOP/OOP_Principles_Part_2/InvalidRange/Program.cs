using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidRange
{
    class Program
    {
        static void Main(string[] args)
        {
            //test with integers
            int minInt = 1;
            int maxInt = 100;

            Console.WriteLine("Insert a number between {0}..{1}", minInt, maxInt);
            int input = int.Parse(Console.ReadLine());

            if (input < minInt || input > maxInt)
            {
                throw new InvalidRangeException<int>("Your input should be in the range specified", minInt, maxInt);
            }


            //test with dates
            Console.WriteLine();
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);

            Console.WriteLine("Insert a date between {0}..{1}", startDate.Date, endDate.Date);
            CultureInfo timeFormat = CultureInfo.InvariantCulture;

            DateTime inputDate = DateTime.Parse(Console.ReadLine(), timeFormat);

            if (input < minInt || input > maxInt)
            {
                throw new InvalidRangeException<int>("Your input should be in the range specified range", minInt, maxInt);
            }
        }
    }
}
