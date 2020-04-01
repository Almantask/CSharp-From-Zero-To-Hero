using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.Extensions
{
    public static class EnumerableExtensions
    {
        public static string ToString<T>(this IEnumerable<T> items)
        {
            var sb = new StringBuilder();
            foreach (var item in items)
            {
                var itemString = item.ToString();
                if (!string.IsNullOrWhiteSpace(itemString))
                {
                    sb.AppendLine(itemString);
                }
            }

            return sb.ToString();
        }

        public static void Print<T>(this IEnumerable<T> items) 
            => Console.WriteLine(ToString(items));
    }
}