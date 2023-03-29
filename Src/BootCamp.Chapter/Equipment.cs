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
            return _weapon.GetWeight() + _head.GetWeight() + _chest.GetWeight()
                   + _leftShoulder.GetWeight() + _rightShoulder.GetWeight() + _legs.GetWeight()
                   + _leftArm.GetWeight() + _rightArm.GetWeight() + _gloves.GetWeight();
        }

        /// <summary>
        /// Returns sums of defense stat of all armour pieces.
        /// </summary>
        /// <returns></returns>
        public float GetTotalDefense()
        {
            return _head.GetDefense() + _chest.GetDefense()
                   + _leftShoulder.GetDefense() + _rightShoulder.GetDefense() + _legs.GetDefense()
                   + _leftArm.GetDefense() + _rightArm.GetDefense() + _gloves.GetDefense();
        }

        /// <summary>
        /// Returns damage done by weapon.
        /// </summary>
        /// <returns></returns>
        public float GetTotalAttack()
        {
            return _weapon.GetAttack();
        }
    }
}