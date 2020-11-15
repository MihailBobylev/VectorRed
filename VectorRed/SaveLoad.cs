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
		static public void Save(String fileName)
		{
			BinaryFormatter binFormat = new BinaryFormatter();
			using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate) )
			{
				binFormat.Serialize(fs, Diagramm.FIGURES);
				binFormat.Serialize(fs, Diagramm.CONNECTIONS);
				fs.Close();
			}
		}

		static public void Load()
		{

		}
	}
}
