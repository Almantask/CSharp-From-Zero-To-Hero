using BootCamp.Chapter.Items;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Player
    {
        /// <summary>
        /// Everyone can carry this much weight at least.
        /// </summary>
        private const int baseCarryWeight = 30;

        public string Name { get; set; }
        public int Hp { get; set; }
        public int Strenght { get; set; }

        public int FullCarryWeight 
        {
            get { return baseCarryWeight + Strenght * 10; }
        }

        public Inventory Inventory { get; }

        public Equipment Equipment { get; }



        public Player()
        {
            Inventory = new Inventory();
            Equipment = new Equipment();
        }

        public List<Item> GetItems()
        {
            return Inventory.Items;
        }

        public void AddItem(Item item)
        {
            Inventory.AddItem(item);
        }

        public void Remove(Item item)
        {
            Inventory.RemoveItem(item);
        }

        public List<Item> GetItems(string name)
        {
            return Inventory[name];
        }

        #region Extra challenge: Equipment
        public float GetTotalDefence()
        {
            return Equipment.GetTotalDefense();
        }

        public float GetTotalAttack()
        {
            return Equipment.GetTotalAttack();
        }

        public void Equip(Headpiece head)
        {
            if (!CanCarryNewItem(head)) return;
            Equipment.Head = head;
        }

        public void Equip(Chestpiece chest)
        {
            if (!CanCarryNewItem(chest)) return;
            Equipment.Chest = chest;
        }

        public void Equip(Shoulderpiece shoulder, bool isLeft)
        {
            if (!CanCarryNewItem(shoulder)) return;

            if (isLeft)
            {
                Equipment.LeftShoulder = shoulder;
            }
            else
            {
                Equipment.RightShoulder = shoulder;
            }
        }

        public void Equip(Legspiece leg)
        {
            if (!CanCarryNewItem(leg)) return;
            Equipment.Legs = leg;
        }

        public void Equip(Armpiece arm, bool isLeft)
        {
            if (!CanCarryNewItem(arm)) return;

            if (isLeft)
            {
                Equipment.LeftArm = arm;
            }
            else
            {
                Equipment.RightArm = arm;
            }
        }

        public void Equip(Gloves gloves)
        {
            if (!CanCarryNewItem(gloves)) return;
            Equipment.Gloves = gloves;
        }
        #endregion

        private bool CanCarryNewItem(Item item)
        {
            if (item == null) return true;
            var currentWeight = Equipment.GetTotalWeight();
            var newWeight = currentWeight + item.Weight;

            return (newWeight <= FullCarryWeight);
        }
    }
}