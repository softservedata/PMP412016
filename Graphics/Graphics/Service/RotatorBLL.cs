using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Graphics.Data;
using Graphics.Primitives;

namespace Graphics.Service
{
    class RotatorBLL
    {
        private Rotator rotator;

        public RotatorBLL(Vector direction, double angle)
        {
            this.rotator = new Rotator(direction, angle);
        }

        public Polygon rotateByZero(Vector direction, double angle, Polygon source)
        {
            // TODO
            return new Polygon();
        }

        public Polygon rotateByPoint(Vector direction, double angle, Point center, Polygon source)
        {
            // TODO
            return new Polygon();
        }
    }
}
