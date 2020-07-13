using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    public static class SnapFingersLINQ
    {
        /// <summary>
        /// Perfectly balanced, as all things should be
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="predicate"></param>
        public static IEnumerable<T> SnapFingers<T>(this IEnumerable<T> items, Func<T, bool> predicate = null)
        {
            if (!items.Any())
            {
                return default(List<T>);
            }
            else
            {
                if (predicate != null)
                {                  
                    IEnumerable<T> shuffItems = LINQExtensions.Shuffle(items);
                    List<T> tempCollection = shuffItems.ToList();
                    IEnumerable<T> newCollection = tempCollection.Where(predicate);
                    newCollection.ToList().RemoveRange(0, AmountToRemove(items));
                    
                    return newCollection;
                }
                else
                {
                    List<T> shuffItems = LINQExtensions.Shuffle(items).ToList();
                    shuffItems.RemoveRange(0, AmountToRemove(items));

                    return shuffItems;
                }
            }
        }

        private static int AmountToRemove<T>(IEnumerable<T> items)
        {
            return items.Count() / 2;
        }
    }
}
