using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics.Data
{
    class Polygon
    {
        List<Line> Series { get; private set; }

        public Polygon()
        {
            Series = new List<Line>();
        }

        public void add(Line line)
        {
            Series.Add(line);
        }
    }
}
