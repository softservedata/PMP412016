using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Graphics.Data;

namespace Graphics.Service
{
    class PolygonPainter
    {
        IViewer view;
        Graphics.Engine.Painter painter;
        public void ConnectTo(IViewer view)
        {
            this.view = view;
        }
        //add new constructor whith colors
        public PolygonPainter(IViewer view)
        {
            ConnectTo(view);
            painter = new Engine.Painter(view);
        }
        public void putRectangle(Rectangle rectangle)
        {
            foreach(Line l in rectangle.Series)
            {
                painter.drawLine(l);
            }
        }
        public void moveRectangle(Rectangle oldRectangle, Graphics.Data.Rectangle newRectangle)
        {
            foreach (Line l in oldRectangle.Series)
            {
                painter.cleanLine(l);
            }
            foreach(Line l in newRectangle.Series)
            {
                painter.drawLine(l);
            }
        }
        public void cleanRectangle(Rectangle oldRectangle)
        {
            foreach (Line l in oldRectangle.Series)
            {
                painter.cleanLine(l);
            }
        }
        public void putCircle(Polygon circle)
        {
            foreach (Line l in circle.Series)
            {
                painter.drawLine(l);
            }
        }
        public void moveCircle(Polygon oldCircle, Polygon newCircle)
        {
            foreach (Line l in oldCircle.Series)
            {
                painter.cleanLine(l);
            }
            foreach (Line l in newCircle.Series)
            {
                painter.drawLine(l);
            }
        }
        public void cleanCircle(Polygon oldCircle)
        {
            foreach (Line l in oldCircle.Series)
            {
                painter.cleanLine(l);
            }
        }
    }
}
