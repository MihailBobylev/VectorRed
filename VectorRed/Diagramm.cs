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

	public class Diagramm
	{
		public Content Content;
		public Content Selection;
		public static List<Figure> SELECTED_F = new List<Figure>();
		public static List<Connection> SELECTED_C = new List<Connection>();
		
		public static void Clear()
		{
			//
			//
			SELECTED_F.Clear();
			SELECTED_C.Clear();
		}
	}
}
