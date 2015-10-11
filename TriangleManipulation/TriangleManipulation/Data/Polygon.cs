using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleManipulation.Data
{
    class Polygon
    {
        public List<Line> Series { get; private set; }

        public Polygon()
        {
            Series = new List<Line>();
        }

        public void Add(Line line)
        {
            Series.Add(line);
        }
    }
}