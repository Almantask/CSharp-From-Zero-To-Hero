using System;
using System.Collections.Generic;
using BootCamp.Chapter.Items;

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

        public string Name { get; set; }
        public int Hp { get; set; }

        /// <summary>
        /// Each point of strength allows extra 10 kg to carry.
        /// </summary>
        public int Strength { get; set; }

        public int CarryWeight { get; set; }

        /// <summary>
        /// Player items. There can be multiple of items with same name.
        /// </summary>
        private Inventory _inventory;
        /// <summary>
        /// Needed only for the extra task.
        /// </summary>
        private Equipment _equipment;

        public Player() //Leave it for tests.
        {
            _inventory = new Inventory();
            _equipment = new Equipment();
            CarryWeight = baseCarryWeight;
        }

        public Player(string name, int hp, int strenght)
        {
            string receivedName = name ?? throw new ArgumentNullException("Name, int and strength must have a value!");
            Name = name;
            Hp = hp;
            Strength = strenght;
            CalculateCarryWeight(strenght);
            _inventory = new Inventory();
            _equipment = new Equipment();

        }

        /// <summary>
        /// Adds item to player's inventory
        /// </summary>
        public void AddItem(Item item)
        {
            _inventory.AddItem(item ?? throw new ArgumentNullException(nameof(item) + " shouldn't be null."));
        }


        public void Remove(Item item)
        {
            _inventory.RemoveItem(item ?? throw new ArgumentNullException(nameof(item) + " shouldn't be null."));
        }

        /// <summary>
        /// Gets items with matching name.
        /// </summary>
        /// <param name="name"></param>
        public List<Item> GetItems(string name)
        {
            if (name == "") throw new ArgumentException(nameof(name) + " shouldn't be empty");

            return _inventory.GetItems(name ?? throw new ArgumentException(nameof(name) + " shouldn't be null or empty."));
        }

        #region Extra challenge: Equipment
        // Player has equipment.
        // Various slots of equipment can be equiped and unequiped.
        // When a slot is equiped, it contributes to total defense
        // and total attack.
        // Implement equiping logic and total defense/attack calculation.
        public void Equip(Weapon weapon)
        {

            if (checkWeight(weapon ?? throw new ArgumentNullException(nameof(weapon) + " shouldn't be null.")))
            {
                _equipment.Weapon = weapon;
            }
        }

        public void Equip(Headpiece head)
        {

            if (checkWeight(head ?? throw new ArgumentNullException(nameof(head) + " shouldn't be null.")))
            {
                _equipment.Headpiece = head;
            }
        }
        public void Equip(Chestpiece chest)
        {
            if (checkWeight(chest ?? throw new ArgumentNullException(nameof(chest) + " shouldn't be null.")))
            {
                _equipment.Chestpiece = chest;
            }

        }

        public void Equip(Shoulderpiece shoulder, bool isLeft)
        {
            if (checkWeight(shoulder ?? throw new ArgumentNullException(nameof(shoulder) + " shouldn't be null.")))
            {
                if (isLeft)
                {
                    _equipment.LeftShoulder = shoulder;
                }
                _equipment.RightShoulder = shoulder;
            }
        }

        public void Equip(Legspiece legs)
        {
            if (checkWeight(legs ?? throw new ArgumentNullException(nameof(legs) + " shouldn't be null.")))
            {
                _equipment.Legs = legs;
            }
        }

        public void Equip(Armpiece armPiece, bool isLeft)
        {
            if (checkWeight(armPiece ?? throw new ArgumentNullException(nameof(armPiece) + " shouldn't be null.")))
            {
                if (isLeft)
                {
                    _equipment.LeftArm = armPiece;
                }
                _equipment.RightArm = armPiece;
            }
        }

        public void Equip(Gloves gloves)
        {
            if (checkWeight(gloves ?? throw new ArgumentNullException(nameof(gloves) + " shouldn't be null.")))
            {
                _equipment.Gloves = gloves;
            }
        }
        #endregion

        private void CalculateCarryWeight(int strength)
        {
            CarryWeight = baseCarryWeight + (strength * 10);
        }
        private bool checkWeight(Item item)
        {
            Item recievedItem = item ?? throw new ArgumentNullException(nameof(item) + " shouldn't be null.");

            float availableWeight = baseCarryWeight - _equipment.GetTotalWeight();
            if (item.Weight > availableWeight) return false;

            return true;
        }

    }
}