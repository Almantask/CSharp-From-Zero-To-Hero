using System;
using JSON = BootCamp.Chapter.Examples.Json.Common.Models;
using BootCamp.Chapter.Examples.MapperConfig;

namespace BootCamp.Chapter.Examples.Json.Mapping
{
    public static class MappingDemo
    {
        public static void Run()
        {
            var mapper = AutomapperConfiguration.Setup();
            var order = new Domain.Order(new Domain.OrderHeader("Test", "Testing", "Tester", "Kaisinel", DateTime.Now),
                new[]
                {
                    new Domain.OrderLine(2, 15.1f,
                        new Domain.Item("Candy", "Delicious", DateTime.Now)),
                    new Domain.OrderLine(1, 1000f,
                        new Domain.Item("Candy", "Luxurious Sofa", DateTime.Now.AddYears(-10)))
                });

            Console.WriteLine("BeforeMapping");
            Console.WriteLine(order.ToString());

            var orderJsonDto = mapper.Map<Common.Models.Order>(order);
            var orderFromDomain = mapper.Map<JSON.Order>(orderJsonDto);

            Console.WriteLine("After:");
            Console.WriteLine(orderFromDomain.ToString());
        }
    }
}
