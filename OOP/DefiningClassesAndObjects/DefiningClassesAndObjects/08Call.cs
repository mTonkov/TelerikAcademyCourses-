using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesAndObjects
{
    class Call
    {
        private DateTime date;
        private TimeSpan time;
        private string dialledNum;
        private int duration;

        public DateTime Date
        {
            get { return date; }
            set { this.date = value; }
        }

        public TimeSpan Time
        {
            get { return time; }
            set { this.time = value; }
        }

        public string DialledNum
        {
            get { return dialledNum; }
            set {
                int result;
                if (int.TryParse(value, out result))
				{
		 	 	 this.dialledNum = value; 
				}

		    }
        }

        public int Duration
        {
            get { return duration; }
            set
            {
                if (value > 0)
                {
                    this.duration = value;
                }
            }
        }
                
        public Call()
        {
            this.Date = DateTime.Now.Date;
            this.Time = DateTime.Now.TimeOfDay;
        }
        public Call(string number, int duration):this()
        {
            this.DialledNum = number;
            this.Duration = duration;
        }
    }
}
