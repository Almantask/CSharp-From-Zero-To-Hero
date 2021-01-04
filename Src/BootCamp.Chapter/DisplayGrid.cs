using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class DisplayGrid
    {
        public static void Display(int x,int y, bool[][] toggles)
        {
            StringBuilder sb = new StringBuilder();
            toggles[x][y] = !toggles[x][y];
            for (int i = 0; i < toggles.GetLength(0); i++)
            {
                for (int j = 0; j < toggles[i].Length; j++)
                {
                    if (toggles[i][j])
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
    }
}
