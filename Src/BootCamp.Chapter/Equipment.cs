using BootCamp.Chapter.Items;
using System;

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

        /// <summary>
        /// Gets total weight of armour.
        /// </summary>
        /// <returns></returns>
        public float GetTotalWeight()
        {
            float currentWeight = 0f;

            currentWeight += EquipedOrNullItem(_head).GetWeight();
            currentWeight += EquipedOrNullItem(_weapon).GetWeight();
            currentWeight += EquipedOrNullItem(_chest).GetWeight();
            currentWeight += EquipedOrNullItem(_leftShoulder).GetWeight();
            currentWeight += EquipedOrNullItem(_rightShoulder).GetWeight();
            currentWeight += EquipedOrNullItem(_legs).GetWeight();
            currentWeight += EquipedOrNullItem(_leftArm).GetWeight();
            currentWeight += EquipedOrNullItem(_rightArm).GetWeight();
            currentWeight += EquipedOrNullItem(_gloves).GetWeight();
            return currentWeight;
        }

        /// <summary>
        /// Returns sums of defense stat of all armour pieces.
        /// </summary>
        /// <returns></returns>
        public float GetTotalDefense()
        {
            float currentDefense = 0f;

            currentDefense += EquipedOrNullArmor(_head).GetDefence();
            currentDefense += EquipedOrNullArmor(_chest).GetDefence();
            currentDefense += EquipedOrNullArmor(_leftShoulder).GetDefence();
            currentDefense += EquipedOrNullArmor(_rightShoulder).GetDefence();
            currentDefense += EquipedOrNullArmor(_legs).GetDefence();
            currentDefense += EquipedOrNullArmor(_leftArm).GetDefence();
            currentDefense += EquipedOrNullArmor(_rightArm).GetDefence();
            currentDefense += EquipedOrNullArmor(_gloves).GetDefence();

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

        /// <summary>
        /// Returns either the item, or if it is null a null item.
        /// </summary>
        /// <param name="item"> Item from which to get weight </param>
        /// <returns> The item's Weight, if null then zero</returns>
        Item EquipedOrNullItem(Item item)
        {
            if (item != null)
            {
                return item;
            }
            return Item.NullItem();
        }

        Armor EquipedOrNullArmor(Armor armor)
        {
            if (armor != null)
            {
                return armor;
            }
            return Armor.NullArmor();
        }
    }
}
