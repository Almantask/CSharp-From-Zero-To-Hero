using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public static class Tests
    {
        public static void ShuffleTest(int number)
        {
            List<int> intList = new List<int>();

            for (int i = number; i > -1; i--)
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

        public static void SnapFingersTest()
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
    }
}