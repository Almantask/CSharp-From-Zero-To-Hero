using System;

namespace BootCamp.Chapter.JaggedGrid
{
    public class JaggedApp
    {
        public static void RunJaggedApp()
        {
            Console.Write("State amount of rows in grid: ");
            int rows = KeyboardInput.ReadLineReturnInt(1);

            bool[][] jaggedGrid = new bool[rows][];

            for (int i = 0; i < rows; i++)
            {
                Console.Write($"State number of cells in row {i + 1}: ");
                int cells = KeyboardInput.ReadLineReturnInt(1);

                jaggedGrid[i] = new bool[cells];
            }

            GridCleanerJagged jaggedGridClearer = new GridCleanerJagged(jaggedGrid);
            ToggleableGridJagged toggleableGridJagged = new ToggleableGridJagged(jaggedGrid, jaggedGridClearer);
            ToggleableGridJagged.printWithBorder = true;

            do
            {
                Console.WriteLine("Toggle element on/off with stating x,y.");
                Console.Write("Enter x or type 0 to quit: ");

                int x = KeyboardInput.ReadLineReturnInt(0, jaggedGrid.Length);

                if (x == 0)
                {
                    break;
                }

                Console.Write("Enter y: ");
                int y = KeyboardInput.ReadLineReturnInt(1);

                toggleableGridJagged.Toggle(x - 1, y - 1);

                Console.WriteLine("Do you want to clear the grid? Press y/n: ");

                char inputKeyStroke = Console.ReadKey(true).KeyChar;

                switch (inputKeyStroke)
                {
                    case 'y':
                        jaggedGridClearer.Clear();
                        toggleableGridJagged.PrintGridWithBorder();
                        break;
                    default:
                        break;
                }
            } while (true);
        }
    }
}
