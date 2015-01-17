using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesAndObjects
{
    class Display
    {
        private double size;
        private ulong colours;

        public double Size
        {
            get { return size; }
            set
            {
                if (value >= 7d)  //task 05  (If value is >7(double), the item is more likely to be a tablet than a mobile phone)
                {
                    throw new ArgumentException("Are you using a tablet. The screen is too big for a cell phone");
                }
                else { this.size = value; }
            }
        }

        public ulong Colours
        {
            get { return colours; }
            set
            {
                if (value > 16000000 && value < 256)  //task 05
                {
                    throw new ArgumentException("There is no existing modern dispay with such number of colours");
                }
                else { this.colours = value; }
            }
        }

        public Display()
        { }
        public Display(double size, ulong colours)
        {
            this.Size = size;
            this.Colours = colours;
        }
    }
}
