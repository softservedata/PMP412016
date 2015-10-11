using TriangleManipulation.Primitive;
using TriangleManipulation.Data;

namespace TriangleManipulation.Service
{
    class Moving
    {
        SimpleMoving moving;
        public Moving ()
        {
            moving = new SimpleMoving();
        }
        public Triangle RelocateTriangle (Triangle triangle, Vector direction)
        {
            return new Triangle(moving.MovePoint(triangle.A, direction), 
                moving.MovePoint(triangle.B, direction), moving.MovePoint(triangle.C, direction));
        }
    }
}
