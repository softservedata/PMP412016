﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Graphics.Data;

namespace Graphics.Primitives
{
    // Rotates objects only around the absolute coordinates.
    class AbsoluteRotator
    {
        public double Angel { get; private set; }
        public Point Axis { get; private set; }
        public Matrix RotateMatrix {get; private set;}
        public AbsoluteRotator(double _angel, Point _axis)
        {
            Angel = _angel;
            Axis = new Point(_axis.X,_axis.Y,_axis.Z);
            RotateMatrix = GetRotateMatrix(Angel,Axis);
        }
        private Matrix GetRotateMatrix(double ang, Point ax)
        {            
            // initializing of rotate matrix
            Matrix m = new Matrix();
            double c = Math.Cos(ang);
            double s = Math.Sin(ang);
            for (int i = 0; i < Vector.VECTOR_SIZE - 1; i++)
            {
                for (int j = 0; j < Vector.VECTOR_SIZE - 1; j++)
                {
                    m[i, j] = ax[i] * ax[j] * (1 - c);
                }
                m[i, i] = m[i, i] + c;
            }
            m[0, 1] = m[0, 1] - ax.Z * s;
            m[0, 2] = m[0, 2] + ax.Y * s;
            m[1, 0] = m[1, 0] + ax.Z * s;
            m[1, 2] = m[1, 2] - ax.X * s;
            m[2, 0] = m[2, 0] - ax.Y * s;
            m[2, 1] = m[2, 1] + ax.X * s;
            return m;
        }
        public Polygon Rotate(Polygon p)
        {            
            // transform points of poligon
            Polygon new_p =new Polygon(); // intialize polygon with center in (0,0,0)
            foreach (Line line in p.Series)
            {
                new_p.Add(Rotate(line));
            }
            return new_p;
         }
        public Point Rotate(Point p)
        {            
            Vector vec_result = RotateMatrix *( new Vector(p.X, p.Y, p.Z));
            return new Point(vec_result);
        }
        public Line Rotate(Line line)
        {
            Vector vec_begin = RotateMatrix * (new Vector(line.Begin.X, line.Begin.Y, line.Begin.Z));
            Vector vec_end = RotateMatrix * (new Vector(line.End.X, line.End.Y, line.End.Z));
            return new Line(new Point(vec_begin),new Point(vec_end));
        }
    }
}
