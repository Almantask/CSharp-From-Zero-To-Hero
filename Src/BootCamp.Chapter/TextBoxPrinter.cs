using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BootCamp.Chapter
{
	public static class TextBoxPrinter
	{
		public static string Print(object obj)
		{
			//Get obj type
			Type objType = obj.GetType();
			//Get TextTableAttribute from obj
			TextTableAttribute textTableAttribute = objType.GetCustomAttribute<TextTableAttribute>();

			//If there's no attribute attached then just return the obj's ToString result
			if (textTableAttribute == null) { return obj.ToString(); }

			//Get obj text per line
			string[] textLines = obj.ToString().Split(Environment.NewLine);

			//Build the text box
			StringBuilder sb = new StringBuilder();
			string corner = textTableAttribute.Corner.ToString();//To not call ToString multiple times
			string sideLeft = textTableAttribute.SideLeft.ToString();//To not call ToString multiple times

			//Get the max width of the object's text
			int maxWidth = 0;
			foreach (string textLine in textLines)
			{
				int width = textLine.Length;
				if (width > maxWidth) { maxWidth = width; }
			}
			int spacePaddingLength = (maxWidth + (2 * textTableAttribute.Padding));//Length is max width + 2x padding (on both sides)
			string linePaddingString = new string(' ', spacePaddingLength);

			//Build top/bottom part of the box
			StringBuilder sbTopBottom = new StringBuilder();
			sbTopBottom.Append(corner);
			sbTopBottom.Append(new string(textTableAttribute.SideTop, spacePaddingLength));
			sbTopBottom.Append(corner);

			//Add top to box
			sb.Append(sbTopBottom);
			sb.AppendLine();//AppendLine() doesn't take StringBuilder, but Append() does

			//Build vertical padding line
			StringBuilder sbVerticalPadding = new StringBuilder();
			sbVerticalPadding.Append(sideLeft);
			sbVerticalPadding.Append(linePaddingString);
			sbVerticalPadding.AppendLine(sideLeft);

			//Duplicated for each number of padding
			StringBuilder sbVerticalPaddingLines = new StringBuilder();
			for (int i = 0; i < textTableAttribute.Padding; i++)
			{
				sbVerticalPaddingLines.Append(sbVerticalPadding);
			}

			//Add Top padding
			sb.Append(sbVerticalPaddingLines);

			//Build middle sections
			string paddingString = new string(' ', textTableAttribute.Padding);//Padding spaces
			foreach (string textLine in textLines)
			{
				//Left wall
				sb.Append(sideLeft);
				//Padding
				sb.Append(paddingString);
				//Text
				sb.Append(textLine);
				//Padding
				sb.Append(paddingString);
				//Extra padding if the line doesn't have the max width
				int extraPaddingLength = maxWidth - textLine.Length;
				if (extraPaddingLength > 0) { sb.Append(new string(' ', extraPaddingLength)); }
				//Right wall
				sb.AppendLine(sideLeft);
			}

			//Add bottom padding
			sb.Append(sbVerticalPaddingLines);

			//Add bottom of the box
			sb.Append(sbTopBottom);

			return sb.ToString();
		}
	}
}
