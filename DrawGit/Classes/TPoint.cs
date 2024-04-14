using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawGit.Classes
{
    public class TPoint
    {
        private Vector3 position;

        private double thickness;

        public double Thickness { get => thickness; set => thickness = value; }
        public Vector3 Position { get => position; set => position = value; }

        public TPoint()
        {
            this.Thickness = 0.0;
            this.Position = Vector3.Zero;
        }

        public TPoint(Vector3 position)
        {
            this.Thickness = 0.0;
            this.Position = position;
        }
    }
}
