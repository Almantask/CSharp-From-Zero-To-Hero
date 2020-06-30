using BootCamp.Chapter.Items;
using System;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Task: simulate a player who has an inventory.
    /// Player can add or remove items from inventory.
    ///
    /// Extra task: player has equipement and maximum weight he/she can carry.
    /// Player should not be able to take items if already at maximum weight.
    /// Player should expose TotalAttack, TotalDefense stats.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Everyone can carry this much weight at least.
        /// </summary>
        private const int baseCarryWeight = 30;
        private const int baseHP = 60;
        private readonly string _name;
        public string Name { get { return _name; } }
        private int _hp;
        private int _carryWeight;

        /// <summary>
        /// Each point of strength allows extra 10 kg to carry.
        /// </summary>
        private int _strenght;

        /// <summary>
        /// Player items. There can be multiple of items with same name.
        /// </summary>
        private PlayerInventory _inventory;
        /// <summary>
        /// Needed only for the extra task.
        /// </summary>
        private Equipment _equipment;

        public Player(string name)
        {
            _name = name;
            _inventory = new PlayerInventory();
            _equipment = new Equipment();
            _hp = baseHP;
            _carryWeight = baseCarryWeight;
            _strenght = 0;
        }

        /// <summary>
        /// Gets all items from player's inventory
        /// </summary>
        public void ShowInventory()
        {
            _inventory.ShowAllItems();
          
        }

        /// <summary>
        /// Adds item to player's inventory
        /// </summary>
        // The inventory method 'AddItem' will throw an expection if no room is available in the inventory for an another item
        public void AddItem(Item item)
        {


            try
            {
                _inventory.AddItem(item ?? throw new ArgumentNullException("The Item was either Null or Empty"));
            }
            catch(InventoryIsFullException msg)
            {
                Console.WriteLine(msg);
            }
        }

        public void Remove(Item item)
        {
            _inventory.RemoveItem(item ?? throw new ArgumentNullException("Name of Item requeted is either Null or Empty"));           
        }

        /// <summary>
        /// Gets items with matching name.
        /// </summary>
        /// <param name="name"></param>
        public Item[] GetItems(string name)
        {
            if (name != "" && name != null)
            {
                return _inventory.GetItems(name);
            }
            else
            {
                throw new ArgumentNullException("Item is Null/Empty");
            }
        }

        #region Extra challenge: Equipment
        // Player has equipment.
        // Various slots of equipment can be equiped and unequiped.
        // When a slot is equiped, it contributes to total defense
        // and total attack.
        // Implement equiping logic and total defense/attack calculation.
        public void Equip(Headpiece head)
        {

        }

        public void Equip(Chestpiece head)
        {

        }

        public void Equip(Shoulderpiece head, bool isLeft)
        {

        }

        public void Equip(Legspiece head)
        {

        }

        public void Equip(Armpiece head, bool isLeft)
        {

        }

        public void Equip(Gloves head)
        {

        }
        #endregion
    }
}
