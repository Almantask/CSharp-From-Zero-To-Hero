using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoFixture;
using BootCamp.Chapter.Dummies.Orders;

namespace BootCamp.Chapter.AutofixtureExamples
{
    public static class BuildingComplexModels
    {
        private static readonly Fixture _fixture = new Fixture();

        public static void Run()
        {
            var header = _fixture.Build<OrderHeader>()
                .With(h => h.Description, "Dummy")
                .Without(h => h.Date)
                .Create();

            _fixture.Inject(header);

            var order = _fixture.Create<Order>();

            Console.WriteLine($"Name: {order.Header.Name}");
            Console.WriteLine($"Description: {order.Header.Description}");
            Console.WriteLine($"Count: {order.Lines.Count()}");
            Console.WriteLine($"Date: {order.Header.Date?.ToString() ?? "none"}");
        }
    }
}
