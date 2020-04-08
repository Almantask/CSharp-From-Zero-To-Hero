using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> SnapFingers<T>(this IEnumerable<T> list, Predicate<T> predicate)
        {
            var list2 = list.Where(x => predicate(x)).ToList();
            var list3 = list2.RemoveHalfElementsAtRandom();

            return list3; 
        }

        public static List<T> RemoveHalfElementsAtRandom<T>(this IEnumerable<T> list)
        {
            var indexOfHalfList = Math.Floor((float)list.Count() / 2);
            var convertedToList = list.ToList();
            var halfList = new List<T>();
            // I start the loop one after the half of the list so I can remove all the items needed
            for (int i = 0; i <= indexOfHalfList; i++)
            {
                halfList.Add(convertedToList[i]);
            }

            return halfList;
        }

        public static IEnumerable<T> ShuffleColllectionExtension<T>(this IEnumerable<T> list)
        {
            var random = new Random();
            var buffer = list.ToList();
            var size = buffer.Count();
            for (int i = 0; i < size; i++)
            {
                var newPosition = random.Next(0, size);
                // here I swap items but first I have to store a old value somewhere befor its going to be overwritten
                var tmp = buffer[newPosition];
                buffer[newPosition] = buffer[i];
                buffer[i] = tmp;
            }

            return buffer;
        }
    }
}