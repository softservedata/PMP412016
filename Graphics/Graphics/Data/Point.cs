using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics.Data
{
    class Point
    {
        private Vector coordinates;

        public Point(double x, double y, double z)
        {
            coordinates = new Vector(x, y, z);
        }

        public double getX()
        {
            return coordinates.Vect[0] / coordinates.Vect[3];
        }
 
        public double getY()
        {
            return coordinates.Vect[1] / coordinates.Vect[3];
        }

        public double getZ()
        {
            return coordinates.Vect[2] / coordinates.Vect[3].;
        }

        public override string ToString()
        {
            return getX().ToString() + " " + getY().ToString() + " " + getZ().ToString();
        }
    }
}
