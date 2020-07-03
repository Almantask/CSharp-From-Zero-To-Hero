using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Grid2DCaster<TToggleGrid2d> : IGridCaster<TToggleGrid2d> where TToggleGrid2d : ToggleableGrid2D
    {
        public void CastGrid(TToggleGrid2d grid)
        {
            for (int i = 0; i < grid.Grid2D.GetLength(0); i++)
            {
                for (int j = 0; j < grid.Grid2D.GetLength(1); j++)
                {
                    if (grid.Grid2D[i, j])
                    {
                        Console.Write("■");
                    }
                    else
                    {
                        Console.Write(" ");
                    }           
                }
                if (i != grid.Grid2D.GetLength(0) - 1) Console.WriteLine();
            }
        }
    }
}
