namespace Abstraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    interface IFigure
    {//every gemetric figure should have Perimeter and Surface
        public double CalcPerimeter();

        public double CalcSurface();
    }
}
