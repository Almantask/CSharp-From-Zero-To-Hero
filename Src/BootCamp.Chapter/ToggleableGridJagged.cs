using System;

namespace BootCamp.Chapter
{
    public class ToggleableGridJagged : IToggleableGrid
    {
        private readonly IGridClearer _gridClearer;
        private readonly bool[][] _jaggedArray;

        public ToggleableGridJagged(bool[][] toggles, IGridClearer gridClearer)
        {
            _gridClearer = gridClearer;
            _jaggedArray = toggles;
        }

        public void Toggle(int x, int y)
        {
            try
            {
                _jaggedArray[x][y] = true;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                throw new ArgumentOutOfRangeException("Index was out of range", ex);
            }
        }
    }
}