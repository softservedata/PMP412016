using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleManipulation.Data
{
    class Triangle : Polygon
    {
        public Point A { get; private set; }
        public Point B { get; private set; }
        public Point C { get; private set; }
        public Point Centre { get; private set; }

        public Triangle (Point a, Point b, Point c):base()
        {
            A = new Point(a);
            B = new Point(b);
            C = new Point(c);
            Add(new Line(A, B));
            Add(new Line(B, C));
            Add(new Line(C, A));
            FindCentre();
        }

        private void FindCentre ()
        {
            Point middle = new Point((B.X + C.X) / 2.0, (B.Y + C.Y) / 2.0, (B.Z + C.Z) / 2.0);
            Console.WriteLine("M = " + middle.ToString());
            Vector median = new Vector(middle.X - A.X, middle.Y - A.Y, middle.Z - A.Z );
            Console.WriteLine("median = " + new Point(median).ToString());
            double length = median.Abs();
            //   median = new Vector(median.Vect[0] * 0.666, median.Vect[1] * 0.666, median.Vect[3] * 0.666);
            Centre = new Point(A.X + length * 0.666666, A.Y + length * 0.666666, A.Z + length * 0.666666);
            Console.WriteLine("median = " + Centre.ToString());
        }


    }
}
