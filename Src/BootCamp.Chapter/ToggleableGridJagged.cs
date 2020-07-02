using System;

namespace BootCamp.Chapter
{
    public class ToggleableGridJagged : IToggleableGrid
    {
        private readonly IGridClearer _gridClearer;
        private readonly IGridCaster<ToggleableGridJagged> gridJaggedCaster;
        public bool[][] GridJagged;

        public ToggleableGridJagged(bool[][] dimensions, IGridClearer gridClearer)
        {
            _gridClearer = gridClearer;
            GridJagged = dimensions ?? throw new ArgumentNullException();
            gridJaggedCaster = new JaggedGridCaster<ToggleableGridJagged>();
            /*
            if (toggles[0][0] == true)
            {
                SpecifyRowsAndColumnsForGrid(out int rows, out int columns);
                var numOfElements = rows * columns;
                GridJagged = new bool[numOfElements][];
            }
            */
        }

        public void Toggle(int x, int y)
        {
            _gridClearer.Clear();
            GridJagged[x][y] = !GridJagged[x][y];
            gridJaggedCaster.CastGrid(this);
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
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}