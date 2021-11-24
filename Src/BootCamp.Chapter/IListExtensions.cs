using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class IListExtensions
    {
        private static Random rng = new Random();
        public static void ShuffleListIList<T>(this IList<T> list)
        {
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

        public static void SnapFingers<T>(this IList<T> list, Predicate<T> predicate)
        {
            List<T> tmpList = new List<T>();
            int count = list.Count;

            bool isEven = count % 2 == 0;

            if (isEven)
            {
                int itemToDel = count / 2;
                for (int i = 0; i < itemToDel; i++)
                {
                    tmpList.Add(i);
                }

            }
            else
            {

            }


        }

        public static void SnapFingers(this List<int> list, Predicate<bool> predicate)
        {
            List<int> tmpList = new List<int>();
            int count = list.Count;

            bool isEven = count % 2 == 0;

            if (isEven)
            {
                int itemToDel = count / 2;
                for (int i = 0; i < itemToDel; i++)
                {
                    tmpList.Add(i);
                }
            }
            else
            {

            }


        }
    }
}
