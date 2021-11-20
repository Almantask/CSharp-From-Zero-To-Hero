using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class ClearGrid : IGridClearer
    {
        public void Clear()
        {
            Console.Clear();
        }
    }
}
