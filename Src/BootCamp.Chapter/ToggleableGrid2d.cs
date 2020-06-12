namespace BootCamp.Chapter
{
    public class ToggleableGrid2D : IToggleableGrid
    {
        private readonly IGridClearer _gridClearer;

        public ToggleableGrid2D(bool[,] toggles, IGridClearer gridClearer)
        {
            _gridClearer = gridClearer;
        }

        public void Toggle(int x, int y)
        {
            
        }
    }
}