using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace BootCamp.Chapter
{
	/// <summary>
	/// Part 1.
	/// </summary>
	public static class TextTable
	{
		private const string Side = "|";
		private const char Top = '-';
		private const string Corner = "+";
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
			if (string.IsNullOrEmpty(message)) return "";
			//Creates message part of table
			message = message.Replace("\r", "");
			var msgArray = message.Split("\n");
			var longestLineLength = msgArray.OrderByDescending(s => s.Length).First().Length;
			var firstLine = msgArray[0].PadLeft(longestLineLength + padding - Convert.ToInt32(Math.Ceiling((longestLineLength - msgArray[0].Length) / 2.0))).PadRight(longestLineLength + padding * 2);
			var messageTable = $"{Side}{firstLine}{Side}";

			foreach (var line in msgArray[1..])
			{
				var linePadding = line.PadLeft(longestLineLength + padding - Convert.ToInt32(Math.Ceiling((longestLineLength - line.Length) / 2.0))).PadRight(longestLineLength + padding * 2);
				messageTable += $"\r\n{Side}{linePadding}{Side}";
			}
			
			
			//Creates the top and bottom part of the table
			var width = longestLineLength + padding * 2;
			var horizontalLine = new string(Top, width);
			var topBottomTable = $"{Corner}{horizontalLine}{Corner}";
			
			
			//Creates empty line part of the table
			var emptySpace = new string(' ', width);
			var emptyLineTable = $"{Side}{emptySpace}{Side}\r\n";


			var table = $"{topBottomTable}\r\n"; // Top layer
			
			for (var i = 0; i < padding; i++) // Empty layers
			{
				table += emptyLineTable;
			}
			
			table += $"{messageTable}\r\n"; // Message layer
			
			for (var i = 0; i < padding; i++) // Empty layers
			{
				table += emptyLineTable;
			}

			table += $"{topBottomTable}\r\n"; // Bottom layer
			
			return table;
		}
	}
}
