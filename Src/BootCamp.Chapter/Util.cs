using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class Util
    {
        public static bool IsNumeric(string s)
        {
            return double.TryParse(s, out _);
        }
    }
}