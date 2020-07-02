using System;

namespace BootCamp.Chapter
{
    public class ToggleableGrid2D : IToggleableGrid
    {
        private readonly IGridClearer _gridClearer;
        private readonly IGridCaster<ToggleableGrid2D> grid2DCaster;
        public bool[,] Grid2D;
        public ToggleableGrid2D(bool[,] dimensions, IGridClearer gridClearer)
        {
            _gridClearer = gridClearer;
            Grid2D = dimensions ?? throw new ArgumentNullException();
            grid2DCaster = new Grid2DCaster<ToggleableGrid2D>();
            /*
            if (toggles[0,0] == true)
            {
                SpecifyRowsAndColumnsForGrid(out int rows, out int columns);
                Grid2D = new bool[rows, columns];
            }
            */
        }

        public void Toggle(int x, int y)
        {
            _gridClearer.Clear();
            Grid2D[x, y] = !Grid2D[x, y];
            grid2DCaster.CastGrid(this);
        }

        /// <summary>
        /// Allows the user to specify the dimensions of the Array
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <returns></returns>
        private int SpecifyRowsAndColumnsForGrid(out int rows, out int columns)
        {
            rows = default;
            columns = default;
            while (true)
            {
                try
                {
                    Console.WriteLine("Please specify the number of rows for the 2D Array");
                    rows = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("User input for Rows was null"));

                    Console.WriteLine("Please specify the number of colums for the 2D Array");
                    columns = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("User input for Rows was null"));
                }
                catch(ArgumentNullException ex)
                {
                    Console.WriteLine(ex);
                }               
            } 
        }
    }
}