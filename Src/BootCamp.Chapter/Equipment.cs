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
                _leftShoulder.Weight + _rightShoulder.Weight +
                _legs.Weight + _head.Weight +
                _gloves.Weight + _chest.Weight +
                _leftArm.Weight + _rightArm.Weight +
                _weapon.Weight;
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
                _leftShoulder.Defense + _rightShoulder.Defense +
                _legs.Defense + _head.Defense +
                _gloves.Defense + _chest.Defense +
                _leftArm.Defense + _rightArm.Defense;
            
            return totalDefence;
        }

        /// <summary>
        /// Returns damage done by weapon.
        /// </summary>
        /// <returns></returns>
        public float GetTotalAttack()
        {
            return _weapon.Attack;
        }
    }
}
