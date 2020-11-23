using System;
using static System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //var player = new Player();
            //var item = new Item("Potion", 20, 0.2f);
            //player.AddItem(item);
            //player.Remove(item);

            //var item1 = new Item("Sword", 10, 5);
            //player.Remove(item1);

            var shop = new Shop(100);
            var item2 = new Item("Potion", 120, 0.2f);
            shop.Add(item2);
            shop.Add(item2);
            shop.Remove(item2.GetName());

            //var itemSold = shop.Sell("Potion");
            //WriteLine(Item.Equals(itemSold, item2));

            var itemBuy = shop.Buy(item2);
            WriteLine(item2.GetPrice() == itemBuy);
            WriteLine(itemBuy);


            var items = shop.GetItems();
            WriteLine(items.Length);

            foreach (Item i in items)
            {
                WriteLine(i.GetName());
            }

        }
    }
}
