using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class Utils
    {
        public static bool IsValid(string input)
        {
            return !string.IsNullOrWhiteSpace(input) || !string.IsNullOrEmpty(input);
        }
    }
}