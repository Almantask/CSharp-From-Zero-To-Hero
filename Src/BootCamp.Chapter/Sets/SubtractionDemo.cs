using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter.Sets
{
    public static class SubtractionDemo
    {
        public static void Run()
        {
            var set1 = new [] {1, 2, 3, 4};
            var set2 = new[] {3, 4, 5};

            // Elements that belong in set1, but not in set2.
            // {1, 2}
            var v1 = InterectForeach(set1, set2);
            var v2 = InterectLINQ(set1, set1);
        }

        private static IEnumerable<int> InterectLINQ(int[] set1, int[] set2)
        {
            return set1.Except(set2);
        }

        private static IEnumerable<int> InterectForeach(int[] set1, int[] set2)
        {
            var result = new List<int>(set1);
            foreach (var element1 in set1)
            {
                foreach (var element2 in set2)
                {
                    if (element1 == element2)
                    {
                        result.Remove(element1);
                        break;
                    }
                }
            }

            return result;
        }
    }
}
