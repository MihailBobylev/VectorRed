using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorRed
{
	class Rectangle : Figure 
	{
		private System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle();
		public Rectangle(Color color, Point leftPoint, Point rightPoint, String text): base(color, leftPoint, rightPoint, text)
		{ }
		public override void Draw()
		{
			throw new NotImplementedException();
		}
	}
}
