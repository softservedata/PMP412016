
using TriangleManipulation.Data;
using TriangleManipulation.Engine;

namespace TriangleManipulation.Helper
{
    class StretchingMatrix
    {
        public static Matrix GetStretchingMatrix (Vector coeficients, Point centre)
        {
            Matrix toCentre = RelocationMatrix.GetRelocatingMatrix(new Vector(-centre.X, -centre.Y, -centre.Z));
            Matrix m = new Matrix();
            m[0, 0] = coeficients.Vect[0];
            m[1, 1] = coeficients.Vect[1];
            m[2, 2] = coeficients.Vect[2];
            m[3, 3] = coeficients.Vect[3];

            return RelocationMatrix.GetRelocatingMatrix(new Vector(centre.X, centre.Y, centre.Z)) *m*toCentre;
        }
    }
}
