using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    public static class LINQExtensions
    {
        /// <summary>
        /// Generic Shuffling Algorithm which will accept a collection of type T and return a new shuffled List<T>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> collection)
        {
            Random rand = new Random();
            int collectionLength = collection.Count();
            List<T> newCollection = new List<T>(collectionLength);
            List<T> tempCollection = collection.ToList();

            if (collection != null)
            {
                for (int i = 0; i < collectionLength; i++)
                {
                    int currLength = tempCollection.Count();
                    int position = rand.Next(currLength);
                    newCollection.Add(tempCollection[position]);
                    tempCollection.RemoveAt(position);
                }

                return newCollection;
            }
            else
            {
                return null;
            }
        }
    }
}
