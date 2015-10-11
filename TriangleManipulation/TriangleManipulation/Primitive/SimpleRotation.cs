using TriangleManipulation.Data;
using TriangleManipulation.Helper;

namespace TriangleManipulation.Primitive
{
    class SimpleRotation
    {
        public Point RotatePoint(Point oldPoint ,Point axis, double angle, Point centre)
        {         
            return new Point(RotationMatrix.GetRotationMatrix(axis, angle, centre) * oldPoint.Coordinates);           
        }
    }
}
