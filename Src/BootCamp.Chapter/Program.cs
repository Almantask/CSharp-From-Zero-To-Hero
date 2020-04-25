using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public static class Program
    {
        public static void Main()
        {
            ShuffleTest();
            SnapFingersTest();

            /*
            //TODO Create any collection of any elements you want and do a demo for LINQ:
            Any Count Order Sets Union Intersection Subtraction
            */
        }

        private static void SnapFingersTest()
        {
            int[] i = new int[] { 1, 2, 3, 4 };

            var newi = i.SnapFingers();

            foreach (int a in newi)
            {
                Console.Write($"{a}, ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void ShuffleTest()
        {
            List<int> intList = new List<int>();
            Random random = new Random();

            for (int i = random.Next(9999, 99999); i > -1; i--)
            {
                intList.Add(i);
            }

            List<int> originalList = new List<int>(intList);

            foreach (int i in intList)
            {
                Console.Write($"{i}, ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("               ==================================================");
            Console.WriteLine();

            intList = intList.Shuffle();

            foreach (int i in intList)
            {
                Console.Write($"{i}, ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{nameof(originalList)} contains {originalList.Count} items. {nameof(intList)} contains {intList.Count} items.");
            Console.WriteLine();
            if (intList.Count == originalList.Count)
            {
                Console.WriteLine("Same Count");
            }

            bool containsSameValues = true;

            foreach (int i in originalList)
            {
                if (!intList.Contains(i))
                {
                    Console.WriteLine($"{nameof(intList)} does not contain {i}");
                    containsSameValues = false;
                    break;
                }
                else
                {
                    intList.Remove(i);
                }
            }

            switch (containsSameValues)
            {
                case true:
                    Console.WriteLine("shuffle went GOOD.");
                    break;

                case false:
                    Console.WriteLine("shuffle went BAD.");
                    break;
            }
        }
    }
}