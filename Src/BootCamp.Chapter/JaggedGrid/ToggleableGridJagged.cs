using System;

namespace BootCamp.Chapter
{
    public class ToggleableGridJagged : IToggleableGrid
    {
        private readonly IGridClearer _gridClearer;
        private bool[][] jaggedGrid;

        public static bool printWithBorder = false;

        public ToggleableGridJagged(bool[][] toggles, IGridClearer gridClearer)
        {
            _gridClearer = gridClearer;
            jaggedGrid = toggles;
        }

        public void Toggle(int x, int y)
        {
            if (y > jaggedGrid.Length || x > jaggedGrid[y].Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                jaggedGrid[y][x] = jaggedGrid[y][x] == false ? true : false;
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

        private int ReturnLongestRow()
        {
            int result = 0;

            for (int y = 0; y < jaggedGrid.Length; y++)
            {
                if(jaggedGrid[y].Length > result)
                {
                    result = jaggedGrid[y].Length;
                }
            }
            return result;
        }

        private void PrintGrid()
        {
            for (int y = 0; y < jaggedGrid.Length; y++)
            {
                for (int x = 0; x < jaggedGrid[y].Length; x++)
                {
                    Console.Write(jaggedGrid[y][x] == false ? " " : "■");
                }

                if(y < jaggedGrid.Length - 1)
                {
                    Console.Write(Environment.NewLine);
                }
            }
        }

        public void PrintGridWithBorder()
        {
            int longestRow = ReturnLongestRow();

            for (int y = 0; y < jaggedGrid.Length; y++)
            {
                for (int i = 0; i < longestRow + 2; i++)
                {
                    Console.Write("-");
                }

                Console.Write("\n|");

                for (int x = 0; x < jaggedGrid[y].Length; x++)
                {
                    Console.Write(jaggedGrid[y][x] == false ? " " : "■");
                }

                Console.Write("|");
                Console.Write(Environment.NewLine);
            }

            for (int i = 0; i < longestRow + 2; i++)
            {
                Console.Write("-");
            }

            Console.Write(Environment.NewLine);
        }
    }
}