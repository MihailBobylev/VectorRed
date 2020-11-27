using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorRed
{
	public class Content
	{
		public List<Figure> Figures = new List<Figure>();
		public List<Connection> Connections = new List<Connection>();

		public Content(List<Figure> figures, List<Connection> connections)
		{
			Figures = figures;
			Connections = connections;
		}

		public Content Clone()
		{
			return new Content(Figures, Connections);
		}

		public void UnbindConnections()
		{

		}
	}

	public  class Diagramm
	{
		public Content Content;
		public Content Selection;

		public Diagramm()
		{
			Content = new Content(new List<Figure>(), new List<Connection>());
			Selection = new Content(new List<Figure>(), new List<Connection>());
		}
		public  void Clear()
		{
			Content.Figures.Clear();
			Content.Connections.Clear();
			Selection.Figures.Clear();
			Selection.Connections.Clear();
		}

		public  void ClearSelection()
		{
			Content.Figures.Clear();
			Content.Connections.Clear();
		}


	}
}
