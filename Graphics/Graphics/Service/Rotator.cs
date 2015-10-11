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
        public PrimitiveRotator AbsRot {get; private set;}
        public Point CenterPoint { get; private set; }        
        public Rotator(Point _centerPoint, double angle, Point axis)
        {
            CenterPoint = new Point(_centerPoint.X, _centerPoint.Y, _centerPoint.Z);
            AbsRot = new PrimitiveRotator(CenterPoint,angle,axis);            
        }
        public Point Rotate(Point p)
        {               
            return AbsRot.Rotate(p);;
        }
        public Line Rotate(Line line)
        {            
            return AbsRot.Rotate(line); 
        }
        public Polygon Rotate(Polygon p)
        {
            Polygon new_p = new Polygon(p.Center); // intialize polygon with center in (0,0,0)
            foreach (Line line in p.Series)
            {
                new_p.Add(AbsRot.Rotate(line));
            }
            return new_p;
        }
    }
}
