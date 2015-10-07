using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics.Data
{
    class Circle: Polygon
    {
        private int numberOfPoints = 50;
        public int NumberOfPoints
        {
            get { return numberOfPoints; }
            set 
            {
                Lines = null;
                numberOfPoints = value; 
            }
        }
        private List<Line> Lines = null;
        public double Radius { get; private set; }
        public double ZenithOfNormal { get; private set; }
        public double AzimuthOfNormal { get; private set; }        
        public override List<Line> Series
        {
            get
            {
                if(Lines == null)  Lines = GetLines();
                return Lines;
            }
        }
        public Circle(double radius,double zenith,double azimuth,Point _center)
        {
            Radius = radius;
            ZenithOfNormal = zenith;
            AzimuthOfNormal = azimuth;
            base.Center = _center;
        }
        private List<Line> GetLines()
        {
            List<Line> lines = new List<Line>();           
            Point begin;
            Point end;
            double t =0,h= 2.0*Math.PI/NumberOfPoints;           
            begin = GetPoint(t);
            for (int i = 0; i < numberOfPoints; i++)
            {               
                t += h;                
                end =GetPoint(t);
                lines.Add(new Line(begin, end));
                begin = end;
            }
            return lines;
        }
        private Point GetPoint(double t)
        {
            double x, y, z;
            x = Radius * Math.Cos(t) * (-Math.Sin(ZenithOfNormal)) +
                    Radius * Math.Sin(t) * Math.Cos(AzimuthOfNormal) * Math.Cos(ZenithOfNormal) + Center.X;
            y = Radius * Math.Cos(t) * (Math.Cos(ZenithOfNormal)) +
                 Radius * Math.Sin(t) * Math.Cos(AzimuthOfNormal) * Math.Sin(ZenithOfNormal) + Center.Y;
            z = Radius * Math.Sin(t) * (-Math.Sin(AzimuthOfNormal)) + Center.Z;
            return new Point(x, y, z);
        }
    }
}
