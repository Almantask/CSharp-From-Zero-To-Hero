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

        private float _maxCarryCapacity;

        public float GetCarryCapacity()
        {
            return _maxCarryCapacity;
        }

        private string _name;

        public string GetName()
        {
            return _name;
        }

        private int _hp;

        public int GetHP()
        {
            return _hp;
        }

        /// <summary>
        /// Each point of strength allows extra 10 kg to carry.
        /// </summary>
        private int _strenght;

        public int GetStrength()
        {
            return _strenght;
        }

        /// <summary>
        /// Player items. There can be multiple of items with same name.
        /// </summary>
        private Inventory _inventory;

        /// <summary>
        /// Needed only for the extra task.
        /// </summary>
        private Equipment _equipment;

        public Equipment GetEquipment()
        {
            return _equipment;
        }

        public Player()
        {
            _inventory = new Inventory();
            _equipment = new Equipment();
            _maxCarryCapacity = baseCarryWeight;
        }

        public Player(string name, int hp, int strength, Inventory inventory, Equipment equipment)
        {
            _name = name;
            _hp = hp;
            _strenght = strength;
            _inventory = inventory;
            _equipment = equipment;
            _maxCarryCapacity = baseCarryWeight + _strenght * 10;
        }

        /// <summary>
        /// Gets all items from player's inventory
        /// </summary>
        public Item[] GetItems()
        {
            return _inventory.GetItems();
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
            _equipment.SetHead(head);
        }

        public void Equip(Chestpiece chestpiece)
        {
            if (IsOverEncumbered(chestpiece)) return;
            _equipment.SetChest(chestpiece);
        }

        public void Equip(Shoulderpiece shoulderpiece, bool isLeft)
        {
            if (IsOverEncumbered(shoulderpiece)) return;

            if (isLeft)
            {
                _equipment.SetLeftShoulder(shoulderpiece);
            }
            else
            {
                _equipment.SetRightShoulder(shoulderpiece);
            }
        }

        public void Equip(Legspiece legspiece)
        {
            if (IsOverEncumbered(legspiece)) return;
            _equipment.SetLeg(legspiece);
        }

        public void Equip(Armpiece armpiece, bool isLeft)
        {
            if (IsOverEncumbered(armpiece)) return;

            if (isLeft)
            {
                _equipment.SetLeftArm(armpiece);
            }
            else
            {
                _equipment.SetRightArm(armpiece);
            }
        }

        public void Equip(Gloves gloves)
        {
            if (IsOverEncumbered(gloves)) return;
            _equipment.SetGloves(gloves);
        }

        public void Equip(Weapon weapon)
        {
            if (IsOverEncumbered(weapon)) return;
            _equipment.SetWeapon(weapon);
        }

        public bool IsOverEncumbered(Item item)
        {
            if (item == null) return true;
            var currentWeight = _equipment.GetTotalWeight();
            var newWeight = currentWeight + item.GetWeight();

            return newWeight > _maxCarryCapacity;
        }
        #endregion
    }
}