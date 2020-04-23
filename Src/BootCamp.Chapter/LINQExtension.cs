using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class LINQExtension
    {
        public static IEnumerable<T> SnapFingers<T>(this IEnumerable<T> source)
        {
            List<T> list = new List<T>();

            int i = 0;

            foreach (var element in source)
            {
                i++;
            }
            int k = 0;
            int middle = i / 2 + i % 2;
            foreach (var element in source)
            {
                list.Add(element);
                k++;
                if (k == middle )
                {
                    break;
                }
            }

            return list;
        }
    }
}
