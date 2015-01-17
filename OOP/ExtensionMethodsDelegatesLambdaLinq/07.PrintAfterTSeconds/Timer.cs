using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*Using delegates write a class Timer that can execute certain method at each t seconds*/
namespace PrintAfterTSeconds
{
    class Timer
    {
        public static void IntervalExecution(int seconds, int programRuntime)
        {
            int endOfExecution = 0;
            TimeSpan timeOut = new TimeSpan(0, 0, seconds);
            var method = new TimerDelegate(Printer);

            while (programRuntime > endOfExecution)
            {
                method(programRuntime);
                programRuntime -= seconds;
                Thread.Sleep(timeOut);
            }
        }

        public static void Printer(int time)
        {
            Console.WriteLine(time);
        }

        public int Seconds { get; set; }
        public int TotalRuntimeForProgram { get; set; }
        
        public delegate void TimerDelegate(int timeLeft);

        public Timer()
        { }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter interval for execution of the printing method");
            int interval = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter total duration of the program");
            int duration = int.Parse(Console.ReadLine());

            Timer.IntervalExecution(interval, duration);
        }
    }
}
