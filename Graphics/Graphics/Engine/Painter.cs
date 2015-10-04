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

        public Painter()
        {
            BackgroundColor = 0;
            BrushColor = 0; // Black
        }

        public void putPoint(Point point)
        {
            // TODO. Must be engine.
            Console.WriteLine("paintPoint=" + point.ToString());
        }

        public void movePoint(Point oldPoint, Point newPoint)
        {
            // TODO. Must be engine.
            Console.WriteLine("oldPoint=" + oldPoint.ToString() + " newPoint=" + newPoint.ToString());
        }

        public void drawLine(Line line)
        {
            // TODO. Must be engine.
            Console.WriteLine("drawLine=" + line.ToString());
        }
    }
}
