using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Graphics.Data;

namespace Graphics.Primitives
{
    class Rotator
    {
        public Matrix Transform {get; private set; }

        public Rotator(Point center, Vector direction, double angle)
        {
            init(center, direction, angle);
        }

        // TODO Build Matrix.
        private void init(Point center, Vector direction, double angle)
        {
            Matrix transformZero = new Matrix();
            transformZero.Matr[0, 0] = Math.Pow(direction.Vect[0], 2) + (1 - Math.Pow(direction.Vect[0], 2)) * Math.Cos(angle);
            transformZero.Matr[0, 1] = direction.Vect[0] * direction.Vect[1] * (1 - Math.Cos(angle)) - direction.Vect[2] * Math.Sin(angle);
            transformZero.Matr[0, 2] = 0;
            transformZero.Matr[0, 3] = 0;
            transformZero.Matr[1, 0] = 0;
            transformZero.Matr[1, 1] = 0;
            transformZero.Matr[1, 2] = 0;
            transformZero.Matr[1, 3] = 0;
            transformZero.Matr[2, 0] = 0;
            transformZero.Matr[2, 1] = 0;
            transformZero.Matr[2, 2] = 0;
            transformZero.Matr[2, 3] = 0;
            transformZero.Matr[3, 0] = 0;
            transformZero.Matr[3, 1] = 0;
            transformZero.Matr[3, 2] = 0;
            transformZero.Matr[3, 3] = 1;
            //
            Transfer transfer0 = new Transfer();
        }

        public Point rotate(Point source)
        {
            // TODO
            return new Point();
        }

    }
}
