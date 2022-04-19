using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Line_Algorithm
{
    public partial class DDALine : Form
    {
        public DDALine()
        {
            InitializeComponent();
        }

        private void Draw_Click(object sender, EventArgs e)
        {
         
            var x1 = int.Parse(Tawal_X.Text);
            var y1 = int.Parse(TAwal_y.Text);
            var x2 = int.Parse(TAkhir_x.Text);
            var y2 = int.Parse(TAkhir_y.Text);

            Point P1 = new Point(x1, y1);
            Point P2 = new Point(x2, y2);

            DDALINE(P1, P2);
        }

        public void DDALINE(Point P1, Point P2)
        {
            //int k = 0;
            double x, y_inc, x_inc, y, x1, y1, steps;

            Bitmap p = new Bitmap(this.Width, this.Height);

            double Dx = P2.X - P1.X;
            double Dy = P2.Y - P1.Y;

            if (Dx > Dy)
            {
                steps = Dx;
            }
            else
            {
                steps = Dy;
            }

            x_inc = Dx / steps;
            y_inc = Dy / steps;


            x = x1 = P1.X;
            y = y1 = P2.Y;


            for (var k = 1; k <= steps; k++)
            {
                x = x + x_inc;
                x = Math.Round(x, 0); 

                y = y + y_inc;
                y = Math.Round(x, 0);

                p.SetPixel((int)x,(int)y, Color.DarkRed); 
            }

            Canvas.Image = p;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
