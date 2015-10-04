using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics.Data
{
    class Line
    {
        public Point Begin { get; private set; }
        public Point End { get; private set; }

        public Line(Point begin, Point end)
        {
            this.Begin = begin;
            this.End = end;
        }

        public override string ToString()
        {
            return "Begin: " + Begin.X.ToString() + " " + Begin.Y.ToString() + " " + Begin.Z.ToString()
                + "\nEnd: " + End.X.ToString() + " " + End.Y.ToString() + " " + End.Z.ToString();
        }
    }
}
