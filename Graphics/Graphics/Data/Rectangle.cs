using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics.Data
{
    class Rectangle : Polygon
    {
        public Rectangle(Point leftUp, Point rightDown, Vector normal): base()
        {
            if (normal.abs() == 0)
            { 
                // TODO Create Custom Exception.
                throw new Exception("Divide by Zero");
            }
            double alpha = Math.Acos(normal * (new Vector(0, 0, 1)) / normal.abs());

        }

        public Rectangle(Point leftUp, Point rightDown, Point point)
            : base()
        {
        }

    }
}
