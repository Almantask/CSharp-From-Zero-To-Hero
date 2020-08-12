using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter.Examples.FunctionalMinStrategy
{
    public static class MinFinder
    {
        public static T Min<T>(this IEnumerable<T> many, Func<T, T, int> compareFunc)
            => many.Aggregate((first, second) => compareFunc(first, second) < 0 ? first : second);

        public static T MinLinqOptimal<T>(IEnumerable<T> elements) where T : IComparable<T>
        {
            return elements
                .Aggregate((first, second)
                    => first.CompareTo(second) < 0 ? first : second);
        }

        public static T MinLinqOptimistic<T>(IEnumerable<T> elements) where T : IComparable<T>
        {
            return elements.OrderBy(t => t).First();
        }

        public static T FindRaw<T>(IEnumerable<T> elements) where T : IComparable<T>
        {
            T min = elements.FirstOrDefault();
            foreach (var element in elements)
            {
                if (element.CompareTo(min) < 0)
                {
                    min = element;
                }
            }

            return min;
        }
    }
}
