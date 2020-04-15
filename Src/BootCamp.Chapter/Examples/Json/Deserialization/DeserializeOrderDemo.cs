using System;
using BootCamp.Chapter.Examples.Json.Common.Models;
using BootCamp.Chapter.Examples.Json.JsonExtensions;

namespace BootCamp.Chapter.Examples.Json.Deserialization
{
    public static class DeserializeOrderDemo
    {
        public static void Run()
        {
            const string path = @"Examples\Json\Deserialization\Order.json"; ;
            var order = JsonConvertExtensions.DeserializeFile<Order>(path);
            
            Console.WriteLine($"Deserialized \"{path}\":");
            Console.WriteLine(order);
        }
    }
}
