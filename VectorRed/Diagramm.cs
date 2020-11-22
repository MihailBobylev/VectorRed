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
		public Content Clone()
		{

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
			FIGURES.Clear();
			CONNECTIONS.Clear();
			SELECTED_F.Clear();
			SELECTED_C.Clear();
		}
	}
}
