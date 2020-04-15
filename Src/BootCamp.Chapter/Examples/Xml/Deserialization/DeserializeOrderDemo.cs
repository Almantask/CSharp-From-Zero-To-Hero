using System;
using Order = BootCamp.Chapter.Examples.Xml.Common.Models.Order;

namespace BootCamp.Chapter.Examples.Xml.Deserialization
{
    public static class DeserializeOrderDemo
    {
        public static void Run()
        {
            const string path = @"Examples\Xml\Deserialization\Order.xml";
            var order = XmlConvert.DeserializeFile<Order>(path);
            Console.WriteLine($"Deserialized \"{path}\":");
            Console.WriteLine(order);
        }
    }
}
