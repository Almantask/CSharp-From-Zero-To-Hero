using System;
using BootCamp.Chapter.Examples.Json.Common.Models;
using Newtonsoft.Json;

namespace BootCamp.Chapter.Examples.Json.Serialization
{
    public static class SerializeOrderDemo
    {
        public static void Run()
        {
            var order = new Order
            {
                Header = new OrderHeader
                {
                    Description = "Test",
                    Name = "Testing",
                    Form = "Kaisinel",
                    To = "Students",
                    OrderedAt = DateTime.Now
                },
                Lines = new[]
                {
                    new OrderLine
                    {
                        Amount = 2,
                        Price = 15.1f,
                        Item = new Item
                        {
                            Name = "Candy",
                            Description = "Delicious",
                            DataOfMaking = DateTime.Now
                        }
                    },
                    new OrderLine
                    {
                        Amount = 1,
                        Price = 1000f,
                        Item = new Item
                        {
                            Name = "Sofa",
                            Description = "Luxurious Sofa",
                            DataOfMaking = DateTime.Now.AddYears(-10)
                        }
                    }
                }
            };

            var json = JsonConvert.SerializeObject(order, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
