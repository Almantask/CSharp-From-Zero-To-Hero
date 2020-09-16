using BootCamp.Chapter.Items;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Extra assignment. 
    /// </summary>
    public class Equipment
    {
        private Weapon _weapon;
        public void SetWeapon(Weapon weapon)
        {
            _weapon = weapon;
        }

        private Headpiece _head;
        public void SetHead(Headpiece head)
        {
            _head = head;
        }

        private Chestpiece _chest;
        public void SetChest(Chestpiece chestpiece)
        {
            _chest = chestpiece;
        }

        private Shoulderpiece _leftShoulder;
        public void SetLeftShoulder(Shoulderpiece should)
        {
            _leftShoulder = should;
        }

        private Shoulderpiece _rightShoulder;
        public void SetRightShoulder(Shoulderpiece shoulder)
        {
            _rightShoulder = shoulder;
        }

        private Legspiece _legs;
        public void SetLeg(Legspiece legs)
        {
            _legs = legs;
        }

        private Armpiece _leftArm;
        public void SetLeftArmp(Armpiece arm)
        {
            _leftArm = arm;
        }

        private Armpiece _rightArm;
        public void SetRightArm(Armpiece arm)
        {
            _rightArm = arm;
        }

        private Gloves _gloves;
        public void SetGloves(Gloves gloves)
        {
            _gloves = gloves;
        }

        /// <summary>
        /// Gets total weight of armour.
        /// </summary>
        /// <returns></returns>
        public float GetTotalWeight()
        {
            float weightSum = 0;
            weightSum += _head == null ? 0 : _head.GetWeight();
            weightSum += _chest == null ? 0 : _chest.GetWeight();
            weightSum += _leftShoulder == null ? 0 : _leftShoulder.GetWeight();
            weightSum += _rightShoulder == null ? 0 : _rightShoulder.GetWeight();
            weightSum += _leftArm == null ? 0 : _leftArm.GetWeight();
            weightSum += _rightArm == null ? 0 : _rightArm.GetWeight();
            weightSum += _gloves == null ? 0 : _gloves.GetWeight();
            weightSum += _legs == null ? 0 : _legs.GetWeight();
            return weightSum;
        }

        /// <summary>
        /// Returns sums of defense stat of all armour pieces.
        /// </summary>
        /// <returns></returns>
        public float GetTotalDefense()
        {
            float defenseSum = 0;
            defenseSum += _head == null ? 0 : _head.GetDefense();
            defenseSum += _chest == null ? 0 : _chest.GetDefense();
            defenseSum += _leftShoulder == null ? 0 : _leftShoulder.GetDefense();
            defenseSum += _rightShoulder == null ? 0 : _rightShoulder.GetDefense();
            defenseSum += _leftArm == null ? 0 : _leftArm.GetDefense();
            defenseSum += _rightArm == null ? 0 : _rightArm.GetDefense();
            defenseSum += _gloves == null ? 0 : _gloves.GetDefense();
            defenseSum += _legs == null ? 0 : _legs.GetDefense();
            return defenseSum;
        }

        /// <summary>
        /// Returns damage done by weapon.
        /// </summary>
        /// <returns></returns>
        public float GetTotalAttack()
        {
            float attackSum = 0;
            attackSum += _weapon.GetTotalAttack();
            return attackSum;
        }

        public override string ToString()
        {
            return string.Format($"{EquipmentToString()} and weapon: {_weapon.GetName()}");
        }

        private string EquipmentToString()
        {
            string result = "";
            Armour[] armourArray = new Armour[8];
            armourArray[0] = _head;
            armourArray[1] = _chest;
            armourArray[2] = _leftShoulder;
            armourArray[3] = _rightShoulder;
            armourArray[4] = _leftArm;
            armourArray[5] = _rightArm;
            armourArray[6] = _gloves;
            armourArray[7] = _legs;

            for (int i = 0; i < armourArray.Length; i++)
            {
                if(armourArray[i] != null)
                {
                    result += armourArray[i].GetName() + ", ";
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
