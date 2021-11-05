using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Items
{
    public interface IItem
    {
        string Name { get; }
        decimal Price { get; }
        float Weight { get; }
    }
}
