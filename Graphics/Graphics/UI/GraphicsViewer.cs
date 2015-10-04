using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using SD = System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Graphics.Data;
using Graphics.Engine;

namespace Graphics.UI
{    
    public partial class GraphicsViewer : Form,IView
    {
        private SD.Graphics gr;
        private SD.SolidBrush sb;
        private SD.Pen pen;
        private Polygon poligon = null;
        private Painter painter;
        public int BitMapWidth { get; set; }
        public int BitMapHight { get; set; }
        public int PenWidth { get; set; }
        public SD.Color PenColor { get; set; }
        public SD.Color BitMapBackgroundColor { get; set; }
        public GraphicsViewer()
        {
            InitializeComponent();
            BitMapWidth = panelScreen.Width;
            BitMapHight = panelScreen.Height;
            PenWidth = 2;
            PenColor = SD.Color.Black;
            BitMapBackgroundColor = panelScreen.BackColor;
            painter = new Painter(this);
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
            if (poligon == null) poligon = new Polygon();
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
            poligon.Add(new Line(new Point(x1, y1, z1), new Point(x2, y2, z2)));    
            painter.DrawPolygon(poligon);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            poligon = null;
            Clear();
        }
    }
}
