using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    public static class LinqMethods
    {
        public static IEnumerable<T> SnapFingers<T>(IEnumerable<T> collection, Predicate<T> predicate)
        {
            List<T> collectionList = collection.Where(x => predicate(x)).Shuffle().ToList();

            int numberOfElements = collectionList.Count;

            if (numberOfElements % 2 == 1)
            {
                collectionList.RemoveRange(0, (numberOfElements - 1) / 2);
            }
            else
            {
                collectionList.RemoveRange(0, numberOfElements / 2);
            }

            return collectionList;
        }
    }
}
