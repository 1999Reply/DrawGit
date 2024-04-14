using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawGit
{
    public partial class frmRectangle1 : Form
    {
        private bool isCreate = true;
        private bool isMDown = false;
        Point firstPoint = new Point(0, 0);
        Point secondPoint = new Point(0, 0);
        double sX = 1;
        double sY = 1;
        public frmRectangle1()
        {
            InitializeComponent();
            Bitmap img = new Bitmap("pexels-razvan-vilt-20784651.jpg");
            sX = img.Width * 1.0 / pictureBox1.Width;
            sY = img.Height * 1.0 / pictureBox1.Height;
            pictureBox1.Image = img;
        }

        private void btnGenRoi_Click(object sender, EventArgs e)
        {
            btnGenRoi.Enabled = false;
            isCreate = true;

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (isCreate)
            {
                isMDown = true;
                int x = (int)(e.X * 1);
                int y = (int)(e.Y * 1);
                firstPoint = new Point(x, y);


            }
            else
            {

            }
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(isCreate && isMDown)
            {
                int x = (int)(e.X * 1);
                int y = (int)(e.Y * 1);
                secondPoint = new Point(x, y);
                // TÌm xem đâu là top left
                int x1 = -1;
                int y1 = -1;
                if(firstPoint.X < secondPoint.X)
                {
                    x1 = firstPoint.X;
                }
                else
                {
                    x1 = secondPoint.X;
                }
                if(firstPoint.Y < secondPoint.Y)
                {
                    y1 = firstPoint.Y;
                }
                else
                {
                    y1 = secondPoint.Y;
                }
                
                
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if(isCreate && isMDown)
            {
                int x1 = -1;
                int y1 = -1;
                if (firstPoint.X < secondPoint.X)
                {
                    x1 = firstPoint.X;
                }
                else
                {
                    x1 = secondPoint.X;
                }
                if (firstPoint.Y < secondPoint.Y)
                {
                    y1 = firstPoint.Y;
                }
                else
                {
                    y1 = secondPoint.Y;
                }
                int w1 = Math.Abs(firstPoint.X - secondPoint.X);
                int h1 = Math.Abs(firstPoint.Y - secondPoint.Y);
                e.Graphics.DrawRectangle(new Pen(Color.Red, 1), new Rectangle(x1, y1, w1, h1));
            }
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMDown = false;
            //isCreate = false;
        }
    }
}
