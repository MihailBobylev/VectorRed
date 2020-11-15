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

		private System.Drawing.Rectangle elipse = new System.Drawing.Rectangle();
		public Ellipse(RectangleF bbox) : base(bbox)
		{
		}

		public Pen Outline { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public Brush Filling { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public override void Draw(Graphics canvas)
		{
			throw new NotImplementedException();
		}


	}
}
