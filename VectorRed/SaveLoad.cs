using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace VectorRed
{
	static public class SaveLoad
	{
		static public void Save(Diagramm d, Stream target)
		{
			BinaryFormatter binFormat = new BinaryFormatter();
			binFormat.Serialize(target, d.Content.Figures);
			binFormat.Serialize(target, d.Content.Connections);
		}

		static public void Load(Stream source, Diagramm d)
		{

		}
	}
}
