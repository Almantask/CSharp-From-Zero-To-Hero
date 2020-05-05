using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public static class Extensions
    {
        public static IEnumerable<T> ShuffleElements<T>(this IEnumerable<T> items)
        {
            var random = new Random();
            var itemsClone = items.ToList();
            var itemsLength = itemsClone.Count;
            
            var shuffledEnumerable = new List<T>(itemsLength);
            for (var i = 0; i < itemsLength; i++)
            {
                var randomIndex = random.Next(0, itemsClone.Count);
                
                shuffledEnumerable.Add(itemsClone[randomIndex]);
                itemsClone.RemoveAt(randomIndex);
            }

            return shuffledEnumerable;
        }

        public static IEnumerable<T> SnapFingers<T>(this IEnumerable<T> items)
        {
            var random = new Random();
            var itemsCopy = items.ToList();
            var maxItemsToRemove = itemsCopy.Count / 2;

            for (var i = 0; i < maxItemsToRemove; i++)
            {
                var randomIndex = random.Next(0, itemsCopy.Count);
                itemsCopy.RemoveAt(randomIndex);
            }

            return itemsCopy;
        }

        public static void PrintAll<T>(this IEnumerable<T> items)
        {
            var print = new StringBuilder();
            foreach (var item in items)
            {
                print.Append($"{item.ToString()}, ");
            }
            Console.WriteLine(print);
        }
        
    }
}
