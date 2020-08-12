using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.FunctionalMinStrategy
{
    public static class FunctionalMinStrategyDemo
    {
        public static Func<IEnumerable<int>, int>[] _minFinders =
        {
            MinFinder.FindRaw,
            MinFinder.MinLinqOptimal,
            MinFinder.MinLinqOptimistic
        };

        public static void Run()
        {
            int[] numbers = { 1, 0, -6, 1, 1, 5 };

            foreach (var minFinder in _minFinders)
            {
                var min = minFinder(numbers);
                Console.WriteLine(min);
            }
        }
    }
}
