using BootCamp.Chapter.Items;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Extra assignment.
    /// </summary>
    public class Equipment
    {
        public Weapon Weapon { get; set; }
        public Headpiece HeadPiece { get; set; }
        public Chestpiece ChestPiece { get; set; }
        public Shoulderpiece LeftShoulderpiece { get; set; }
        public Shoulderpiece RightShoulderpiece { get; set; }
        public Legspiece Legspiece { get; set; }
        public Armpiece LeftArmPiece { get; set; }
        public Armpiece RightArmPiece { get; set; }
        public Gloves Gloves { get; set; }

        /// <summary>
        /// Gets total weight of armour.
        /// </summary>
        /// <returns></returns>
        public float GetTotalWeight()
        {
            var items = new List<Item> { Weapon, HeadPiece, ChestPiece, LeftShoulderpiece, RightShoulderpiece, Legspiece, LeftArmPiece, RightArmPiece, Gloves };
            var totalweight = 0f;

            foreach (var item in items)
            {
                if (item == null)
                {
                    continue;
                }

                totalweight += item.Weight;
            }

            return totalweight;
        }

        /// <summary>
        /// Returns sums of defense stat of all armour pieces.
        /// </summary>
        /// <returns></returns>
        public float GetTotalDefense()
        {
            var items = new List<Armour> { HeadPiece, ChestPiece, LeftShoulderpiece, RightShoulderpiece, Legspiece, LeftArmPiece, RightArmPiece, Gloves };
            var totaldefense = 0f;

            foreach (var item in items)
            {
                if (item == null)
                {
                    continue;
                }

                totaldefense += item.Defence;
            }

            return totaldefense;
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

            return Weapon.Damage;
        }
    }
}