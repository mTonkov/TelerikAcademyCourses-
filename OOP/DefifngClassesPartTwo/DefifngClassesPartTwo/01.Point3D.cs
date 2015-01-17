using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartTwo
{
    struct Point3D
    {
        private static readonly Point3D o = new Point3D("O", 0, 0, 0); //task 02

        public static Point3D O //task02
        {
            get {return o;}
        }

        public Point3D(string name, int x, int y, int z):this()
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }


                
        public override string ToString()
        {
            return string.Format("{3}({0},{1},{2})", this.X, this.Y, this.Z, this.Name);
        }
    }
}
