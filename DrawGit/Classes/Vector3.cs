using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawGit.Classes
{
    public class Vector3
    {
		private double x;

		public double X
		{
			get { return x; }
			set { x = value; }
		}

		private double y;

		public double Y
		{
			get { return y; }
			set { y = value; }
		}

		private double z;
        public double Z
        {
            get { return z; }
            set { z = value; }
        }

		public Vector3(double x, double y)
		{
			this.X = x;
			this.Y = y;
			this.Z = 0.0;
		}

        public Vector3(double x, double y, double z):this(x,y)
        {
            this.Z = z;
        }

		public static Vector3 Zero
		{
			get { return new Vector3(0.0,0.0,0.0); }
		}

		public PointF ToPointF
		{
			get
			{
				return new PointF((float) x, (float)y);
			}
		}

    }
}
