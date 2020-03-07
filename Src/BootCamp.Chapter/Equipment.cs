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
            var items = new Item[] {_weapon, _head, _chest,  _leftShoulder,  _rightShoulder, _legs, _leftArm, _rightArm,_gloves};
            var totalweight = 0f; 

            foreach (var item in items)
            {
                if (item == null)
                {
                    totalweight += 0;
                    continue; 
                }

                totalweight += item.GetWeight(); 
            }

            return totalweight; 
        }

        /// <summary>
        /// Returns sums of defense stat of all armour pieces.
        /// </summary>
        /// <returns></returns>
        public float GetTotalDefense()
        {
            var items = new Armor[] { _head, _chest, _leftShoulder, _rightShoulder, _legs, _leftArm, _rightArm, _gloves };
            var totaldefense = 0f;

            foreach (var item in items)
            {
                if (item == null)
                {
                    totaldefense += 0;
                    continue;
                }

                totaldefense += item.GetDefence(); 
            }

            return totaldefense;
        }

        /// <summary>
        /// Returns damage done by weapon.
        /// </summary>
        /// <returns></returns>
        public float GetTotalAttack()
        {
            if (_weapon == null)
            {
                return 0; 
            }

            return _weapon.GetDamage(); 
        }
    }
}
