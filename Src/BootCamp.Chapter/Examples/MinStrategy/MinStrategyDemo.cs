using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.MinStrategy
{
    public static class MinStrategyDemo
    {
        private static readonly IMinStrategy[] _strategies =
        {
            new MinOptimisticLinq(),
            new MinBetterLinq(),
            new MinRaw()
        };

        public static void Execute()
        {
            int[] numbers = {1, 0, -6, 1, 1, 5};

            foreach (var minStrategy in _strategies)
            {
                var min1 = minStrategy.Find(numbers);
                Console.WriteLine(min1);
            }
        }
    }
}
