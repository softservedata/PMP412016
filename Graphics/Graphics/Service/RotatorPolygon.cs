using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Graphics.Data;
using Graphics.Primitives;

namespace Graphics.Service
{
    class RotatorPolygon
    {
        private Rotator rotator;

        public RotatorPolygon(Point center, Vector direction, double angle)
        {
            this.rotator = new Rotator(center, direction, angle);
        }

        public Polygon rotate(Polygon source)
        {
            Polygon result = new Polygon();
            foreach (Line l in source.Series)
            {
                result.add(new Line(rotator.rotate(l.Begin), rotator.rotate(l.End)));
            }
            return result;
        }
        public Circle rotate(Circle source)
        {
            Circle result = new Circle(source.Radius, source.Center, 100);
            foreach (Line l in source.Series)
            {
                result.add(new Line(rotator.rotate(l.Begin), rotator.rotate(l.End)));
            }
            return result;
        }
        public Rectangle rotateRectangle(Rectangle source)
        {
           // Rectangle result = new Rectangle(source.)
            List<Line> result = new List<Line>();
            foreach (Line l in source.Series)
            {
                result.Add(new Line(rotator.rotate(l.Begin), rotator.rotate(l.End)));
                //l = new Line(rotator.rotate(l.Begin), rotator.rotate(l.End));
            }
            Rectangle res=new Rectangle(result);
            return res;
        }

    }
}
