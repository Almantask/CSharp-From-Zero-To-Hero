using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Renderer
{
    public class TwoDimensionalArrayRenderer<T2DArray> : IGridRenderer<T2DArray> where T2DArray : ToggleableGrid2D
    {
        public void Render(T2DArray grid)
        {
            var rows = grid.Toggleables.GetLength(0);
            var columns = grid.Toggleables.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(grid.Toggleables[i, j] ? "■" : " ");
                }

                //We prevent WriteLine at the last row
                if (i < rows - 1) Console.WriteLine();
            }
        }
    }
}
