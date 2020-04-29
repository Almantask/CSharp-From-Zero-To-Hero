using System;
using System.Collections.Generic;
using BootCamp.Chapter.Items;

namespace BootCamp.Chapter
{
    public class Player
    {
        private const int baseCarryWeight = 30;

        private string _name;
        private int _hp;
        private int _strength;
        
        private int MaxCarryCapacity { get; }
        private Inventory _inventory;
        private Equipment _equipment;
        
        public Player(string name, int hp, int strength)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));
            _name = name;
            _hp = hp;
            _strength = strength;
            _inventory = new Inventory();
            _equipment = new Equipment();
            MaxCarryCapacity = strength * 10 + baseCarryWeight;
        }
        
        public Player()
        {
           _inventory = new Inventory();
           _equipment = new Equipment();
           MaxCarryCapacity = baseCarryWeight;
        }
        
        public void AddItem(Item item)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));
            _inventory.AddItem(item);
        }

        public void Remove(Item item)
        {
            if(item is null) throw new ArgumentNullException(nameof(item));
            _inventory.RemoveItem(item);
        }

        // string.IsNullOrEmpty(name) fits better than
        // if (name is null) throw new ArgumentException();
        // var itemName = name ?? throw new ArgumentException();
        public List<Item> GetItems(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("Searched item name is empty or empty.");
            return _inventory.GetItems(name);
        }
        
        #region Extra challenge: Equipment
        // To equip, pass an item.
        // To unequip pass null to the function.
        public void EquipHead(Headpiece head)
        {
            if(!HasAvailableCarryCapacity(head)) return;
            _equipment.Head = head;
        }
        
        public void EquipChest(Chestpiece chestpiece)
        {
            if(!HasAvailableCarryCapacity(chestpiece)) return;
            _equipment.Chest = chestpiece;
        }
        
        public void EquipShoulder(Shoulderpiece shoulderpiece, bool isLeft)
        {
            if(!HasAvailableCarryCapacity(shoulderpiece)) return;
            if (isLeft)
            {
                _equipment.LeftShoulder = shoulderpiece;
            }
            else
            {
                _equipment.RightShoulder = shoulderpiece;
            }
        }
        
        public void EquipLeg(Legspiece legspiece)
        {
            if(!HasAvailableCarryCapacity(legspiece)) return;
            _equipment.Legs = legspiece;
        }
        
        public void EquipArm(Armpiece armpiece, bool isLeft)
        {
            if(!HasAvailableCarryCapacity(armpiece)) return;
            if (isLeft)
            {
                _equipment.LeftArm = armpiece;
            }
            else
            {
                _equipment.RightArm = armpiece;
            }
        }
        
        public void EquipGloves(Gloves gloves)
        {
            if(!HasAvailableCarryCapacity(gloves)) return;
            _equipment.Gloves =gloves;
        }
        
        public void EquipWeapon(Weapon weapon)
        {
            if(!HasAvailableCarryCapacity(weapon)) return;
            _equipment.Weapon = weapon;
        }
        
        private bool HasAvailableCarryCapacity(Item item)
        {
            if (item is null) return true;
            var currentWeight = _equipment.Weight;
            var newWeight = currentWeight + item.Weight;
        
            return newWeight <= MaxCarryCapacity;
        }
        #endregion
    }
}
