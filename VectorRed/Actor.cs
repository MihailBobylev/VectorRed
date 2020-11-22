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

		public Pen Outline { get => Outline; set { Outline = value; } }
		public Brush Filling { get => Filling; set { Filling = value; } }

		public override void Draw(Graphics canvas)
		{
            //разметка
            float centerX = BoundingBox.X + BoundingBox.Width / 2;//Середина рисунка по вертикали
            //голова
            float headD = (((BoundingBox.Height < BoundingBox.Width) ? BoundingBox.Height : BoundingBox.Width) / 10 * 3);
            float headX = BoundingBox.X + BoundingBox.Width / 2 - headD / 2;

            float headY = BoundingBox.Y;
            //туловише
            float bodyY = BoundingBox.Y + BoundingBox.Height / 10 * 6;
            //руки
            float handY = BoundingBox.Y + BoundingBox.Height / 10 * 4;

            canvas.DrawEllipse(Outline, headX, headY, headD, headD);//голова
            canvas.DrawLine(Outline, centerX, BoundingBox.Y + headD, centerX, bodyY);//туловище
            canvas.DrawLine(Outline, BoundingBox.X, handY, BoundingBox.X + BoundingBox.Width, handY);//руки
            canvas.DrawLine(Outline, BoundingBox.X, BoundingBox.Y + BoundingBox.Height, centerX, bodyY);//левая нога
            canvas.DrawLine(Outline, centerX, bodyY, BoundingBox.X + BoundingBox.Width, BoundingBox.Y + BoundingBox.Height);//правая нога
        }
	}
}
