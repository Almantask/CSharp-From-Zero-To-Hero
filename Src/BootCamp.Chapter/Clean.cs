using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Clean:IGridClearer
    {
        public void Clear()
        {
            int top = Console.CursorTop;
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i <= top; i++)
            {
                Console.WriteLine("      ");
            }
        }
    }
}
