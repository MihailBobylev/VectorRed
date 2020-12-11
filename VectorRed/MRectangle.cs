using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorRed
{
	[Serializable]
	class MRectangle : Figure
	{
		public MRectangle(RectangleF bbox) : base(bbox)
		{
			ColorPen = Color.Black;
			ColorBrush = Color.White;
			Text = "dasdas";
			Font = SystemFonts.DefaultFont;
		}

		public override void Draw(BufferedGraphics canvas)
		{
			canvas.Graphics.FillRectangle(Filling, BoundingBox);
			canvas.Graphics.DrawRectangle(Outline, Rectangle.Round(BoundingBox));
			canvas.Graphics.DrawString(Text, Font, Brushes.Black, BoundingBox);
		
		}
	}
}
