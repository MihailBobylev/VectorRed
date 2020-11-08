using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorRed
{
	class Elipse : Figure
	{
		private System.Drawing.Rectangle elipse = new System.Drawing.Rectangle();
		public Elipse(Color color, Point leftPoint, Point rightPoint, string text) : base(color, leftPoint, rightPoint, text)
		{
		}

		public override void Draw()
		{
			throw new NotImplementedException();
		}
	}
}
