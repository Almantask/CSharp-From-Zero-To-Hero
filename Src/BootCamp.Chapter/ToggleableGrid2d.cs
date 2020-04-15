using System;

namespace BootCamp.Chapter
{
    public class ToggleableGrid2D : IToggleableGrid
    {
        private readonly IGridClearer _gridClearer;
        bool[,] grid;

        public ToggleableGrid2D(bool[,] toggles, IGridClearer gridClearer)
        {
            _gridClearer = gridClearer;
            grid = toggles;
        }

        public void Toggle(int x, int y)
        {
            CheckIsOutOfBounds(x, y);
            grid[x, y] = !grid[x, y];
            DrawGrid();
        }

        private void DrawGrid()
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int k = 0; k < grid.GetLength(1); k++)
                {
                    if (grid[i, k])
                    {
                        Console.Write("■");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                if (i != grid.GetLength(0) -1)
                {
                    Console.WriteLine();
                }
            }
        }

        private void CheckIsOutOfBounds(int x, int y)
        {
            if (x < 0 || x >= grid.GetLength(0))
            {
                throw new IndexOutOfRangeException($"{x} is out of bounds of the grid.");
            }
            if ( y < 0 || y >= grid.GetLength(1))
            {
                throw new IndexOutOfRangeException($"{y} is out of bounds of the grid.");
            }
        }
    }
}