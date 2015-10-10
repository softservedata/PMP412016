using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics.Service
{
   public interface IViewer
    {
          void putPoint(Graphics.Data.Point source);
         void paintLine(Graphics.Data.Line source);
          void cleanPoint(Graphics.Data.Point source);
          void cleanLine(Graphics.Data.Line source);
    }
}
