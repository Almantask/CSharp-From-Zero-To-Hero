using System;

namespace BootCamp.Chapter
{
    public static class Lesson5
    {
        private static ToggleableGrid2D CreateTwoDGrid()
        {
            Console.WriteLine("How much rows do you want the grid to be");
            var input = Console.ReadLine();
            var rows = ValidateInput(input);

            var grid = new bool[rows, rows];
            
            var cleaner = new GridCleaner();
            var twoDGrid = new ToggleableGrid2D(grid, cleaner);

            return twoDGrid;                 

        }

        public static void RunTwoDGrid()
        {
            var TwoDArray = CreateTwoDGrid(); 
            int x, y;
            InputToggle(out x, out y);
            TwoDArray.Toggle(x, y);
        }

        private static void InputToggle(out int x, out int y)
        {
            Console.WriteLine("Give me the x-coordinate of a cell which you want to toggle");
            var input = Console.ReadLine();
            x = ValidateInput(input);
            Console.WriteLine("Give me the y-coordinate of a cell which you want to toggle");
            input = Console.ReadLine();
            y = ValidateInput(input);
        }

        public static void RunJaggedGrid()
        {
            var jaggedArray = CreateJaggedArray();
            int x, y;
            InputToggle(out x, out y);
            jaggedArray.Toggle(x, y);
        }

        private static ToggleableGridJagged CreateJaggedArray()
        {
            Console.WriteLine("How much rows do you want the grid to be");
            var input = Console.ReadLine();
            var rows = ValidateInput(input);

            var grid = new bool[rows][];
            
            var cleaner = new GridCleaner();
            var jaggedDGrid = new ToggleableGridJagged(grid, cleaner);

            return jaggedDGrid; 

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