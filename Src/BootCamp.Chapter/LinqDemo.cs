using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    internal class LinqDemo
    {
        private static List<int> list1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private static List<int> list2 = new List<int> { 1, 11, 12 };
        private static List<int> list3 = new List<int> { 4, 2, 5, 4 };

        internal static void Demo()
        {
            AnyDemo(list1);
            CountDemo(list1);
            SortDemo(list3);
            WhereDemo(list1);
            UnionDemo(list1, list2);
            IntersectionDemo(list1, list2);
            ExtractDemo(list1, list2);
        }

        private static void ExtractDemo(List<int> list1, List<int> list2)
        {
            Console.Write($"The intersection of a list and another list looks like this: ");
            var substractedList = list1.Except(list2);
            PrintList(substractedList);
        }

        private static void IntersectionDemo(List<int> list1, List<int> list2)
        {
            Console.Write("The intersection of a list and a another list looks like this: ");
            var intersectedList = list1.Intersect(list2);
            PrintList(intersectedList);
        }

        private static void UnionDemo(List<int> list1, List<int> list2)
        {
            Console.Write("The union of a list and another looks like this: ");
            var unionList = list1.Union(list2);
            PrintList(unionList);
        }

        private static void WhereDemo(List<int> list)
        {
            // now we are going to select all numbers under the 6 on list1
            Console.Write("All numbers under the 6 of the given list looks like: ");
            var selectedList = list1.Where(n => n < 6);
            PrintList(selectedList);
        }

        private static void SortDemo(List<int> list )
        {
            var sortedList = list.OrderBy(n => n);
            Console.Write("the given list sorted looks like this: ");
            PrintList(sortedList);
        }

        private static void CountDemo(List<int> list)
        {
            var count = list.Count(n => n % 2 == 0);
            Console.WriteLine($"There are {count} even numbers in the given list {Environment.NewLine}");
        }

        private static void AnyDemo(List<int> list)
        {
            var valid = list.Any(n => n % 2 == 0);

            if (valid)
            {
                Console.WriteLine($"The given list does contain a even number{Environment.NewLine}");
            }
            else
            {
                Console.WriteLine("The given list does not contain a even number");
            }
        }

        private static void PrintList(IEnumerable<int> list)
        {
            foreach (var number in list)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine(Environment.NewLine);
        }
    }
}