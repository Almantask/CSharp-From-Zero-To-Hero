using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public static class LinqMethodDemo
    {
        internal static IEnumerable<T> Demo<T>(this IEnumerable<T> list, Predicate<T> predicate)
        {
            list = Filter(list, predicate);
            list = ReduceToHalfLength(list);

            return list; 
        }

        private static List<T> ReduceToHalfLength<T>(IEnumerable<T> list)
        {
            var indexOfHalfList = Math.Floor((decimal) list.Count() / 2);
            var convertedToList = list.ToList();
            var halfList = new List<T>(); 
            // I start the loop one after the half of the list so I can remove all the items needed 
            for (int i = 0 ; i < indexOfHalfList; i++)
            {
                halfList.Add(convertedToList[i]); 
            }

            return halfList; 
        }

        private static IEnumerable<T> Filter<T>(IEnumerable<T> list, Predicate<T> predicate)
        {
            var filteredList = new List<T>();
            foreach (var item in list)
            {
                if (predicate(item))
                {
                    filteredList.Add(item); 
                }
            }

            return filteredList; 
        }
    }
}
