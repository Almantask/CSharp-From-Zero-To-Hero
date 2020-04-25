using System;
using System.Collections.Generic;

namespace BootCamp.Chapter.Examples.Deconstruction
{
    public class Order
    {
        public OrderHeader Header { get; }
        public IList<OrderLine> Lines { get; }

        public Order(OrderHeader header, IList<OrderLine> lines)
        {
            Header = header;
            Lines = lines;
        }

        public void Deconstruct(out string name, out string description, out int linesCount)
        {
            name = Header.Name;
            description = Header.Description;
            linesCount = Lines.Count;
        }

        public static Order Fresh(string name, string description)
        {
            return new Order(new OrderHeader(name, description), new List<OrderLine>());
        }

        public void AddLine(OrderLine line)
        {
            Lines.Add(line);
        }
    }

    public class OrderLine
    {
        public string Item { get; }
        public double Amount { get; }

        public OrderLine(string item, double amount)
        {
            Item = item;
            Amount = amount;
        }
    }
    public class OrderHeader
    {
        public string Name { get; }
        public string Description { get; }

        public OrderHeader(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }

    public static class DeconstructionDemo
    {
        public static void Run()
        {
            DiscardDateTimeToJustCheckIsDate();
            DeconstructFullObject();
            DeconstructSome();
        }

        private static void DiscardDateTimeToJustCheckIsDate()
        {
            const string input = "2017-05-05";
            // _ is a discard operator.
            // If we don't care an out parameter, we can ignore it with _
            var isDateTime = DateTime.TryParse(input, out _);
            // is "2017-05-05" a date? true
            Console.WriteLine($"is \"{input}\" a date? {isDateTime}");
        }

        private static void DeconstructFullObject()
        {
            (string name, string description, int linesCount) = CreateOrderWith1Item();
            // Prints: Order : Dummy. Testing. Total lines: 10.
            Console.WriteLine($"Order:{name}. {description}. Total lines: {linesCount}.");
        }

        private static void DeconstructSome()
        {
            // Ignore description and lines count
            (string name, _, _) = CreateOrderWith1Item();
            // Prints: Order : Dummy
            Console.WriteLine($"Order:{name}");
        }

        private static Order CreateOrderWith1Item()
        {
            var order = Order.Fresh("Dummy", "Testing");
            order.AddLine(new OrderLine("Item1", 10));

            return order;
        }
    }
}
