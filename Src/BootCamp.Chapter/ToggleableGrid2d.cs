using System;

namespace BootCamp.Chapter
{
    public class ToggleableGrid2D : IToggleableGrid
    {
        private readonly IGridClearer _gridClearer;
        private readonly IGridCaster<ToggleableGrid2D> grid2DCaster;
        public bool[,] Grid2D;

        public ToggleableGrid2D(bool[,] dimensions, IGridClearer gridClearer)
        {
            _gridClearer = gridClearer;
            Grid2D = dimensions ?? throw new ArgumentNullException();
            grid2DCaster = new Grid2DCaster<ToggleableGrid2D>();
        }

        public void Toggle(int x, int y)
        {
            _gridClearer.Clear();
            Grid2D[x, y] = !Grid2D[x, y];
            grid2DCaster.CastGrid(this);
        }
    }
}