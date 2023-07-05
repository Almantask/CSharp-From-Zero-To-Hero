using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace BootCamp.Chapter
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> names = new List<string>()
			{
				"Tyler",
				"Andrew",
				"Jakey",
				"Shea",
				"Michael"
			};

			//names = names.Shuffle().ToList();

			//names = names.SnapFingers(n => true).ToList();

			LinqStringDemo(names);

			Console.ReadLine();
		}

		public static void LinqStringDemo(List<string> names)
		{
			List<string> names2 = new List<string>()
			{
				"Tylor",
				"Josh",
				"Shea",
				"Kyle",
				"Tyler"
			};

			Console.WriteLine(GetPrintableList(names));

			//Any
			bool hasNameWithA = names.Any(name => name.Contains('a'));
			Console.WriteLine($"Any names contain a?: {hasNameWithA}");
			bool hasNameWithZ = names.Any(name => name.Contains("z"));
			Console.WriteLine($"Any names contain z?: {hasNameWithZ}");

			//Count
			Console.WriteLine($"Number of names containing a: {names.Count(name => name.Contains('a'))}");

			//Order
			Console.WriteLine($"abc order: {GetPrintableList(names.OrderBy(name => name).ToList())}");

			//Sets
			Console.WriteLine($"Set 1: {GetPrintableList(names)}");
			Console.WriteLine($"Set 2: {GetPrintableList(names2)}");

			//Union
			Console.WriteLine($"All names in both sets: {GetPrintableList(names.Union(names2).ToList())}");

			//Intersection
			Console.WriteLine($"Names in both sets: {GetPrintableList(names.Intersect(names2).ToList())}");

			//Substraction
			Console.WriteLine($"Names that are in set 1, but not set 2: {GetPrintableList(names.Except(names2).ToList())}");

			//All 3
			Console.WriteLine($"Names that aren't in both sets: {GetPrintableList(names.Union(names2).Except(names.Intersect(names2)).ToList())}");
		}

		public static string GetPrintableList(List<string> names)
		{
			StringBuilder sb = new StringBuilder();
			foreach (string name in names.GetRange(0, names.Count - 1))
			{
				sb.Append(name);
				sb.Append(", ");
			}
			sb.Append(names[^1]);

			return sb.ToString();
		}
	}
}
