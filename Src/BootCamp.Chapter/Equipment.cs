using BootCamp.Chapter.Items;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Extra assignment. 
    /// </summary>
    public class Equipment
    {
        private Weapon _weapon;
        public Weapon Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }

        private Headpiece _head;
        public Headpiece Head
        {
            get { return _head; }
            set { _head = value; }
        }

        private Chestpiece _chest;
        public Chestpiece Chest
        {
            get { return _chest; }
            set { _chest = value; }
        }

        private Shoulderpiece _leftShoulder;
        public Shoulderpiece LeftShould
        {
            get { return _leftShoulder; }
            set { _leftShoulder = value; }
        }

        private Shoulderpiece _rightShoulder;
        public Shoulderpiece RightShoulder
        {
            get { return _rightShoulder; }
            set { _rightShoulder = value; }
        }

        private Legspiece _legs;
        public Legspiece Legs
        {
            get { return _legs; }
            set { _legs = value; }
        }

        private Armpiece _leftArm;
        public Armpiece LeftArm
        {
            get { return _leftArm; }
            set { _leftArm = value; }
        }

        private Armpiece _rightArm;
        public Armpiece RightArm
        {
            get { return _rightArm; }
            set { _rightArm = value; }
        }

        private Gloves _gloves;
        public Gloves Gloves
        {
            get { return _gloves; }
            set { _gloves = value; }
        }

        public Equipment[] currentEquip { get; set; }

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
