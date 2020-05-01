using System;

namespace BootCamp.Homework.Menu
{
    public class GridMenu
    {
        private readonly GridClearer _clearer = new GridClearer();
        
        public void DisplayGridJaggedMenu()
        {
            Console.WriteLine("Enter GridJagged size (rows,columns):");
            var gridSize = GetGrid();
            
            var grid = new bool[gridSize[0]][];
            for (var i = 0; i < gridSize[0]; i++)
            {
                grid[i] = new bool[gridSize[1]];
            }
            
            var gridJagged = new ToggleableGridJagged(grid, _clearer);
            DisplayCommonMenu(gridJagged);
        }

        public void DisplayGrid2dMenu()
        {
            Console.WriteLine("[Grid2d]");
            var gridSize = GetGrid();
            var grid = new bool[gridSize[0], gridSize[1]];
            
            var grid2d = new ToggleableGrid2D(grid, _clearer);
            DisplayCommonMenu(grid2d);
        }

        private void DisplayCommonMenu(IToggleableGrid grid)
        {
            grid.PrintTable();
            do
            {
                Console.WriteLine();
                Console.WriteLine("Select which element you want to toggle (row,column):");
                var toggleOption = GetGrid();
                grid.Toggle(toggleOption[0], toggleOption[1]);
            } while (true);
        }

        private int[] GetGrid()
        {
            const string invalid = "Invalid try again";
            
            do
            {
                Console.WriteLine("Enter grid size (rows,columns) | Max(10,10):");
                var size = Console.ReadLine();
                if (string.IsNullOrEmpty(size))
                {
                    Console.WriteLine(invalid);
                    continue;
                }
                
                var sizeToVerify = size.Split(',');
                if (sizeToVerify.Length != 2)
                {
                    Console.WriteLine(invalid);
                    continue;
                }

                var isValid = int.TryParse(sizeToVerify[0], out var row) | int.TryParse(sizeToVerify[1], out var column);
                if (!isValid)
                {
                    Console.WriteLine(invalid);
                    continue;
                }

                if (row < 0 || row > 10 || column < 0 || column > 10)
                {
                    Console.WriteLine(invalid);
                    continue;
                }

                return new[] {row, column};

            } while (true);
        }
    }
}