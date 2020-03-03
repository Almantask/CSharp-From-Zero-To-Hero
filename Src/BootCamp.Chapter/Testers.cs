using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class Testers
    {
        public static bool IsThisStringValid(string file)
        {
            return (String.IsNullOrEmpty(file) || String.IsNullOrWhiteSpace(file));
        }
        public static bool IsThisStringArrayValid(this Array array)
        {
            return (array == null || array.Length == 0);
        }
    }
}
