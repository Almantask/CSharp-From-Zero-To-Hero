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

        public List<Item> Items { get; set; }

        public Player()
        {
            _inventory = new Inventory();
           _equipment = new Equipment();
        }

        /// <summary>
        /// Gets all items from player's inventory
        /// </summary>

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
           return  _inventory.GetItems(name); 
        }

        #region Extra challenge: Equipment

        // Player has equipment.
        // Various slots of equipment can be equiped and unequiped.
        // When a slot is equiped, it contributes to total defense
        // and total attack.
        // Implement equiping logic and total defense/attack calculation.
        private bool CanEquipNewItem(Item currentEquipedItem, Item newItemToEquip)
        {
            if (currentEquipedItem == null)
            {
                return _equipment.GetTotalWeight() + newItemToEquip.Weight < (baseCarryWeight + _strenght * 10);
            }
            
            return _equipment.GetTotalWeight() - currentEquipedItem.Weight + newItemToEquip.Weight < (baseCarryWeight + _strenght * 10);
        }

        public void Equip(Headpiece headPiece)
        {
            if (!CanEquipNewItem(_equipment.HeadPiece, headPiece))
            {
                return;
            }

            _equipment.HeadPiece = headPiece;
        }

        public void Equip(Chestpiece chestPiece)
        {
            if (!CanEquipNewItem(_equipment.ChestPiece, chestPiece))
            {
                return;
            }

            _equipment.ChestPiece = chestPiece;
        }

        public void Equip(Shoulderpiece shoulderpiece, bool isLeft)
        {
            if (isLeft)
            {
                if (!CanEquipNewItem(_equipment.LeftShoulderpiece, shoulderpiece))
                {
                    return;
                }

                _equipment.LeftShoulderpiece = shoulderpiece;
            }
            else
            {
                if (!CanEquipNewItem(_equipment.RightShoulderpiece, shoulderpiece))
                {
                    return;
                }

                _equipment.RightShoulderpiece = shoulderpiece;
            }
        }

        public void Equip(Armpiece armpiece, bool isLeft)
        {
            if (isLeft)
            {
                if (!CanEquipNewItem(_equipment.LeftArmPiece, armpiece))
                {
                    return;
                }

                _equipment.LeftArmPiece = armpiece;
            }
            else
            {
                if (!CanEquipNewItem(_equipment.RightArmPiece, armpiece))
                {
                    return;
                }
                _equipment.RightArmPiece = armpiece;
            }
        }

        public void Equip(Gloves gloves)
        {
            if (!CanEquipNewItem(_equipment.Gloves, gloves))
            {
                return;
            }

            _equipment.Gloves = gloves;
        }

        public void Equip(Legspiece legspiece)
        {
            if (!CanEquipNewItem(_equipment.Legspiece, legspiece))
            {
                return;
            }

            _equipment.Legspiece = legspiece;

            #endregion Extra challenge: Equipment
        }
    }
}