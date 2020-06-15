using BootCamp.Chapter.Renderer;
using System;

namespace BootCamp.Chapter
{
    public class ToggleableGridJagged : IToggleableGrid
    {
        private readonly IGridClearer _gridClearer;
        private readonly IGridRenderer<ToggleableGridJagged> _gridRenderer;

        public bool[][] Toggleables { get; }

        public ToggleableGridJagged(bool[][] toggles, IGridClearer gridClearer)
        {
            _gridClearer = gridClearer ?? throw new ArgumentNullException();
            _gridRenderer = new JaggedArrayRenderer<ToggleableGridJagged>();

            Toggleables = toggles ?? throw new ArgumentNullException();
        }

        public void Toggle(int x, int y)
        {
            _gridClearer.Clear();

            Toggleables[x][y] = !Toggleables[x][y];
            _gridRenderer.Render(this);
        }
    }
}