using BootCamp.Chapter.Items;
using System;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Extra assignment. 
    /// </summary>
    public class Equipment
    {
        #region equipment and setters
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
        public void SetLeftShoulder(Shoulderpiece shoulder)
        {
            _leftShoulder = shoulder;
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
        public void SetLeftArmpiece(Armpiece arm)
        {
            _leftArm = arm;
        }

        private Armpiece _rightArm;
        public void SetRightArmiece(Armpiece arm)
        {
            _rightArm = arm;
        }

        private Gloves _gloves;
        public void SetGloves(Gloves gloves)
        {
            _gloves = gloves;
        }

        #endregion

        /// <summary>
        /// Gets total weight of armour.
        /// </summary>
        /// <returns></returns>
        public float GetTotalWeight()
        {
            float currentWeight = 0f;

            var items = new Item[]
           {
               _chest,
                _gloves,
                _head,
                _leftArm,
                _leftShoulder,
                _legs,
                _rightArm,
                _rightShoulder,
                _weapon
            };

            foreach (var item in items)
            {
                if (item == null)
                {
                    currentWeight += 0f;
                    continue;
                }
                currentWeight += item.GetWeight();
            }

            return currentWeight;
        }

        /// <summary>
        /// Returns sums of defense stat of all armour pieces.
        /// </summary>
        /// <returns></returns>
        public float GetTotalDefense()
        {
            float currentDefense = 0f;

            var armorset = new Armor[]
           {
               _chest,
                _gloves,
                _head,
                _leftArm,
                _leftShoulder,
                _legs,
                _rightArm,
                _rightShoulder
            };

            foreach (var armor in armorset)
            {
                if (armor == null)
                {
                    currentDefense += 0f;
                    continue;
                }
                currentDefense += armor.GetDefence();
            }

            return currentDefense;
        }

        /// <summary>
        /// Returns damage done by weapon.
        /// </summary>
        /// <returns></returns>
        public float GetTotalAttack()
        {
            if (_weapon != null)
            {
                return _weapon.GetDamage();
            }
            return 0;
        }
    }
}
