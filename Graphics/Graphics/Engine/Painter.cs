using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Graphics.Data;
using Graphics.UI;

namespace Graphics.Engine
{
    class Painter
    {
        public int BackgroundColor { get; set; }
        public int BrushColor { get; set; }        
        private const int R = 200, L = -200, T = 200, B = -200, N = -1, F = -50;
        private IView view;
        public Painter(IView _view)
        {
            BackgroundColor = 0;
            BrushColor = 0; // Black            
            view = _view;
        }

        public void PutPoint(Point point)
        {
            // TODO. Must be engine.            
            Point onScreen = GetScreenPoint(0, 0, view.BitMapWidth, view.BitMapHight, point);
            view.DrawPoint(Convert.ToInt32(onScreen.X),Convert.ToInt32(onScreen.Y));            
        }
        public void DrawLine(Point begin, Point end)
        {
            // TODO. Must be engine.            
            Point onScreenBegin = GetScreenPoint(0, 0, view.BitMapWidth, view.BitMapHight, begin);
            Point onScreenEnd =  GetScreenPoint(0, 0, view.BitMapWidth, view.BitMapHight, end);
            view.DrawLine(Convert.ToInt32(onScreenBegin.X), Convert.ToInt32(onScreenBegin.Y), Convert.ToInt32(onScreenEnd.X), Convert.ToInt32(onScreenEnd.Y));
        }        
        public void Clear()
        {
            view.Clear();
        }
        public Point GetScreenPoint(double x, double y, double w, double h, Point p) // (x,y) - coordinates of bottom-left corner of window
        {
            // point (0,0) is in top left corner. So we need to put (-p.Y)             
            double xScreen = w * p.X / 2.0 + x + w / 2.0;
            double yScreen = h * (-p.Y) / 2.0 - y + h / 2.0;            
            return new Point(xScreen, yScreen, p.Z);
        }
    }
}
