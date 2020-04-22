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
        private int _maxCarryCapacity;
        public int GetMaxCarryCapacity()
        {
            return _maxCarryCapacity;
        }
        
        private string _name;
        private int _hp;

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

        public Player(string name, int hp, int strenght)
        {
            _name = name;
            _hp = hp;
            _strenght = strenght;
            _inventory = new Inventory();
            _equipment = new Equipment();
            _maxCarryCapacity = strenght * 10 + baseCarryWeight;
        }
        
        public Player()
        {
           _inventory = new Inventory();
           _equipment = new Equipment();
           _maxCarryCapacity = baseCarryWeight;
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
            return _inventory.GetItems(name);
        }
        
        #region Extra challenge: Equipment
        // To equip, pass an item
        // To unequip pass null to the function
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
            var newWeight = currentWeight + item.GetWeight();

            return newWeight <= _maxCarryCapacity;
        }
        #endregion
    }
}
