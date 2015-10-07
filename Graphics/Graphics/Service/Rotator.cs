using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Graphics.Primitives;
using Graphics.Data;

namespace Graphics.Service
{
    class Rotator
    {
        public AbsoluteRotator AbsRot {get; private set;}
        public Point CenterPoint { get; private set; }
        public Rotator(Point _centerPoint, double angle, Point axis)
        {
            CenterPoint = new Point(_centerPoint.X, _centerPoint.Y, _centerPoint.Z);
            AbsRot = new AbsoluteRotator(angle,axis);
        }
        public Point Rotate(Point p)
        {
            p = (new PrimitiveRelocator(new Point(-CenterPoint.X, -CenterPoint.Y, -CenterPoint.Z))).Relocate(p);
            p = AbsRot.Rotate(p);            
            return (new PrimitiveRelocator(CenterPoint)).Relocate(p);
        }
        public Line Rotate(Line line)
        {
            line = (new PrimitiveRelocator(new Point(-CenterPoint.X, -CenterPoint.Y, -CenterPoint.Z))).Relocate(line);
            line = AbsRot.Rotate(line);
            return (new PrimitiveRelocator(CenterPoint)).Relocate(line);
        }
        public Polygon Rotate(Polygon p)
        {
            p = (new Relocator(new Point(-CenterPoint.X, -CenterPoint.Y, -CenterPoint.Z))).Relocate(p);
            p = AbsRot.Rotate(p);
            return (new Relocator(CenterPoint)).Relocate(p);
        }
    }
}
