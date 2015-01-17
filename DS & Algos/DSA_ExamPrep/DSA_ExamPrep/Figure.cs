using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_ExamPrep
{
    public class Figure
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Figure Flip()
        {
            int oldWidth = this.Width;
            this.Width = this.Height;
            this.Height = oldWidth;

            return this;
        }

        public override string ToString()
        {
            return "(" + this.Width + ", " + this.Height + ")";
        }
    }
}
