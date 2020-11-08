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
		public Actor(Color color, Point leftPoint, Point rightPoint, string text) : base(color, leftPoint, rightPoint, text)
		{
		}

		public override void Draw()
		{
			throw new NotImplementedException();
		}
	}
}
