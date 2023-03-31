using System;
using System.Collections.Generic;
using BootCamp.Chapter.Items;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Task: simulate a player who has an inventory.
    /// Player can add or remove items from inventory.
    ///
    /// Extra task: player has equipment and maximum weight he/she can carry.
    /// Player should not be able to take items if already at maximum weight.
    /// Player should expose TotalAttack, TotalDefense stats.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Everyone can carry this much weight at least.
        /// </summary>
        private const int baseCarryWeight = 30;

        private const int baseStrength = 0;

        public string Name { get; set; }
        public int Hp { get; set; }

        /// <summary>
        /// Each point of strength allows extra 10 kg to carry.
        /// </summary>
        public int Strength { get; set; }

        public int GetMaxCarryWeight()
        {
            if (Strength > 0)
            {
                return baseCarryWeight + (Strength * 10);
            }
            else
            {
                return baseCarryWeight;
            }
        }

        public float GetTotalAttack()
        {
            return _equipment.GetTotalAttack();
        }

        public float GetTotalDefense()
        {
            return _equipment.GetTotalDefense();
        }


        /// <summary>
        /// Player items. There can be multiple of items with same name.
        /// </summary>
        private readonly Inventory _inventory;

        /// <summary>
        /// Needed only for the extra task.
        /// </summary>
        private readonly Equipment _equipment;

        public Player()
        {
            _inventory = new Inventory();
            _equipment = new Equipment();
            Strength = baseStrength;
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
            return _inventory.Items;
        }

        #region Extra challenge: Equipment

        // Player has equipment.
        // Various slots of equipment can be equipped and unequipped.
        // When a slot is equipped, it contributes to total defense
        // and total attack.
        // Implement equipping logic and total defense/attack calculation.
        public void Equip(Headpiece head)
        {
            SetHead(head);
        }

        public void Equip(Chestpiece chest)
        {
            SetChest(chest);
        }

        public void Equip(Shoulderpiece shoulder, bool isLeft)
        {
            if (isLeft)
            {
                SetLeftShoulder(shoulder);
            }
            else
            {
                SetRightShoulder(shoulder);
            }
        }

        public void Equip(Legspiece legs)
        {
            SetLeg(legs);
        }

        public void Equip(Armpiece arm, bool isLeft)
        {
            if (isLeft)
            {
                SetLeftArm(arm);
            }
            else
            {
                SetRightArm(arm);
            }
        }

        public void Equip(Gloves gloves)
        {
            SetGloves(gloves);
        }

        #endregion

        public void SetWeapon(Weapon weapon)
        {
            if (_equipment.GetTotalWeight() + weapon.Weight <= GetMaxCarryWeight())
            {
                _equipment.SetWeapon(weapon);
            }
        }

        public void SetHead(Headpiece head)
        {
            if (_equipment.GetTotalWeight() + head.Weight <= GetMaxCarryWeight())
            {
                _equipment.SetHead(head);
            }
        }

        public void SetChest(Chestpiece chest)
        {
            if (_equipment.GetTotalWeight() + chest.Weight <= GetMaxCarryWeight())
            {
                _equipment.SetChest(chest);
            }
        }

        public void SetLeftShoulder(Shoulderpiece shoulder)
        {
            if (_equipment.GetTotalWeight() + shoulder.Weight <= GetMaxCarryWeight())
            {
                _equipment.SetLeftShoulder(shoulder);
            }
        }

        public void SetRightShoulder(Shoulderpiece shoulder)
        {
            if (_equipment.GetTotalWeight() + shoulder.Weight <= GetMaxCarryWeight())
            {
                _equipment.SetRightShoulder(shoulder);
            }
        }

        public void SetLeg(Legspiece legs)
        {
            if (_equipment.GetTotalWeight() + legs.Weight <= GetMaxCarryWeight())
            {
                _equipment.SetLeg(legs);
            }
        }

        public void SetLeftArm(Armpiece arm)
        {
            if (_equipment.GetTotalWeight() + arm.Weight <= GetMaxCarryWeight())
            {
                _equipment.SetLeftArm(arm);
            }
        }

        public void SetRightArm(Armpiece arm)
        {
            if (_equipment.GetTotalWeight() + arm.Weight <= GetMaxCarryWeight())
            {
                _equipment.SetRightArm(arm);
            }
        }

        public void SetGloves(Gloves gloves)
        {
            if (_equipment.GetTotalWeight() + gloves.Weight <= GetMaxCarryWeight())
            {
                _equipment.SetGloves(gloves);
            }
        }
    }
}