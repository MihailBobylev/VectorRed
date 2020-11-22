using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorRed
{
	class MRectangle : Figure, IHasOutline, IHasFilling
	{

		public MRectangle(RectangleF bbox) : base(bbox)
		{
		}

		public Brush Filling { get => Filling; set { Filling = value; } }
		public Pen Outline { get => Outline; set { Outline = value; } }

		public override void Draw(Graphics canvas)
		{
			//Pen pen = new Pen(Color.Black);
			canvas.DrawRectangle(pen, Rectangle.Round(BoundingBox));
		}
	}
}
