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

        private string _name;
        public string GetName()
        {
            return _name;
        }
        private int _hp;
        public int GetHp()
        {
            return _hp;

        }

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
            if (name == null || hp == 0 || strenght == 0) throw new Exception("Name, int and strength must have a value!");
            _name = name;
            _hp = hp;
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
        public void Equip(Weapon weapon)
        {

            if (checkWeight(weapon))
            {
                _equipment.SetWeapon(weapon);
            }
        }

        public void Equip(Headpiece head)
        {

            if (checkWeight(head))
            {
                _equipment.SetHead(head);
            }
        }
        public void Equip(Chestpiece chest)
        {
            if (checkWeight(chest))
            {
                _equipment.SetChest(chest);
            }

        }

        public void Equip(Shoulderpiece shoulder, bool isLeft)
        {
            if (checkWeight(shoulder))
            {
                if (isLeft)
                {
                    _equipment.SetLeftShoulder(shoulder);
                }
                _equipment.SetRightShoulder(shoulder);
            }
        }

        public void Equip(Legspiece legs)
        {
            if (checkWeight(legs))
            {
                _equipment.SetLeg(legs);
            }
        }

        public void Equip(Armpiece armPiece, bool isLeft)
        {
            if (checkWeight(armPiece))
            {
                if (isLeft)
                {
                    _equipment.SetLeftArmp(armPiece);
                }
                _equipment.SetRightArm(armPiece);
            }
        }

        public void Equip(Gloves gloves)
        {
            if (checkWeight(gloves))
            {
                _equipment.SetGloves(gloves);
            }
        }
        #endregion

        private void CalculateCarryWeight(int strength)
        {
            CarryWeight = baseCarryWeight + (strength * 10);
        }
        private bool checkWeight(Item item)
        {
            float availableWeight = baseCarryWeight - _equipment.GetTotalWeight();
            if (item.Weight > availableWeight) return false;

            return true;
        }

    }
}
