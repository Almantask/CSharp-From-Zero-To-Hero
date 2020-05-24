using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Person
    {
        public string Name { get; set; }
        public decimal[] Balance { get; set; }

        public Person()
        {
            Balance = new decimal[20];
        }
    }
}
