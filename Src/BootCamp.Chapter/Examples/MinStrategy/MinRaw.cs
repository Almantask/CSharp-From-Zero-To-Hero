using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter.Examples.MinStrategy
{
    public class MinRaw : IMinStrategy
    {
        public T Find<T>(IEnumerable<T> elements) where T : IComparable<T>
        {
            T min = elements.FirstOrDefault();
            foreach (var element in elements)
            {
                if (element.CompareTo(min) < 0)
                {
                    min = element;
                }
            }

            return min;
        }
    }
}
