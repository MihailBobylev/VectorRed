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
		bool figureDraw = false;
		bool figureMoved = false;
		bool figureClick = false;

		float x;
		float y;

		Graphics canvas;
		Figure figure;
		Figure movedFigure;
		public static Diagramm diagramm = new Diagramm();
		

		private void btnFill_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			press = true;
			PrevPoint = e.Location;
			if (figureClick)
			{
				foreach (Figure f in diagramm.Content.Figures)
				{
					if (f.BoundingBox.Contains(PrevPoint))
					{
						switch (f) {
							case MRectangle m:
								tText.Text = f.Text;
								nWidth.Value = (decimal)f.BoundingBox.Width;
								nHeight.Value = (decimal)f.BoundingBox.Height;
								btnColorOutline.FlatAppearance.BorderColor = f.Outline.Color;
								SolidBrush solidBrush = (SolidBrush)f.Filling;
								btnFill.FlatAppearance.BorderColor = solidBrush.Color;
								break;
							case Actor m:
								tText.Text = f.Text;
								nWidth.Value = (decimal)f.BoundingBox.Width;
								nHeight.Value = (decimal)f.BoundingBox.Height;
								btnColorOutline.FlatAppearance.BorderColor = f.Outline.Color;
								Block(f);
								break;
							case Ellipse m:
								tText.Text = f.Text;
								nWidth.Value = (decimal)f.BoundingBox.Width;
								nHeight.Value = (decimal)f.BoundingBox.Height;
								btnColorOutline.FlatAppearance.BorderColor = f.Outline.Color;
								solidBrush = (SolidBrush)f.Filling;
								btnFill.FlatAppearance.BorderColor = solidBrush.Color;
								break;
						}
					}
				}
			}
		}

		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			if (press && figureDraw)
			{
				CurrentPoint = e.Location;
				SwapPoint();
				figure.BoundingBox = new RectangleF(PrevPoint.X, PrevPoint.Y, CurrentPoint.X - PrevPoint.X, CurrentPoint.Y - PrevPoint.Y);
				figure.Draw(canvas);
				diagramm.Content.Figures.Add(figure);
			}
			else if (press && figureMoved)
			{
				CurrentPoint = e.Location;

				foreach(Figure f in diagramm.Content.Figures)
				{
					if (f.BoundingBox.Contains(PrevPoint))
					{
						Color c = f.Outline.Color;
						Brush b = f.Filling;

						f.Remove(canvas);

						f.BoundingBox = new RectangleF(CurrentPoint.X, CurrentPoint.Y, f.BoundingBox.Width, f.BoundingBox.Height);
						f.Outline.Color = c;
						f.Filling = b;
						f.Draw(canvas);
					}
				}

			}
			press = false;
			
		}

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{

		}

		private void btnRectangle_Click(object sender, EventArgs e)
		{
			figureMoved = false;
			figureDraw = true;
			figureClick = false;
			figure = new MRectangle(new RectangleF(0,0,0,0));
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			canvas = canvasBox.CreateGraphics();
		}

		private void btnEllipse_Click(object sender, EventArgs e)
		{
			figureMoved = false;
			figureDraw = true;
			figureClick = false;
			figure = new Ellipse(new RectangleF(0, 0, 0, 0));

		}

		private void btnConnection_Click(object sender, EventArgs e)
		{

		}

		private void btnActor_Click(object sender, EventArgs e)
		{
			figureMoved = false;
			figureDraw = true;
			figureClick = false;
			figure = new Actor(new RectangleF(0, 0, 0, 0));
		}

		private void btnCursor_Click(object sender, EventArgs e)
		{
			figure = null;
			figureDraw = false;
			figureMoved = false;
			figureClick = true;
		}


		private void Block(Figure figure)
		{
			IHasOutline inter = figure as IHasOutline;
			if (inter is null)
			{
				btnColorOutline.Enabled = false;
			}
			else
			{
				btnColorOutline.Enabled = true;
			}

			IHasFilling inter1 = figure as IHasFilling;
			if (inter1 == null)
			{
				btnFill.Enabled = false;
			}
			else
			{
				btnFill.Enabled = true;
			}
		}

		private void SwapPoint()
		{
			int tmp;

			if(PrevPoint.X > CurrentPoint.X)
			{
				tmp = CurrentPoint.X;
				CurrentPoint.X = PrevPoint.X;
				PrevPoint.X = tmp;
			}
			if(PrevPoint.Y > CurrentPoint.Y)
			{
				tmp = CurrentPoint.Y;
				CurrentPoint.Y = PrevPoint.Y;
				PrevPoint.Y = tmp;
			}
		}

		private void btnMovedCursor_Click(object sender, EventArgs e)
		{
			figureMoved = true;
			figureDraw = false;
			figureClick = false;
			figure = null;
		}

		private void btnColorOutline_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.Cancel)
				return;
			btnColorOutline.FlatAppearance.BorderColor = colorDialog1.Color;
		}

		private void btnFill_Click_1(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.Cancel)
				return;
			btnFill.FlatAppearance.BorderColor = colorDialog1.Color;
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			if(figureClick)
				foreach (Figure f in diagramm.Content.Figures)
				{
					if (f.BoundingBox.Contains(PrevPoint))
					{
						f.Remove(canvas);
						f.BoundingBox = new RectangleF(f.BoundingBox.X, f.BoundingBox.Y, (float)nWidth.Value, (float)nHeight.Value);
						f.Outline.Color = btnColorOutline.FlatAppearance.BorderColor;
						f.Filling = new SolidBrush(btnFill.FlatAppearance.BorderColor);
						f.Text = tText.Text;
						f.Draw(canvas);
					}
				}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			canvas.Clear(canvasBox.BackColor);
			diagramm.Clear();
		}
	}
}
