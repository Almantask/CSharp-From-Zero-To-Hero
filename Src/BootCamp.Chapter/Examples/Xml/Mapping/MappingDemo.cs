using System;
using XML = BootCamp.Chapter.Examples.Xml.Common.Models;
using BootCamp.Chapter.Examples.MapperConfig;

namespace BootCamp.Chapter.Examples.Xml.Mapping
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

            var orderXmlDto = mapper.Map<XML.Order>(order);
            var orderFromDomain = mapper.Map<Domain.Order>(orderXmlDto);

            Console.WriteLine("After:");
            Console.WriteLine(orderFromDomain.ToString());
        }
    }
}
