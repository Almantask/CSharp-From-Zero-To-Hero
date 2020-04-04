using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter.Querying
{
    public static class MinDemo
    {
        public static void Run()
        {
            var numbers = new[] { 1, 2, 3, 18, 5 };

            // Same results.
            // 2
            var v1 = MinLINQ(numbers);
            var v2 = MinForeach(numbers);
        }

        private static int MinLINQ(int[] numbers)
        {
            // Smallest even number
            return numbers.Min();
        }

        private static int MinForeach(int[] numbers)
        {
            return 0;
        }
    }
}
