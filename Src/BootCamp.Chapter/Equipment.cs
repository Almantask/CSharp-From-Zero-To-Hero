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

        /// <summary>
        /// Gets total weight of armour.
        /// </summary>
        /// <returns></returns>
        public float GetTotalWeight()
        {

            return 0;
        }

        /// <summary>
        /// Returns sums of defense stat of all armour pieces.
        /// </summary>
        /// <returns></returns>
        public float GetTotalDefense()
        {
            return 0;
        }

        /// <summary>
        /// Returns damage done by weapon.
        /// </summary>
        /// <returns></returns>
        public float GetTotalAttack()
        {
            return 0;
        }
    }
}
