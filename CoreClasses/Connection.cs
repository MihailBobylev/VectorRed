using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VectorRed
{

	public struct ConnectionEnd
	{
		Figure LinkedFigure;
		int PointIndex;
		PointF Coords;
		public ConnectionEnd(Figure fig, int idx) 
		{
			LinkedFigure = fig;
			PointIndex = idx;
			Coords = new PointF();
		}
		public ConnectionEnd(PointF p)
		{
			LinkedFigure = null;
			PointIndex = -1;
			Coords = p;
		}
		public PointF Target
		{
			get
			{
				if (LinkedFigure == null)
					return Coords;
				else
					return LinkedFigure.ToGlobal(LinkedFigure.ConnectionPoints[PointIndex]);
			}
		}
	}

	public class Connection : IHasOutline
	{
		public ConnectionEnd Start;
		public ConnectionEnd End;

		public Connection() { }
		public Pen Outline { get; set; }
		
	}
}
