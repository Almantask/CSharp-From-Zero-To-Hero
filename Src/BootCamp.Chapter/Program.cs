using System;
using static System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new Item("Potion", 20, 0.2f);
            Item item1 = null;
            var _player = new Player();
            //_player.AddItem(item1);
            _player.Remove(item1);
            var item2 = new Item("Sword", 10, 5);
            _player.Remove(item2);
            var items = _player.GetItems("Sword");
            //foreach (var i in items)
            //{
            //    WriteLine(i.Name);

            //}           
            //Write(items.Count);
            //var shop = new Shop(100);
            //var item2 = new Item("Potion", 20, 0.2f);
            //shop.Add(item2);
            //shop.Add(item2);
            //shop.Remove(item2.Name);

            ////var itemSold = shop.Sell("Potion");
            ////WriteLine(Item.Equals(itemSold, item2));

            //var itemBuy = shop.Buy(item2);
            //WriteLine(item2.Price == itemBuy);
            //WriteLine(itemBuy);


            //var items = shop.Items;
            //WriteLine(items.Count);

            //foreach (Item i in items)
            //{
            //    WriteLine(i.Name);
            //}

        }
    }
}
