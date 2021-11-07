﻿using BootCamp.Chapter.Items;
using System;

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
        private decimal _money;
        public decimal Money
        {
            get => _money;
        }

        /// <summary>
        /// Everyone can carry this much weight at least.
        /// </summary>
        private const int baseCarryWeight = 30;

        private string _name;
        public string Name
        {
            get => _name;
        }

        private int _hp;

        private decimal _maxCarryWeightInKg;
        public decimal MaxCarryWeightInKg
        {
            get => _maxCarryWeightInKg;
        }

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

        public Player()
        {
            _inventory = new Inventory();
            _equipment = new Equipment();
            _name = "Mr Null";
            _strenght = 10;
            _hp = 2 * _strenght;
            _maxCarryWeightInKg = (30 + _strenght * 10);
            _money = 9999;
        }

        public Player(int strenght)
        {
            _inventory = new Inventory();
            _equipment = new Equipment();
            _name = "Mr Null";
            _strenght = strenght;
            _hp = 2 * _strenght;
            _maxCarryWeightInKg = (30 + _strenght * 10);
            _money = 9999;
        }

        /// <summary>
        /// Gets all items from player's inventory
        /// </summary>
        public IItem[] GetItems()
        {
            return _inventory.GetItems();
        }

        /// <summary>
        /// Adds item to player's inventory
        /// </summary>
        public void AddItem(IItem item)
        {
            float currentWeight = _equipment.GetTotalWeight() + item.Weight;
            decimal test = (decimal)currentWeight;

            if (test < _maxCarryWeightInKg)
            {
                _inventory?.AddItem(item);
            }
            else
            {
                Console.WriteLine("Player {0}, cannot carry more items", _name);
            }
        }

        public void Remove(IItem item)
        {
            _inventory?.RemoveItem(item);
        }

        /// <summary>
        /// Gets items with matching name.
        /// </summary>
        /// <param name="name"></param>
        public IItem[] GetItems(string name)
        {
            return _inventory.GetItems(name);
        }

        #region Extra challenge: Equipment
        // Player has equipment.
        // Various slots of equipment can be equiped and unequiped.
        // When a slot is equiped, it contributes to total defense
        // and total attack.
        // Implement equiping logic and total defense/attack calculation.
        // If an item exist in inventory and is equipped, it dissappear from inventory, and appear as equipment
        public void Equip(Weapon weap)
        {
            _equipment.Weapon = weap;

            if (_inventory.ContainItem(weap))
            {
                _inventory?.RemoveItem(weap);
            }
        }

        public void Equip(Headpiece head)
        {
            _equipment.Head = head;

            if (_inventory.ContainItem(head))
            {
                _inventory?.RemoveItem(head);
            }
        }

        public void Equip(Chestpiece head)
        {
            _equipment.Chest = head;

            if (_inventory.ContainItem(head))
            {
                _inventory?.RemoveItem(head);
            }
        }

        public void Equip(Shoulderpiece head, bool isLeft)
        {
            if (isLeft)
            {
                _equipment.LeftShould = head;

                if (_inventory.ContainItem(head))
                {
                    _inventory?.RemoveItem(head);
                }
            }
            else
            {
                _equipment.RightShoulder = head;

                if (_inventory.ContainItem(head))
                {
                    _inventory?.RemoveItem(head);
                }
            }
        }

        public void Equip(Legspiece head)
        {
            _equipment.Legs = head;

            if (_inventory.ContainItem(head))
            {
                _inventory?.RemoveItem(head);
            }
        }

        public void Equip(Armpiece head, bool isLeft)
        {
            if (isLeft)
            {
                _equipment.LeftArm = head;

                if (_inventory.ContainItem(head))
                {
                    _inventory?.RemoveItem(head);
                }
            }
            else
            {
                _equipment.RightArm = head;

                if (_inventory.ContainItem(head))
                {
                    _inventory?.RemoveItem(head);
                }
            }
        }

        public void Equip(Gloves head)
        {
            _equipment.Gloves = head;

            if (_inventory.ContainItem(head))
            {
                _inventory?.RemoveItem(head);
            }
        }

        public void SellItemToShop(IItem item, Shop shop)
        {
            if (_inventory.ContainItem(item))
            {
                shop?.Buy(item);
                this._money += item.Price;
                _inventory?.RemoveItem(item);
            }
        }

        public void BuyItemFromShop(IItem item, Shop shop)
        {
            var shopInventory = shop.GetItems();
            bool hasThisItem = false;

            for (int i = 0; i < shopInventory.Length; i++)
            {
                if (shopInventory[i] == item)
                {
                    hasThisItem = true;
                }
            }
            
            if (hasThisItem)
            {
                shop.Sell(item.Name);
                this._money -= item.Price;
                _inventory.AddItem(item);
            }
        }

        public decimal GetTotalPlayerAttack()
        {
            return (decimal)_equipment.GetTotalAttack();
        }

        public decimal GetTotalPlayerDefense()
        {
            return (decimal)_equipment.GetTotalDefense();
        }

        #endregion
    }
}
