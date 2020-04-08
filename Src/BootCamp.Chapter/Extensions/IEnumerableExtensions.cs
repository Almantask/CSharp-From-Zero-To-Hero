using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Extensions
{
    public static class IEnumerableExtensions
    {
        public static void Print<T>(this IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
