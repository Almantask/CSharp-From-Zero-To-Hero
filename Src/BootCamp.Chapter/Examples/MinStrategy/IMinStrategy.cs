using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.MinStrategy
{
    public interface IMinStrategy
    {
        T Find<T>(IEnumerable<T> elements) where T : IComparable<T>;
    }
}
