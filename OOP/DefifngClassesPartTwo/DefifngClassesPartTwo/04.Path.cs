using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartTwo
{
    class Path
    {
        private List<Point3D> sequence;

        public Path()
        {
            this.sequence = new List<Point3D>();
        }

        public Path(Point3D point):this() //counstructor with a given one point
        {
            this.sequence.Add(point);
        }

        public List<Point3D> Sequence 
        { 
            get { return this.sequence; }
            set { this.sequence = value;} 
        }//"setter" instead of creating a constructor where the new path hold existing sequence of points

        public void AddPoint(Point3D point)
        {
            this.sequence.Add(point);
        }

    }
}
