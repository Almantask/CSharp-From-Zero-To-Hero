using System;

namespace BootCamp.Chapter
{
    public class ToggleableGridJagged : IToggleableGrid
    {
        private readonly IGridClearer _gridClearer;
        private readonly bool[][] _toggle;

        public ToggleableGridJagged(bool[][] toggles, IGridClearer gridClearer)
        {
            _toggle = toggles;
            _gridClearer = gridClearer;
        }

        public void Toggle(int x, int y)
        {
        }
    }
} 