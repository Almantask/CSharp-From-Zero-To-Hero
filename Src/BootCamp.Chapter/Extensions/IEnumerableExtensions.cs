using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Extensions
{
    public static class IEnumerableExtensions
    {
        public static string ToStringFormated<T>(this IEnumerable<T> enumerableInput)
        {
            if (enumerableInput is null)
            {
                throw new ArgumentException(nameof(enumerableInput), $"{enumerableInput} can not bet null or empty");
            }

            var sb = new StringBuilder();
            foreach (var item in enumerableInput)
            {
                var itemString = item.ToString();
                {
                    if (itemString.IsValid())
                    {
                        sb.Append(item).Append(",");
                    }
                }
            }

            if (sb.Length != 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }

            return sb.ToString();
        }

        public static void Print<T>(this IEnumerable<T> enumerableInput)
        {
            if (enumerableInput is null)
            {
                throw new ArgumentException(nameof(enumerableInput), $"{enumerableInput} can not bet null or empty");
            }

            Console.WriteLine(enumerableInput.ToStringFormated());
        }
    }
}