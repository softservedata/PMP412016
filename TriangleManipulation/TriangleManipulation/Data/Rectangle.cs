using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleManipulation.Data
{
    class Rectangle : Polygon
    {
        public Rectangle(Point leftUp, Point rightDown, Vector normal) : base ()
        {
            if (normal.Abs()==0)
            {
           //     throw new Exeption
            }
            double alpha = Math.Acos(normal * (new Vector(0, 0, 1)) / normal.Abs());
        }

        public Rectangle(Point leftUp, Point rightDown, Point normal) : base()
        {

        }
    }
}
