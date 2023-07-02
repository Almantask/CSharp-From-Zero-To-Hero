using System;

namespace BootCamp.Chapter
{
    public class ToggleableGrid2D : IToggleableGrid
    {
        private readonly IGridClearer _gridClearer;
		private bool[,] Toggles { get; set; }

        public ToggleableGrid2D(bool[,] toggles, IGridClearer gridClearer)
        {
            _gridClearer = gridClearer;
			Toggles = toggles;
        }

        public void Toggle(int x, int y)
        {
			//Flip bit in that location
			Toggles[y,x] = !Toggles[y,x];

			//Print grid
			PrintGrid();
		}

		public void PrintGrid()
		{
			int rowLength = Toggles.GetLength(1);
			int columnLength = Toggles.GetLength(0);

			for (int y = 0; y < columnLength; y++)
			{
				for (int x = 0; x < rowLength; x++)
				{
					Console.Write(Toggles[y,x] ? "■" : " ");
				}

				//Newline
				if (y + 1 == columnLength)//Skip if we're on the last line
				{
					continue;
				}
				Console.WriteLine();
			}
		}
	}

	
}