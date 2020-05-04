using BootCamp.Chapter.Items;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory newInventory = new Inventory();
            newInventory.AddItem(new Gloves("Gloves of Torment", 15.5m, 2.5f, 5.0f));
            newInventory.AddItem(new Chestpiece("Breastplate of the Vanquisher", 15.5m, 2.5f, 5.0f));
            newInventory.AddItem(new Gloves("Gloves of Torment", 15.5m, 2.5f, 5.0f));
            newInventory.AddItem(new Weapon("Sword of Despair", 55.5m, 4.5f, 15.0f));
            newInventory.AddItem(new Gloves("Gloves of Torment", 15.5m, 2.5f, 5.0f));

            newInventory.AddItem(new Chestpiece("Breastplate of the Vanquisher", 15.5m, 2.5f, 5.0f));
            newInventory.AddItem(new Gloves("Gloves of Torment", 15.5m, 2.5f, 5.0f));
            newInventory.AddItem(new Weapon("Sword of Despair", 55.5m, 4.5f, 15.0f));
            newInventory.AddItem(new Gloves("Gloves of Torment", 15.5m, 2.5f, 5.0f));

            Chestpiece newChestpiece = new Chestpiece("Chainmail of Valor", 12.5m, 10.0f, 20.0f);
            newInventory.AddItem(newChestpiece);

            newInventory.RemoveItem(newChestpiece);

            Shop newShop = new Shop(500.0m);
            newShop.Add(newChestpiece);
        }
    }
}
