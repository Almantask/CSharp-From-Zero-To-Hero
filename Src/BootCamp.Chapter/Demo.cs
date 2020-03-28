using System;

namespace BootCamp.Chapter
{
    internal class Demo1
    {
        internal static void TwoDGrid()
        {
            Console.WriteLine("How much rows do you want the grid to be");
            var input = Console.ReadLine();
            var rows = ValidateInput(input);

            var grid = new bool[rows, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    grid[i, j] = false;
                }

            }

            var cleaner = new GridCleaner();
            var twoDGrid = new ToggleableGrid2D(grid, cleaner);
            int x, y;
            InputToggle(out input, out x, out y);

            twoDGrid.Toggle(x, y);

        }

        private static void InputToggle(out string input, out int x, out int y)
        {
            Console.WriteLine("Give me the x-coordinate of a cell which you want to toggle");
            input = Console.ReadLine();
            x = ValidateInput(input);
            Console.WriteLine("Give me the y-coordinate of a cell which you want to toggle");
            input = Console.ReadLine();
            y = ValidateInput(input);
        }

        internal static void JaggedArray()
        {
            Console.WriteLine("How much rows do you want the grid to be");
            var input = Console.ReadLine();
            var rows = ValidateInput(input);

            var grid = new bool[rows][];
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"How much columns do you want row {i} to be");
                input = Console.ReadLine();
                var columns = ValidateInput(input);

                for (int j = 0; j <columns; j++)
                {
                    grid[i][j] = false;
                }

            }

            var cleaner = new GridCleaner();
            var jaggedDGrid = new ToggleableGridJagged(grid, cleaner);

            int x, y;
            InputToggle(out input, out x, out y); 

            jaggedDGrid.Toggle(x, y);

        }

        private static int ValidateInput(string input)
        {
            var isValid = int.TryParse(input, out int number); 
            if (!isValid)
            {
                throw new ArgumentException(); 
            }

            return number; 
        }
    }
}