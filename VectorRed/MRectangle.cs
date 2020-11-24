using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorRed
{
	class MRectangle : Figure, IHasOutline, IHasFilling, IHasText
	{

		Pen outline;
		String text;
		Font font;
		Brush brush;
		public MRectangle(RectangleF bbox) : base(bbox)
		{
			outline = new Pen(Color.Black);
			brush = Brushes.Red;
		}
		public Pen Outline { get => outline; set => outline = value; }
		public Brush Filling { get => brush; set => brush = value; }

		public Font Font { get => font; set => font = value; }
		public string Text { get => text; set => text = value; }

		public override void Draw(Graphics canvas)
		{
			canvas.DrawRectangle(Outline, Rectangle.Round(BoundingBox));
			Text = "Sdaadsad";
			Font = SystemFonts.DefaultFont;
			canvas.DrawString(Text, Font, Filling, BoundingBox);
		}
	}
}
