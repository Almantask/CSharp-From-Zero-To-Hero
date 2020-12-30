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
            _toggle[x][y] = !_toggle[x][y];
            StringBuilder sb = new StringBuilder();            
            CheckInput(x, y);
            for(int i = 0; i < _toggle.Rank; i++)
            {
                for (int j = 0; j <_toggle[i].Length; j++)
                {
                    if (_toggle[i][j])
                    {
                        sb.Append("■");
                    }
                    else
                    {
                        sb.Append(" ");
                    }
                }
                sb.Append(Environment.NewLine);
            }           
            var str = sb.ToString().TrimEnd("\r\n".ToCharArray());
            Console.Write(str);
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