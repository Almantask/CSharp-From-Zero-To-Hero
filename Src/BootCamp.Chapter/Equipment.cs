using BootCamp.Chapter.Items;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Extra assignment. 
    /// </summary>
    public class Equipment
    {
        private float _totalAttackValue;
        private float _totalDefenseValue;
        private float _totalCombinedWeight;

        private Weapon _weapon;
        public void SetWeapon(Weapon weapon)
        {
            if (weapon == null) return;
            
            _totalAttackValue = (weapon == null) ? 0.0f : weapon.GetAttackValue();

            var currentWeight = (_weapon == null) ? 0.0f : weapon.GetWeight();
            var newWeight = (weapon == null) ? 0.0f : weapon.GetWeight();

            _totalCombinedWeight += newWeight - currentWeight;
            _weapon = weapon;
        }

        private Headpiece _head;
        public void SetHead(Headpiece head)
        {
            RefreshArmorStatistics(_head, head);
            _head = head;
        }

        private Chestpiece _chest;
        public void SetChest(Chestpiece chestpiece)
        {
            RefreshArmorStatistics(_chest, chestpiece);
            _chest = chestpiece;
        }

        private Shoulderpiece _leftShoulder;
        public void SetLeftShoulder(Shoulderpiece shoulder)
        {
            RefreshArmorStatistics(_leftShoulder, shoulder);
            _leftShoulder = shoulder;
        }

        private Shoulderpiece _rightShoulder;
        public void SetRightShoulder(Shoulderpiece shoulder)
        {
            RefreshArmorStatistics(_rightShoulder, shoulder);
            _rightShoulder = shoulder;
        }

        private Legspiece _legs;
        public void SetLeg(Legspiece legs)
        {
            RefreshArmorStatistics(_legs, legs);
            _legs = legs;
        }

        private Armpiece _leftArm;
        public void SetLeftArm(Armpiece arm)
        {
            RefreshArmorStatistics(_leftArm, arm);
            _leftArm = arm;
        }

        private Armpiece _rightArm;
        public void SetRightArm(Armpiece arm)
        {
            RefreshArmorStatistics(_rightArm, arm);
            _rightArm = arm;
        }

        private Gloves _gloves;
        public void SetGloves(Gloves gloves)
        {
            RefreshArmorStatistics(_gloves, gloves);
            _gloves = gloves;
        }

        /// <summary>
        /// Gets total weight of armour.
        /// </summary>
        /// <returns></returns>
        public float GetTotalWeight()
        {
            return _totalCombinedWeight;
        }

        /// <summary>
        /// Returns sums of defense stat of all armour pieces.
        /// </summary>
        /// <returns></returns>
        public float GetTotalDefense()
        {
            return _totalDefenseValue;
        }

        /// <summary>
        /// Returns damage done by weapon.
        /// </summary>
        /// <returns></returns>
        public float GetTotalAttack()
        {
            return _totalAttackValue;
        }

        private void RefreshArmorStatistics(Armor currentArmor, Armor newArmor)
        {
            var currentDefenseValue = (currentArmor == null) ? 0.0f : currentArmor.GetDefenseValue();
            var newDefenseValue = (newArmor == null) ? 0.0f : newArmor.GetDefenseValue();

            _totalDefenseValue += newDefenseValue - currentDefenseValue;

            var currentWeight = (currentArmor == null) ? 0.0f : currentArmor.GetWeight();
            var newWeight = (newArmor == null) ? 0.0f : newArmor.GetWeight();

            _totalCombinedWeight += newWeight - currentWeight;
        }
    }
}
