using System;
using System.Collections.Generic;
using System.Text;
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

        }

        private Headpiece _head;
        public void SetHead(Headpiece head)
        {

        }

        private Chestpiece _chest;
        public void SetChest(Chestpiece chestpiece)
        {

        }

        private Shoulderpiece _leftShoulder;
        public void SetLeftShoulder(Shoulderpiece should)
        {

        }

        private Shoulderpiece _rightShoulder;
        public void SetRightShoulder(Shoulderpiece shoulder)
        {

        }

        private Legspiece _legs;
        public void SetLeg(Legspiece legs)
        {

        }

        private Armpiece _leftArm;
        public void SetLeftArmp(Armpiece arm)
        {

        }

        private Armpiece _rightArm;
        public void SetRightArm(Armpiece arm)
        {

        }

        private Gloves _gloves;
        public void SetGloves(Gloves gloves)
        {

        }

        /// <summary>
        /// Gets total weight of armour.
        /// </summary>
        /// <returns></returns>
        public float GetTotalWeight()
        {
            return 0;
        }

        /// <summary>
        /// Returns sums of defense stat of all armour pieces.
        /// </summary>
        /// <returns></returns>
        public float GetTotalDefense()
        {
            return 0;
        }

        /// <summary>
        /// Returns damage done by weapon.
        /// </summary>
        /// <returns></returns>
        public float GetTotalAttack()
        {
            return 0;
        }
    }
}
