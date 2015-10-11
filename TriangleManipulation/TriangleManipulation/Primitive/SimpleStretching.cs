using TriangleManipulation.Data;
using TriangleManipulation.Helper;

namespace TriangleManipulation.Primitive
{
    class SimpleStretching
    {
        public Point StretchPoint (Point oldPoint, Vector coef, Point centre)
        {
            return new Point(StretchingMatrix.GetStretchingMatrix(coef, centre) * oldPoint.Coordinates);
        }
    }
}
