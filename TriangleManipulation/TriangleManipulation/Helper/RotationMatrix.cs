using System;
using TriangleManipulation.Data;

namespace TriangleManipulation.Helper
{
    class RotationMatrix
    {      

            public static Matrix GetRotationMatrix(Point axis, double angle, Point centre)
        {
            Matrix toCentre = RelocationMatrix.GetRelocatingMatrix(new Vector(-centre.X, -centre.Y, -centre.Z));

            Matrix m = new Matrix();
            double c = Math.Cos(angle);
            double s = Math.Sin(angle);
            m[0, 0] = axis.X * axis.X * (1 - c) + c;
            m[1, 0] = axis.X * axis.Y * (1 - c) + axis.Z * s;
            m[2, 0] = axis.X * axis.Z * (1 - c) - axis.Y * s;
                                             
            m[0, 1] = axis.Y * axis.X * (1 - c) - axis.Z * s;
            m[1, 1] = axis.Y * axis.Y * (1 - c) + c;
            m[2, 1] = axis.Y * axis.Z * (1 - c) + axis.X * s;
                                             
            m[0, 2] = axis.X * axis.Z * (1 - c) + s;
            m[1, 2] = axis.Y * axis.Z * (1 - c) - axis.X * s;
            m[2, 2] = axis.Z * axis.Z * (1 - c) + c;

            m[3, 0] = m[3, 1] = m[3, 2] = m[0, 3] = m[1, 3] = m[2, 3] = 0;
            m[3, 3] = 1;

            return RelocationMatrix.GetRelocatingMatrix(new Vector(centre.X, centre.Y, centre.Z)) * m*toCentre;
        }
    }
}
