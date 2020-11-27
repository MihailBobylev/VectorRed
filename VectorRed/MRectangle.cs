using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorRed
{
	class MRectangle : Figure
	{
		public MRectangle(RectangleF bbox) : base(bbox)
		{
			Outline = new Pen(Color.Black);
			Filling = Brushes.Red;
			Text = "dasdas";
			Font = SystemFonts.DefaultFont;
		}

		public override void Draw(Graphics canvas)
		{
			canvas.FillRectangle(Filling, BoundingBox);
			canvas.DrawRectangle(Outline, Rectangle.Round(BoundingBox));
			canvas.DrawString(Text, Font, Brushes.Black, BoundingBox);
		}
	}
}
