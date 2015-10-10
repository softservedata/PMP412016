using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics.Data
{
    class Point
    {
        public Vector Coordinates {get; private set; }

        public Point(): this(0,0,0)
        {
        }

        public Point(double x, double y, double z)
        {
            Coordinates = new Vector(x, y, z);
        }

        public Point(Vector source)
        {
            Coordinates = source;
        }

        public double getX()
        {
            return Coordinates.Vect[0] / Coordinates.Vect[3];
        }
 
        public double getY()
        {
            return Coordinates.Vect[1] / Coordinates.Vect[3];
        }

        public double getZ()
        {
            return Coordinates.Vect[2] / Coordinates.Vect[3];
        }

        public override string ToString()
        {
            return getX().ToString() + " " + getY().ToString() + " " + getZ().ToString();
        }
        public  Point operator -(Point left, Point right)
        {
            return new Point(left.getX() - right.getX(), left.getY() - right.getY(), left.getZ() - right.getZ());
        }
    }
}
