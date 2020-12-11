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
		static public void Save(Diagramm d, string filename)
		{
			BinaryFormatter binFormat = new BinaryFormatter();
			using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
			{
				binFormat.Serialize(fs, d.Content);
				fs.Close();
			}
		}

		static public void Load(ref Diagramm d, string filename)
		{
			BinaryFormatter binFormat = new BinaryFormatter();
			using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
			{
				d.Content = (Content)binFormat.Deserialize(fs);
				fs.Close();
			}
		}
	}
}
