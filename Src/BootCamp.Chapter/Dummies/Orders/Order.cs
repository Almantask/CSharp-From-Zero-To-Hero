using System;
using System.Collections.Generic;

namespace BootCamp.Chapter.Dummies.Orders
{
    public class Order
    {
        public OrderHeader Header { get; }
        public IEnumerable<OrderLine> Lines { get; }

        public Order(OrderHeader header, IEnumerable<OrderLine> lines)
        {
            Header = header;
            Lines = lines;
        }
    }

    public class OrderLine
    {
        public string ItemName { get; }
        public int Count { get; }

        public OrderLine(string itemName, int count)
        {
            ItemName = itemName;
            Count = count;
        }
    }

    public class OrderHeader
    {
        public string Name { get; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
        public bool IsConfirmed { get; }

        public OrderHeader(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}