using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter.Querying
{
    public static class OrderDemo
    {
        public static void Run()
        {
            var numbers1 = new[] { 1, 2, 3, 18, 5 };
            var numbers2 = new[] { 1, 2, 3, 18, 5 };
            // Same results.
            // {1, 2, 3, 5, 18}
            var v1 = OrderLINQ(numbers1);
            var v2 = OrderForeach(numbers2);
        }

        private static IEnumerable<int> OrderLINQ(int[] numbers)
        {
            // Order in ascending order (default)
            // n => n - means ordering by collection element itself.
            return numbers.OrderBy(n => n);
        }

        private static IEnumerable<int> OrderForeach(int[] numbers)
        {
            for(var i = 0; i < numbers.Length-1; i++)
            {
                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        var temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            return numbers.Clone() as int[];
        }
    }
}
