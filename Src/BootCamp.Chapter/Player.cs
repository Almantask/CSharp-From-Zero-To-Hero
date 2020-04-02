using BootCamp.Chapter.Items;
using System;
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
        /// Player items. There can be multiple of items with same name.
        /// </summary>
        private Inventory _inventory;
        public Player()
        {
            _inventory = new Inventory();
        }

        /// <summary>
        /// Gets all items from player's inventory
        /// </summary>
        public List<Item> GetItems()
        {
            return _inventory.Items;
        }

        /// <summary>
        /// Adds item to player's inventory
        /// </summary>
        public void AddItem(Item item)
        {
            _inventory.AddItem(item ?? throw new ArgumentNullException($"{nameof(item)} can't be null."));

        }

        public void Remove(Item item)
        {
            _inventory.RemoveItem(item ?? throw new ArgumentNullException($"{nameof(item)} can't be null."));
        }

        /// <summary>
        /// Gets items with matching name.
        /// </summary>
        /// <param name="name"></param>
        public List<Item> GetItems(string name)
        {
            NullChecks.StringNullChecks(name);

            return _inventory.GetItems(name);
        }

        #region Extra challenge: Equipment
        // Player has equipment.
        // Various slots of equipment can be equiped and unequiped.
        // When a slot is equiped, it contributes to total defense
        // and total attack.
        // Implement equiping logic and total defense/attack calculation.
        /// <summary>
        /// Everyone can carry this much weight at least.
        /// </summary>
        private const int baseCarryWeight = 30;

        private int Name { get; set; }
        private int Hp { get; set; }

        /// <summary>
        /// Each point of strength allows extra 10 kg to carry.
        /// </summary>
        private int Strenght { get; set; }


        /// <summary>
        /// Needed only for the extra task.
        /// </summary>
        private Equipment Equipment { get; set; }

        public void Equip(Headpiece head)
        {
            Equipment.Head = head;
        }

        public void Equip(Chestpiece chest)
        {
            Equipment.Chest = chest;
        }

        public void Equip(Shoulderpiece shoulder, bool isLeft)
        {
            if (isLeft)
            {
                Equipment.LeftShoulder = shoulder;
            }
            else
            {
                Equipment.RightShoulder = shoulder;
            }
        }

        public void Equip(Legspiece legs)
        {
            Equipment.Legs = legs;
        }

        public void Equip(Armpiece arm, bool isLeft)
        {
            if (isLeft)
            {
                Equipment.LeftArm = arm;
            }
            else
            {
                Equipment.RightArm = arm;
            }
        }

        public void Equip(Gloves gloves)
        {
            Equipment.Gloves = gloves;
        }
        #endregion
    }
}
