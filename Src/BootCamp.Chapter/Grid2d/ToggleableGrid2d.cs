using System;

namespace BootCamp.Chapter
{
    public class ToggleableGrid2D : IToggleableGrid
    {
        private readonly IGridClearer _gridClearer;
        private bool[,] grid2D;

        public static bool printWithBorder = false;

        public ToggleableGrid2D(bool[,] toggles, IGridClearer gridClearer)
        {
            _gridClearer = gridClearer;
            grid2D = toggles;
        }

        public void Toggle(int x, int y)
        {
            if (x > grid2D.GetLength(0) || y > grid2D.GetLength(1))
            {
                throw new System.IndexOutOfRangeException();
            }
            else
            {
                grid2D[x, y] = grid2D[x,y] == false ? true : false;
            }

            if (printWithBorder)
            {
                PrintGridWithBorder();
            }
            else
            {
                PrintGrid();
            }
        }

        private void PrintGrid()
        {
            for (int i = 0; i < grid2D.GetLength(1); i++)
            {
                for (int j = 0; j < grid2D.GetLength(0); j++)
                {
                    Console.Write(grid2D[j, i] == false ? " " : "■");
                }

                if (i < grid2D.GetLength(1) - 1)
                {
                    Console.Write(Environment.NewLine);
                }
            }
        }

        public void PrintGridWithBorder()
        {
            for (int y = 0; y < grid2D.GetLength(1); y++)
            {
                for (int i = 0; i < grid2D.GetLength(0) + 2; i++)
                {
                    Console.Write("-");
                }

                Console.Write("\n|");

                for (int x = 0; x < grid2D.GetLength(0); x++)
                {
                    Console.Write(grid2D[x,y] == false ? " " : "■");
                }

                Console.Write("|");
                Console.Write(Environment.NewLine);
            }

            for (int i = 0; i < grid2D.GetLength(0) + 2; i++)
            {
                Console.Write("-");
            }

            Console.Write(Environment.NewLine);
        }
    }
}