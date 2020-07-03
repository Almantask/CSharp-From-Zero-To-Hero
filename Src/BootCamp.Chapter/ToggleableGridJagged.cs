using System;

namespace BootCamp.Chapter
{
    public class ToggleableGridJagged : IToggleableGrid
    {
        private readonly IGridClearer _gridClearer;
        private readonly IGridCaster<ToggleableGridJagged> gridJaggedCaster;
        public bool[][] GridJagged;

        public ToggleableGridJagged(bool[][] dimensions, IGridClearer gridClearer)
        {
            _gridClearer = gridClearer;
            GridJagged = dimensions ?? throw new ArgumentNullException();
            gridJaggedCaster = new JaggedGridCaster<ToggleableGridJagged>();
        }

        public void Toggle(int x, int y)
        {
            _gridClearer.Clear();
            GridJagged[x][y] = !GridJagged[x][y];
            gridJaggedCaster.CastGrid(this);
        }
    }
}