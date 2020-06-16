using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace BootCamp.Chapter.Examples.CompositionVsInheritance.Good
{
    public class Sculture : ILocatable
    {
        public Vector3 Position { get; set; }

        public Sculture(Vector3 position)
        {
            Position = position;
        }
    }
}
