using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Items
{
    interface IArmor : IItem
    {
        float Defense { get; }
    }
}
