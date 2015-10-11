using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Graphics.Data;

namespace Graphics.Primitives
{
    class PerspectiveProjection
    {
        // повинні бути такі щоб обєкт помістився в з зрізану пірамуду. Дно піраміди перпендикулярне до кришталика ока
        public double R { get; private set; }
        public double B { get; private set; }
        public double L { get; private set; }
        public double T { get; private set; }
        public double N { get; private set; }
        public double F { get; private set; }

        public Matrix Mprojection { get; private set; }
        public PerspectiveProjection(double _r,double _l,double _b,double _t,double _n, double _f)
        {
            R = _r;
            L = _l;
            B = _b;
            T = _t;
            N = _n;
            F = _f;
            Mprojection = GetProjectionMatrix(R,L,B,T,N,F);
        }
        private Matrix GetProjectionMatrix(double r, double l, double b, double t, double n, double f)
        {
            Matrix m = new Matrix();
            m[0, 0] = 2.0 * n / (r - l);
            m[1, 1] = 2.0 * n / (t - b);
            m[2, 2] = -(f + n) / (f - n);
            m[3, 3] = 0;
            m[0, 2] = (r + l) / (r - l);
            m[1, 2] = (t + b) / (t + b);// -
            m[3, 2] = -1;
            m[2, 3] = -2.0 * f * n / (f - n);
            return m;
        }
        public Point ProjectToNDC(Point p)   // projects point to NDC - normalized divice coordinates
        {
            Vector vec = Mprojection * (new Vector(p.X, p.Y, p.Z));
           /// if (vec[Vector.VECTOR_SIZE - 1] == 0) vec[Vector.VECTOR_SIZE - 1] = 1;
            for(int i=0;i<Vector.VECTOR_SIZE-1;i++)
            {
                vec[i] = vec[i] / vec[Vector.VECTOR_SIZE - 1];
            }
            // I will know if you copied this code T.K.=)  
            vec[2] = (F - N) * vec[2] / 2.0 + (F + N) / 2.0;
            vec[Vector.VECTOR_SIZE - 1] = 1;
            return new Point(vec);
        }
        //public Point GetScreenPoint(double x, double y, double w, double h, Point p) // (x,y) - coordinates of bottom-left corner of window
        //{
        //    // point (0,0) is in top left corner. So we need to put (-pNDC.Y) 
        //    Point pNDC = ProjectToNDC(p);
        //    double xScreen = w * pNDC.X/2.0 + x + w / 2.0;
        //    double yScreen = h * (- pNDC.Y) / 2.0 - y + h / 2.0;
        //    double z = (F - N) * pNDC.Z / 2.0 + (F + N) / 2.0;
        //    return new Point(xScreen, yScreen, z);
        //}
    }
}
