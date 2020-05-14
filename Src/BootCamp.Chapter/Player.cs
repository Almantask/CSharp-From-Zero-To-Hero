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
        private Inventory _inventory;

        public float MaxCarryCapacity { get; private set; }
        public string Name { get; private set; }
        public int Hp { get; private set; }
        public int Strength { get; private set; }
        public Equipment Equipment { get; private set; }

        public Player()
        {
            _inventory = new Inventory();
            Equipment = new Equipment();
            MaxCarryCapacity = baseCarryWeight;
        }

        public Player(string name, int hp, int strength, Inventory inventory, Equipment equipment)
        {
            Name = name;
            Hp = hp;
            Strength = strength;
            MaxCarryCapacity = baseCarryWeight + Strength * 10;
            _inventory = inventory;
            Equipment = equipment;
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
        public Item[] GetItems(string name)
        {
            return _inventory.GetItem(name);
        }

        #region Extra challenge: Equipment
        // Player has equipment.
        // Various slots of equipment can be equiped and unequiped.
        // When a slot is equiped, it contributes to total defense
        // and total attack.
        // Implement equiping logic and total defense/attack calculation.
        public void Equip(Headpiece head)
        {
            if (IsOverEncumbered(head)) return;
            Equipment.Headpiece = head;
        }

        public void Equip(Chestpiece chestpiece)
        {
            if (IsOverEncumbered(chestpiece)) return;
            Equipment.SetChest(chestpiece);
        }

        public void Equip(Shoulderpiece shoulderpiece, bool isLeft)
        {
            if (IsOverEncumbered(shoulderpiece)) return;

            if (isLeft)
            {
                Equipment.SetLeftShoulder(shoulderpiece);
            }
            else
            {
                Equipment.SetRightShoulder(shoulderpiece);
            }
        }

        public void Equip(Legspiece legspiece)
        {
            if (IsOverEncumbered(legspiece)) return;
            Equipment.SetLeg(legspiece);
        }

        public void Equip(Armpiece armpiece, bool isLeft)
        {
            if (IsOverEncumbered(armpiece)) return;

            if (isLeft)
            {
                Equipment.SetLeftArm(armpiece);
            }
            else
            {
                Equipment.SetRightArm(armpiece);
            }
        }

        public void Equip(Gloves gloves)
        {
            if (IsOverEncumbered(gloves)) return;
            Equipment.SetGloves(gloves);
        }

        public void Equip(Weapon weapon)
        {
            if (IsOverEncumbered(weapon)) return;
            Equipment.Weapon = weapon;
        }

        public bool IsOverEncumbered(Item item)
        {
            if (item == null) return true;
            var currentWeight = Equipment.TotalCombinedWeight;
            var newWeight = currentWeight + item.Weight;

            return newWeight > MaxCarryCapacity;
        }
        #endregion
    }
}