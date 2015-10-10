using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics.Data
{
  public   class Line
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
            return "Begin: " + Begin.getX().ToString() + " " + Begin.getY().ToString() + " " + Begin.getZ().ToString()
                + "\nEnd: " + End.getX().ToString() + " " + End.getY().ToString() + " " + End.getZ().ToString();
        }
    }
}
