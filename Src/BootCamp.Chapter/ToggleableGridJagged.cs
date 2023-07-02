using System;

namespace BootCamp.Chapter
{
	public class ToggleableGridJagged : IToggleableGrid
	{
		private readonly IGridClearer _gridClearer;
		private bool[][] Toggles { get; set; }

		public ToggleableGridJagged(bool[][] toggles, IGridClearer gridClearer)
		{
			_gridClearer = gridClearer;
			Toggles = toggles;
		}

		public void Toggle(int x, int y)
		{
			//Check if points are valid
			//if (y < 0 || Toggles.Length < y - 1)
			//{
			//	throw new ArgumentException($"{nameof(y)} is out of range.");
			//}
			//if (x < 0 || Toggles[y].Length < x - 1)
			//{
			//	throw new ArgumentException($"{nameof(x)} is out of range.");
			//}

			//Flip bit in that location
			Toggles[y][x] = !Toggles[y][x];

			//Print grid
			PrintGrid();
		}

		public void PrintGrid()
		{
			for (int y = 0; y < Toggles.Length; y++)
			{
				for (int x = 0; x < Toggles[y].Length; x++)
				{
					Console.Write(Toggles[y][x] ? "■" : " ");
				}

				//Newline
				if (y + 1 == Toggles.Length)//Skip if we're on the last line
				{
					continue;
				}
				Console.WriteLine();
			}
		}
	}
}