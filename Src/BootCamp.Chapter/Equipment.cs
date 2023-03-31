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

        public void SetLeftArm(Armpiece arm)
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
            return _weapon.Weight + _head.Weight + _chest.Weight
                   + _leftShoulder.Weight + _rightShoulder.Weight + _legs.Weight
                   + _leftArm.Weight + _rightArm.Weight + _gloves.Weight;
        }

        /// <summary>
        /// Returns sums of defense stat of all armour pieces.
        /// </summary>
        /// <returns></returns>
        public float GetTotalDefense()
        {
            return _head.Defense + _chest.Defense
                   + _leftShoulder.Defense + _rightShoulder.Defense + _legs.Defense
                   + _leftArm.Defense + _rightArm.Defense + _gloves.Defense;
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