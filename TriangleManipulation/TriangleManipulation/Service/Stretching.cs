using TriangleManipulation.Data;
using TriangleManipulation.Primitive;

namespace TriangleManipulation.Service
{
    class Stretching
    {
        private SimpleStretching stretcher = new SimpleStretching();
        public Triangle StretchTriangle (Triangle triangle, Vector coeficients, Point centre)
        {
            return new Triangle(stretcher.StretchPoint(triangle.A, coeficients, centre),
                stretcher.StretchPoint(triangle.B, coeficients, centre), stretcher.StretchPoint(triangle.C, coeficients, centre));
        }
    }
}
