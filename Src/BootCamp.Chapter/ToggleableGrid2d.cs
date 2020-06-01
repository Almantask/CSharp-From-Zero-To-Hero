using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace BootCamp.Chapter
{
    public class ToggleableGrid2D : IToggleableGrid
    {
        private readonly IGridClearer _gridClearer;
        private bool[,] _boolArray;

        public ToggleableGrid2D(bool[,] boolArray
            , IGridClearer gridClearer)
        {
            _gridClearer = gridClearer;
            _boolArray = boolArray;
        }

        public void Toggle(int x, int y)
        {
            int expectedMinimumArrayLength = (x + 1) * (y + 1);

            if (_boolArray.Length < expectedMinimumArrayLength) throw new IndexOutOfRangeException("Index was outside of the bounds.");

            _boolArray[x, y] = !_boolArray[x, y];
            PrintArray();
        }

        private void PrintArray()
        {
            _gridClearer.Clear();

            for (int i = 0; i < _boolArray.GetLength(0); i++)
            {
                for (int j = 0; j < _boolArray.GetLength(1); j++)
                {
                    Console.Write(_boolArray[i, j] == true ? "■" : " ");
                }

                //if it is last row don't create new line. Yes, this line looks like crap but I couldn't find any solution except this.
                if (i == _boolArray.GetLength(0) - 1) return;

                Console.Write(Environment.NewLine);
            }
        }
    }
}