using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter.Examples.MinStrategy
{
    public class MinBetterLinq: IMinStrategy
    {
        public T Find<T>(IEnumerable<T> elements) where T : IComparable<T>
        {
            return elements
                .Aggregate((first, second)
                    => first.CompareTo(second) < 0 ? first : second);
        }
    }
}
