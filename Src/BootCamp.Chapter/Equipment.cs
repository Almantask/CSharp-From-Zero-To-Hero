using BootCamp.Chapter.Items;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Extra assignment. 
    /// </summary>
    public class Equipment
    {
        private float _totalWeight;
        private float _totalDefense;
        private float _totalAttack;

        //I haven't change those to properties cause it has so many if statements.

        private Weapon _weapon;
        public void SetWeapon(Weapon weapon)
        {
            if (weapon == null) return;

            changeWepon(_weapon, weapon);
            weapon = _weapon;

        }

        private Headpiece _head;
        public void SetHead(Headpiece head)
        {
            if (head == null) return;

            changeArmor(_head, head);
            _head = head;
        }

        private Chestpiece _chest;
        public void SetChest(Chestpiece chestpiece)
        {
            if (chestpiece == null) return;
            changeArmor(_chest, chestpiece);
        }

        private Shoulderpiece _leftShoulder;
        public void SetLeftShoulder(Shoulderpiece should)
        {
            if (should == null) return;
            changeArmor(_leftShoulder, should);
        }

        private Shoulderpiece _rightShoulder;
        public void SetRightShoulder(Shoulderpiece shoulder)
        {
            if (shoulder == null) return;
            changeArmor(_rightShoulder, shoulder);
        }

        private Legspiece _legs;
        public void SetLeg(Legspiece legs)
        {
            if (legs == null) return;
            changeArmor(_legs, legs);
        }

        private Armpiece _leftArm;
        public void SetLeftArmp(Armpiece arm)
        {
            if (arm == null) return;
            changeArmor(_leftArm, arm);
        }

        private Armpiece _rightArm;
        public void SetRightArm(Armpiece arm)
        {
            if (arm == null) return;
            changeArmor(_rightArm, arm);
        }

        private Gloves _gloves;
        public void SetGloves(Gloves gloves)
        {
            if (gloves == null) return;
            changeArmor(_gloves, gloves);
        }

        /// <summary>
        /// Gets total weight of armour.
        /// </summary>
        /// <returns></returns>
        public float GetTotalWeight()
        {
            return _totalWeight;
        }

        /// <summary>
        /// Returns sums of defense stat of all armour pieces.
        /// </summary>
        /// <returns></returns>
        public float GetTotalDefense()
        {
            return _totalDefense;
        }

        /// <summary>
        /// Returns damage done by weapon.
        /// </summary>
        /// <returns></returns>
        public float GetTotalAttack()
        {
            return _totalAttack;
        }
        private void changeWepon(Weapon currentWeapon, Weapon newWeapon)
        {
            _totalAttack -= currentWeapon.GetDamageValue();
            _totalAttack += newWeapon.GetDamageValue();

            _totalWeight -= currentWeapon.Weight;
            _totalWeight += currentWeapon.Weight;
        }

        private void changeArmor(Armor currentArmorPiece, Armor newArmorPiece)
        {
            _totalWeight -= currentArmorPiece.Weight;
            _totalWeight += newArmorPiece.Weight;

            _totalDefense -= currentArmorPiece.GetDefenseValue();
            _totalDefense += currentArmorPiece.GetDefenseValue();
        }
    }
}
