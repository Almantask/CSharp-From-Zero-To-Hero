using System;

namespace BootCamp.Chapter.Examples.Models
{
    public class Person
    {
        public long Id { get; }
        public string Name { get; }
        public DateTime Birthday { get; }

        public Person(long id, string name, DateTime birthday)
        {
            Id = id;
            Name = name;
            Birthday = birthday;
        }
    }
}
