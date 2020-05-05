using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CsvLib;

namespace BootCamp.Chapter
{
    public static class IEnumerableExtensions
    {
        public static void Enumerate<T>(this IEnumerable<T> enumerableInput, Action<T> action)
        {
            if (enumerableInput?.Any() != true)
            {
                throw new ArgumentException($"{enumerableInput} can not bet null or empty", nameof(enumerableInput));
            }

            foreach (var item in enumerableInput)
            {
                action(item);
            }
        }

        public static decimal AverageOrZero(this IEnumerable<decimal> input)
        {
            return input.Any() ? input.Average() : 0m;
        }

        public static string ToStringFormated<T>(this IEnumerable<T> enumerableInput, char delimiter)
        {
            if (enumerableInput?.Any() != true)
            {
                throw new ArgumentException($"{enumerableInput} can not bet null or empty", nameof(enumerableInput));
            }

            var firstColumn = true;
            var builder = new StringBuilder();

            foreach (var item in enumerableInput)
            {
                var itemString = item.ToString();
                if (itemString.IsValid())
                {
                    if (!firstColumn)
                    {
                        builder.Append(delimiter);
                    }

                    builder.Append(item);

                    firstColumn = false;
                }
            }

            return builder.ToString();
        }

        public static void Print<T>(this IEnumerable<T> enumerableInput, char delimiter)
        {
            if (enumerableInput?.Any() != true)
            {
                throw new ArgumentException($"{enumerableInput} can not bet null or empty", nameof(enumerableInput));
            }

            Console.WriteLine(enumerableInput.ToStringFormated(delimiter));
        }
    }
}