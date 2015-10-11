using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleManipulation.Data;

namespace TriangleManipulation.Helper
{
    class RelocationMatrix
    {
        public static Matrix GetRelocatingMatrix(Vector direction)
        {
            Matrix m = new Matrix();
            for (int i = 0; i < Vector.VECTOR_SIZE-1; i++)
                m[i, 3] = direction[i];
            return m;
        }   

       
    }
}
