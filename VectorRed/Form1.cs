using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

			//canvasBox.ContextMenuStrip = ContextMenuStrip;

			ContextMenu cm = new ContextMenu();
			MenuItem copy = new MenuItem("Копировать");
			copy.Click += Copy_Click;
			MenuItem paste = new MenuItem("Вставить");
			paste.Click += Paste_Click;
			cm.MenuItems.AddRange(new MenuItem[] { copy, paste });
			canvasBox.ContextMenu = cm;

		}

		

		public static Diagramm diagramm;

		Point PrevPoint;
		Point CurrentPoint;

		bool press = false;
		bool figureDraw = false;
		bool figureMoved = false;
		bool figureClick = false;
		bool connectionDraw = false;
		bool delete = false;
		bool select = false;
		bool selectMove = false;

		bool connectionDown = false;

		Graphics canvas;
		BufferedGraphicsContext bufferedGraphicsContext;
		BufferedGraphics bufferedGraphics;

		Figure figure;
		Figure drawFigure;

		Connection connection;


		private void Form1_Load(object sender, EventArgs e)
		{
			canvas = canvasBox.CreateGraphics();
			bufferedGraphicsContext = new BufferedGraphicsContext();
			bufferedGraphics = bufferedGraphicsContext.Allocate(canvas, canvasBox.DisplayRectangle);
			diagramm = new Diagramm();
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
						figure = f;
						switch (f) {
							case MRectangle m:
								tText.Text = f.Text;
								nWidth.Value = (decimal)f.BoundingBox.Width;
								nHeight.Value = (decimal)f.BoundingBox.Height;
								btnColorOutline.FlatAppearance.BorderColor = f.ColorPen;
								btnFill.FlatAppearance.BorderColor = f.ColorBrush;
								break;
							case Actor m:
								tText.Text = f.Text;
								nWidth.Value = (decimal)f.BoundingBox.Width;
								nHeight.Value = (decimal)f.BoundingBox.Height;
								btnColorOutline.FlatAppearance.BorderColor = f.ColorPen;
								Block(f);
								break;
							case Ellipse m:
								tText.Text = f.Text;
								nWidth.Value = (decimal)f.BoundingBox.Width;
								nHeight.Value = (decimal)f.BoundingBox.Height;
								btnColorOutline.FlatAppearance.BorderColor = f.ColorPen;
								btnFill.FlatAppearance.BorderColor = f.ColorBrush;
								break;
						}
					}
				}
			}
			if (connectionDraw)
			{
				foreach (Figure f in diagramm.Content.Figures)
				{
					if (f.BoundingBox.Contains(PrevPoint))
					{
						double len = 2;
						PointF hook = f.ToLocal(PrevPoint);
						int idx = -1;
						for(int i = 0; i < f.ConnectionPoints.Count; i++)
						{
							if(LengthLine(f.ConnectionPoints[i], hook) < len)
							{
								idx = i;
								len = LengthLine(f.ConnectionPoints[i], hook);
							}
													
						}
						connection.Start = new ConnectionEnd(f, idx);
						connectionDown = true;
					}
				}
			}
			if (delete)
			{
				int idx = -1;
				bool stop = false;
				for(int i = 0; i < diagramm.Content.Figures.Count; i++)
				{
					if (diagramm.Content.Figures[i].BoundingBox.Contains(CurrentPoint))
					{
						idx = i;
					}
				}
				if (idx != -1)
				{
					diagramm.Content.Figures.RemoveAt(idx);
					stop = true;
				}
				
				for (int i = 0; i < diagramm.Content.Connections.Count; i++)
				{
					if (diagramm.Content.Connections[i].BoundingBox.Contains(CurrentPoint) )
					{
						idx = i;
					}
				}
				if (idx != -1 && !stop)
					diagramm.Content.Connections.RemoveAt(idx);
			}
			UpdateScreen();

		}
		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			CurrentPoint = e.Location;

			if (press && figureDraw)
			{
				SwapPoint();
				
				switch (figure) 
				{
					case MRectangle m:
						figure = new MRectangle(new RectangleF(PrevPoint.X, PrevPoint.Y, CurrentPoint.X - PrevPoint.X, CurrentPoint.Y - PrevPoint.Y));
						break;
					case Actor m:
						figure = new Actor(new RectangleF(PrevPoint.X, PrevPoint.Y, CurrentPoint.X - PrevPoint.X, CurrentPoint.Y - PrevPoint.Y));
						break;
					case Ellipse m:
						figure = new Ellipse(new RectangleF(PrevPoint.X, PrevPoint.Y, CurrentPoint.X - PrevPoint.X, CurrentPoint.Y - PrevPoint.Y));
						break;
				}
				diagramm.Content.Figures.Add(figure);
			}
			if (press && figureMoved)
			{
				foreach(Figure f in diagramm.Content.Figures)
				{
					if (f.BoundingBox.Contains(PrevPoint))
					{
						f.BoundingBox = new RectangleF(CurrentPoint.X, CurrentPoint.Y, f.BoundingBox.Width, f.BoundingBox.Height);
					}
				}

			} 
			if (press && connectionDraw)
			{
				foreach (Figure f in diagramm.Content.Figures)
				{
					if (f.BoundingBox.Contains(CurrentPoint))
					{
						double len = 2.0;
						PointF hook = f.ToLocal(CurrentPoint);
						int idx = -1;
						for (int i = 0; i < f.ConnectionPoints.Count; i++)
						{
							if (LengthLine(f.ConnectionPoints[i], hook) < len)
							{
								idx = i;
								len = LengthLine(f.ConnectionPoints[i], hook);
							}

						}
						connection.End = new ConnectionEnd(f, idx);					
					}
					else
					{
						connection.End = new ConnectionEnd(CurrentPoint);
					}
				}
				Connection c = new Connection();
				c.Start = connection.Start;
				c.End = connection.End;
				diagramm.Content.Connections.Add(c);

			}
			if (press && figureMoved && selectMove)
			{
				float x = CurrentPoint.X - PrevPoint.X;
				float y = CurrentPoint.Y - PrevPoint.Y;
				List<Figure> l = diagramm.Content.Figures;

				foreach (Figure f in diagramm.Selection.Figures)
				{	
					f.BoundingBox = new RectangleF(f.BoundingBox.X + x, f.BoundingBox.Y + y, f.BoundingBox.Width, f.BoundingBox.Height);
				}
				selectMove = false;
				diagramm.ClearSelection();
			}
			UpdateScreen();
			if (press && select && !selectMove)
			{
				SwapPoint();
				RectangleF selected = new RectangleF(PrevPoint.X, PrevPoint.Y, CurrentPoint.X - PrevPoint.X, CurrentPoint.Y - PrevPoint.Y);
				foreach (Figure f in diagramm.Content.Figures)
				{
					if (selected.Contains(f.BoundingBox))
					{
						f.Selected(bufferedGraphics);
						bufferedGraphics.Render(canvas);
						diagramm.Selection.Figures.Add(f);
					}
				}
				foreach (Connection c in diagramm.Content.Connections)
				{
					if (selected.Contains(c.BoundingBox))
						diagramm.Selection.Connections.Add(c);
				}
				selectMove = true;
			}
			if (figureClick && figure != null)
			{
				figure.Selected(bufferedGraphics);
				bufferedGraphics.Render(canvas);
			}
			press = false;

			
		}
		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			CurrentPoint = e.Location;
			if (press && figureDraw)
			{				
				UpdateScreen();
				drawFigure.BoundingBox = new RectangleF(PrevPoint.X, PrevPoint.Y, CurrentPoint.X - PrevPoint.X, CurrentPoint.Y - PrevPoint.Y);
				bufferedGraphics.Graphics.Clear(canvasBox.BackColor);
				drawFigure.Draw(bufferedGraphics);
				bufferedGraphics.Render(canvas);
			}
			if(press && connectionDraw && connectionDown)
			{
				UpdateScreen();
				connection.End = new ConnectionEnd(CurrentPoint);
				connection.Draw(bufferedGraphics);
				bufferedGraphics.Render(canvas);
			}
		}


		private void Copy_Click(object sender, EventArgs e)
		{
			Clipboard.Clear();
			DataObject dataObject = new DataObject();
			dataObject.SetData(diagramm.Selection);
			Clipboard.SetDataObject(dataObject);
		}
		private void Paste_Click(object sender, EventArgs e)
		{
			IDataObject dataObject = Clipboard.GetDataObject();
			Type type = typeof(Content);
			diagramm.Selection = (Content)dataObject.GetData(type);

			if (diagramm.Selection.Figures.Count > 0 || diagramm.Selection.Connections.Count > 0)
			{
				float x = CurrentPoint.X - diagramm.Selection.Figures[1].BoundingBox.X;
				float y = CurrentPoint.Y - diagramm.Selection.Figures[1].BoundingBox.Y;

				foreach (Figure f in diagramm.Selection.Figures)
				{

					foreach (Connection c in diagramm.Selection.Connections)
					{
						if (c.Start.Link.Equals(f))
							c.Start = new ConnectionEnd(f, c.Start.Index);
						if (c.End.Link.Equals(f))
							c.End = new ConnectionEnd(f, c.End.Index);
					}
					PointF p = new PointF(f.BoundingBox.X + x, f.BoundingBox.Y + y);
					f.BoundingBox = new RectangleF(p, f.BoundingBox.Size);
				}
				diagramm.Content.Connections.AddRange(diagramm.Selection.Connections);
				diagramm.Content.Figures.AddRange(diagramm.Selection.Figures);

				diagramm.ClearSelection();
				UpdateScreen();
			}
		}


		private void btnRectangle_Click(object sender, EventArgs e)
		{
			figureMoved = false;
			figureDraw = true;
			figureClick = false;
			delete = false;
			select = false;
			figure = new MRectangle(new RectangleF(0,0,0,0));
			drawFigure = new MRectangle(new RectangleF(0, 0, 0, 0));
		}
		private void btnEllipse_Click(object sender, EventArgs e)
		{
			figureMoved = false;
			figureDraw = true;
			figureClick = false;
			connectionDraw = false;
			delete = false;
			select = false;
			figure = new Ellipse(new RectangleF(0, 0, 0, 0));
			drawFigure = new Ellipse(new RectangleF(0, 0, 0, 0));

		}
		private void btnConnection_Click(object sender, EventArgs e)
		{
			figureMoved = false;
			figureDraw = false;
			figureClick = false;
			connectionDraw = true;
			delete = false;
			select = false;
			connection = new Connection();
		}
		private void btnActor_Click(object sender, EventArgs e)
		{
			figureMoved = false;
			figureDraw = true;
			figureClick = false;
			connectionDraw = false;
			delete = false;
			select = false;
			figure = new Actor(new RectangleF(0, 0, 0, 0));
			drawFigure = new Actor(new RectangleF(0, 0, 0, 0));
		}
		private void btnCursor_Click(object sender, EventArgs e)
		{
			figure = null;
			figureDraw = false;
			figureMoved = false;
			figureClick = true;
			connectionDraw = false;
			delete = false;
			select = false;
		}
		private void btnMovedCursor_Click(object sender, EventArgs e)
		{
			figureMoved = true;
			figureDraw = false;
			figureClick = false;
			connectionDraw = false;
			figure = null;
			drawFigure = null;
			delete = false;
			select = false;
		}
		private void btn_Delete_MouseClick(object sender, MouseEventArgs e)
		{
			figureMoved = false;
			figureDraw = false;
			figureClick = false;
			connectionDraw = false;
			figure = null;
			delete = true;
			select = false;
		}
		private void btn_Select_Click(object sender, EventArgs e)
		{
			press = true;
			figureDraw = false;
			figureMoved = false;
			figureClick = false;
			connectionDraw = false;
			delete = false;
			select = true;
			figure = null;
			drawFigure = null;
			selectMove = false;
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
			if (figureClick)
			{
				figure.BoundingBox = new RectangleF(figure.BoundingBox.X, figure.BoundingBox.Y, (float)nWidth.Value, (float)nHeight.Value);
				figure.ColorPen = btnColorOutline.FlatAppearance.BorderColor;
				figure.ColorBrush = btnFill.FlatAppearance.BorderColor;
				figure.Text = tText.Text;
			}
			UpdateScreen();
		}


		private void btnClear_Click(object sender, EventArgs e)
		{
			bufferedGraphics.Graphics.Clear(canvasBox.BackColor);
			diagramm.Clear();
			UpdateScreen();
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "dat файл (.dat)|.dat|Все файлы (.)|.";
			saveFileDialog.DefaultExt = "*.dat";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				SaveLoad.Save(diagramm, saveFileDialog.FileName);
				MessageBox.Show("Файл сохранен");
			}

		}
		private void btnLoad_Click(object sender, EventArgs e)
		{
			OpenFileDialog op = new OpenFileDialog();
			op.Filter = "dat файл (.dat)|.dat|Все файлы (.)|.";
			op.DefaultExt = "*.dat";
			if (op.ShowDialog() == DialogResult.OK)
			{
				diagramm.Clear();
				SaveLoad.Load(ref diagramm, op.FileName);
			}
			UpdateScreen();
		}
		private void canvasBox_Resize(object sender, EventArgs e)
		{
			bufferedGraphics = bufferedGraphicsContext.Allocate(canvas, canvasBox.DisplayRectangle);
			UpdateScreen();
		}

		#region(Методы)
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

			if (PrevPoint.X > CurrentPoint.X)
			{
				tmp = CurrentPoint.X;
				CurrentPoint.X = PrevPoint.X;
				PrevPoint.X = tmp;
			}
			if (PrevPoint.Y > CurrentPoint.Y)
			{
				tmp = CurrentPoint.Y;
				CurrentPoint.Y = PrevPoint.Y;
				PrevPoint.Y = tmp;
			}
		}
		private void UpdateScreen()
		{
			bufferedGraphics.Graphics.Clear(canvasBox.BackColor);
			foreach (Figure f in diagramm.Content.Figures)
			{
				f.Draw(bufferedGraphics);
			}
			foreach (Connection c in diagramm.Content.Connections)
			{
				c.Draw(bufferedGraphics);
			}
			bufferedGraphics.Render(canvas);
		}
		private double LengthLine(PointF start, PointF end)
		{
			return Math.Sqrt((Math.Pow((end.X - start.X), 2) + Math.Pow((end.Y - start.Y), 2)));
		}

		#endregion
	}
}
