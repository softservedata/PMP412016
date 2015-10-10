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
            double c = Math.Cos(angle);
            double s = Math.Sin(angle);
            Matrix transformZero = new Matrix();
            transformZero.Matr[0, 0] = Math.Pow(direction.Vect[0], 2) * (1 - c) + c;
            transformZero.Matr[0, 1] = direction.Vect[0] * direction.Vect[1] * (1 - c) - direction.Vect[2] * s;
            transformZero.Matr[0, 2] = direction.Vect[0] * direction.Vect[2] * (1 - c) + direction.Vect[1] * direction.Vect[2];
            transformZero.Matr[0, 3] = 0;
            transformZero.Matr[1, 0] = direction.Vect[0] * direction.Vect[1] * (1 - c) + direction.Vect[2] * s;
            transformZero.Matr[1, 1] = Math.Pow(direction.Vect[1], 2) * (1 - c) + c;
            transformZero.Matr[1, 2] = direction.Vect[1] * direction.Vect[2] * (1 - c) - direction.Vect[0] * direction.Vect[2];
            transformZero.Matr[1, 3] = 0;
            transformZero.Matr[2, 0] = direction.Vect[0] * direction.Vect[2] * (1 - c) - direction.Vect[1] * direction.Vect[2];
            transformZero.Matr[2, 1] = direction.Vect[1] * direction.Vect[2] * (1 - c) + direction.Vect[0] * direction.Vect[2];
            transformZero.Matr[2, 2] = Math.Pow(direction.Vect[2], 2) * (1 - c) + c;
            transformZero.Matr[2, 3] = 0;
            transformZero.Matr[3, 0] = 0;
            transformZero.Matr[3, 1] = 0;
            transformZero.Matr[3, 2] = 0;
            transformZero.Matr[3, 3] = 1;
            //
            Transfer transfer0 = new Transfer(new Vector(new Point() - center));
            Transfer transfer1 = new Transfer(new Vector(center));
            Transform = transfer1.Transform * transformZero;
            Transform = Transform * transfer0.Transform;
        }

        public Point rotate(Point source)//rotate one point, matrix from constructor
        {
            Vector sourceVector = new Vector(source);
            sourceVector = Transform * sourceVector;
            return new Point(sourceVector);
        }

    }
}
