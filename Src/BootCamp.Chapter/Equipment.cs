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
            weightSum += Head == null ? 0 : Head.Weight;
            weightSum += Chest == null ? 0 : Chest.Weight;
            weightSum += LeftShoulder == null ? 0 : LeftShoulder.Weight;
            weightSum += RightShoulder == null ? 0 : RightShoulder.Weight;
            weightSum += LeftArm == null ? 0 : LeftArm.Weight;
            weightSum += RightArm == null ? 0 : RightArm.Weight;
            weightSum += Gloves == null ? 0 : Gloves.Weight;
            weightSum += Legs == null ? 0 : Legs.Weight;
            return weightSum;
        }

        /// <summary>
        /// Returns sums of defense stat of all armour pieces.
        /// </summary>
        /// <returns></returns>
        public float GetTotalDefense()
        {
            float defenseSum = 0;
            defenseSum += Head == null ? 0 : Head.Defense;
            defenseSum += Chest == null ? 0 : Chest.Defense;
            defenseSum += LeftShoulder == null ? 0 : LeftShoulder.Defense;
            defenseSum += RightShoulder == null ? 0 : RightShoulder.Defense;
            defenseSum += LeftArm == null ? 0 : LeftArm.Defense;
            defenseSum += RightArm == null ? 0 : RightArm.Defense;
            defenseSum += Gloves == null ? 0 : Gloves.Defense;
            defenseSum += Legs == null ? 0 : Legs.Defense;
            return defenseSum;
        }

        /// <summary>
        /// Returns damage done by weapon.
        /// </summary>
        /// <returns></returns>
        public float GetTotalAttack()
        {
            float attackSum = 0;
            if(Weapon == null)
            {
                return 0;
            }
            else
            {
                attackSum += Weapon.Damage;
                return attackSum;
            }
        }

        public override string ToString()
        {
            return string.Format($"{EquipmentToString()} and weapon: {Weapon.Name}");
        }

        private string EquipmentToString()
        {
            string result = "";
            Armour[] armourArray = new Armour[8];
            armourArray[0] = Head;
            armourArray[1] = Chest;
            armourArray[2] = LeftShoulder;
            armourArray[3] = RightShoulder;
            armourArray[4] = LeftArm;
            armourArray[5] = RightArm;
            armourArray[6] = Gloves;
            armourArray[7] = Legs;

            for (int i = 0; i < armourArray.Length; i++)
            {
                if (armourArray[i] != null)
                {
                    result += armourArray[i].Name + ", ";
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