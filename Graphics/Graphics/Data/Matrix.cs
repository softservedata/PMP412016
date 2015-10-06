using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics.Data
{
    class Matrix
    {
        public double[,] Matr { get; private set; }
        
        public Matrix()
        {
            Matr = new double[Vector.VECTOR_SIZE, Vector.VECTOR_SIZE];
            for (int i = 0; i < Vector.VECTOR_SIZE; i++)
            {
                for (int j = 0; j < Vector.VECTOR_SIZE; j++)
                {
                    Matr[i, j] = 0;
                }
                Matr[i, i] = 1;
            }
        }

        public static Matrix operator*(Matrix left, Matrix right)
        {
           Matrix result = new Matrix();
           for (int i = 0; i < Vector.VECTOR_SIZE; i++)
            {
                for (int j = 0; j < Vector.VECTOR_SIZE; j++)
                {
                    result.Matr[i, j] = 0;
                    for (int k = 0; k < Vector.VECTOR_SIZE; k++)
                    {
                        result.Matr[i, j] = result.Matr[i, j] + left.Matr[i, k] * right.Matr[k, j];
                    }
                }
            }
           return result;
        }
 
        public static Vector operator*(Matrix left, Vector right)
        {
            Vector result = new Vector();
            for (int i = 0; i < Vector.VECTOR_SIZE; i++)
            {
                result.Vect[i] = 0;
                for (int j = 0; j < Vector.VECTOR_SIZE; j++)
                {
                    result.Vect[i] = result.Vect[i] + left.Matr[i, j] * right.Vect[j];
                }
            }
            return result;
        }
    }
}
