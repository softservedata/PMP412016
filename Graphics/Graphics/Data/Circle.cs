using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics.Data
{
    public class Circle:Polygon
    {
        public double Radius { get; private set; }
        public Point Center { get; private set; }
        public Circle(double radius, Point center, int n)
        {
            init(radius, center, n);
        }
        public void init(double radius, Point center, int n)
        {
            
            Radius = radius;
            Center = center;
            //double angle = 360/(double)n;
            double angle = 2*Math.PI / (double)n;
            Point begin1 = new Point(Center.getX(), Center.getY() - Radius, Center.getZ());
            Point end = new Point(Center.getX(), Center.getY() - Radius, Center.getZ());
            Point begin = new Point(Center.getX(), Center.getY() - Radius, Center.getZ());
            //Point begin = new Point(Radius * Math.Cos(0) + Center.getX(), Radius * Math.Sin(0) + Center.getY(), 0);
            //Point end = new Point(Radius * Math.Cos(0) + Center.getX(), Radius * Math.Sin(0) + Center.getY(), 0);
            //Point begin1 = begin;
            for (int i = 0; i <n; i++)
            {
                Graphics.Primitives.Rotator rotate = new Primitives.Rotator(Center, new Vector(0, 0, 1), angle);
                end = rotate.rotate(begin1);
                Series.Add(new Line(begin1, end));
                begin1 = end;
                //end=new Point(Radius*Math.Cos(angle)+Center.getX(), Radius*Math.Sin(angle)+Center.getY(), 0);
                //Series.Add(new Line(begin1, end));
                //begin1 = end;
                //angle += angle;
            }
            Series.Add(new Line(end, begin));
        }
    }
}
