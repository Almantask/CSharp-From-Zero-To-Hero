using System;
using System.Collections.Generic;
using System.Linq;


namespace BootCamp.Chapter
{
    class Program
    {
        static void Main()
        {
            Demo.StartHomework();

            Console.ReadLine();
        }
    }

    class Demo
    {
        internal static void StartHomework()
        {
            List<int> intCollection = new List<int> {11, 14, 4, 16, 43, 10, 8, 189, 234, 10394, 123, 44, -1, 3 };

            //Task 1 and 2
            var list1 = LinqMethods.SnapFingers(intCollection, x => x.ToString().StartsWith('1'));

            var list2 = LinqMethods.SnapFingers(intCollection, x => x % 2 == 0);

            Console.WriteLine($"Task 1&2. Collection A:{ListToString(intCollection)}{Environment.NewLine}");
            Console.WriteLine("Collection B (number starts with 1 from Collection A):");

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Collection C (number is equal from Collection A):");

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
            Console.WriteLine($"Order the collection B: {ListToString(list1.OrderBy(x => x))}");
            Console.WriteLine($"Union the set of collection B with C: {ListToString(list1.Union(list2))}");
            Console.WriteLine($"Intersection the set of collection B with C: {ListToString(list1.Intersect(list2))}");
            Console.WriteLine($"Subtraction the set of collection B with C: {ListToString(list1.Except(list2))}");
        }

        internal static string ListToString<T>(IEnumerable<T> collection)
        {
            string result = "";

            foreach (var item in collection)
            {
                result += $", {item}";
            }
            if (string.IsNullOrEmpty(result))
            {
                return result;
            }

            result = result.Remove(0, 1);
            return result;
        }
    }
}
