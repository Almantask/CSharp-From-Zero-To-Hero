using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

            //ShuffleTest();

            


            /*
             * 
            //TODO Make your own LINQ method!
            Create a method SnapFingers which works like LINQ methods, takes a predicate and removes exactly half of all the elements in the collection.
            If it's not even number, it should remove 1 less.
            For example:
            if it's 2, it removes 1;
            if it's 4, it removes 2;
            but if it's 3, it removes 1.
            //TODO Create any collection of any elements you want and do a demo for LINQ:
            Any Count Order Sets Union Intersection Subtraction
            */
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
