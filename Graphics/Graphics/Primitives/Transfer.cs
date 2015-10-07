using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Graphics.Data;

namespace Graphics.Primitives
{
    class Transfer
    {
        public Matrix Transform { get; private set; }

        public Transfer(Vector direction)
        {
            init(direction);
        }

        private void init(Vector direction)
        {
            Transform = new Matrix();
            Transform.Matr[0, 3] = direction.Vect[0];
            Transform.Matr[1, 3] = direction.Vect[1];
            Transform.Matr[2, 3] = direction.Vect[2];
        }

        public Point move(Point source)
        {
            return new Point(Transform * source.Coordinates);
        }
    }
}
