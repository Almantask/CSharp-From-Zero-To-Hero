using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Computer
{
    public abstract class Component
    {
        public Component(string name)
        {
            Name = name;
        }
        public string Name { get; }
    }
}
