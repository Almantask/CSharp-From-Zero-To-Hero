using System;

namespace BootCamp.Homework
{
    public class ToggleableGrid2D : IToggleableGrid
    {
        private readonly bool[,] _toggles;
        private readonly IGridClearer _gridClearer;
        private readonly int _rowsLength;
        private readonly int _columnsLength;

        public ToggleableGrid2D(bool[,] toggles, IGridClearer gridClearer)
        {
            _toggles = toggles;
            _gridClearer = gridClearer;
            _rowsLength = _toggles.GetLength(0);
            _columnsLength = _toggles.GetLength(1);
        }

        public void Toggle(int x, int y)
        {
            _toggles[x, y] = !_toggles[x, y];
            PrintTable();
        }
        
        public void PrintTable()
        {
            _gridClearer.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            PrintColumnGuide();

            for (var row = 0; row < _rowsLength; row++)
            {
                Console.Write($" {row} |");
                for (var column = 0; column < _columnsLength; column++)
                {
                    var message = GetToggleStatus(row, column) ? " o " : " x ";
                    Console.Write($"{message}|");
                }
                Console.Write(Environment.NewLine);
            }
            
            Console.ResetColor();
        }

        private void PrintColumnGuide()
        {
            Console.Write("   |");
            for (var column = 0; column < _columnsLength; column++)
            {
                Console.Write($" {column} |");
            }

            Console.WriteLine();
        }
        
        private bool GetToggleStatus(int row, int column)
        {
            return _toggles[row, column];
        }
    }
}