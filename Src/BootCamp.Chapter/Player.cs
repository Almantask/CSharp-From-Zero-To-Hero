using BootCamp.Chapter.Items;
using System.Collections.Generic;

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

        private string _name;
        private int _hp;

        /// <summary>
        /// Each point of strength allows extra 10 kg to carry.
        /// </summary>
        private int _strenght;

        /// <summary>
        /// Player items. There can be multiple of items with same name.
        /// </summary>
        private Inventory _inventory;

        /// <summary>
        /// Needed only for the extra task.
        /// </summary>
        private Equipment _equipment;

        public List<Item> Items { get; set; }

        public Player()
        {
            _inventory = new Inventory();
            Items = new List<Item>(); 
        }

        /// <summary>
        /// Gets all items from player's inventory
        /// </summary>
        

        /// <summary>
        /// Adds item to player's inventory
        /// </summary>
        public void AddItem(Item item)
        {
            Items.Add(item); 
        }

        public void Remove(Item item)
        {
            Items.Remove(item); 
        }

        /// <summary>
        /// Gets items with matching name.
        /// </summary>
        /// <param name="name"></param>
        public List<Item> GetItems(string name)
        {
            var foundItems = new List<Item>(); 
            for (int i = 0; i < Items.Count; i++)
            {
                if (name == Items[i].Name)
                {
                    foundItems.Add(Items[i]); 
                }
            }

            return foundItems; 
        }

        #region Extra challenge: Equipment

        // Player has equipment.
        // Various slots of equipment can be equiped and unequiped.
        // When a slot is equiped, it contributes to total defense
        // and total attack.
        // Implement equiping logic and total defense/attack calculation.
        private bool CheckForTotalWeight()
        {
            return _equipment.GetTotalWeight() > (baseCarryWeight + _strenght * 10);
        }

        public void Equip(Headpiece head)
        {
            if (!CheckForTotalWeight())
            {
                return;
            }

            _equipment.HeadPiece = head;
        }

        public void Equip(Chestpiece head)
        {
            if (!CheckForTotalWeight())
            {
                return;
            }

            _equipment.ChestPiece = head;
        }

        public void Equip(Shoulderpiece head, bool isLeft)
        {
            if (!CheckForTotalWeight())
            {
                return;
            }

            if (isLeft)
            {
                _equipment.LeftShoulderpiece = head;
            }
            else
            {
                _equipment.RightShoulderpiece = head;
            }
        }

        public void Equip(Armpiece head, bool isLeft)
        {
            if (!CheckForTotalWeight())
            {
                return;
            }

            if (isLeft)
            {
                _equipment.LeftArmPiece = head;
            }
            else
            {
                _equipment.RightArmPiece = head;
            }
        }

        public void Equip(Gloves head)
        {
            if (!CheckForTotalWeight())
            {
                return;
            }

            _equipment.Gloves = head;
        }

        public void Equip(Legspiece head)
        {
            if (!CheckForTotalWeight())
            {
                return;
            }

            _equipment.Legspiece = head;

            #endregion Extra challenge: Equipment
        }
    }
}