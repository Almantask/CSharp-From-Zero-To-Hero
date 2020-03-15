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

        public Chestpiece Chest { get; set;  }
        
        public Shoulderpiece LeftShoulder { get; set; }

        public Shoulderpiece RightShoulder { get; set; }

        public Legspiece Legs { get; set; }

        public Armpiece LeftArm { get; set; }
        
        public Armpiece RightArm { get; set; }

        public Gloves Gloves { get; set; }

        /// <summary>
        /// Gets total weight of armour.
        /// </summary>
        /// <returns></returns>
        public float GetTotalWeight()
        {
            var equipped = new Item[]
            {
                Weapon,
                Head,
                Chest,
                LeftShoulder,
                RightShoulder,
                Legs,
                LeftArm,
                RightArm,
                Gloves
            };

            float weight = 0f;

            foreach (Item item in equipped)
            {
                if (item != null)
                {
                    weight += item.Weight;
                }
            }
            
            return weight;
        }

        /// <summary>
        /// Returns sums of defense stat of all armour pieces.
        /// </summary>
        /// <returns></returns>
        public float GetTotalDefense()
        {
            var equipped = new Armor[]
            {
                Head,
                Chest,
                LeftShoulder,
                RightShoulder,
                Legs,
                LeftArm,
                RightArm,
                Gloves
            };

            float defense = 0f;

            foreach (Armor armor in equipped)
            {
                if (armor != null)
                {
                    defense += armor.Defence;
                }
            }

            return defense;
        }

        /// <summary>
        /// Returns damage done by weapon.
        /// </summary>
        /// <returns></returns>
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
