using System;
using BootCamp.Chapter.Examples.Xml.Common.Models;

namespace BootCamp.Chapter.Examples.Xml.Serialization
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

            var xml = XmlConvert.SerializeObject(order);
            Console.WriteLine(xml);
        }
    }
}
