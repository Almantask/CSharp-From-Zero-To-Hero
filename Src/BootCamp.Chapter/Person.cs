using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Person
    {
        public string Name { get; set; }
        public List<decimal> Balance { get; set; }

        public Person()
        {
            Balance = new List<decimal>();
        }
    }
}
