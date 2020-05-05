using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    public static class DemoLinq
    {
        private static IEnumerable<int> Numbers => ListsDemo.Numbers;
        private static IEnumerable<int> Numbers2 => ListsDemo.Numbers;
        
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++[DEMO LINQ]++++++++++++");
            Console.WriteLine();
            
            // List string
            PrintWhereDemo();
            
            // List int
            PrintAnyDemo();
            PrintCountDemo();
            PrintWhereDemo2();
            PrintOrderByDemo();
            PrintSelectDemo();
            
            // Sets
            PrintUnionDemo();
            PrintIntersectionDemo();
            PrintSubtractionDemo();
        }

        private static void PrintSubtractionDemo()
        {
            Console.WriteLine($"[Subtraction between _numbers and _numbers 2]");
            var except = Numbers.Except(Numbers2);
            except.PrintAll();
            Console.WriteLine("-------------------------------------------------");
        }

        private static void PrintIntersectionDemo()
        {
            Console.WriteLine($"[Intersection between _numbers and _numbers 2]");
            var intersection = Numbers.Intersect(Numbers2);
            intersection.PrintAll();
            Console.WriteLine("-------------------------------------------------");
        }

        private static void PrintUnionDemo()
        {
            Console.WriteLine($"[Union between _numbers and _numbers 2]");
            var union = Numbers.Union(Numbers2);
            union.PrintAll();
            Console.WriteLine("-------------------------------------------------");
        }

        private static void PrintSelectDemo()
        {
            // Select
            Console.WriteLine($"[Select primer numbers from list and multiply by themselves.]");
            var select = Numbers.Where(IsPrimeNumber)
                .Select(n => n * n);
            select.PrintAll();
            Console.WriteLine("-------------------------------------------------");
        }

        private static void PrintOrderByDemo()
        {
            // OrderBy where
            Console.WriteLine("[Order primer numbers from list.]");
            var orderBy = Numbers.Where(IsPrimeNumber)
                .OrderBy(n => n);

            orderBy.PrintAll();
            Console.WriteLine("-------------------------------------------------");
        }

        private static void PrintWhereDemo2()
        {
            // Where
            // Print which number is prime
            Console.WriteLine("[All prime numbers from list.]");
            foreach (var num in Numbers.Where(IsPrimeNumber))
            {
                Console.Write($"{num}, ");
            }

            Console.WriteLine("\n-------------------------------------------------");
        }

        private static void PrintCountDemo()
        {
            // Count
            Console.WriteLine($"[Count how many prime numbers have in list.]");
            var count = Numbers.Count(IsPrimeNumber);
            Console.WriteLine(count);
            Console.WriteLine("-------------------------------------------------");
        }

        private static void PrintAnyDemo()
        {
            // Check if contain any prime number in list.
            Console.WriteLine($"[(ANY)Check if any number in list is a prime number.]");
            var any = Numbers.Any(IsPrimeNumber);
            Console.WriteLine(any);
            Console.WriteLine("-------------------------------------------------");
        }

        private static void PrintWhereDemo()
        {
            // Print names with 'a'.
            Console.WriteLine($"[Print names contain letter 'a'.]");
            var where = ListsDemo.Names.Where(n => n.ToLower().Contains('a'));
            @where.PrintAll();
            Console.WriteLine("-------------------------------------------------");
        }

        private static bool IsPrimeNumber(int number)
        {
            if (number <= 3) return true;
            
            var maxChecks = number / 2;
            for (var i = 2; i < maxChecks; i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}