using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorRed
{
	public static class Diagramm
	{
		public static List<Figure> FIGURES = new List<Figure>();
		public static List<Connection> CONNECTIONS = new List<Connection>();
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
