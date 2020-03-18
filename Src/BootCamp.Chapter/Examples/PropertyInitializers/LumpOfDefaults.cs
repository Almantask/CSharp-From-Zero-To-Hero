using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.PropertyInitializers
{
    public class LumpOfDefaults1
    {
        public int Number { get; } = 1;
        public string Word { get; } = "Hi";
    }

    public class LumpOfDefaults2
    {
        public int Number { get; }
        public string Word { get; }

        public LumpOfDefaults2()
        {
            Number = 1;
            Word = "Hi";
        }
    }
}
