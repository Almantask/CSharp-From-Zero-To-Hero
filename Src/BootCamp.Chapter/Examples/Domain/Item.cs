using System;

namespace BootCamp.Chapter.Examples.Domain
{
    public class Item
    {
        public string Name { get; }
        public string Description { get; }
        public DateTime DataOfMaking { get; }

        public Item(string name, string description, DateTime dataOfMaking)
        {
            Name = name;
            Description = description;
            DataOfMaking = dataOfMaking;
        }
    }
}
