using BootCamp.Chapter.Items;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Extra assignment. 
    /// </summary>
    public class Equipment
    {
        private Weapon _weapon;
        private Headpiece _head;
        private Chestpiece _chest;
        private Shoulderpiece _leftShoulder;
        private Shoulderpiece _rightShoulder;
        private Legspiece _legs;
        private Armpiece _leftArm;
        private Armpiece _rightArm;
        private Gloves _gloves;
        
        private float _weight = 0;
        private float _defense = 0;
        private float _attack = 0;
        
        public void SetWeapon(Weapon weapon)
        {
            // Update attack
            _attack = (_weapon == null) ? 0 : _weapon.BaseAttack;
            
            // Update weight
            var oldWeight = (_weapon == null) ? 0 : _weapon.Weight;
            var newWeight = (weapon == null) ? 0 : weapon.Weight;
            _weight += newWeight - oldWeight;
            
            _weapon = weapon;
        }
        
        public void SetHead(Headpiece head)
        {
            UpdateEquippedArmourInfo(_head, head);
            _head = head;
        }
        
        public void SetChest(Chestpiece chestpiece)
        {
            UpdateEquippedArmourInfo(_chest, chestpiece);
            _chest = chestpiece;
        }
        
        public void SetLeftShoulder(Shoulderpiece should)
        {
            UpdateEquippedArmourInfo(_leftShoulder, should);
            _leftShoulder = should;
        }
        
        public void SetRightShoulder(Shoulderpiece shoulder)
        {
            UpdateEquippedArmourInfo(_rightShoulder, shoulder);
            _rightShoulder = shoulder;
        }
        
        public void SetLeg(Legspiece legs)
        {
            UpdateEquippedArmourInfo(_legs, legs);
            _legs = legs;
        }
        
        public void SetLeftArm(Armpiece arm)
        {
            UpdateEquippedArmourInfo(_leftArm, arm);
            _leftArm = arm;
        }

        public void SetRightArm(Armpiece arm)
        {
            UpdateEquippedArmourInfo(_rightArm, arm);
            _rightArm = arm;
        }
        
        public void SetGloves(Gloves gloves)
        {
            UpdateEquippedArmourInfo(_gloves, gloves);
            _gloves = gloves;
        }
        
        private void UpdateEquippedArmourInfo(Armour oldItem, Armour newItem)
        {
            var oldDefense = (oldItem == null) ? 0 : oldItem.BaseDefense;
            var newDefense = (newItem == null) ? 0 : newItem.BaseDefense;
            _defense += newDefense - oldDefense;
            
            var oldWeight = (oldItem == null) ? 0 : oldItem.Weight;
            var newWeight = (newItem == null) ? 0 : newItem.Weight;
            _weight += newWeight - oldWeight;
        }
        
        public float GetTotalWeight()
        {
            return _weight;
        }
        
        public float GetTotalDefense()
        {
            return _defense;
        }
        
        public float GetTotalAttack()
        {
            return _attack;
        }
    }
}
