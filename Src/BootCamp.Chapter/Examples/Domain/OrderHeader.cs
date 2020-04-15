using System;

namespace BootCamp.Chapter.Examples.Domain
{
    public class OrderHeader
    {
        public string Name { get; }
        public string Description { get; }
        public string To { get; }
        public string Form { get; }
        public DateTime OrderedAt { get; }

        public OrderHeader(string name, string description, string to, string form, DateTime orderedAt)
        {
            Name = name;
            Description = description;
            To = to;
            Form = form;
            OrderedAt = orderedAt;
        }
    }
}
