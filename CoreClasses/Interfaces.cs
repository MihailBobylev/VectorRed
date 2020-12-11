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
		Color ColorPen { get; set; }
		Pen Outline { get; }
	}

	public interface IHasFilling
	{
		Color ColorBrush { get; set; }
		Brush Filling { get; }
	}

	public interface IHasText
	{
		Font Font { get; set; }
		string Text { get; set; }
	}


}
