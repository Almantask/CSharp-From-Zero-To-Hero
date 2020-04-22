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
            // Update attack
            _attack = IsEquipNull(_weapon) ? 0 : _weapon.GetBaseAttack();
            
            // Update weight
            var oldWeight = IsEquipNull(_weapon) ? 0 : _weapon.GetWeight();
            var newWeight = IsEquipNull(weapon) ? 0 : weapon.GetWeight();
            _weight += newWeight - oldWeight;
            
            _weapon = weapon;
        }

        private Headpiece _head;
        public void SetHead(Headpiece head)
        {
            UpdateEquippedArmourInfo(_head, head);
            _head = head;
        }

        private Chestpiece _chest;
        public void SetChest(Chestpiece chestpiece)
        {
            UpdateEquippedArmourInfo(_chest, chestpiece);
            _chest = chestpiece;
        }

        private Shoulderpiece _leftShoulder;
        public void SetLeftShoulder(Shoulderpiece should)
        {
            UpdateEquippedArmourInfo(_leftShoulder, should);
            _leftShoulder = should;
        }

        private Shoulderpiece _rightShoulder;
        public void SetRightShoulder(Shoulderpiece shoulder)
        {
            UpdateEquippedArmourInfo(_rightShoulder, shoulder);
            _rightShoulder = shoulder;
        }

        private Legspiece _legs;
        public void SetLeg(Legspiece legs)
        {
            UpdateEquippedArmourInfo(_legs, legs);
            _legs = legs;
        }

        private Armpiece _leftArm;
        public void SetLeftArm(Armpiece arm)
        {
            UpdateEquippedArmourInfo(_leftArm, arm);
            _leftArm = arm;
        }

        private Armpiece _rightArm;
        public void SetRightArm(Armpiece arm)
        {
            UpdateEquippedArmourInfo(_rightArm, arm);
            _rightArm = arm;
        }

        private Gloves _gloves;
        public void SetGloves(Gloves gloves)
        {
            UpdateEquippedArmourInfo(_gloves, gloves);
            _gloves = gloves;
        }

        /// <summary>
        /// Gets total weight of armour.
        /// </summary>
        /// <returns></returns>
        private float _weight = 0;
        public float GetTotalWeight()
        {
            return _weight;
        }

        /// <summary>
        /// Returns sums of defense stat of all armour pieces.
        /// </summary>
        /// <returns></returns>
        private float _defense = 0;
        public float GetTotalDefense()
        {
            return _defense;
        }
        /// <summary>
        /// Returns damage done by weapon.
        /// </summary>
        /// <returns></returns>
        private float _attack = 0;
        public float GetTotalAttack()
        {
            return _attack;
        }

        private void UpdateEquippedArmourInfo(Armour oldItem, Armour newItem)
        {
            var oldDefense = IsEquipNull(oldItem) ? 0 : oldItem.GetBaseDefense();
            var newDefense = IsEquipNull(newItem) ? 0 : newItem.GetBaseDefense();
            _defense += newDefense - oldDefense;
            
            var oldWeight = IsEquipNull(oldItem) ? 0 : oldItem.GetWeight();
            var newWeight = IsEquipNull(newItem) ? 0 : newItem.GetWeight();
            _weight += newWeight - oldWeight;
        }
        
        private bool IsEquipNull(Item item)
        {
            return item == null;
        }
        
    }
}
