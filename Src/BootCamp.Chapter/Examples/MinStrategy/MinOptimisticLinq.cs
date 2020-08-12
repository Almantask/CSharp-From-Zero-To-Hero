using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter.Examples.MinStrategy
{
    class MinOptimisticLinq : IMinStrategy
    {
        public T Find<T>(IEnumerable<T> elements) where T : IComparable<T>
        {
            return elements.OrderBy(t => t).First();
        }
    }
}
