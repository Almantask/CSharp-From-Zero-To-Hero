 using System;
using System.Text; 

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
            _toggle[x][y] = !_toggle[x][y];
            DisplayGrid.Display(_toggle);
        }
        private void CheckInput(int x,int y)
        {
            if (x >= _toggle.GetLength(0) || x < 0)
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