using System;

namespace BootCamp.Chapter
{
    public class ToggleableGridJagged : IToggleableGrid
    {
        private readonly IGridClearer _gridClearer;
        private bool[][] _boolArray;

        public ToggleableGridJagged(bool[][] boolArray, IGridClearer gridClearer)
        {
            _boolArray = boolArray;
            _gridClearer = gridClearer;
        }

        public void Toggle(int x, int y)
        {
            int expectedMinimumArrayLength = (x + 1) * (y + 1);

            if ((_boolArray.GetLength(0) * _boolArray.GetLength(0)) < expectedMinimumArrayLength) throw new IndexOutOfRangeException("Index was outside of the bounds.");

            _boolArray[x][y] = !_boolArray[x][y];
            PrintArray();

        }

        private void PrintArray()
        {
            _gridClearer.Clear();

            for (int i = 0; i < _boolArray.Length; i++)
            {
                for (int j = 0; j < _boolArray[i].Length ; j++)
                {
                    Console.Write(_boolArray[i][j] == true ? "■" : " ");
                }

                //if it is last row don't create new line. Yes, this line looks like crap but I couldn't find any solution except this.
                if (i == _boolArray.GetLength(0) - 1) return;

                Console.Write(Environment.NewLine);
            }
        }
    }
}