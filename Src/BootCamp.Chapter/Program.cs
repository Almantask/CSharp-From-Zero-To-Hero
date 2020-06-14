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

            Console.WriteLine(MostCommonLetterFinder.Find("This is a test sentence with a ton of t-s inside of it."));
        }
    }
}
