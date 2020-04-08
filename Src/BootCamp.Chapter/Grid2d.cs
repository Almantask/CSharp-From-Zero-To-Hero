using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Grid2d
    {
        char[,] array2d;

        public Grid2d(bool[,] array)
        {
            array2d = new char[array.GetLength(0), array.GetLength(1)];
            for (int i = 0; i < 2; i++)
            {
                for (int k = 0; k < array.GetLength(i); k++)
                {
                    if (array[i,k])
                    {
                        array2d[i, k] = '■';
                    }
                    else
                    {
                        array2d[i, k] = ' ';
                    }
                }
            }
        }
    }
}
