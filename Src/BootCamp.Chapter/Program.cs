using System;
using System.Collections.Generic;
using System.Linq;


namespace BootCamp.Chapter
{
    class Program
    {
        static void Main()
        {
            Demo.Start();

            Console.ReadLine();
        }
    }

    class Demo
    {
        internal static void Start()
        {
            List<int> intCollection = new List<int> { 11, 13, 4, 16, 43, 10, 8, 189, 222 };

            //Task 1 and 2
            var list1 = LinqMethods.SnapFingers(intCollection, x => x.ToString().StartsWith('1'));
            var list2 = LinqMethods.SnapFingers(intCollection, x => x % 2 == 0);

            Console.WriteLine($"Task 1 and 2 on collection A:{EnumerableToString(intCollection)}");
            Console.WriteLine("Collection B:");
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Collection C:");
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            //Task 3
            Console.WriteLine();
            Console.WriteLine("Task 3. LINQ.");
            Console.WriteLine();
            Console.WriteLine($"Is there any number in collection C that equals 4: {list2.Any(x => x == 4)}");
            Console.WriteLine($"Count number of elements in collection B: {list1.Count()}");
            Console.WriteLine($"Order the collection B: {EnumerableToString(list1.OrderBy(x => x))}");
            Console.WriteLine($"Union the set of collection B with C: {EnumerableToString(list1.Union(list2))}");
            Console.WriteLine($"Intersection the set of collection B with C: {EnumerableToString(list1.Intersect(list2))}");
            Console.WriteLine($"Subtraction the set of collection B with C: {EnumerableToString(list1.Except(list2))}");
        }

        internal static string EnumerableToString<T>(IEnumerable<T> collection)
        {
            string result = "";

            if (collection.Count() == 0)
            {
                return result;
            }

            foreach (var item in collection)
            {
                result += $", {item}";
            }

            result = result.Remove(0, 1);
            return result;
        }
    }
}
