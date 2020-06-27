using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.AdaptingThirdParty
{
    public interface IInventory
    {
        int Capacity { get; }
        void Add(Item item);
        void Remove(Item item);
        IEnumerable<Item> Get(Item item);
        IEnumerable<Item> Get();
    }

    public class Inventory : IInventory
    {
        private readonly IList<Item> _items;
        public int Capacity { get; }

        public Inventory(IList<Item> items, int capacity)
        {
            _items = items;
            Capacity = capacity;
        }

        public void Add(Item item)
        {

        }
        public void Remove(Item item)
        {

        }
        public IEnumerable<Item> Get(Item item)
        {
            return _items;
        }
        public IEnumerable<Item> Get()
        {
            return _items;
        }
    }

    public class Item
    {
    }
}
