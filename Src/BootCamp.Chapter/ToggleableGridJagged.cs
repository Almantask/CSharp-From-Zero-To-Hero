using System;

namespace BootCamp.Chapter
{
    public class ToggleableGridJagged : IToggleableGrid
    {
        private readonly IGridClearer _gridClearer;

        public ToggleableGridJagged(bool[][] toggles, IGridClearer gridClearer)
        {
            _gridClearer = gridClearer ?? throw new ArgumentNullException();
        }

        public void Toggle(int x, int y)
        {
        }
    }
}