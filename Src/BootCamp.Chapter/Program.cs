using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IGridClearer gridClearer = new GridClearer();
            ToggleableGrid2D grid2D = new ToggleableGrid2D(new bool[1,1], gridClearer);
            grid2D.Toggle(1, 1);
        }
    }
}
