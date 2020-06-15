using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Demos
{
    public static class DemoJaggedArrays
    {
        public static void Demo()
        {
            Console.WriteLine("Demoing JaggedArray rendering.");
            bool[][] jaggedArray = new bool[2][];
            jaggedArray[0] = new bool[2];
            jaggedArray[1] = new bool[2];

            ToggleableGridJagged toggleableGrid = new ToggleableGridJagged(jaggedArray, new GridClearer());

            Console.WriteLine("First Toggle:");
            toggleableGrid.Toggle(0, 0);

            Console.WriteLine();

            Console.WriteLine("Second Toggle:");
            toggleableGrid.Toggle(0, 1);

            Console.WriteLine();

            Console.WriteLine("Third Toggle:");
            toggleableGrid.Toggle(1, 0);

            Console.WriteLine();

            Console.WriteLine("Fourth Toggle:");
            toggleableGrid.Toggle(1, 1);
        }
    }
}
