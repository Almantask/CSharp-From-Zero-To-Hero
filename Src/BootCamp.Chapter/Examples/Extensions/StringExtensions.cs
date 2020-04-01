using System;

namespace BootCamp.Chapter.Examples.Extensions
{
    public static class StringExtensions
    {
        public static string ToPascalCase(this string text)
        {
            if (string.IsNullOrEmpty(text)) return text;

            return text[0].ToString().ToUpper() + text[1..];
        }
    }
}
