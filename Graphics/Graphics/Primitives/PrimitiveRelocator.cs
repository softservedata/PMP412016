using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Graphics.Data;

namespace Graphics.Primitives
{
    //This class translates objects towards the vector ((0,0,0), Target_Point) 
    class PrimitiveRelocator
    {
        public Point Target { get; private set; }
        public Matrix RelocateMatrix { get; private set;}
        public PrimitiveRelocator(Point target)
        {
            Target = new Point(target.X, target.Y, target.Z);
            RelocateMatrix = GetRelocateMatrix(Target);
        }
        private Matrix GetRelocateMatrix( Point targ)
        {
            Matrix m = new Matrix();
            m[0, 3] = targ.X;
            m[1, 3] = targ.Y;
            m[2, 3] = targ.Z;
            return m; 
        }
        public Point Relocate(Point p)
        {
            Vector vec_result = RelocateMatrix * (new Vector(p.X, p.Y, p.Z));
            return new Point(vec_result);
        }
        public Line Relocate(Line line)
        {
            Vector vec_begin = RelocateMatrix * (new Vector(line.Begin.X, line.Begin.Y, line.Begin.Z));
            Vector vec_end = RelocateMatrix * (new Vector(line.End.X, line.End.Y, line.End.Z));
            return new Line(new Point(vec_begin), new Point(vec_end));
        }        
    }
}
