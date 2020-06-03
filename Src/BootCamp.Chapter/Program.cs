using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BootCamp.Chapter.ExtensionMethods;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExtensionMethodsDemo();
            
            List<int> list1 = new List<int> {1, 2, 3, 4, 5};
            List<int> list2 = new List<int> {4, 5, 6, 7, 8};
            
            //LinqAnyDemo(list1, list2);
            //LinqCountDemo(list1);
            //LinqOrderByDemo(list1);
            //LinqUnionDemo(list2, list1);
            LinqIntersectDemo(list2, list1);
        }

        private static void LinqIntersectDemo(List<int> list2, List<int> list1)
        {
            var list3 = list2.Intersect(list1).ToList();
            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }
        }

        private static void LinqUnionDemo(List<int> list2, List<int> list1)
        {
            var list3 = list2.Union(list1).ToList();
            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }
        }

        private static void LinqOrderByDemo(List<int> list1)
        {
            List<int> orderedList = list1.OrderByDescending(t => t).ToList();
            foreach (int item in orderedList)
            {
                Console.WriteLine(item);
            }
        }

        private static void LinqCountDemo(List<int> list1)
        {
            int biggerThan3 = list1.Count(t => t > 3);
            Console.WriteLine(biggerThan3);
        }

        private static void LinqAnyDemo(List<int> list1, List<int> list2)
        {
            bool anyList = list1.Any(n => n == 3);
            Console.WriteLine(anyList);
            bool anyList2 = list2.Any(n => n == 3);
            Console.WriteLine(anyList2);
        }

        private static void ExtensionMethodsDemo()
        {
            List<string> list = new List<string>();
            list.Add("test1");
            list.Add("test2");
            list.Add("test3");
            list.Add("test4");
            list.Add("test5");
            list.Add("test6");
            list.Add("test7");
            list.Add("test8");
            list.Add("test9");
            list.Add("test10");
            list.Add("test11");
            list.Add("test12");
            list.Shuffle();
            list = list.SnapFingers(t => t).ToList();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
