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
            _inventory.AddItem(item);
        }

        public void Remove(Item item)
        {
            _inventory.RemoveItem(item);
        }

        public List<Item> GetItems(string name)
        {
            return _inventory.GetItems(name);
        }
        
        #region Extra challenge: Equipment
        // To equip, pass an item.
        // To unequip pass null to the function.
        public void EquipHead(Headpiece head)
        {
            if(!HasAvailableCarryCapacity(head)) return;
            _equipment.SetHead(head);
        }

        public void EquipChest(Chestpiece chestpiece)
        {
            if(!HasAvailableCarryCapacity(chestpiece)) return;
            _equipment.SetChest(chestpiece);
        }

        public void EquipShoulder(Shoulderpiece shoulderpiece, bool isLeft)
        {
            if(!HasAvailableCarryCapacity(shoulderpiece)) return;
            if (isLeft)
            {
                _equipment.SetLeftShoulder(shoulderpiece);
            }
            else
            {
                _equipment.SetRightShoulder(shoulderpiece);
            }
        }

        public void EquipLeg(Legspiece legspiece)
        {
            if(!HasAvailableCarryCapacity(legspiece)) return;
            _equipment.SetLeg(legspiece);
        }

        public void EquipArm(Armpiece armpiece, bool isLeft)
        {
            if(!HasAvailableCarryCapacity(armpiece)) return;
            if (isLeft)
            {
                _equipment.SetLeftArm(armpiece);
            }
            else
            {
                _equipment.SetRightArm(armpiece);
            }
        }

        public void EquipGloves(Gloves gloves)
        {
            if(!HasAvailableCarryCapacity(gloves)) return;
            _equipment.SetGloves(gloves);
        }
        
        public void EquipWeapon(Weapon weapon)
        {
            if(!HasAvailableCarryCapacity(weapon)) return;
            _equipment.SetWeapon(weapon);
        }

        private bool HasAvailableCarryCapacity(Item item)
        {
            if (item == null) return true;
            var currentWeight = _equipment.GetTotalWeight();
            var newWeight = currentWeight + item.Weight;

            return newWeight <= MaxCarryCapacity;
        }
        #endregion
    }
}
