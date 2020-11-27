using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorRed
{
	class Ellipse : Figure, IHasOutline
	{
		public Ellipse(RectangleF bbox) : base(bbox)
		{
			Outline = new Pen(Color.Black);
		}

		public override void Draw(Graphics canvas)
		{
			canvas.FillEllipse(Filling, BoundingBox);
			canvas.DrawEllipse(Outline, Rectangle.Round(BoundingBox));
		}
	}
}
