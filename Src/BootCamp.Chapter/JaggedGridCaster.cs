using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class JaggedGridCaster<TToggleableGridJagged> : IGridCaster<TToggleableGridJagged> where TToggleableGridJagged : ToggleableGridJagged    
    {
        public void CastGrid(TToggleableGridJagged grid)
        {
            for (int i = 0; i < grid.GridJagged.Length; i++)
            {
                for (int j = 0; j < grid.GridJagged[i].Length; j++)
                {
                    if (grid.GridJagged[i][j])
                    {
                        Console.Write("■");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                if (i != grid.GridJagged.Length - 1) Console.WriteLine();
            }
        }
    }
}
