using System;
using AutoFixture;
using BootCamp.Chapter.Dummies;
using BootCamp.Chapter.Dummies.Orders;

namespace BootCamp.Chapter.AutofixtureExamples
{
    public static class GeneratingRandomData
    {
        private static readonly Fixture _fixture = new Fixture();

        public static void Run()
        {
            var num1 = _fixture.Create<int>();
            var num2 = _fixture.Create<int>();
            var isSmth = _fixture.Create<bool>();
            var guid = _fixture.Create<Guid>();
            var order = _fixture.Create<Order>();
            var deliveryService = _fixture.Create<DeliveryService>();

            Console.WriteLine($"{num1} {num2}");
        }
    }
}
