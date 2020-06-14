using BootCamp.Chapter.Renderer;
using System;

namespace BootCamp.Chapter
{
    public class ToggleableGrid2D : IToggleableGrid
    {
        private readonly IGridClearer _gridClearer;
        private readonly IGridRenderer<ToggleableGrid2D> _gridRenderer;

        public bool[,] Toggleables { get; }
        public int Length { get; }

        public ToggleableGrid2D(bool[,] toggles, IGridClearer gridClearer)
        {
            _gridClearer = gridClearer ?? throw new ArgumentNullException();
            _gridRenderer = new TwoDimensionalArrayRenderer<ToggleableGrid2D>();

            Toggleables = toggles ?? throw new ArgumentNullException();
        }

        public void Toggle(int x, int y)
        {
            Toggleables[x, y] = !Toggleables[x, y];
            _gridRenderer.Render(this);
        }
    }
}