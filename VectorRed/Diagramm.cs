using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorRed
{
	class Diagramm
	{
		private List<Figure> figures;
		private List<Connection> connections;
		private List<Figure> selectedF;
		private List<Connection> selectedC;
		public Diagramm() 
		{
			Figures = new List<Figure>();
			Connections = new List<Connection>();
			SelectedF = new List<Figure>();
			SelectedC = new List<Connection>();
		}

		internal List<Figure> Figures { get => figures; set => figures = value; }
		internal List<Connection> Connections { get => connections; set => connections = value; }
		internal List<Figure> SelectedF { get => selectedF; set => selectedF = value; }
		internal List<Connection> SelectedC { get => selectedC; set => selectedC = value; }
	}
}
