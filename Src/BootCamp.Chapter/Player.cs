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

        private int _strenght;

        public int GetFullCarryWeight()
        {
            int fullCarryWeight = baseCarryWeight + _strenght * 10;
            return fullCarryWeight;
        }

        private Inventory _inventory;

        private Equipment _equipment;



        public Player()
        {
            _inventory = new Inventory();
            _equipment = new Equipment();
        }

        public Item[] GetItems()
        {
            return _inventory.GetItems();
        }

        public void AddItem(Item item)
        {
            _inventory.AddItem(item);
        }

        public void Remove(Item item)
        {
            _inventory.RemoveItem(item);
        }

        public Item[] GetItems(string name)
        {
            return _inventory.GetItems(name);
        }

        #region Extra challenge: Equipment
        public float GetTotalDefence()
        {
            return _equipment.GetTotalDefense();
        }

        public float GetTotalAttack()
        {
            return _equipment.GetTotalAttack();
        }

        public void Equip(Headpiece head)
        {
            if (!CanCarryNewItem(head)) return;
            _equipment.SetHead(head);
        }

        public void Equip(Chestpiece chest)
        {
            if (!CanCarryNewItem(chest)) return;
            _equipment.SetChest(chest);
        }

        public void Equip(Shoulderpiece shoulder, bool isLeft)
        {
            if (!CanCarryNewItem(shoulder)) return;

            if(isLeft)
            {
                _equipment.SetLeftShoulder(shoulder);
            }
            else
            {
                _equipment.SetRightShoulder(shoulder);
            }
        }

        public void Equip(Legspiece leg)
        {
            if (!CanCarryNewItem(leg)) return;
            _equipment.SetLeg(leg);
        }

        public void Equip(Armpiece arm, bool isLeft)
        {
            if (!CanCarryNewItem(arm)) return;

            if (isLeft)
            {
                _equipment.SetLeftArmp(arm);
            }
            else
            {
                _equipment.SetRightArm(arm);
            }
        }

        public void Equip(Gloves gloves)
        {
            if (!CanCarryNewItem(gloves)) return;
            _equipment.SetGloves(gloves);
        }
        #endregion

        private bool CanCarryNewItem(Item item)
        {
            if (item == null) return true;
            var currentWeight = _equipment.GetTotalWeight();
            var newWeight = currentWeight + item.GetWeight();

            return (newWeight <= GetFullCarryWeight());
        }
    }
}
