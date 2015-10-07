using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Graphics.Data;

namespace Graphics.Primitives
{
    class Rotator
    {
        Matrix matrix;

        public Rotator(Vector direction, double angle)
        {
            this.matrix = new Matrix();
        }

        public Point rotateBase(Point source)
        {
            // TODO
            return new Point();
        }

        public Point rotateBase(Vector direction, double angle, Point source)
        {
            // Rebuild matrix
            // TODO
            return new Point();
        }

        public Point rotateExtend(Point center, Point source)
        {
            // TODO
            return new Point();
        }
        
        public Point rotateExtend(Vector direction, double angle, Point center, Point source)
        {
            // Rebuild matrix
            // TODO
            return new Point();
        }
    }
}
