using BootCamp.Chapter.Items;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Extra assignment. 
    /// </summary>
    public class Equipment
    {
        public Equipment()
        {
            _weapon = new Weapon("", 0, 0, 0);
            _head = new Headpiece("", 0, 0, 0);
            _chest = new Chestpiece("", 0, 0, 0);
            _leftArm = new Armpiece("", 0, 0, 0);
            _rightArm = new Armpiece("", 0, 0, 0);
            _leftShoulder = new Shoulderpiece("", 0, 0, 0);
            _rightShoulder = new Shoulderpiece("", 0, 0, 0);
            _legs = new Legspiece("", 0, 0, 0);
            _gloves = new Gloves("", 0, 0, 0);
        }

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
            float totalEquipmentWeight =
                _leftShoulder.GetShoulderpieceWeightStat() + _rightShoulder.GetShoulderpieceWeightStat() +
                _legs.GetLegspieceWeightStat() + _head.GetHeadpieceWeightStat() +
                _gloves.GetGlovesWeightStat() + _chest.GetChestpieceWeightStat() +
                _leftArm.GetArmpieceWeightStat() + _rightArm.GetArmpieceWeightStat() +
                _weapon.GetWeaponWeightStat();
            ;
            return totalEquipmentWeight;
        }

        /// <summary>
        /// Returns sums of defense stat of all armour pieces.
        /// </summary>
        /// <returns></returns>
        public float GetTotalDefense()
        {
            float totalDefence =
                _leftShoulder.GetShoulderpieceDefence() + _rightShoulder.GetShoulderpieceDefence() +
                _legs.GetLegspieceDefence() + _head.GetHeadpieceDefence() +
                _gloves.GetGlovesDefence() + _chest.GetChestpieceDefence() +
                _leftArm.GetArmpieceDefence() + _rightArm.GetArmpieceDefence();
            
            return totalDefence;
        }

        /// <summary>
        /// Returns damage done by weapon.
        /// </summary>
        /// <returns></returns>
        public float GetTotalAttack()
        {
            return _weapon.GetWeaponAttackStat();
        }
    }
}
