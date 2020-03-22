using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    interface School<TId>
    {
        TId id { get; set; }
    }
}
