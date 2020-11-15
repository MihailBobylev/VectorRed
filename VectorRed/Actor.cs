using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorRed
{
	class Actor : Figure
	{
		public Actor(RectangleF bbox) : base(bbox)
		{
		}

		public override void Draw(Graphics canvas)
		{
			throw new NotImplementedException();
		}
	}
}
