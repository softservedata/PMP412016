using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Graphics.Data;
using Graphics.Engine;

namespace Graphics.Primitives
{
    class PrimitiveDrawer
    {
        private Painter painter;
        private PerspectiveProjection projector;
        private const int R = 1, L = -1, T = 1, B = -1, N = -1, F = -10;
        public PrimitiveDrawer(IView view)
        {
            projector = new PerspectiveProjection(R, L, B, T, N, F);
            painter = new Painter(view);
        }
        public void PutPoint(Point point)
        {
            // NDC - Normalized device coordinates x from [-1,1] , y from [-1,1]
            Point pointNDC = projector.ProjectToNDC(point);            
            painter.PutPoint(pointNDC);
        }
        public void DrawLine(Line line)
        {
            Point beginPointNDC = projector.ProjectToNDC(line.Begin);
            Point endPointNDC = projector.ProjectToNDC(line.End);            
            painter.DrawLine(beginPointNDC, endPointNDC);
        }
        public void Clear()
        {
            painter.Clear();
        }
    }
}
