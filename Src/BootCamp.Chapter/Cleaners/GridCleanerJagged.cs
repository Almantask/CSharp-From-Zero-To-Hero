namespace BootCamp.Chapter
{
    public class GridCleanerJagged : IGridClearer
    {
        bool[][] jaggedGrid;

        public GridCleanerJagged(bool[][] grid)
        {
            jaggedGrid = grid;
        }

        public void Clear()
        {
            for (int y = 0; y < jaggedGrid.Length; y++)
            {
                for (int x = 0; x < jaggedGrid[y].Length; x++)
                {
                    jaggedGrid[y][x] = false;
                }
            }
        }
    }
}
