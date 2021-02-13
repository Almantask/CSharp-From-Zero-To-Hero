using System;

namespace BootCamp.Chapter
{
    public class Person
    {
        // add missing properties
        public string Name { get; set; }
        public string SureName { get; set; }
        public DateTime Birthday { get; set; }
        public Enum Gender { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string StreetAdress { get; set; }

        public override string ToString()
        {
            return string.Format($"{Name},{SureName},{Birthday.ToShortDateString()},{Gender},{Country},{Email},{StreetAdress}");
        }
    }
}