using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopInterfaces
{
    public class Triangle : Shape
    {
        public Triangle(Point p1, Point p2, Point p3)
        : base(new[]
            {
                p1 ?? new Point(0, 0),
                p2 ?? new Point(0, 0), 
                p3 ?? new Point(0, 0) 
            })
        {
        }

        public Point P1
        {
            get { return Points[0]; }
        }

        public Point P2
        {
            get { return Points[1]; }
        }

        public Point P3
        {
            get { return Points[2]; }
        }

        public override double GetArea()
        {
            // see: https://www.mathopenref.com/coordtrianglearea.html
            double area = Math.Abs(P1.X * (P2.Y - P3.Y) + P2.X * (P3.Y - P1.Y) + P3.X * (P1.Y - P2.Y)) / 2;

            return Math.Round(area, 2);
        }
    }
}
