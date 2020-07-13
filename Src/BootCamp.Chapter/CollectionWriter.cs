using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public static class CollectionWriter
    {
        public static void WriteCollectionToConsole<T>(IEnumerable<T> collection)
        {
            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }
    }
}
