using System;

namespace BootCamp.Chapter
{
    public class ToggleableGridJagged : IToggleableGrid
    {
        private readonly IGridClearer _gridClearer;
        private readonly bool[][] _toggles;

        public ToggleableGridJagged(bool[][] toggles, IGridClearer gridClearer)
        {
            _gridClearer = gridClearer;
            _toggles = toggles;
        }

        public void Toggle(int x, int y)
        {
            var current = _toggles[x][y];
            _toggles[x][y] = !current;
            Redraw(_toggles);
        }

        private void Redraw(bool[][] toggles)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            var numberOfRows = toggles.GetLength(0);
            var numberOfCols = numberOfRows;

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfCols; j++)
                {
                    if (toggles[i][j])
                    {
                        Console.Write("\u25A0");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                if (i < numberOfRows - 1)
                {
                    Console.Write($"{Environment.NewLine}");
                }


            }
        }
    }
}