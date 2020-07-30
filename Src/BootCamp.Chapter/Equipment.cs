using BootCamp.Chapter.Items;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Extra assignment. 
    /// </summary>
    public class Equipment
    {
        public Weapon Weapon { get; set; }
        public Headpiece Head { get; set; }
        public Chestpiece Chest { get; set; }
        public Shoulderpiece LeftShoulder { get; set; }
        public Shoulderpiece RightShoulder { get; set; }
        public Legspiece Legs { get; set; }
        public Armpiece LeftArm { get; set; }
        public Armpiece RightArm { get; set; }
        public Gloves Gloves { get; set; }

        public float GetTotalWeight()
        {
            var items = new Item[] { Weapon, Head, Chest, LeftShoulder, RightShoulder, Legs, LeftArm, RightArm, Gloves };
            float totalWeight = 0;

            foreach (var item in items)
            {
                if (item == null)
                {
                    continue;
                }

                totalWeight += item.Weight;
            }

            return totalWeight;
        }

        public float GetTotalDefense()
        {
            var items = new Armor[] { Head, Chest, LeftShoulder, RightShoulder, Legs, LeftArm, RightArm, Gloves };
            float totalDefence = 0;

            foreach (var item in items)
            {
                if (item == null)
                {
                    continue;
                }

                totalDefence += item.Defence;
            }

            return totalDefence;
        }

        public float GetTotalAttack()
        {
            if (Weapon == null)
            {
                return 0;
            }

            return Weapon.Attack;
        }
    }
}
