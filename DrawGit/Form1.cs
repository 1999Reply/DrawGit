using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawGit.Classes;

namespace DrawGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double DPI
        {
            get
            {
                using(var g = CreateGraphics())
                {
                    return g.DpiX;
                }
            }
        }

        List<TPoint> points = new List<TPoint>();
        private bool active_drawing = false;
        private int drawIndex = -1;
        private Vector3 currPosition = Vector3.Zero;
        List<TLine> lines = new List<TLine>();
        int clicksNum = 1;
        Vector3 firstPoint = new Vector3 (0, 0, 0); 
        private Vector3 PointToDeCarter(Point p)
        {
            return new Vector3(p.X, pbDraw.Height - p.Y);
        }

        private float PixelToMM(float pix)
        {
            return (float)(pix * 25.4 / DPI);
        }
        private void pbDraw_MouseMove(object sender, MouseEventArgs e)
        {
            currPosition = new Vector3(e.X, e.Y, 0);
            label1.Text = string.Format("{0},{1}", e.Location.X, e.Location.Y);
            pbDraw.Refresh();
        }

        private void pbDraw_Paint(object sender, PaintEventArgs e)
        {
            float k = PixelToMM(pbDraw.Height);
            e.Graphics.SetParameters(k);

            // draw all points
            if(points.Count > 0)
            {
                foreach(TPoint point in points)
                {
                    e.Graphics.DrawPoint(new Pen(Color.Red, 6), point);
                    //using (Graphics g = CreateGraphics())
                    //{
                    //    g.SetTransform();
                    //    e.Graphics.DrawEllipse(new Pen(Color.Red, 1), (float)point.Position.X, pbDraw.Height - (float)point.Position.Y, 2, 2);
                    //    g.ResetTransform();
                    //}


                }
            }
            // draw all lines
            if(lines.Count > 0)
            {
                foreach (TLine line in lines)
                {
                    e.Graphics.DrawPoint(new Pen(Color.Red, 6), new TPoint(new Vector3(line.StartPoint.X,line.StartPoint.Y)));
                    e.Graphics.DrawPoint(new Pen(Color.Red, 6), new TPoint(new Vector3(line.EndPoint.X, line.EndPoint.Y)));
                    e.Graphics.DrawLine(new Pen(Color.Blue, 2), line);
                    TLine l1 = new TLine(firstPoint, currPosition);
                    e.Graphics.DrawLine(new Pen(Color.Blue), l1);
                    
                }
            }
            switch (drawIndex)
            {
                case 1:
                    if(clicksNum == 2)
                    {
                        
                    }
                    TLine l1 = new TLine(firstPoint, currPosition);
                    e.Graphics.DrawLine(new Pen(Color.Blue), l1);
                    break;
            }
        }

        private void pbDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (active_drawing)
                {
                    switch (drawIndex)
                    {
                        case 0:
                            points.Add(new TPoint(new Vector3(e.X,e.Y)));
                            break;

                        case 1:
                            points.Add(new TPoint(new Vector3(e.X, e.Y)));
                            switch (clicksNum)
                            {
                                case 1:
                                    //lines.Add(new TLine(firstPoint, currPosition));
                                    firstPoint = currPosition;
                                    
                                    
                                    clicksNum++;
                                    break;
                                 case 2:

                                    lines.Add(new TLine(firstPoint, currPosition));
                                    firstPoint = currPosition;
                                    //clicksNum = 1;  

                                    break;
                            }

                            break;

                    }
                    pbDraw.Refresh();
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawIndex = 0;
            active_drawing = true;
            pbDraw.Cursor = Cursors.Cross;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drawIndex = 1;
            active_drawing = true;
            pbDraw.Cursor = Cursors.Cross;
        }
    }
}
