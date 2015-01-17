using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        { }

        //There is no need of overriding the "CalculateSurface" method, because its description in the base class "Shape" is as needed
    }
}
