using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ToggleableGrid2D grid = new ToggleableGrid2D(new bool[2, 5]);
            grid.Toggle(1, 4);
        }
    }
}
