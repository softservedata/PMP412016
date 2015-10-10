using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graphics
{
    public partial class UIForm : Form, Graphics.Service.IViewer
    {
        int CenterX;
        int CenterY;
        int Radius;
        Data.Circle circle;
        Data.Rectangle rectangle;
        public UIForm()
        {
            InitializeComponent();
        }
        public void putPoint(Data.Point source)
        {
            System.Drawing.Graphics g = this.CreateGraphics();
            g.DrawEllipse(new Pen(Color.Coral, 1), (int)source.getX(), (int)source.getY(), 1, 1);
        }
        public void paintLine(Graphics.Data.Line source)
        {
            System.Drawing.Graphics g = this.CreateGraphics();
            g.DrawLine(new Pen(Color.Coral, 1), (int)source.Begin.getX(), (int)source.Begin.getY(), (int)source.End.getX(), (int)source.End.getY());
        
        }
        public void cleanPoint(Graphics.Data.Point source)
        {
            System.Drawing.Graphics g = this.CreateGraphics();
            g.DrawEllipse(new Pen(this.BackColor, 1), (int)source.getX(), (int)source.getY(), 1, 1);
        
        }
        public void cleanLine(Graphics.Data.Line source)
        {
            System.Drawing.Graphics g = this.CreateGraphics();
            g.DrawLine(new Pen(this.BackColor, 1), (int)source.Begin.getX(), (int)source.Begin.getY(), (int)source.End.getX(), (int)source.End.getY());
        
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            CenterX = int.Parse(XTextBox.Text);
            CenterY = int.Parse(YTextBox.Text);
            Radius = int.Parse(RadiusTextBox.Text);
            if((CenterX>this.Width)||(CenterY>this.Height)||(Radius>this.Height/2)||(Radius>this.Width/2))
            {
                MessageBox.Show("This circle is too big");
            }
            else
            {
                this.circle = new Data.Circle((double)Radius, new Data.Point(CenterX, CenterY, 0), 100);
                Service.PolygonPainter painter = new Service.PolygonPainter(this);
                painter.putCircle(circle);
                this.rectangle = new Data.Rectangle(new Data.Point((int)(CenterX - Radius / (Math.Sqrt(2))), (int)(CenterY + Radius / (Math.Sqrt(2))), 0), new Data.Point((int)(CenterX + Radius / (Math.Sqrt(2))), (int)(CenterY - Radius / (Math.Sqrt(2))), 0), new Data.Vector(0, 0, 1));
                painter.putRectangle(this.rectangle);
            }
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            Service.RotatorPolygon rotator = new Service.RotatorPolygon(new Data.Point(CenterX, CenterY, 0), new Data.Vector(0, 0, -1), 2 * Math.PI / 100);
            Service.PolygonPainter painter = new Service.PolygonPainter(this);
            //painter.moveCircle(circle, (Data.Circle)rotator.rotate(circle));
            Data.Rectangle newrectangle = rotator.rotateRectangle(this.rectangle);
            painter.moveRectangle(this.rectangle, newrectangle);
            this.rectangle = newrectangle;
            painter.putCircle(circle);

        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            Service.RotatorPolygon rotator = new Service.RotatorPolygon(new Data.Point(CenterX, CenterY, 0), new Data.Vector(0, 0, 1), 2 * Math.PI / 100);
            Service.PolygonPainter painter = new Service.PolygonPainter(this);
            //painter.moveCircle(circle, (Data.Circle)rotator.rotate(circle));
            Data.Rectangle newrectangle = rotator.rotateRectangle(this.rectangle);
            painter.moveRectangle(this.rectangle, newrectangle);
            this.rectangle = newrectangle;
            painter.putCircle(circle);

        }
    }
}
