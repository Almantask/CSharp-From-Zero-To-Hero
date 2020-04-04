using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter.Querying
{
    public static class WhereDemo
    {
        public static void Run()
        {
            var numbers = new[] { 1, 2, 3, 18, 5 };

            // Same results.
            // { 1, 2, 3 }
            var v1 = WhereForeach(numbers);
            var v2 = WhereLINQ(numbers);
        }

        private static IEnumerable<int> WhereLINQ(int[] numbers)
        {
            // Gets all numbers under 4.
            // LINQ return type is always IEnumerable<T>
            // LINQ utilizes Lambda expressions.
            // Lambda: n => n < 4
            // Where is a method which takes a Predicate.
            // Only members which predicate evaluates to true will be returned.
            return numbers.Where(n => n < 4);
        }

        private static IEnumerable<int> WhereForeach(int[] numbers)
        {
            var under4 = new List<int>();
            foreach (var number in numbers)
            {
                if (number < 4)
                {
                    under4.Add(number);
                }
            }

            return under4;
        }
    }
}
