using BootCamp.Chapter.Items;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Extra assignment. 
    /// </summary>
    public class Equipment
    {
        public float TotalAttackValue { get; private set; }
        public float TotalDefenseValue { get; private set; }
        public float TotalCombinedWeight { get; private set; }

        private Weapon _weapon;
        public Weapon Weapon
        {
            get
            {
                return _weapon;
            }
            set
            {
                if (value == null) return;

                TotalAttackValue = (value == null) ? 0.0f : value.AttackValue;

                var currentWeight = (_weapon == null) ? 0.0f : Weapon.Weight;
                var newWeight = (value == null) ? 0.0f : value.Weight;

                TotalCombinedWeight += newWeight - currentWeight;
                _weapon = value;
            }
        }

        private Headpiece _headpiece;
        public Headpiece Headpiece
        {
            get
            {
                return _headpiece;
            }
            set
            {
                RefreshArmorStatistics(_headpiece, value);
                _headpiece = value;
            }
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

        private void RefreshArmorStatistics(Armor currentArmor, Armor newArmor)
        {
            var currentDefenseValue = (currentArmor == null) ? 0.0f : currentArmor.DefenseValue;
            var newDefenseValue = (newArmor == null) ? 0.0f : newArmor.DefenseValue;

            TotalDefenseValue += newDefenseValue - currentDefenseValue;

            var currentWeight = (currentArmor == null) ? 0.0f : currentArmor.Weight;
            var newWeight = (newArmor == null) ? 0.0f : newArmor.Weight;

            TotalCombinedWeight += newWeight - currentWeight;
        }
    }
}