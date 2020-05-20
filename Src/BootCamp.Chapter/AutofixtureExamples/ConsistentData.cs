using System;
using AutoFixture;
using BootCamp.Chapter.Dummies.Orders;

namespace BootCamp.Chapter.AutofixtureExamples
{
    public static class ConsistentData
    {
        private static readonly Fixture _fixture = new Fixture();

        public static void Run()
        {
            _fixture.Freeze<int>();
            
            var num1 = _fixture.Create<int>();
            var num2 = _fixture.Create<int>();
            var line1 = _fixture.Create<OrderLine>();
            Console.WriteLine($"{num1} {num2} {line1.Count}");

            _fixture.Inject(5);
            
            var num3 = _fixture.Create<int>();
            var num4 = _fixture.Create<int>();
            var line2 = _fixture.Create<OrderLine>();
            Console.WriteLine($"{num3} {num4} {line2.Count}");
        }
    }
}
