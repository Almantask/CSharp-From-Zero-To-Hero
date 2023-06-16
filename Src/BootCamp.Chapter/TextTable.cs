using System.Text;
using System;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Part 1.
    /// </summary>
    public static class TextTable
    {
        /*

         Input: "Hello", 0
           +-----+
           |Hello|
           +-----+
           
         Input: $"Hello{Environment.NewLine}World!", 0
           +------+
           |Hello |
           |World!|
           +------+
           
         Input: "Hello", 1
           +-------+
           |       |
           | Hello |
           |       |
           +-------+

         */

        /// <summary>
        /// Build a table for given message with given padding.
        /// Padding means how many spaces will a message be wrapped with.
        /// Table itself is made of: "+-" symbols. 
        /// </summary>
        public static string Build(string message, int padding)
		{
			//Return if blank
			if (message.Equals(""))
			{
				return "";
			}

			//Find length of longest line
			int longestLength = 0;
			//Split message by newlines
			string[] lines = message.Split(Environment.NewLine);
			//Loop and grab longest length
			foreach (string line in lines)
			{
				if (line.Length > longestLength)
				{
					longestLength = line.Length;
				}
			}

			//Build ceiling/floor string
			StringBuilder sbCeiling = new StringBuilder("+");
			sbCeiling.Append(new string('-', (longestLength + (padding * 2))));//Add - for length plus padding on both sides
			sbCeiling.Append("+");
			string ceiling = sbCeiling.ToString();

			//Build other strings needed for the table
			//Padding
			string paddingSpace = new string(' ', padding);
			//Extra lines if there's padding
			string paddingLine = "";
			string paddingLines = "";
			if (padding > 0)
			{
				//Create single line
				StringBuilder sbPaddingLine = new StringBuilder("|");
				sbPaddingLine.Append(new string(' ', (longestLength + (padding * 2))));//length plus padding on both sides
				sbPaddingLine.Append('|');
				paddingLine = sbPaddingLine.ToString();

				//Combine lines
				StringBuilder sbPaddingLines = new StringBuilder();
				for (int i = 0; i < padding; i++)
				{
					sbPaddingLines.AppendLine(paddingLine);
				}
				paddingLines = sbPaddingLines.ToString();
			}

			//Build table
			StringBuilder sbTable = new StringBuilder();
			//Ceiling
			sbTable.AppendLine(ceiling);
			//Top padding
			if (padding > 0)
			{
				sbTable.Append(paddingLines);//Append not AppendLine as padding lines already has trailing newline
			}
			//Text lines with padding
			foreach (string text in lines)
			{
				sbTable.Append("|");
				sbTable.Append(paddingSpace);
				sbTable.Append(text);
				//Add extra padding on the right if the word isn't the longest
				if (text.Length < longestLength)
				{
					sbTable.Append(new string(' ', longestLength - text.Length));
				}
				sbTable.Append(paddingSpace);
				sbTable.AppendLine("|");
			}
			//Bottom padding
			if (padding > 0)
			{
				sbTable.Append(paddingLines);//Append not AppendLine as padding lines already has trailing newline
			}
			//Floor
			sbTable.AppendLine(ceiling);

			return sbTable.ToString();
		}
	}
}
