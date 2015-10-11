using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleManipulation.Data
{
    public class Point
    {
        private Vector coordinates;
        public Vector Coordinates { get { return new Vector (X,Y,Z); }  }
        public double X { get { return coordinates[0] / coordinates.Vect[3]; } }
        public double Y { get { return coordinates[1] / coordinates.Vect[3]; } }
        public double Z { get { return coordinates[2] / coordinates.Vect[3]; } }
        public Point(double x, double y, double z)
        {
            coordinates = new Vector(x, y, z);
        }
        public Point (Point point)
        {
            coordinates = new Vector(point.X,point.Y, point.Z);  
        }

        public Point (Vector vector)
        {
            coordinates = new Vector();
            coordinates[0]= vector[0];
            coordinates[1] = vector[1];
            coordinates[2] = vector[2];
            coordinates[3] = 1;

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
            return coordinates.Vect[2] / coordinates.Vect[3];
        }

        public override string ToString()
        {
            return getX().ToString() + " " + getY().ToString() + " " + getZ().ToString();
        }
    }
}