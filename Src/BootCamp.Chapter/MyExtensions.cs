using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public static class MyExtensions
    {
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> collection)
        {
            var collectionList = EnumerableToList(collection);

            List<T> shuffledList = new List<T>();

            Random random = new Random();

            while(collectionList.Count > 0)
            {
                int nextElement = random.Next(collectionList.Count);

                shuffledList.Add(collectionList[nextElement]);

                collectionList.RemoveAt(nextElement);
            }

            return shuffledList;
        }

        public static List<T> EnumerableToList<T>(IEnumerable<T> collection)
        {
            List<T> tempList = new List<T>();

            foreach (var item in collection)
            {
                tempList.Add(item);
            }

            return tempList;
        }
    }
}
