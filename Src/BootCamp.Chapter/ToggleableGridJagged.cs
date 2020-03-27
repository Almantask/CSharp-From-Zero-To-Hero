using System;

namespace BootCamp.Chapter
{
    public class ToggleableGridJagged : IToggleableGrid
    {
        public ToggleableGridJagged(bool[][] toggles)
        {
        }

        public void Toggle(int x, int y)
        {
            Console.Write("■");
        }
    }
}