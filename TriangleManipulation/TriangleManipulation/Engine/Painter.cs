using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleManipulation.Data;
using System.Windows.Forms;

namespace TriangleManipulation.Engine
{
    class Painter
    {
        public System.Drawing.Graphics FormGraphics { get; set; }
        public int BackgroundColor { get; set; }
        public int BrushColor { get; set; }

        public Painter()
        {
            BackgroundColor = 0;
            BrushColor = 0; // Black
        }

        public void Clear()
        {
            if (FormGraphics != null)
                FormGraphics.Clear(System.Drawing.Color.Black);
        }
        public void DrawPoint2D(Point point, System.Drawing.Color color)
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(color, 4);
            System.Drawing.Graphics formGraphics = Form1.ActiveForm.CreateGraphics();
            formGraphics.DrawLine(myPen, (float)point.X, (float)point.Y, (float)(point.X), (float)(point.Y+2));
            myPen.Dispose();
            formGraphics.Dispose();
            Console.WriteLine("DrawPoint=" + point.ToString());
        }

        public Point movePoint(Point oldPoint, Vector direction)
        {
            return new Point(oldPoint.X + direction[0], oldPoint.Y + direction[1], oldPoint.Z + direction[2]);

            Console.WriteLine("oldPoint=" + oldPoint.ToString());
        }

        public void DrawLine3D(Line line, System.Drawing.Color color)
        {
            Console.WriteLine("Width!!!!= " + Form1.ActiveForm.Width + "  Heigth!!!!= " + Form1.ActiveForm.Height);
            Point onScreenBegin = GetScreenPoint(0, 0, Form1.ActiveForm.Width, Form1.ActiveForm.Height, line.Begin);
            Point onScreenEnd = GetScreenPoint(0, 0, Form1.ActiveForm.Width, Form1.ActiveForm.Height, line.End);
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(color, 5);
            System.Drawing.Graphics formGraphics = Form1.ActiveForm.CreateGraphics();
            formGraphics.DrawLine(myPen, Convert.ToInt32(onScreenBegin.X), Convert.ToInt32(onScreenBegin.Y), Convert.ToInt32(onScreenEnd.X), Convert.ToInt32(onScreenEnd.Y));
            myPen.Dispose();
            formGraphics.Dispose();
            Console.WriteLine("drawLine=" + line.ToString());
        }

        public void DrawLine2D(Line line, System.Drawing.Color color)
        {                       
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(color, 4);
            FormGraphics = Form1.ActiveForm.CreateGraphics();
            //Line screenLine = new Line(GetScreenPoint(0, 0, Form1.ActiveForm.Width, Form1.ActiveForm.Height, line.Begin),
            //    GetScreenPoint(0, 0, Form1.ActiveForm.Width, Form1.ActiveForm.Height, line.End));

            //formGraphics.DrawLine(myPen, (float)screenLine.Begin.X, (float)screenLine.Begin.Y, 
            //    (float)screenLine.End.X, (float)screenLine.End.Y);
            FormGraphics.DrawLine(myPen, (float)line.Begin.X, (float)line.Begin.Y, 
                (float)line.End.X, (float)line.End.Y);

            myPen.Dispose();
            FormGraphics.Dispose();
            Console.WriteLine("drawLine=" + line.ToString());
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