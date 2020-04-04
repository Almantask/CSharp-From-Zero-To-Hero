using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter.Querying
{
    public static class AnyDemo
    {
        public static void Run()
        {
            var numbers = new[] { 1, 2, 3, 18, 5 };

            // Same results.
            // true
            var v1 = AnyLINQ(numbers);
            var v2 = AnyForeach(numbers);
        }

        private static bool AnyLINQ(int[] numbers)
        {
            // Any even numbers.
            return numbers.Any(n => n % 2 == 0);
        }

        private static bool AnyForeach(int[] numbers)
        {
            foreach (var number in numbers)
            {
                // Any even numbers.
                if (number % 2 == 0) return true;
            }

            return false;
        }
    }
}
