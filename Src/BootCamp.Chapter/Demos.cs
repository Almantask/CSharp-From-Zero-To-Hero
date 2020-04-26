using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    public static class Demos
    {
        public static void SubstractionDemo()
        {
            var list1 = CreateCollection();
            List<Item> items = new List<Item>();

            items.Add(new Item("Sword", 10, 5));
            items.Add(new Item("Shield", 5, 10));
            items.Add(new Item("new Axe", 20, 10));

            var union = list1.Except(items);

            foreach (Item item in union)
            {
                Console.WriteLine($"{item.Name} Costs {item.Price} and weighs {item.Weight}.");
            }
        }

        public static void IntersectDemo()
        {
            var list1 = CreateCollection();
            List<Item> items = new List<Item>();

            items.Add(new Item("Sword", 10, 5));
            items.Add(new Item("Shield", 5, 10));
            items.Add(new Item("new Axe", 20, 10));

            var union = list1.Intersect(items);

            foreach (Item item in union)
            {
                Console.WriteLine($"{item.Name} Costs {item.Price} and weighs {item.Weight}.");
            }
        }

        public static void UnionDemo()
        {
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

        public static void OrderByDemo()
        {
            var list1 = CreateCollection();

            var orderdByList = list1.OrderBy(Item => Item.Price);

            foreach (Item item in orderdByList)
            {
                Console.WriteLine($"{item.Name} Costs {item.Price} and weighs {item.Weight}.");
            }
        }

        public static void CountDemo()
        {
            var list1 = CreateCollection();
            var list2 = new List<Item>();

            if (list1.Count > 0)
            {
                Console.WriteLine($"{nameof(list1)} has items");
            }
            else
            {
                Console.WriteLine($"{nameof(list1)} has no items");
            }

            if (list2.Count > 0)
            {
                Console.WriteLine($"{nameof(list2)} has items");
            }
            else
            {
                Console.WriteLine($"{nameof(list2)} has no items");
            }
        }

        public static void AnyDemo()
        {
            var list1 = CreateCollection();
            var list2 = new List<Item>();

            if (list1.Any(C => C.Price > 10))
            {
                Console.WriteLine($"{nameof(list1)} has items costing more than 10€ ");
            }
            else
            {
                Console.WriteLine($"{nameof(list1)} has no items costing more than 10€ ");
            }

            if (list2.Any(C => C.Price > 10))
            {
                Console.WriteLine($"{nameof(list2)} has items costing more than 10€ ");
            }
            else
            {
                Console.WriteLine($"{nameof(list2)} has no items costing more than 10€ ");
            }
        }

        public static List<Item> CreateCollection()
        {
            List<Item> items = new List<Item>();

            items.Add(new Item("Sword", 10, 5));
            items.Add(new Item("Shield", 5, 10));
            items.Add(new Item("Axe", 20, 10));
            items.Add(new Item("Wand", 50, 1));
            items.Add(new Item("Sword", 20, 7));
            items.Add(new Item("Shirt", 5, 3));
            items.Add(new Item("Chainmail", 30, 20));

            return items;
        }
    }
}