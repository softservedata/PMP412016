using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Graphics.Data;
using Graphics.Primitives;

namespace Graphics.Service
{
    class Relocator
    {
        public Point Target { get; private set; }
        private PrimitiveRelocator prReloc;
        public Relocator(Point direction)
        {
            prReloc = new PrimitiveRelocator(direction);
        }
        public Point Relocate(Point p)
        {
            return prReloc.Relocate(p);
        }
        public Line Relocate(Line line)
        {
            return prReloc.Relocate(line);
        }
        public Polygon Relocate(Polygon p)
        {
            // transform points of poligon
            Polygon new_p = new Polygon(prReloc.Relocate(p.Center)); 
            foreach (Line line in p.Series)
            {
                new_p.Add(prReloc.Relocate(line));
            }           
            return new_p;
        }

    }
}
