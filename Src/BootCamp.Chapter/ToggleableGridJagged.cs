using System;

namespace BootCamp.Chapter
{
    public class ToggleableGridJagged : IToggleableGrid
    {
        private readonly IGridClearer _gridClearer;
        private bool[][] grid;

        public ToggleableGridJagged(bool[][] toggles, IGridClearer gridClearer)
        {
            _gridClearer = gridClearer;
            grid = toggles;
        }

        public void Toggle(int x, int y)
        {
            OutOfBoundsCheck(x, y);
            grid[x][y] = !grid[x][y];
            DrawGrid();
        }

        private void DrawGrid()
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int k = 0; k < grid[i].Length; k++)
                {
                    if (grid[i][k])
                    {
                        Console.Write("■");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                if (i != grid.GetLength(0) - 1)
                {
                    Console.WriteLine();
                }
            }
        }

        private void OutOfBoundsCheck(int x, int y)
        {
            if (x < 0 || x >= grid.GetLength(0))
            {
                throw new IndexOutOfRangeException();
            }
            if (y < 0 || y >= grid[x].Length)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}