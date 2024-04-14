using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DrawGit.Classes
{
    public static class GraphicExtension
    {
        private static float Height = 0;

        public static void SetParameters(this System.Drawing.Graphics g, float height)
        {
            Height = height;
        }

        public static void SetTransform(this System.Drawing.Graphics g)
        {
            //g.PageUnit = GraphicsUnit.Millimeter;
            //g.TranslateTransform(0, Height);
            //g.ScaleTransform(1.0f, -1.0f);
        }

        public static void DrawPoint(this System.Drawing.Graphics g, System.Drawing.Pen p, TPoint point)
        {
            g.SetTransform();
            PointF pointF = point.Position.ToPointF;
            g.DrawEllipse(p, pointF.X - 1, pointF.Y - 1, 2, 2);
            g.ResetTransform();

        }

        public static void DrawLine(this Graphics g, Pen pen, TLine line)
        {
            g.SetTransform();
            g.DrawLine(pen, line.StartPoint.ToPointF,line.EndPoint.ToPointF);
            g.ResetTransform();
        }
    }
}
