using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawGit.Classes
{
    public class TLine
    {
		private Vector3 startPoint;

		public Vector3 StartPoint
		{
			get { return startPoint; }
			set { startPoint = value; }
		}

		private Vector3 endPoint;

		public Vector3 EndPoint
		{
			get { return endPoint; }
			set { endPoint = value; }
		}

		private double thickness;

		public double Thickness
		{
			get { return thickness; }
			set { thickness = value; }
		}

		public TLine(Vector3 startPoint, Vector3 endPoint, double thickness = 0.0)
		{
			this.startPoint = startPoint;
			this.endPoint = endPoint;
			this.thickness = thickness;
		}

		public TLine() : this(Vector3.Zero, Vector3.Zero)
		{

		}
	}
}
