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
        private PerspectiveRrojection projector;
        private const int R = 100, L = -100, T = 100, B = -100, N = -1, F = -2;
        private IView view;
        public Painter(IView _view)
        {
            BackgroundColor = 0;
            BrushColor = 0; // Black
            projector = new PerspectiveRrojection(R,L,B,T,N,F);
            view = _view;
        }

        public void PutPoint(Point point)
        {
            // TODO. Must be engine.            
            Point onScreen = projector.GetScreenPoint(0, 0, view.BitMapWidth, view.BitMapHight, point);
            view.DrawPoint(Convert.ToInt32(onScreen.X),Convert.ToInt32(onScreen.Y));            
        }

        //public void movePoint(Point oldPoint, Point newPoint)
        //{
        //    // TODO. Must be engine.            
        //    Console.WriteLine("oldPoint=" + oldPoint.ToString() + " newPoint=" + newPoint.ToString());
        //}

        public void DrawLine(Line line)
        {
            // TODO. Must be engine.            
            Point onScreenBegin = projector.GetScreenPoint(0, 0, view.BitMapWidth, view.BitMapHight, line.Begin);
            Point onScreenEnd =  projector.GetScreenPoint(0, 0, view.BitMapWidth, view.BitMapHight, line.End);
            view.DrawLine(Convert.ToInt32(onScreenBegin.X), Convert.ToInt32(onScreenBegin.Y), Convert.ToInt32(onScreenEnd.X), Convert.ToInt32(onScreenEnd.Y));
        }
        public void DrawPolygon(Polygon pol)
        {
            view.Clear();
            foreach (Line line in pol.Series)
            {
                DrawLine(line);
            }
        }
        public void Clear()
        {
            view.Clear();
        }

    }
}
