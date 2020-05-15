using BootCamp.Chapter.Items;
using System.ComponentModel;

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
        public Chestpiece Chestpiece
        {
            get
            {
                return _chest;
            }
            set
            {
                RefreshArmorStatistics(_chest, value);
                _chest = value;
            }
        }

        private Shoulderpiece _leftShoulder;
        public Shoulderpiece LeftShoulderpiece
        {
            get
            {
                return _leftShoulder;
            }
            set
            {
                RefreshArmorStatistics(_leftShoulder, value);
                _leftShoulder = value;
            }
        }

        private Shoulderpiece _rightShoulder;
        public Shoulderpiece RightShoulderpiece
        {
            get
            {
                return _rightShoulder;
            }
            set
            {
                RefreshArmorStatistics(_rightShoulder, value);
                _rightShoulder = value;
            }
        }

        private Legspiece _legs;
        public Legspiece Legspiece
        {
            get
            {
                return _legs;
            }
            set
            {
                RefreshArmorStatistics(_legs, value);
                _legs = value;
            }
        }

        private Armpiece _leftArm;
        public Armpiece LeftArm
        {
            get
            {
                return _leftArm;
            }
            set
            {
                RefreshArmorStatistics(_leftArm, value);
                _leftArm = value;
            }
        }

        private Armpiece _rightArm;
        public Armpiece RightArm
        {
            get
            {
                return _rightArm;
            }
            set
            {
                RefreshArmorStatistics(_rightArm, value);
                _rightArm = value;
            }
        }

        private Gloves _gloves;
        public Gloves Gloves
        {
            get
            {
                return _gloves;
            }
            set
            {
                RefreshArmorStatistics(_gloves, value);
                _gloves = value;
            }
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