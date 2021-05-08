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

            Console.WriteLine($"Task 1 and 2 on collection:{ListToString(intCollection)}");
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            //Task 3

            
        }

        internal static string ListToString<T>(IEnumerable<T> collection)
        {
            string result = "";

            foreach (var item in collection)
            {
                result += $", {item}";
            }

            result = result.Remove(0, 1);
            return result;
        }
    }
}
