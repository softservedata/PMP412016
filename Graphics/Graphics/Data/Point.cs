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
        public Point(Vector vec)
        {
            coordinates = new Vector();
            for(int i=0;i<Vector.VECTOR_SIZE;i++)
            {
                coordinates[i] = vec[i];
            }
        }
        public double this[int index]
        {
            get
            {
                return coordinates[index] / coordinates.Vect[3];
            }            
        }
        public double X 
        {
            get { return coordinates.Vect[0] / coordinates.Vect[3]; }
        }
        public double Y
        {
            get { return coordinates.Vect[1] / coordinates.Vect[3]; }
        }
        public double Z
        {
            get { return coordinates.Vect[2] / coordinates.Vect[3]; }
        }       

        public override string ToString()
        {
            return X.ToString() + " " + Y.ToString() + " " + Z.ToString();
        }
    }
}
