using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics.Service
{
    interface IViewer
    {
        public void putPoint(Graphics.Data.Point source);
        public void paintLine(Graphics.Data.Line source);
        public void cleanPoint(Graphics.Data.Point source);
        public void cleanLine(Graphics.Data.Line source);
    }
}
