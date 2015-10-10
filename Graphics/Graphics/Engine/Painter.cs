using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Graphics.Data;

namespace Graphics.Engine
{
    class Painter
    {
        public int BackgroundColor { get; set; }
        public int BrushColor { get; set; }
        private Graphics.Service.IViewer view;

        public Painter()
        {
            BackgroundColor = 0;
            BrushColor = 0; // Black
        }
        public Painter(Graphics.Service.IViewer view, int BackgroundColor, int BrushColor) 
        {
            this.view = view;
            this.BackgroundColor = BackgroundColor;
            this.BrushColor = BrushColor;
        }
        public Painter(Graphics.Service.IViewer view):base()
        {
            this.view = view;
        }

        public void putPoint(Point point)
        {
            // TODO. Must be engine.
            view.putPoint(point);
            //Console.WriteLine("paintPoint=" + point.ToString());
        }

        public void movePoint(Point oldPoint, Point newPoint)
        {
            // TODO. Must be engine.
            view.cleanPoint(oldPoint);
            view.putPoint(newPoint);
           // Console.WriteLine("oldPoint=" + oldPoint.ToString() + " newPoint=" + newPoint.ToString());
        }
        public void cleanPoint(Point oldPoint)
        {
            view.cleanPoint(oldPoint);
        }
        public void drawLine(Line line)
        {
            // TODO. Must be engine.
            view.paintLine(line);
            //Console.WriteLine("drawLine=" + line.ToString());
        }
        public void moveLine(Line oldLine, Line newLine)
        {
            view.paintLine(newLine);
            view.cleanLine(oldLine);
        }
        public void cleanLine(Line oldLine)
        {
            view.cleanLine(oldLine);
        }
    }
}
