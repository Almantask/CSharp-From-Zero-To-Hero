using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter.Querying
{
    public static class CountDemo
    {
        public static void Run()
        {
            var numbers = new[] { 1, 2, 3, 18, 5 };

            // Same results.
            // 3
            var v1 = CountForeach(numbers);
            var v2 = CountLINQ(numbers);
        }

        private static int CountLINQ(int[] numbers)
        {
            // Counts all numbers under 4.
            return numbers.Count(n => n < 4);
        }

        private static int CountForeach(int[] numbers)
        {
            // Counts all numbers under 4.
            var count = 0;
            foreach (var number in numbers)
            {
                if (number < 4)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
