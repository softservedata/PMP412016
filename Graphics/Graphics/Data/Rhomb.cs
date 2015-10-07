using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics.Data
{
    class Rhomb : Polygon
    {
        public Rhomb(Point diagonBegin, Point diagonEnd, double angleAdjacentToDiag, Vector normal): base()
        {
            Point c = new Point((diagonBegin.X + diagonEnd.X) / 2.0, 
                                (diagonBegin.Y + diagonEnd.Y) / 2.0,
                                (diagonBegin.Z + diagonEnd.Z) / 2.0);
            base.Center = c;
            Vector nn = new Vector(diagonEnd.X - diagonBegin.X, diagonEnd.Y - diagonBegin.Y, diagonEnd.Z - diagonBegin.Z) ^ normal;
            // перевіряємо чи справді normal перпендикулярний до діагоналі
            double scalarDob = nn * normal;
            if (scalarDob > 1e-10) throw new ApplicationException("Normal vector to rhomb is not normal");
            //
            nn = new Vector(nn[0] / nn.Abs(), nn[1] / nn.Abs(), nn[2] / nn.Abs());
            Vector AC = new Vector(c.X-diagonBegin.X,c.Y- diagonBegin.Y,c.Z- diagonBegin.Z);
            Point d = new Point(c.X + nn[0] * Math.Tan(angleAdjacentToDiag) * AC.Abs(), c.Y + nn[1] * Math.Tan(angleAdjacentToDiag) * AC.Abs(), c.Z + nn[2] * Math.Tan(angleAdjacentToDiag) * AC.Abs());
            Point f = new Point(c.X - nn[0] * Math.Tan(angleAdjacentToDiag) * AC.Abs(), c.Y - nn[1] * Math.Tan(angleAdjacentToDiag) * AC.Abs(), c.Z - nn[2] * Math.Tan(angleAdjacentToDiag) * AC.Abs());
            this.Series.Add(new Line(diagonBegin, d));
            this.Series.Add(new Line(d, diagonEnd));
            this.Series.Add(new Line(diagonEnd, f));
            this.Series.Add(new Line(f, diagonBegin));
        }
    }
}
