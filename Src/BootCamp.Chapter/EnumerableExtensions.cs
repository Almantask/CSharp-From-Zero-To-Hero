using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Invokes average if the sequence contains elements, otherwise returns 0.
        /// </summary>
        /// <returns>The average of the sequence of values.</returns>
        public static decimal AverageOrZero(this IEnumerable<decimal> sequence) => sequence.Any() ? sequence.Average() : 0m;
    }
}
