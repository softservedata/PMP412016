using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics.Data
{
    class Vector
    {
        public const int VECTOR_SIZE = 4;
        public double[] Vect {get; private set;}

        public Vector()
        {
            Vect = new double[VECTOR_SIZE];
            for (int i = 0; i < Vector.VECTOR_SIZE; i++)
            {
                Vect[i] = 0;
            }
        }
        public Vector(double x, double y, double z):base()
        {
            Vect[0] = x;
            Vect[1] = y;
            Vect[2] = z;
            Vect[3] = 1;
        }
    }
}
