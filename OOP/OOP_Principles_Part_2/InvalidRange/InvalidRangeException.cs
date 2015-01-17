using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidRange
{
    public class InvalidRangeException<T> : ApplicationException
        where T : struct, IComparable, IComparable<T>
    {

        public InvalidRangeException(T min, T max)
            : base()
        {
            this.Min = min;
            this.Max = max;
        }
        public InvalidRangeException(string msg, T min, T max)
            : base(msg)
        {
            this.Min = min;
            this.Max = max;
        }


        private T Min { get; set; }
        private T Max { get; set; }

    }
}
