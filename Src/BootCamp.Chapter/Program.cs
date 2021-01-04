using System;
using static System.Console;
using System.Threading;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "asdII";
            WriteLine(MostCommonLetterFinder.Find(s)); //a
            var like =new bool[][] { new bool[]{false, false},new bool[]{false,false} };
            IGridClearer clearer = new Clean();
            ToggleableGridJagged jagged = new ToggleableGridJagged(like, clearer);
            jagged.Toggle(1, 1);
            WriteLine();
            jagged.Toggle(1, 1);
            WriteLine();
            jagged.Toggle(0, 0);
            WriteLine();

            var test = new bool[,] { {false} };
            ToggleableGrid2D grid2D = new ToggleableGrid2D(test, null);
            grid2D.Toggle(0, 0);
            WriteLine();
            grid2D.Toggle(0, 0);

            //Thread.Sleep(2000);
            //jagged.CleanConsole();

        }
    }
}
