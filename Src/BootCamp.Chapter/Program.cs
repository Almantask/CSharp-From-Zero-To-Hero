using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] a = new bool[2,2];
            GridClearer gc = new GridClearer();
            ToggleableGrid2D tg2d = new ToggleableGrid2D(a,gc);
            tg2d.Toggle(1,1);
        }
    }
}
