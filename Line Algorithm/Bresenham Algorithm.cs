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
    public partial class Bresenham_Algorithm : Form
    {
        public Bresenham_Algorithm()
        {
            InitializeComponent();
        }

        private void Bresenham_Algorithm_Load(object sender, EventArgs e)
        {

        }

        private void Draw_Click(object sender, EventArgs e)
        {
            var x1 = int.Parse(Tawalx.Text);
            var y1 = int.Parse(Tawaly.Text);
            var x2 = int.Parse(Takhirx.Text);
            var y2 = int.Parse(Takhiry.Text);

            Point P1 = new Point(x1, y1);
            Point P2 = new Point(x2, y2);

            BRESENHAM(P1, P2);

         
        }
        public void BRESENHAM(Point P1, Point P2)
        {
            double x1, y1, x2, y2;

            Bitmap pict = new Bitmap(this.Width, this.Height);


            double dx = P2.X - P1.X;
            double dy = P2.Y - P2.Y;

            double p = 2 * (dx - dy);

            double C1 = 2 * dy;

            double C2 = 2 * dy - dx;
            double x, y;

            x = x1 = P1.X;
            y = y1 = P1.Y;

            x2 = P2.X;
            y2 = P2.Y;

            while (x < x2)
            {
                if (p < 0 )
                {
                    p += C1;
                }
                else
                {
                    p += C2;
                    y += 1;
                }
                x++;
                pict.SetPixel((int)x, (int)y, Color.BlanchedAlmond);
            }
            
            Canva.Image = pict;
                
        }
    }
}
