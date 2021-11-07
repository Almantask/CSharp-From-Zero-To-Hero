using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Items
{
    public interface IWeapon : IItem
    {
        float Attack { get; }
    }
}
