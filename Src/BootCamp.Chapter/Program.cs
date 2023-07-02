using System;

namespace BootCamp.Chapter
{
	class Program
	{
		static void Main(string[] args)
		{
			JaggedArrayDemo();
			Array2DDemo();
			CommonLetterDemo();

			Console.ReadLine();
		}

		public static void CommonLetterDemo()
		{
			Console.WriteLine("Write a sentence to find most common symbol: ");
			string sentence = Console.ReadLine();
			Console.WriteLine($"Most common symbol is {MostCommonLetterFinder.Find(sentence)}.");
		}

		public static void Array2DDemo()
		{
			//Build 2D array
			//Get rows
			int rows = GetConsoleInt("Number of rows: ", min: 0);
			//Get columns
			int columns = GetConsoleInt("Number of columns: ", min: 0);
			//Create toggleable grid
			bool[,] grid = new bool[rows, columns];
			ToggleableGrid2D grid2d = new ToggleableGrid2D(grid, new GridClearer());
			//Toggle coordinates
			UserTogglesCoordinates(grid2d);
		}

		public static void JaggedArrayDemo()
		{
			//Build jagged array
			//Get rows
			int rows = GetConsoleInt("Number of rows: ", min: 0);
			bool[][] grid = new bool[rows][];
			//Get columns
			for (int i = 0; i < rows; i++)
			{
				int columns = GetConsoleInt($"Length for row {i}: ");
				grid[i] = new bool[columns];
			}
			//Create toggleable grid
			ToggleableGridJagged jaggedGrid = new ToggleableGridJagged(grid, new GridClearer());
			//Toggle coordinates
			UserTogglesCoordinates(jaggedGrid);
		}

		public static void UserTogglesCoordinates(IToggleableGrid grid)
		{
			bool isToggling;

			do
			{
				//Get toggle cordinates
				int x;
				int y;
				GetConsoleCoordinates("Enter x,y to toggle element: ", out x, out y);

				//Toggle
				grid.Toggle(x, y);

				Console.Write(Environment.NewLine + "Toggle another element? (y/n): ");
				isToggling = Console.ReadLine().ToLower() == "y";
			} while (isToggling);
		}

		public static int GetConsoleInt(string prompt, int? min = null, int? max = null)
		{
			int number;
			bool isNumber = false;
			bool isInRange = false;

			do
			{
				//Get number
				do
				{
					Console.Write(prompt);
					isNumber = Int32.TryParse(Console.ReadLine(), out number);
				} while (!isNumber);

				//Check if inside of range given
				isInRange = !(number < (min ?? number) || number > (max ?? number));
			} while (!isInRange);
			

			return number;
		}

		public static void GetConsoleCoordinates(string prompt, out int x, out int y)
		{
			x = default;
			y = default;
			bool isNumber = false;
			do
			{
				//Get coordinates as a string
				Console.Write(prompt);
				string[] stringCoordinates = Console.ReadLine().Split(',');
				//Convert to int
				if (stringCoordinates.Length != 2) continue;
				isNumber = Int32.TryParse(stringCoordinates[0], out x);
				isNumber = isNumber && Int32.TryParse(stringCoordinates[1], out y);//Keep status from x in case y is good but x was bad
			} while (!isNumber);
		}
	}
}
