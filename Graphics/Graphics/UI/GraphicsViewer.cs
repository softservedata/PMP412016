using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using SD = System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Graphics.Data;
using Graphics.Service;

namespace Graphics.UI
{    
    public partial class GraphicsViewer : Form,IView
    {
        private SD.Graphics gr;
        private SD.SolidBrush sb;
        private SD.Pen pen;
        private Polygon poligon = null;
        private List<Polygon> shapes = null;
        private Drawer drawer;
        public int BitMapWidth { get; set; }
        public int BitMapHight { get; set; }
        public int PenWidth { get; set; }
        public SD.Color PenColor { get; set; }
        public SD.Color BitMapBackgroundColor { get; set; }
        private double angleStep = Math.PI / 4.0;
        public GraphicsViewer()
        {
            InitializeComponent();
            BitMapWidth = panelScreen.Width;
            BitMapHight = panelScreen.Height;
            PenWidth = 2;
            PenColor = SD.Color.Black;
            BitMapBackgroundColor = panelScreen.BackColor;
            drawer = new Drawer();
            drawer.ConnectTo(this);
            shapes = new List<Polygon>();
        }        
        private void panelScreen_MouseClick(object sender, MouseEventArgs e)
        {            
            gr = ((Panel)sender).CreateGraphics();
            sb = new SD.SolidBrush(SD.Color.Black);
            gr.FillRectangle(sb,e.X,e.Y,10,10);
        }
        public void DrawPoint(int x, int y)
        {
            gr = (panelScreen).CreateGraphics();
            sb = new SD.SolidBrush(PenColor);
            gr.FillRectangle(sb, x,y, PenWidth, PenWidth);
        }
        public void DrawLine(int x1, int y1, int x2,int y2)
        {
            gr = (panelScreen).CreateGraphics();
            pen = new SD.Pen(PenColor,PenWidth);
            gr.DrawLine(pen, x1, y1, x2, y2);
        }
        public void Clear()
        {
            panelScreen.Refresh();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {            
            double x1, y1, z1, x2, y2, z2;
            try
            {
                x1 = Convert.ToDouble(textBoxX1.Text);
                x2 = Convert.ToDouble(textBoxX2.Text);
                y1 = Convert.ToDouble(textBoxY1.Text);
                y2 = Convert.ToDouble(textBoxY2.Text);
                z1 = Convert.ToDouble(textBoxZ1.Text);
                z2 = Convert.ToDouble(textBoxZ2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (poligon == null) poligon = new Polygon(new Point(x1, y1, z1));
            poligon.Add(new Line(new Point(x1, y1, z1), new Point(x2, y2, z2)));
            shapes.Add( poligon);
            drawer.Clear();
            foreach (Polygon pol in shapes)
            {
                drawer.DrawPolygon(poligon);
            }            
            textBoxX1.UseWaitCursor = false;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            poligon = null;
            drawer.Clear();
        }       
        private void GraphicsViewer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right: { poligon = (new Rotator(poligon.Center, 10, new Point(0, 1, 0))).Rotate(poligon); break; }
            }
            drawer.Clear();
            drawer.DrawPolygon(poligon);
        }

        private void buttonZRight_Click(object sender, EventArgs e)
        {
            for(int i=0;i < shapes.Count;i++)
            {
                shapes[i] = (new Rotator(shapes[i].Center, -angleStep, new Point(0, 0, 1))).Rotate(shapes[i]);
            } 
            drawer.Clear();
            DrawAllShapes();         
        }
        private void buttonZLeft_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i] = (new Rotator(shapes[i].Center, angleStep, new Point(0, 0, 1))).Rotate(shapes[i]);
            }
            drawer.Clear();
            DrawAllShapes(); 
        }
        private void buttonYLeft_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i] = (new Rotator(shapes[i].Center, angleStep, new Point(0, 1, 0))).Rotate(shapes[i]);
            }            
            drawer.Clear();
            DrawAllShapes();
        }
        private void buttonYRight_Click(object sender, EventArgs e)
        {
           for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i] = (new Rotator(shapes[i].Center, -angleStep, new Point(0, 1, 0))).Rotate(shapes[i]);
            }            
            drawer.Clear();
            DrawAllShapes();
        }
        private void buttonXDown_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i] = (new Rotator(shapes[i].Center, -angleStep, new Point(1, 0, 0))).Rotate(shapes[i]);
            }
            drawer.Clear();
            DrawAllShapes();
        }
        private void buttonXUp_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i] = (new Rotator(shapes[i].Center, angleStep, new Point(1, 0, 0))).Rotate(shapes[i]);
            }
            drawer.Clear();
            DrawAllShapes();
        }  
        private void buttonCreateRhomb_Click(object sender, EventArgs e)
        {
            double x1, y1, z1, x2, y2, z2,nx,ny,nz,angle;
            try
            {
                x1 = Convert.ToDouble(textBoxRhombX1.Text);
                x2 = Convert.ToDouble(textBoxRhombX2.Text);
                y1 = Convert.ToDouble(textBoxRhombY1.Text);
                y2 = Convert.ToDouble(textBoxRhombY2.Text);
                z1 = Convert.ToDouble(textBoxRhombZ1.Text);
                z2 = Convert.ToDouble(textBoxRhombZ2.Text);
                nx = Convert.ToDouble(textBoxNormalX.Text);
                ny = Convert.ToDouble(textBoxNormalY.Text);
                nz = Convert.ToDouble(textBoxNormalZ.Text);
                angle = Convert.ToDouble(textBoxAngle.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            double zinith = (nx != 0)? Math.Atan(ny/nx): Math.PI/2.0;
            double azimuth = Math.Acos(nz / Math.Sqrt(nx * nx + ny * ny + nz * nz));
            shapes.Add(new Rhomb(new Point(x1, y1, z1), new Point(x2, y2, z2), angle, new Vector(nx, ny, nz)));            
            shapes.Add( new Circle(new Vector((x2 - x1) / 2.0, (y2 - y1) / 2.0, (z2 - z1) / 2.0).Abs() * Math.Sin(angle),
                                  zinith, azimuth, new Point((x1 + x2) / 2.0, (y1 + y2) / 2.0, (z1 + z2) / 2.0)));
           foreach (Polygon pol in shapes)
           {
               drawer.DrawPolygon(pol);
           }    
        }
        private void DrawAllShapes()
        {
            foreach (Polygon pol in shapes)
            {
                drawer.DrawPolygon(pol);
            } 
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {           
            base.OnKeyDown(e);
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.Right: buttonZRight_Click(null, null); break;
                    case Keys.Left: buttonZLeft_Click(null, null); break;
                    case Keys.Up: buttonXUp_Click(null, null); break;
                    case Keys.Down: buttonXDown_Click(null, null); break;
                }
            }
            if (e.Shift)
            {
                switch (e.KeyCode)
                {
                    case Keys.Right: buttonYRight_Click(null, null); break;
                    case Keys.Left: buttonYLeft_Click(null, null); break;
                }
            }
            
        }
        //protected override void OnKeyPress(KeyPressEventArgs e)
        //{
        //    base.OnKeyPress(e);
        //    if (e.KeyChar == 'd')
        //    {
        //        for (int i = 0; i < shapes.Count; i++)
        //        {
        //            shapes[i] = (new Rotator(shapes[i].Center, -angleStep, new Point(0, 0, 1))).Rotate(shapes[i]);
        //        }
        //        drawer.Clear();
        //        DrawAllShapes();
        //    }
        //}
    }
}
