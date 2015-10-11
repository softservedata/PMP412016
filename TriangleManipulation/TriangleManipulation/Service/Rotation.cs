using TriangleManipulation.Primitive;
using TriangleManipulation.Data;


namespace TriangleManipulation.Service
{
    class Rotation
    {
        public Triangle RotateTriangle(Triangle triangle, Point axis,  double angle, Point centre)
        {
            SimpleRotation rotator = new SimpleRotation();

            return new Triangle(rotator.RotatePoint(triangle.A, axis, angle, centre),
                rotator.RotatePoint(triangle.B, axis, angle, centre), rotator.RotatePoint(triangle.C, axis, angle, centre));
        }     

    }
}
