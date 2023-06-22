using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Computer
{
    public class Body
    {
        public string name { get; private set; }

        public Body(string name)
        {
            this.name = name;
        }
    }
}
