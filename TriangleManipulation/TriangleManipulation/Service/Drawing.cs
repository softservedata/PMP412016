using TriangleManipulation.Data;
using TriangleManipulation.Primitive;

namespace TriangleManipulation.Service
{
    class Drawing
    {
        private SimpleDrawing drawer = new SimpleDrawing();
        public void DrawTriangle (Triangle triangle, System.Drawing.Color color)
        {          
            foreach (Line l in triangle.Series)
            {
                // 2D
                drawer.DrawLine2D(l, color);
            }        
        }

        public  void Clear ()
        {
            drawer.Painter.Clear();
        }
    }
}
