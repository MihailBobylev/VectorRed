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
		public Figure (Color color, Point leftPoint, Point rightPoint, String text)
		{
			Color = color;
			Text = text;
			LeftPoint = leftPoint;
			RightPoint = rightPoint;
		}
		public Color Color { get; set; }
		public String Text { get; set; }
		public Int16[] Options { get; set; }
		public Point LeftPoint { get; set; }
		public Point RightPoint { get; set; }
		public List<Point> ConnectionPoint { get; set; }

		public abstract void Draw();

	}

}
