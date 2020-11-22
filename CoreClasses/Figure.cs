using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorRed
{
	public abstract class Figure
	{
		public RectangleF BoundingBox { get; set; }
		public Figure (RectangleF bbox)
		{
			BoundingBox = bbox;
		}
		protected List<PointF> FConnectionPoints = new List<PointF>();
		public IReadOnlyList<PointF> ConnectionPoints { get => FConnectionPoints; }

		public PointF ToGlobal(PointF local) 
		{
			float x = (BoundingBox.X + local.X) * BoundingBox.Width;
			float y = (BoundingBox.Y + local.Y) * BoundingBox.Height;
			return new PointF(x,y);
		}

		public PointF ToLocal(PointF global) 
		{
			float x = (global.X - BoundingBox.X) / BoundingBox.Width;
			float y = (global.Y - BoundingBox.Y) / BoundingBox.Height;
			return new PointF(x, y);
		}

		public abstract void Draw(Graphics canvas);

	}

}
