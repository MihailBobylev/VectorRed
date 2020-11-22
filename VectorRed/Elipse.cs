﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorRed
{
	class Ellipse : Figure, IHasOutline, IHasFilling
	{

		public Ellipse(RectangleF bbox) : base(bbox)
		{
		}

		public Pen Outline { get => Outline; set { Outline = value; } }
		public Brush Filling { get => Filling; set { Filling = value; } }

		public override void Draw(Graphics canvas)
		{
			canvas.DrawEllipse(Outline, Rectangle.Round(BoundingBox));
		}
	}
}
