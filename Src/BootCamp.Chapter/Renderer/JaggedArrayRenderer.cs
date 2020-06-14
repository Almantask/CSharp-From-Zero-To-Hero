using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Renderer
{
    public class JaggedArrayRenderer<TJaggedArray> : IGridRenderer<TJaggedArray> where TJaggedArray : ToggleableGridJagged
    {
        public void Render(TJaggedArray grid)
        {
            for (int i = 0; i < grid.Toggleables.Length; i++)
            {
                for (int j = 0; j < grid.Toggleables[i].Length; j++)
                {
                    Console.Write(grid.Toggleables[i][j] ? "■" : " ");
                }

                //We prevent WriteLine at the last row
                if (i != grid.Toggleables.Length - 1) Console.WriteLine();
            }
        }
    }
}
