using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics.Data
{
    public class Rectangle : Polygon
    {
        public Rectangle(Point leftUp, Point rightDown, Vector normal): base()
        {
            if (normal.abs() == 0)
            { 
                // TODO Create Custom Exception.
                throw new Exception("Divide by Zero");
            }
          //  double alpha = Math.Acos(normal * (new Vector(0, 0, 1)) / normal.abs());
            Series.Add(new Line(leftUp, new Point(leftUp.getX(), rightDown.getY(), rightDown.getZ())));
            Series.Add(new Line(new Point(leftUp.getX(), rightDown.getY(), rightDown.getZ()), rightDown));
            Series.Add(new Line(rightDown, new Point(rightDown.getX(), leftUp.getY(), leftUp.getZ())));
            Series.Add(new Line(new Point(rightDown.getX(), leftUp.getY(), leftUp.getZ()), leftUp));
        
        }
        public Rectangle(List<Line> list):base()
        {
            foreach(Line l in list)
            {
                Series.Add(l);
            }
        }
        public Rectangle(Point leftUp, Point rightDown, Point point)
            : base()
        {
        }

    }
}
