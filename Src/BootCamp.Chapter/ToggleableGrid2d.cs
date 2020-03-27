using System;

namespace BootCamp.Chapter
{
    public class ToggleableGrid2d : IToggleableGrid
    {
        private readonly bool[][] _toggles;

        public ToggleableGrid2d(bool[][] toggles)
        {
            _toggles = toggles; 
        }

        public void Toggle(int x, int y)
        {
            var current = _toggles[x][y];
            _toggles[x][y] = !current;
            Redraw(_toggles); 
        }

        private void Redraw(bool[][] toggles)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            var numberOfRows = toggles.Length;
            var numberOfCols = toggles.GetLength(0);

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfCols; j++)
                {
                    if (toggles[i][j])
                    {
                        Console.Write("\u25A0");
                    }
                   
                }

                if (i < numberOfRows - 1)
                {
                    Console.Write($"{Environment.NewLine}");
                }
                
                 
            }
        }
    }
}