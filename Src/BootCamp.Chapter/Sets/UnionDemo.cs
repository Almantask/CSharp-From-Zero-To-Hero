using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter.Sets
{
    public static class UnionDemo
    {
        public static void Run()
        {
            var set1 = new [] {1, 2, 3, 4};
            var set2 = new[] {3, 4, 5};

            // Everything, without duplicates.
            // {1, 2, 3, 4, 5}
            var v1 = UnionForeach(set1, set2);
            var v2 = UnionLINQ(set1, set2);
        }

        private static IEnumerable<int> UnionLINQ(int[] set1, int[] set2)
        {
            return set1.Union(set2);
        }

        private static IEnumerable<int> UnionForeach(int[] set1, int[] set2)
        {
            var result = new List<int>(set1);
            foreach (var element2 in set2)
            {
                bool anyEqual = false;
                
                foreach (var element1 in set1)
                {
                    if (element1 == element2)
                    {
                        anyEqual = true;
                    }
                }

                if (!anyEqual)
                {
                    result.Add(element2);
                }
            }

            return result;
        }
    }
}
