using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Demos
{
    public class Demo2DArrays
    {
        public static void Demo()
        {
            Console.WriteLine("Demoing 2DimensionalArray rendering.");
            bool[,] TwoDArray = new bool[4, 2];

            ToggleableGrid2D toggleableGrid2D = new ToggleableGrid2D(TwoDArray, new GridClearer());

            Console.WriteLine("First Toggle:");
            toggleableGrid2D.Toggle(0, 0);

            Console.WriteLine("Second Toggle:");
            toggleableGrid2D.Toggle(0, 1);

            Console.WriteLine("Third Toggle:");
            toggleableGrid2D.Toggle(1, 0);

            Console.WriteLine("Fourth Toggle:");
            toggleableGrid2D.Toggle(1, 1);
        }
    }
}
