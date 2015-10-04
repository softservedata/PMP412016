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
    }       
}
