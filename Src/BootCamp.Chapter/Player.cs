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
        /// Everyone can carry this much weight at least.
        /// </summary>
        private const int baseCarryWeight = 30;

        private string _name;
        private int _hp;

        /// <summary>
        /// Each point of strength allows extra 10 kg to carry.
        /// </summary>
        private int _strength;

        /// <summary>
        /// Player items. There can be multiple of items with same name.
        /// </summary>
        private Inventory _inventory;
        /// <summary>
        /// Needed only for the extra task.
        /// </summary>
        private Equipment _equipment;


        public Player()
        {
            _inventory = new Inventory();
            _equipment = new Equipment();
        }

        public int Strength => baseCarryWeight + _strength * 10;
        public float CurrentWeight
        {
            get;
            set;
        }
        public float TotalAttack
        {
            get => _equipment.GetTotalAttack();
        }
        public float TotalDefense
        {
            get => _equipment.GetTotalDefense();
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
            _inventory.AddItem(item);
        }

        public void Remove(Item item)
        {
            _inventory.RemoveItem(item);
        }

        /// <summary>
        /// Gets items with matching name.
        /// </summary>
        /// <param name="name"></param>
        public List<Item> GetItems(string name)
        {
            return _inventory.GetItems(name);
        }

        #region Extra challenge: Equipment
        // Player has equipment.
        // Various slots of equipment can be equiped and unequiped.
        // When a slot is equiped, it contributes to total defense
        // and total attack.
        // Implement equiping logic and total defense/attack calculation.
        public bool IsEquipped(Item item)
        {
            CurrentWeight += item.Weight;
            return CurrentWeight <= Strength;
        }
        public void Equip(Headpiece head)
        {
            _equipment.SetHead(head);
        }

        public void Equip(Chestpiece head)
        {
            _equipment.SetChest(head);
        }

        public void Equip(Shoulderpiece head, bool isLeft)
        {
            if (isLeft)
                _equipment.SetLeftShoulder(head);
            else
                _equipment.SetRightShoulder(head);

        }

        public void Equip(Legspiece head)
        {
            _equipment.SetLeg(head);
        }

        public void Equip(Armpiece head, bool isLeft)
        {
            if (isLeft)
                _equipment.SetLeftArmp(head);
            else
                _equipment.SetRightArm(head);
        }

        public void Equip(Gloves head)
        {
            _equipment.SetGloves(head);
        }
        #endregion
    }
}