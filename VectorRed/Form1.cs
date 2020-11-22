using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorRed
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}

		Point PrevPoint;
		Point CurrentPoint;
		bool press = false;
		Figure figure;
		

		private void btnFill_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			press = true;
			if (press)
			{
				PrevPoint = e.Location;
				
			}
		}

		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			if (press)
			{
				CurrentPoint = e.Location;
			}
			press = false;
			figure.BoundingBox = new RectangleF(PrevPoint.X, PrevPoint.Y, CurrentPoint.X - PrevPoint.X, CurrentPoint.Y - PrevPoint.Y);
			Graphics canvas = canvasBox.CreateGraphics();
			figure.Draw(canvas);
		}

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{

		}

		private void btnRectangle_Click(object sender, EventArgs e)
		{
			figure = new MRectangle(new RectangleF(0,0,0,0));
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}
	}
}
