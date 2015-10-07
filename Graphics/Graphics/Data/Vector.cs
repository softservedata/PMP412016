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

        public double abs()
        {
            return Math.Sqrt(Math.Pow((Vect[0] / Vect[3]), 2) + Math.Pow((Vect[1] / Vect[3]), 2) + Math.Pow((Vect[2] / Vect[3]), 2));
        }

        // Scalar Multiply
        public static double operator *(Vector left, Vector right)
        {
            double result = 0;
            for (int i = 0; i < Vector.VECTOR_SIZE - 1; i++)
            {
                result = result + (left.Vect[i] / left.Vect[3]) * (right.Vect[i] / right.Vect[3]);
            }
            return result;
        }

        // Vector Multiply
        public static Vector operator ^(Vector left, Vector right)
        {
            double x1 = (left.Vect[0] / left.Vect[3]);
            double y1 = (left.Vect[1] / left.Vect[3]);
            double z1 = (left.Vect[2] / left.Vect[3]);
            double x2 = (right.Vect[0] / right.Vect[3]);
            double y2 = (right.Vect[1] / right.Vect[3]);
            double z2 = (right.Vect[2] / right.Vect[3]);
            return new Vector(y1 * z2 - y2 * z1, x1 * z2 - x2 * z1, x1 * y2 - x2 * y1);
        }

    }
}
