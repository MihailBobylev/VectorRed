using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorRed
{
	class Ellipse : Figure, IHasOutline, IHasFilling
	{
		Pen outline;
		public Ellipse(RectangleF bbox) : base(bbox)
		{
			outline = new Pen(Color.Black);
		}

		public Pen Outline { get => outline; set { outline = value; } }
		public Brush Filling { get => Filling; set { Filling = value; } }

		public override void Draw(Graphics canvas)
		{
			canvas.DrawEllipse(Outline, Rectangle.Round(BoundingBox));
		}
	}
}
