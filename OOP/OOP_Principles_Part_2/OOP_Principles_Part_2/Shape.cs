using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape()
        { }

        public Shape(double w, double h)
        {
            this.Width = w;
            this.Height = h;
        }
        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width should be positive value");
                }
                this.width = value;
            }
        }
        public double Height 
        {
            get { return this.height; }
            private set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Height should be positive value");
                }
                this.height = value;
            }
        }


        public virtual double CalculateSurface()
        {            
            return this.Height * this.Width;
        }
    }
}
