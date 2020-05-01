using System;

namespace BootCamp.Chapter
{
    public class ToggleableGridJagged : IToggleableGrid
    {
        private readonly bool[][] _toggles;
        private readonly IGridClearer _gridClearer;

        public ToggleableGridJagged(bool[][] toggles, IGridClearer gridClearer)
        {
            _toggles = toggles;
            _gridClearer = gridClearer;
        }

        public void Toggle(int x, int y)
        {
            _toggles[x][y] = !_toggles[x][y];
            _gridClearer.Clear();
            PrintTable();
        }
        
        private void PrintTable()
        {
            var rowsLength = _toggles.Length;
            var columnsLength = _toggles[0].Length;
            for (var x = 0; x < rowsLength; x++)
            {
                for (var y = 0; y < columnsLength; y++)
                {
                    var message = _toggles[x][y] ? "■" : " ";
                    Console.Write(message);
                }

                if (x != rowsLength - 1) Console.Write(Environment.NewLine);
            }
        }
    }
}