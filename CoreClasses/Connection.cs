using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VectorRed
{

	[Serializable]
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

		public int Index { get => PointIndex; }

		public Figure Link { get => LinkedFigure; }

		public PointF Target
		{
			get
			{
				if (LinkedFigure == null)
					return Coords;
				else
				{
					Coords.X = LinkedFigure.ToGlobal(LinkedFigure.ConnectionPoints[PointIndex]).X;
					Coords.Y = LinkedFigure.ToGlobal(LinkedFigure.ConnectionPoints[PointIndex]).Y;
					return LinkedFigure.ToGlobal(LinkedFigure.ConnectionPoints[PointIndex]);
				}
			}
		}
	}

	[Serializable]
	public class Connection : IHasOutline
	{
		public ConnectionEnd Start;
		public ConnectionEnd End;
		public Connection() 
		{
			ColorPen = Color.Black;
		}

		public Color ColorPen { get; set; }
		public Pen Outline { get => new Pen(ColorPen); }

		public RectangleF BoundingBox 
		{
			get
			{
				Size size = new Size((int)Math.Abs(End.Target.X - Start.Target.X), (int)Math.Abs(End.Target.Y - Start.Target.Y));
				PointF point = new PointF();
				if (End.Target.X < Start.Target.X)
				{
					point.X = End.Target.X;
				}
				else point.X = Start.Target.X;
				if (End.Target.Y < Start.Target.Y)
				{
					point.Y = End.Target.Y;
				}
				else point.Y = Start.Target.Y;
				return new RectangleF(point, size);
			}
		
		}

		public void Draw(BufferedGraphics canvas) 
		{
			canvas.Graphics.DrawLine(Outline, Start.Target, End.Target);
		}
		
	}
}
