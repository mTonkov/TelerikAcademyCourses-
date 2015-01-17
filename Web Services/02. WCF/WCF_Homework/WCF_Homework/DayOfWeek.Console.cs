using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF_Homework.DayOfWeekService;

namespace WCF_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            DayOfWeekServiceClient client = new DayOfWeekServiceClient();
            var result = client.GetDayOfWeek(DateTime.Now);

            Console.WriteLine(result);
        }
    }
}
