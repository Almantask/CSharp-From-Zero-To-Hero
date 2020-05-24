using System;
using System.Collections.Generic;

namespace BootCamp.Chapter.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Currency { get; set; }
        public List<Single> Balances { get; set; }
    }
}