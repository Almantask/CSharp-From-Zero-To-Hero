using BootCamp.Chapter.Items;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Extra assignment. 
    /// </summary>
    public class Equipment
    {
        private Weapon _weapon;
        public Weapon weapon { get { return _weapon; } set { _weapon = value; } }


        private Headpiece _head;
        public Headpiece head { get { return _head; } set { _head = value; } }


        private Chestpiece _chest;
        public Chestpiece chest { get { return _chest; } set { _chest = value; } }

        private Shoulderpiece _leftShoulder;
        public Shoulderpiece leftShoulder { get { return _leftShoulder; } set { _leftShoulder = value; } }


        private Shoulderpiece _rightShoulder;
        public Shoulderpiece rightShoulder { get { return _rightShoulder; } set { _rightShoulder = value; } }

        private Legspiece _legs;
        public Legspiece legs { get { return _legs; } set { _legs = value; } }


        private Armpiece _leftArm;
        public Armpiece leftArm { get { return _leftArm; } set { _leftArm = value; } }


        private Armpiece _rightArm;
        public Armpiece rightArm { get { return _rightArm; } set { _rightArm = value; } }

        private Gloves _gloves;
        public Gloves gloves { get { return _gloves; } set { _gloves = value; } }


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
