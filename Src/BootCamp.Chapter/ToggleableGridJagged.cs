using System;

namespace BootCamp.Chapter
{
    public class ToggleableGridJagged : IToggleableGrid
    {
        private readonly bool[][] _toggles;
        private readonly IGridClearer _gridClearer;
        private readonly int _rowsLength;
        private readonly int _columnsLength;

        public ToggleableGridJagged(bool[][] toggles, IGridClearer gridClearer)
        {
            _toggles = toggles;
            _gridClearer = gridClearer;
            _rowsLength = toggles.Length;
            _columnsLength = toggles[0].Length;
        }

        public void Toggle(int x, int y)
        {
            _toggles[x][y] = !_toggles[x][y];
            PrintTable();
        }
        
        private void PrintTable()
        {
            _gridClearer.Clear();
            for (var row = 0; row < _rowsLength; row++)
            {
                for (var column = 0; column < _columnsLength; column++)
                {
                    var message = GetToggleStatus(row, column) ? "■" : " ";
                    Console.Write(message);
                }
                
                if (row != _rowsLength - 1) Console.Write(Environment.NewLine);
            }
        }
        
        private bool GetToggleStatus(int row, int column)
        {
            return _toggles[row][column];
        }
    }
}