using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesAndObjects
{
    class GSMCallHistoryTest
    {
        static void Main()
        {
            GSM tel = new GSM("HTC", "one");
            tel.Batt = new Battery("BHTC-01", 80, 8, BatteryType.LiIon);
            tel.Disp = new Display(4.3, 16000000);
            tel.AddCalls(new Call("0888123321", 46));
            tel.AddCalls(new Call("0888123456", 55));
            tel.AddCalls(new Call("0888123222", 19));

            foreach (var call in tel.CallHistory)
            {
                Console.WriteLine("Date:{0:dd.mm.yyyy}; Time: {1:hh':'mm':'ss}; Number: {2}; Duration: {3}", call.Date, call.Time, call.DialledNum, call.Duration);
            }

            Console.WriteLine("Total amount to pay: {0}",tel.CallsCost());

            int maxIndex = 0;
            int maxDuration = 0;
            for (int i = 0; i < tel.CallHistory.Count; i++)
            {
                if (tel.CallHistory[i].Duration > maxDuration)
                {
                    maxIndex = i;
                }
            }

            tel.RemoveCall(maxIndex);
            Console.WriteLine("Total amount to pay: {0}", tel.CallsCost());

            tel.ClearHistory();

            Console.WriteLine(tel.CallHistory);

        }
    }
}
