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
        private int _hp;

        /// <summary>
        /// Each point of strength allows extra 10 kg to carry.
        /// </summary>
        private int _strenght;
        public int CarryLimit()
        {
            return baseCarryWeight + 10 * _strenght;
        }

        /// <summary>
        /// Player items. There can be multiple of items with same name.
        /// </summary>
        private Inventory _inventory;
        /// <summary>
        /// Needed only for the extra task.
        /// </summary>
        private Equipment _equipment;

        public Player(string name, int hp, int strength)
        {
            _name = name;
            _hp = hp;
            _strenght = strength;

            _inventory = new Inventory();
            _equipment = new Equipment();
        }
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
        // Player has equipment.
        // Various slots of equipment can be equiped and unequiped.
        // When a slot is equiped, it contributes to total defense
        // and total attack.
        // Implement equiping logic and total defense/attack calculation.
        public void Equip(Headpiece head)
        {
            _equipment.SetHead(head);
        }

        public void Equip(Chestpiece chest)
        {
            _equipment.SetChest(chest);
        }

        public void Equip(Shoulderpiece shoulder, bool isLeft)
        {
            if (isLeft)
            {
                _equipment.SetLeftShoulder(shoulder);
            } 
            else
            {
                _equipment.SetRightShoulder(shoulder);
            }
        }

        public void Equip(Legspiece legs)
        {
            _equipment.SetLeg(legs);
        }

        public void Equip(Armpiece arms, bool isLeft)
        {
            if (isLeft)
            {
                _equipment.SetLeftArmpiece(arms);
            }
            else
            {
                _equipment.SetRightArmiece(arms);
            }
        }

        public void Equip(Gloves gloves)
        {
            _equipment.SetGloves(gloves);
        }
        #endregion
    }
}
