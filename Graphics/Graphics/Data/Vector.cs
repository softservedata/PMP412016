using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics.Data
{
    class Vector
    {
        public const int VECTOR_SIZE = 4;
        public double[] Vect { get; private set; }

        public Vector()
        {
            Vect = new double[VECTOR_SIZE];
            for (int i = 0; i < Vector.VECTOR_SIZE; i++)
            {
                Vect[i] = 0;
            }
        }
        public Vector(double x, double y, double z)
            : this()
        {
            Vect[0] = x;
            Vect[1] = y;
            Vect[2] = z;
            Vect[3] = 1;
        }
        public double this[int index]
        {
            get
            {
                if ((index < VECTOR_SIZE)&&(index>=0)) return Vect[index];
                else throw new IndexOutOfRangeException("Index is out of range.");
            }
            set
            {
                if ((index < VECTOR_SIZE) && (index >= 0)) Vect[index] = value;
                else throw new IndexOutOfRangeException("Index is out of range.");
                
            }
        }
        public static double operator *(Vector left, Vector right)
        {
            double result = 0;
            for(int i = 0; i< VECTOR_SIZE-1;i++)
            {
                result += (left[i] / left[VECTOR_SIZE - 1]) * (right[i] / right[VECTOR_SIZE - 1]);
            }
            return result;
        }
        public double Abs()
        {
            double result = 0;
            for (int i = 0; i < VECTOR_SIZE - 1; i++)
            {
                result += Math.Pow(Vect[i] / Vect[VECTOR_SIZE - 1],2);
            }
            return Math.Sqrt(result);
        }
        public static Vector operator^ (Vector left, Vector right)
        {           
            double u1 = left[0] / left[VECTOR_SIZE - 1];
            double u2 = left[1] / left[VECTOR_SIZE - 1];
            double u3 = left[2] / left[VECTOR_SIZE - 1];
            double v1 = right[0] / right[VECTOR_SIZE - 1];
            double v2 = right[1] / right[VECTOR_SIZE - 1];
            double v3 = right[2] / right[VECTOR_SIZE - 1];
            return new Vector(u2*v3 - u3*v2,u3*v1-u1*v3,u1*v2-u2*v1);
        }
    }       
}
