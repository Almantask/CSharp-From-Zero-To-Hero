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
            float weightSum = 0;
            weightSum += Head?.Weight ?? 0;
            weightSum += Chest?.Weight ?? 0;
            weightSum += LeftShoulder?.Weight ?? 0;
            weightSum += RightShoulder?.Weight ?? 0;
            weightSum += LeftArm?.Weight ?? 0;
            weightSum += RightArm?.Weight ?? 0;
            weightSum += Gloves?.Weight ?? 0;
            weightSum += Legs?.Weight ?? 0;
            return weightSum;
        }

        /// <summary>
        /// Returns sums of defense stat of all armour pieces.
        /// </summary>
        /// <returns></returns>
        public float GetTotalDefense()
        {
            float defenseSum = 0;
            defenseSum += Head?.Defense ?? 0;
            defenseSum += Chest?.Defense ?? 0;
            defenseSum += LeftShoulder?.Defense ?? 0;
            defenseSum += RightShoulder?.Defense ?? 0;
            defenseSum += LeftArm?.Defense ?? 0;
            defenseSum += RightArm?.Defense ?? 0;
            defenseSum += Gloves?.Defense ?? 0;
            defenseSum += Legs?.Defense ?? 0;
            return defenseSum;
        }

        /// <summary>
        /// Returns damage done by weapon.
        /// </summary>
        /// <returns></returns>
        public float GetTotalAttack()
        {
            return Weapon?.Damage ?? 0;
        }

        public override string ToString()
        {
            return string.Format($"{EquipmentToString()} and weapon: {Weapon.Name}");
        }

        private string EquipmentToString()
        {
            string result = "";
            Armour[] armour = { Head, Chest, LeftShoulder, RightShoulder, LeftArm, RightArm, Gloves, Legs };

            for (int i = 0; i < armour.Length; i++)
            {
                if (armour[i] != null)
                {
                    result += armour[i].Name + ", ";
                }
            }

            if (string.IsNullOrEmpty(result))
            {
                return "";
            }
            else
            {
                result = result.Remove(result.Length - 2);
                return result;
            }
        }
    }
}