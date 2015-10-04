using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics.Data
{
    interface IView
    {
        int BitMapWidth { get; set; }
        int BitMapHight { get; set; }
        int PenWidth { get; set; }
        System.Drawing.Color PenColor { get; set; }
        System.Drawing.Color BitMapBackgroundColor { get; set; }
        void DrawPoint(int x, int y);
        void DrawLine(int x1, int y1, int x2, int y2);
        void Clear();
    }
}
