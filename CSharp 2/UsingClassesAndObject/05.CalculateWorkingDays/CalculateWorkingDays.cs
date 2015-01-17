using System;
using System.Collections.Generic;
//Write a method that calculates the number of workdays between today and given date, passed as parameter. 
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.


namespace CalculateWorkingDays
{
    class CalculateWorkingDays
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            Console.WriteLine("Please enter the end date in the following format: yyyy/mm/dd");
            string[] input = Console.ReadLine().Split('/');
            int yyyy = int.Parse(input[0]);
            int mm = int.Parse(input[1]);
            int dd = int.Parse(input[2]);

            DateTime givenDate = new DateTime(yyyy, mm, dd);
            DateTime[] holidays =   { new DateTime(2014, 01, 01), 
                                    new DateTime(2014, 01, 06),
                                    new DateTime(2014, 01, 07),
                                    new DateTime(2014, 01, 15),
                                    new DateTime(2014, 01, 20),
                                    new DateTime(2014, 02, 05),
                                    new DateTime(2014, 02, 11),
                                    new DateTime(2014, 02, 16)};

            if (today < givenDate)
            {
                WorkDays(today, givenDate, holidays);
            }
            else
            {
                WorkDays(givenDate, today, holidays);
            }           
        }

        static void WorkDays(DateTime start, DateTime end, DateTime[] holidays)
        {
            int workDays = 0;
            for (DateTime i = start; i <= end; i=i.AddDays(1))
            {
                if (i.DayOfWeek != DayOfWeek.Sunday && i.DayOfWeek != DayOfWeek.Saturday)
                {
                    bool isHoliday=false;
                    for (int j = 0; j < holidays.Length; j++)
                    {
                        if (i == holidays[j])
                        {
                            isHoliday = true;
                            break;
                        }
                    }

                    if (!isHoliday)
                    {
                        workDays++;
                    }
                }
            }
            Console.WriteLine("There are {0} working days from today to the day you entered", workDays);
        }
    }
}
