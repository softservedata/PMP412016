using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleManipulation.Data
{
     public class Vector
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
        public Vector(double x, double y, double z) : this()
        {            
            Vect[0] = x;
            Vect[1] = y;
            Vect[2] = z;
            Vect[3] = 1;
        }

        public double this[int i]
        {
            get
            {               
                return Vect[i];
            }
            set
            {
                Vect[i] = value;
            }
        }

        public static double operator * (Vector left, Vector right)
        {
            double result = 0;
            for (int i=0; i<Vector.VECTOR_SIZE-1; i++)
            {
                result = result + (left.Vect[i] / left.Vect[3]) * (right.Vect[i] / right.Vect[3]);
            }
            return result;
        }

        public double Abs ()
        {
            // !!!
            return Math.Sqrt(Vect[0]*Vect[0]+Vect[1]* Vect[1]+ Vect[2]* Vect[2]);
        }
    }
}