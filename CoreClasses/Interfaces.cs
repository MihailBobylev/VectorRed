using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorRed
{
	public interface IHasOutline
	{
		Pen Outline { get; set; }
	}

	public interface IHasFilling
	{
		Brush Filling { get; set; }
	}

	public interface IHasText
	{
		Font Font { get; set; }
		string Text { get; set; }
	}


}
