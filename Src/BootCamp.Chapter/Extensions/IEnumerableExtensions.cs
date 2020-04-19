using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class IEnumerableExtensions
    {
        public static string ToStringFormated<T>(this IEnumerable<T> enumerableInput, char delimiter)
        {
            if (enumerableInput is null)
            {
                throw new ArgumentException(nameof(enumerableInput), $"{enumerableInput} can not bet null or empty");
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
            if (enumerableInput is null)
            {
                throw new ArgumentException(nameof(enumerableInput), $"{enumerableInput} can not bet null or empty");
            }

            Console.WriteLine(enumerableInput.ToStringFormated(delimiter));
        }
    }
}