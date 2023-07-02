using System.Collections.Generic;
using System.Linq;
using System;

namespace BootCamp.Chapter
{
	public static class MostCommonLetterFinder
	{
		public static char Find(string sentence)
		{
			if (string.IsNullOrWhiteSpace(sentence))
			{
				throw new ArgumentNullException();
			}

			//Store counts in a dictionary
			Dictionary<char, int> counts = new Dictionary<char, int>();

			foreach (char ch in sentence)
			{
				if (counts.ContainsKey(ch))
				{
					counts[ch]++;
				}
				else
				{
					counts.Add(ch, 1);
				}
			}

			int HighestCount = counts.Values.Max();
			
			//Don't know LINQ yet, so get highest char by looping through the dict
			foreach (var pair in counts)
			{
				if (pair.Value ==  HighestCount)
				{
					return pair.Key;
				}
			}

			return ' ';
		}
	}
}