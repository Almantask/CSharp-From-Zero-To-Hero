using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public static class ListExtensions
    {
        /// <summary>
        /// https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
        /// </summary>
        public static void Shuffle<T>(this IList<T> items)
        {
            var count = items.Count;
            while (count > 1)
            {
                count--;
                var index = Next(count + 1);
                Swap(items, index, count);
            }
        }

        private static void Swap<T>(IList<T> items, int index1, int index2)
        {
            var value = items[index2];
            items[index2] = items[index1];
            items[index1] = value;
        }

        private static int Next(int max) => Randomizer.Instance.Next(max);
    }
}
