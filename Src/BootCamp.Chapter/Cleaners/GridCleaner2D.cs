namespace BootCamp.Chapter.Cleaners
{
    public class GridCleaner2D : IGridClearer
    {
        static bool[,] grid2D;

        public GridCleaner2D(bool[,] grid)
        {
            grid2D = grid;
        }

        public void Clear()
        {
            for (int y = 0; y < grid2D.GetLength(1); y++)
            {
                for (int x = 0; x < grid2D.GetLength(0); x++)
                {
                    grid2D[x,y] = false;
                }
            }
        }
    }
}
