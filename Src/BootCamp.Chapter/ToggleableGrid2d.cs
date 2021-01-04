using System;
using System.Text;

namespace BootCamp.Chapter
{
    public class ToggleableGrid2D : IToggleableGrid
    {
        private readonly IGridClearer _gridClearer;
        private readonly bool[,] _toggle;

        public ToggleableGrid2D(bool[,] toggles, IGridClearer gridClearer)
        {
            _toggle = toggles;
            _gridClearer = gridClearer;
            
        }
        public void Toggle(int x, int y)
        {
            CheckInput(x, y);
            int top = _toggle.GetLength(0);
            int left = _toggle.GetLength(1);
            bool[][] tempToggle = new bool[top][];
            _toggle[x,y] = !_toggle[x,y];
            for (int i = 0; i < top; i++)
            {
                tempToggle[i] = new bool[left];
                for (int j = 0; j < left; j++)
                {
                    tempToggle[i][j] = _toggle[i, j];
                }
            }
            DisplayGrid.Display(tempToggle);
        }
        private void CheckInput(int x, int y)
        {
            if (x >= _toggle.GetLength(0) || x < 0)
                throw new IndexOutOfRangeException();
            if (y >= _toggle.GetLength(1) || y < 0)
                throw new IndexOutOfRangeException();
        }
    }
}