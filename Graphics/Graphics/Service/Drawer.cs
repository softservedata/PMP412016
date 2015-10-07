using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Graphics.Primitives;
using Graphics.Data;

namespace Graphics.Service
{
    class Drawer
    {
        private PrimitiveDrawer pDrawer;       
        public Drawer(){}        
        public void ConnectTo(IView view)
        {
            pDrawer = new PrimitiveDrawer(view);
        }
        public void DrawPoint(Point p)
        {
            pDrawer.PutPoint(p);
        }
        public void DrawLine(Line line)
        {
            pDrawer.Clear();
            pDrawer.DrawLine(line);
        }
        public void DrawPolygon(Polygon p)
        {
            //pDrawer.Clear();
            foreach (Line line in p.Series)
            {
                pDrawer.DrawLine(line);
            }
        }
        public void Clear()
        {
            pDrawer.Clear();
        }
    }
}
