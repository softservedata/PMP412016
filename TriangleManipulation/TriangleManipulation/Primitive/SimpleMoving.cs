using System;
using TriangleManipulation.Data;
using TriangleManipulation.Engine;
using TriangleManipulation.Helper;


namespace TriangleManipulation.Primitive
{
    class SimpleMoving
    {
        public Line MoveLine (Line line, Vector direction)
        {
            Painter p = new Painter();
            return new Line(p.movePoint(line.Begin, direction), p.movePoint(line.End,direction));
        }

        public Point MovePoint(Point oldPoint, Vector direction)
        {         
            return new Point(RelocationMatrix.GetRelocatingMatrix(direction)*oldPoint.Coordinates);
              
        }
    }
}
