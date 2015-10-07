using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics.Data
{
    class Polygon
    {        
        virtual public List<Line> Series { get; private set; }
        public Point Center { get; protected set; }
        public Polygon()
        {
            Series = new List<Line>();
            Center = new Point(0,0,0);
        }
        public Polygon(Point _center)
        {
            Series = new List<Line>();
            Center = new Point(_center.X,_center.Y,_center.Z);
        }

        public void Add(Line line)
        {
            Series.Add(line);
        }
    }
}
