using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    public static class Program
    {
        public static void Main()
        {
            //ShuffleTest();
            //SnapFingersTest();
            //AnyDemo();
            //CountDemo();
            //OrderByDemo();
            UnionDemo();

            /*
            //TODO Create any collection of any elements you want and do a demo for LINQ:
            Any Done
            Count Done
            Order Done

            Sets ----

            Union Done
            Intersection 
            Subtraction
            */
        }
        private static void UnionDemo()
        {
            //TODO finish SetsDemo.
            var list1 = CreateCollection();
            List<Item> items = new List<Item>();

            items.Add(new Item("Sword", 10, 5));
            items.Add(new Item("Shield", 5, 10));
            items.Add(new Item("new Axe", 20, 10));

            var union = list1.Union(items);

            foreach (Item item in union)
            {

                Console.WriteLine($"{item.Name} Costs {item.Price} and weighs {item.Weight}.");
            }
        }
        private static void OrderByDemo()
        {
            var list1 = CreateCollection();

            var orderdByList = list1.OrderBy(Item => Item.Price);

            foreach (Item item in orderdByList)
            {

                Console.WriteLine($"{item.Name} Costs {item.Price} and weighs {item.Weight}.");
            }
        }
        private static void CountDemo()
        {
            var list1 = CreateCollection();
            var list2 = new List<Item>();

            if (list1.Count() > 0)
            {
                Console.WriteLine($"{nameof(list1)} has items");
            }
            else
            {
                Console.WriteLine($"{nameof(list1)} has no items");
            }

            if (list2.Count() > 0)
            {
                Console.WriteLine($"{nameof(list2)} has items");
            }
            else
            {
                Console.WriteLine($"{nameof(list2)} has no items");
            }
        }

        private static void AnyDemo()
        {
            var list1 = CreateCollection();
            var list2 = new List<Item>();

            if (list1.Any())
            {
                Console.WriteLine($"{nameof(list1)} has items");
            }
            else
            {
                Console.WriteLine($"{nameof(list1)} has no items");
            }

            if (list2.Any())
            {
                Console.WriteLine($"{nameof(list2)} has items");
            }
            else
            {
                Console.WriteLine($"{nameof(list2)} has no items");
            }
        }
        private static List<Item> CreateCollection()
        {
            List<Item> items = new List<Item>();

            items.Add( new Item("Sword", 10, 5));
            items.Add(new Item("Shield", 5, 10));
            items.Add(new Item("Axe", 20, 10));
            items.Add(new Item("Wand", 50, 1));
            items.Add(new Item("Sword", 20, 7));
            items.Add(new Item("Shirt", 5, 3));
            items.Add(new Item("Chainmail", 30, 20));

            return items;
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