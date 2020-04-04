using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootCamp.Chapter.Maths
{
    public static class MaxDemo
    {
        public static void Run()
        {
            var numbers = new[] { 1, 2, 3, 18, 5 };

            // Same results.
            // 18
            var v1 = MaxLINQ(numbers);
            var v2 = MaxForeach(numbers);
            var v3 = numbers.MaxCustom();
        }

        private static int MaxLINQ(int[] numbers)
        {
            // Get max even number.
            return numbers
                .Where(n => n % 2 == 0)
                .Max();
        }

        private static int MaxForeach(int[] numbers)
        {
            // Get max even number.
            var max = int.MinValue;
            foreach (var number in numbers)
            {
                if (number % 2 == 0 && number > max)
                {
                    max = number;
                }
            }

            return max;
        }
    }

    public static class IEnumerableMathExtensions
    {
        public static T MaxCustom<T>(this IEnumerable<T> items, Predicate<T> predicate = null)
            where T : IComparable<T>
        {
            if (!items.Any())
            {
                return default(T);
            }

            // Get max even number.
            var max = items.First();
            foreach (var item in items)
            {
                if (item.CompareTo(max) > 0)
                {
                    if (predicate == null)
                    {
                        max = item;
                    }
                    else if(predicate(item))
                    {
                        max = item;
                    }
                }
            }

            return max;
        }
    }
}