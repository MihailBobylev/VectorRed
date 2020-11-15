using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorRed
{
	static public class CopyPaste
	{
		static public void Copy()
		{
			Clipboard.SetDataObject(Diagramm.SELECTED_F);

			Clipboard.SetDataObject(Diagramm.SELECTED_C);
		}

		static public void Paste()
		{

		}
	}
}
