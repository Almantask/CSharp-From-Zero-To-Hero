using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace BootCamp.Chapter.ExtensionMethods
{
    static class ListExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            
            if (list.Count < 2) throw new ArgumentException("Not enough items to shuffle.");

            Random rng = new Random();
            int n = list.Count;
            
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static IList<T> SnapFingers<T>(this IList<T> list, Predicate<bool> predicate)
        {
            if (list.Count < 2) throw new ArgumentException("Not enough items.");

            int countItemToDelete = list.Count / 2;
            
            while (list.Count > countItemToDelete  + 1)
            {
                list.RemoveAt(countItemToDelete  + 1);
            }

            return list;
        }
    }
}
