using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorRed
{
	[Serializable]
	public abstract class Figure : IHasOutline, IHasFilling, IHasText
	{
		public Color ColorPen { get; set; }
		public Color ColorBrush { get; set; }
		public RectangleF BoundingBox { get; set; }
		public Figure (RectangleF bbox)
		{
			BoundingBox = bbox;
		}
		protected List<PointF> FConnectionPoints = new List<PointF>() 
		{ 
			new PointF(0, 0),
			new PointF(0.5f, 0),
			new PointF(1, 0),
			new PointF(1, 0.5f),
			new PointF(1, 1),
			new PointF(0.5f, 1),
			new PointF(0, 1),
			new PointF(0, 0.5f),
		};
		public IReadOnlyList<PointF> ConnectionPoints { get => FConnectionPoints; }
		public Pen Outline { get=> new Pen(ColorPen); }
		public Brush Filling { get => new SolidBrush(ColorBrush);}
		public Font Font { get; set; }
		public string Text { get; set; }

		public PointF ToGlobal(PointF local) 
		{
			float x = BoundingBox.X + local.X * BoundingBox.Width;
			float y = BoundingBox.Y + local.Y * BoundingBox.Height;
			return new PointF(x,y);
		}

		public PointF ToLocal(PointF global) 
		{
			float x = (global.X - BoundingBox.X) / BoundingBox.Width;
			float y = (global.Y - BoundingBox.Y) / BoundingBox.Height;
			return new PointF(x, y);
		}

		public abstract void Draw(BufferedGraphics canvas);

		public void Selected(BufferedGraphics canvas)
		{
			canvas.Graphics.DrawRectangles(new Pen(Color.Blue), new RectangleF[] { new RectangleF(BoundingBox.X - 3, BoundingBox.Y - 3, BoundingBox.Width + 6, BoundingBox.Height + 6) });
		}

	}
}
