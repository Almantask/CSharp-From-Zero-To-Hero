using BootCamp.Chapter.Renderer;
using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[][] toggles = new bool[3][];
            toggles[0] = new bool[3];
            toggles[1] = new bool[3];
            toggles[2] = new bool[3];

            //ToggleableGridJagged toggleableGrid = new ToggleableGridJagged(toggles, null);

            //Console.WriteLine("First Toggle:");
            //toggleableGrid.Toggle(0, 0);

            //Console.WriteLine();

            //Console.WriteLine("Second Toggle:");
            //toggleableGrid.Toggle(0, 1);

            //Console.WriteLine();

            //Console.WriteLine("Third Toggle:");
            //toggleableGrid.Toggle(0, 2);

            //Console.WriteLine();

            //Console.WriteLine("Fourth Toggle:");
            //toggleableGrid.Toggle(1, 0);

            //Console.WriteLine();

            //Console.WriteLine("Fifth Toggle:");
            //toggleableGrid.Toggle(1, 1);

            //Console.WriteLine();

            //Console.WriteLine("Sixth Toggle:");
            //toggleableGrid.Toggle(1, 2);

            //Multidimensional

            bool[,] multiDimensionalArray = new bool[4, 2];
            ToggleableGrid2D toggleableGrid2D = new ToggleableGrid2D(multiDimensionalArray, null);

            Console.WriteLine("First Toggle:");
            toggleableGrid2D.Toggle(0, 0);

            Console.WriteLine();

            Console.WriteLine("Second Toggle:");
            toggleableGrid2D.Toggle(0, 1);

            Console.WriteLine();

            Console.WriteLine("Third Toggle:");
            toggleableGrid2D.Toggle(1, 0);

            Console.WriteLine();

            Console.WriteLine("Fourth Toggle:");
            toggleableGrid2D.Toggle(1, 1);

            Console.WriteLine();

            Console.WriteLine("Fifth Toggle:");
            toggleableGrid2D.Toggle(2, 0);

            Console.WriteLine();

            Console.WriteLine("Sixth Toggle:");
            toggleableGrid2D.Toggle(2, 1);

            Console.WriteLine("Seventh Toggle:");
            toggleableGrid2D.Toggle(3, 0);

            Console.WriteLine();

            Console.WriteLine("Eight Toggle:");
            toggleableGrid2D.Toggle(3, 1);
        }
    }
}
