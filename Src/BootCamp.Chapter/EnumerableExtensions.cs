using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BootCamp.Chapter
{
	public static class EnumerableExtensions
	{
		public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> values)
		{
			List<T> list = new List<T>(values);
			Random rnd = new Random();
			int count = list.Count();
			//Fisher Yates Shuffle
			for (int i = 0; i < count; i++)
			{
				int swapIndex = rnd.Next(i, count);
				T swapValue = list[swapIndex];
				list[swapIndex] = list[i];
				list[i] = swapValue;
			}

			return list;
		}

		public static IEnumerable<T> SnapFingers<T>(this IEnumerable<T> values, Predicate<T> predicate)
		{
			//Apply predicate
			List<T> list = values.Where(value => predicate(value)).ToList();

			//Remove half
			int count = list.Count();
			int remove = count / 2;
			return list.Take(count - remove);
		}
	}
}
