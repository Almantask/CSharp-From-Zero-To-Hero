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
            bool[][] tempToggle = new bool[100][100]();
            for (int i = 0; i < _toggle.GetLength(0);i++)
            {
                for (int j = 0; j < _toggle.GetLength(1); j++)
                {
                    tempToggle[i][j] = _toggle[i,j];
                }
            }
            //DisplayGrid.Display(x, y, tempToggle);
        }
        private void CheckInput(int x, int y)
        {
            if (x >= _toggle.GetLength(0) || x < 0)
                throw new IndexOutOfRangeException();
            if (y >= _toggle.GetLength(1) || y < 0)
                throw new IndexOutOfRangeException();
        }
        //public void Backup(int x,int y)
        //{
        //    _toggle[x, y] = !_toggle[x, y];
        //    StringBuilder sb = new StringBuilder();
        //    CheckInput(x, y);
        //    for (int i = 0; i < _toggle.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < _toggle.GetLength(1); j++)
        //        {
        //            if (_toggle[i, j])
        //            {
        //                sb.Append("■");
        //            }
        //            else
        //            {
        //                sb.Append(" ");
        //            }
        //        }
        //        sb.Append(Environment.NewLine);
        //    }
        //    var str = sb.ToString().TrimEnd("\r\n".ToCharArray());
        //    Console.Write(str);
        //}
    }
}