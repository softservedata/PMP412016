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
        public double this[int index_i,int index_j]
        {
            get
            {
                return Matr[index_i,index_j];            
            }
            set
            {
               Matr[index_i,index_j] = value;            
            }
        }
        public static Matrix operator*(Matrix left, Matrix right)
        {
           Matrix result = new Matrix();
           double sum = 0;
           for (int i = 0; i < Vector.VECTOR_SIZE; i++)
            {
                for (int j = 0; j < Vector.VECTOR_SIZE; j++)
                {
                    sum = 0;
                    for (int k = 0; k < Vector.VECTOR_SIZE; k++)
                    {
                        sum += left[i, k] * right[k, j];
                    }
                    result[i, j] = sum;
                }
            }
           return result;
        }
 
        public static Vector operator*(Matrix left, Vector right)
        {
            Vector result = new Vector();
            for (int i = 0; i < Vector.VECTOR_SIZE; i++)
            {
                result[i] = 0;
                for (int j = 0; j < Vector.VECTOR_SIZE; j++)
                {
                    result[i] = result[i] + left[i, j] * right[j];
                }
            }
            return result;
        }
    }
}
