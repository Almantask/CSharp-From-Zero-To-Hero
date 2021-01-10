using BootCamp.Chapter.Cleaners;
using System;

namespace BootCamp.Chapter.Grid2d
{
    public static class Grid2dApp
    {
        public static void Run2dApp()
        {
            Console.Write("State amount of rows in the grid (y): ");
            int rows = KeyboardInput.ReadLineReturnInt(1);

            Console.Write($"State number of cells per row (x): ");
            int cells = KeyboardInput.ReadLineReturnInt(1);

            bool[,] grid2D = new bool[cells, rows];

            GridCleaner2D grid2dClearer = new GridCleaner2D(grid2D);
            ToggleableGrid2D toggleableGrid2D = new ToggleableGrid2D(grid2D, grid2dClearer);
            ToggleableGrid2D.printWithBorder = true;

            do
            {
                Console.WriteLine("Toggle element on/off with stating x,y.");
                Console.Write("Enter x or type 0 to quit: ");

                int x = KeyboardInput.ReadLineReturnInt(0, cells);

                if (x == 0)
                {
                    break;
                }

                Console.Write("Enter y: ");

                int y = KeyboardInput.ReadLineReturnInt(1, rows);

                toggleableGrid2D.Toggle(x - 1, y - 1);

                Console.WriteLine("Do you want to clear the grid? Press y/n: ");
                
                char inputKeyStroke = Console.ReadKey(true).KeyChar;

                switch (inputKeyStroke)
                {
                    case 'y':
                        grid2dClearer.Clear();
                        toggleableGrid2D.PrintGridWithBorder();
                        break;
                    default:
                        break;
                }
            } while (true);
        }
    }
}
