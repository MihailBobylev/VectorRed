using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorRed
{
	class Rectangle : Figure, IHasOutline, IHasFilling
	{
		private System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle();
		public Rectangle(RectangleF bbox) : base(bbox)
		{ 
		}

		public Brush Filling { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public Pen Outline { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public override void Draw(Graphics canvas)
		{
			throw new NotImplementedException();
		}
	}
}
