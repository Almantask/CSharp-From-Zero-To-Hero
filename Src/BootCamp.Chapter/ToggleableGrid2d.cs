using System;

namespace BootCamp.Chapter
{
    public class ToggleableGrid2D : IToggleableGrid
    {
        private readonly bool[,] _toggles;
        private readonly IGridClearer _gridClearer;

        public ToggleableGrid2D(bool[,] toggles, IGridClearer gridClearer)
        {
            _toggles = toggles;
            _gridClearer = gridClearer;
        }

        public void Toggle(int x, int y)
        {
            _toggles[x, y] = !_toggles[x, y];
            _gridClearer.Clear();
            PrintTable();
        }
        
        private void PrintTable()
        {
            var rowsLength = _toggles.GetLength(0);
            var columnsLength = _toggles.GetLength(1);
            for (var x = 0; x < rowsLength; x++)
            {
                for (var y = 0; y < columnsLength; y++)
                {
                    var message = _toggles[x, y] ? "■" : " ";
                    Console.Write(message);
                }

                if (x != rowsLength - 1) Console.Write(Environment.NewLine);
            }
        }
    }
}