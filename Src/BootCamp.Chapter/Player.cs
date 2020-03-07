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

        }

        public void Equip(Chestpiece head)
        {

        }

        public void Equip(Shoulderpiece head, bool isLeft)
        {

        }

        public void Equip(Legspiece head)
        {

        }

        public void Equip(Armpiece head, bool isLeft)
        {

        }

        public void Equip(Gloves head)
        {

        }
        #endregion

        public void AddWeapon(Weapon weapon) 
        {
            if (_equipment.GetTotalWeight() > (30 + _strenght * 10))
            {
                return;   
            }

            _equipment.SetWeapon(weapon);
        }

        public void AddHeadPiece(Headpiece headpiece)
        {
            if (_equipment.GetTotalWeight() > (30 + _strenght * 10))
            {
                return;
            }

            _equipment.SetHead(headpiece);
        }

        public void AddChestPiece(Chestpiece chestpiece)
        {
            if (_equipment.GetTotalWeight() > (30 + _strenght * 10))
            {
                return;
            }

            _equipment.SetChest(chestpiece);
        }

        public void AddArmPiece(Armpiece armpiece, bool isRight )
        {
            if (_equipment.GetTotalWeight() > (30 + _strenght * 10))
            {
                return;
            }

            if (isRight)
            {
                _equipment.SetRightArm(armpiece); 
            }
            else
            {
                _equipment.SetLeftArmp(armpiece); 
            }
        }

        public void AddSchoulderPiece(Shoulderpiece shoulderpiece, bool isRight)
        {
            if (_equipment.GetTotalWeight() > (30 + _strenght * 10))
            {
                return;
            }

            if (isRight)
            {
                _equipment.SetRightShoulder(shoulderpiece); 
            }
            else
            {
                _equipment.SetLeftShoulder(shoulderpiece); 
            }
        }

        public void AddLegPiece(Legspiece legspiece)
        {
            if (_equipment.GetTotalWeight() > (30 + _strenght * 10))
            {
                return;
            }

            _equipment.SetLeg(legspiece); 
        }

        public void AddGloves(Gloves gloves)
        {
            if (_equipment.GetTotalWeight() > (30 + _strenght * 10))
            {
                return;
            }

            _equipment.SetGloves(gloves); 
        }
    }
}
