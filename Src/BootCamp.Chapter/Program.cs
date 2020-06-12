using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[][] jaggedArray = new bool[3][];
            ToggleableGridJagged toggleableGridJagged = new ToggleableGridJagged(jaggedArray, null);
        }
    }
}
