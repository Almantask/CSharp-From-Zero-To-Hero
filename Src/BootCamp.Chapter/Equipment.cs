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
