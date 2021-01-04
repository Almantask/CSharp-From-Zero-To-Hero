using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class DisplayGrid
    {
        public static void Display(bool[][] toggles)
        {
            StringBuilder sb = new StringBuilder();
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
