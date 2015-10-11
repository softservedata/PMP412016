using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriangleManipulation.Data;
using TriangleManipulation.Engine;
using TriangleManipulation.Service;

namespace TriangleManipulation
{
    public partial class Form1 : Form
    {
        private Triangle tr;
        private Drawing drawer;
        private Rotation rotator;
        private Moving mover;
        private Stretching stretcher;
        private System.Drawing.Color color;

        public Form1()
        {
            InitializeComponent();
            rotator = new Rotation();
            drawer = new Drawing();
            mover = new Moving();
            stretcher = new Stretching();
            color = Color.Red;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbRefresh.Checked == true)
                this.Refresh();
            
            tr = new Triangle(new Data.Point(160, 200, 0), new Data.Point(180, 300, 0), new Data.Point(250, 220, 0));            
            drawer.DrawTriangle(tr, color);

        }

        private void bClockRotation_Click(object sender, EventArgs e)
        {
            if (cbRefresh.Checked == true)
                this.Refresh();


            double angle = Convert.ToDouble(tbAngle.Text)*0.0174532925199;
            Data.Point centre = new Data.Point(Convert.ToDouble(tbRotX.Text), Convert.ToDouble(tbRotY.Text), Convert.ToDouble(tbRotZ.Text));
            Data.Point axis = new Data.Point(0, 0, 1);
            tr = rotator.RotateTriangle(tr, axis, angle, centre);
            drawer.DrawTriangle(tr, color);
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void bLeftMoving_Click(object sender, EventArgs e)
        {
            if (cbRefresh.Checked == true)
                this.Refresh();

            tr = mover.RelocateTriangle(tr, new Vector(-20, 0, 0));
            drawer.DrawTriangle(tr, color);
           
        }

        private void bRightMoving_Click(object sender, EventArgs e)
        {
            if (cbRefresh.Checked == true)
                this.Refresh();

            tr = mover.RelocateTriangle(tr, new Vector(20, 0, 0));
            drawer.DrawTriangle(tr, color);
        }

        private void bDownMoving_Click(object sender, EventArgs e)
        {
            if (cbRefresh.Checked == true)
                this.Refresh();


            tr = mover.RelocateTriangle(tr, new Vector(0, 20, 0));
            drawer.DrawTriangle(tr, color);
        }

        private void bUpMoving_Click(object sender, EventArgs e)
        {
            if (cbRefresh.Checked == true)
                this.Refresh();

            tr = mover.RelocateTriangle(tr, new Vector(0, -20, 0));
            drawer.DrawTriangle(tr, color);
        }

        private void bMover_Click(object sender, EventArgs e)
        {
            if (cbRefresh.Checked == true)
                this.Refresh();

            Vector move = new Vector(Convert.ToDouble(tbMovX.Text), Convert.ToDouble(tbMovY.Text), Convert.ToDouble(tbMovZ.Text));
            tr = mover.RelocateTriangle(tr, move);
            drawer.DrawTriangle(tr, color);
        }

        private void bStretch_Click(object sender, EventArgs e)
        {
            if (cbRefresh.Checked == true)
                this.Refresh();

            Vector coef = new Vector(Convert.ToDouble(tbStrX.Text), Convert.ToDouble(tbStrY.Text), Convert.ToDouble(tbStrZ.Text));
            Data.Point stretch = new Data.Point(tr.Centre.X, tr.Centre.Y, tr.Centre.Z);
            tr = stretcher.StretchTriangle(tr, coef, stretch);
            drawer.DrawTriangle(tr, color);         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbRotX.Text = tr.Centre.X.ToString();
            tbRotY.Text = tr.Centre.Y.ToString();
            tbRotZ.Text = tr.Centre.Z.ToString();
        }

        private void ColorChange(object sender, EventArgs e)
        {
            if (rbBlue.Checked == true)
                color = Color.Blue;
            else
                if (rbGreen.Checked == true)
                color = Color.ForestGreen;
            else
                if (rbPurple.Checked == true)
                color = Color.Violet;
            else
                if (rbRed.Checked == true)
                color = Color.DarkRed;
            else
                if (rbYellow.Checked == true)
                color = Color.Yellow;
        }
    }
}
