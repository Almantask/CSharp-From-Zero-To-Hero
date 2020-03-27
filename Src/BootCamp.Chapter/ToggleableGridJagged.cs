using System;

namespace BootCamp.Chapter
{
    public class ToggleableGridJagged : IToggleableGrid
    {
        private readonly IGridClearer _gridClearer;

        public ToggleableGridJagged(bool[][] toggles, IGridClearer gridClearer)
        {
            _gridClearer = gridClearer;
        }

        public void Toggle(int x, int y)
        {
            _gridClearer.Clear();
            Console.Write("■");
        }
    }
}