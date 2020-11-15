using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorRed
{
	abstract class Figure
	{
		public RectangleF BoundingBox { get; set; }
		public Figure (RectangleF bbox)
		{
			BoundingBox = bbox;
		}
		protected List<PointF> FConnectionPoints = new List<PointF>();
		public IReadOnlyList<PointF> ConnectionPoints { get => FConnectionPoints; }

		public PointF ToGlobal(PointF local) { }

		public PointF ToLocal(PointF global) { }

		public abstract void Draw(System.Drawing.Graphics canvas);

	}

}
