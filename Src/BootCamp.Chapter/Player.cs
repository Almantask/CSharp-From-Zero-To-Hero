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

        public string Name { get; private set; }
        public int Hp { get; private set; }

        /// <summary>
        /// Each point of strength allows extra 10 kg to carry.
        /// </summary>
        public int Strength { get; private set; }

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
        }

        /// <summary>
        /// Gets all items from player's inventory
        /// </summary>
        public Item[] GetItems()
        {
            return new Item[0];
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
        private float EquipCapacity { get { return baseCarryWeight + 10 * Strength; } }
        public void Equip(Headpiece head)
        {
            var weightIfEquipped = WeightIfAdded(head) ;
            if (_equipment.Head != null)
            {
                weightIfEquipped -= _equipment.Head.Weight; 
            }
            if (weightIfEquipped <= EquipCapacity)
            {
                _equipment.Head = head;
            }
        }

        public void Equip(Chestpiece chest)
        {
            var weightIfEquipped = WeightIfAdded(chest);
            if (_equipment.Chest != null)
            {
                weightIfEquipped -= _equipment.Chest.Weight;
            }
            if (weightIfEquipped <= EquipCapacity)
            {
                _equipment.Chest = chest;
            }
        }

        public void Equip(Shoulderpiece shoulder, bool isLeft)
        {
            var weightIfEquipped = WeightIfAdded(shoulder);
            if (isLeft)
            {
                if (_equipment.LeftShoulder != null)
                {
                    weightIfEquipped -= _equipment.LeftShoulder.Weight;
                }
                if (weightIfEquipped <= EquipCapacity)
                {
                    _equipment.LeftShoulder = shoulder;
                }
            }
            else
            {
                if (_equipment.RightShoulder != null)
                {
                    weightIfEquipped -= _equipment.RightShoulder.Weight;
                }
                if (weightIfEquipped <= EquipCapacity)
                {
                    _equipment.RightShoulder = shoulder;
                }
            }
        }

        public void Equip(Legspiece legs)
        {
            var weightIfEquipped = WeightIfAdded(legs);
            if (_equipment.Legs != null)
            {
                weightIfEquipped -= _equipment.Legs.Weight;
            }
            if (weightIfEquipped <= EquipCapacity)
            {
                _equipment.Legs = legs;
            }
        }

        public void Equip(Armpiece arms, bool isLeft)
        {
            var weightIfEquipped = WeightIfAdded(arms);
            if (isLeft)
            {
                if (_equipment.LeftArm != null)
                {
                    weightIfEquipped -= _equipment.LeftArm.Weight;
                }
                if (weightIfEquipped <= EquipCapacity)
                {
                    _equipment.LeftArm = arms;
                }
            }
            else
            {
                if (_equipment.RightArm != null)
                {
                    weightIfEquipped -= _equipment.RightArm.Weight;
                }
                if (weightIfEquipped <= EquipCapacity)
                {
                    _equipment.RightArm = arms;
                }
            }
        }

        public void Equip(Gloves gloves)
        {
            var weightIfEquipped = WeightIfAdded(gloves);
            if (_equipment.Gloves != null)
            {
                weightIfEquipped -= _equipment.Gloves.Weight;
            }
            if (weightIfEquipped <= EquipCapacity)
            {
                _equipment.Gloves = gloves;
            }
        }

        float WeightIfAdded(Item item)
        {
            return _equipment.GetTotalWeight() + item.Weight;
        }
        #endregion
    }
}
