using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleManipulation.Data;
using TriangleManipulation.Engine;

namespace TriangleManipulation.Primitive
{
    class SimpleDrawing
    {
        public  Painter Painter { get; set; }
        private Projection projector;
        private const int R = 50, L = -50, T = 50, B = -50, N = -1, F = -50;
        public SimpleDrawing()
        {
            projector = new Projection(R, L, B, T, N, F);
            Painter = new Painter();
        }
        public void PutPoint(Point point)
        {
            // NDC - Normalized device coordinates x from [-1,1] , y from [-1,1]
            Point pointNDC = projector.ProjectToNDC(point);
         //   painter.PutPoint(pointNDC);
        }
        public void DrawLine(Line line, System.Drawing.Color color )
        {
            Point beginPointNDC = projector.ProjectToNDC(line.Begin);
            Point endPointNDC = projector.ProjectToNDC(line.End);
            Painter.DrawLine3D(new Line (beginPointNDC, endPointNDC), color);
        }

        public void DrawLine2D(Line line, System.Drawing.Color color)
        {           
            Painter.DrawLine2D(new Line(line.Begin, line.End), color);
        }
    }
}
