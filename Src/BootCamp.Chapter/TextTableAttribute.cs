using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
	public class TextTableAttribute : Attribute
	{
		public int Padding { get; }
		public char SideTop { get; }
		public char SideLeft { get; }
		public char Corner { get; }
		public TextTableAttribute(int padding = 0, char sideTop = '-', char sideLeft = '|', char corner = '+')
		{
			Padding = padding;
			SideTop = sideTop;
			SideLeft = sideLeft;
			Corner = corner;
		}
	}
}
