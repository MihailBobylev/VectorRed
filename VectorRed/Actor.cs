using System; 
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorRed
{
    [Serializable]
    class Actor : Figure
    {
        public Actor(RectangleF bbox) : base(bbox)
		{
            ColorPen = Color.Black;
            ColorBrush = Color.White;
            Text = "dasdas";
            Font = SystemFonts.DefaultFont;
        }

		public override void Draw(BufferedGraphics canvas)
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

            canvas.Graphics.DrawEllipse(Outline, headX, headY, headD, headD);//голова
            canvas.Graphics.DrawLine(Outline, centerX, BoundingBox.Y + headD, centerX, bodyY);//туловище
            canvas.Graphics.DrawLine(Outline, BoundingBox.X, handY, BoundingBox.X + BoundingBox.Width, handY);//руки
            canvas.Graphics.DrawLine(Outline, BoundingBox.X, BoundingBox.Y + BoundingBox.Height, centerX, bodyY);//левая нога
            canvas.Graphics.DrawLine(Outline, centerX, bodyY, BoundingBox.X + BoundingBox.Width, BoundingBox.Y + BoundingBox.Height);//правая нога
            canvas.Graphics.DrawString(Text, Font, Brushes.Black, BoundingBox.X + BoundingBox.Width / 2, BoundingBox.Y + BoundingBox.Height);
        }
	}
}
