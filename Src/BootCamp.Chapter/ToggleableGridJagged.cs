 using System;

namespace BootCamp.Chapter
{
    public class ToggleableGridJagged : IToggleableGrid
    {
        private readonly IGridClearer _gridClearer;
        private readonly bool[][] _toggle;

        public ToggleableGridJagged(bool[][] toggles, IGridClearer gridClearer)
        {
            _toggle = toggles;
            _gridClearer = gridClearer;
        }

        public void Toggle(int x, int y)
        {
            CheckInput(x, y);
            for(int i =0; i <= y; i++)
            {
                if (_toggle[x][i])
                {
                    _toggle[x][i] = false;
                    Console.WriteLine(" ");
                }
                else
                {
                    _toggle[x][i] = true;
                    Console.WriteLine("■");
                }
            }          
        }
        private void CheckInput(int x,int y)
        {
            if (x >= _toggle.Rank||x < 0)
                throw new IndexOutOfRangeException();
            if(y >= _toggle[x].Length || y < 0)
                throw new IndexOutOfRangeException();
        }
        public void CleanConsole()
        {
            _gridClearer.Clear();
        }
    }
} 