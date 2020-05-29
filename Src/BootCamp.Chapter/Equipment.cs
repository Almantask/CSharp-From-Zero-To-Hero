using System;
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

        public Weapon Weapon { get; set; }
        public Headpiece Headpiece { get; set; }
        public Chestpiece Chestpiece { get; set; }
        public Shoulderpiece LeftShoulder { get; set; }
        public Shoulderpiece RightShoulder { get; set; }
        public Legspiece Legs { get; set; }
        public Armpiece LeftArm { get; set; }
        public Armpiece RightArm { get; set; }
        public Gloves Gloves { get; set; }

        //I haven't change those to properties cause it has so many if statements.

        public void SetWeapon(Weapon weapon)
        {
            Weapon newWeapon = weapon ?? throw new ArgumentNullException(nameof(weapon) + " shouldn't be null.");

            changeWepon(Weapon, newWeapon);
        }

        
        public void SetHead(Headpiece head)
        {
            Headpiece newHeadpiece = head ?? throw new ArgumentNullException(nameof(head) + " shouldn't be null.");

            changeArmor(Headpiece, head);
        }

        public void SetChest(Chestpiece chestpiece)
        {
            Chestpiece newChestpiece = chestpiece ?? throw new ArgumentNullException(nameof(chestpiece) + " shouldn't be null.");
            changeArmor(Chestpiece, chestpiece);
        }

        public void SetLeftShoulder(Shoulderpiece should)
        {
            Shoulderpiece newShoulderpiece = should ?? throw new ArgumentNullException(nameof(should) + " shouldn't be null.");
            changeArmor(LeftShoulder, should);
        }

        
        public void SetRightShoulder(Shoulderpiece shoulder)
        {
            Shoulderpiece newShoulderpiece = shoulder ?? throw new ArgumentNullException(nameof(shoulder) + " shouldn't be null.");
            changeArmor(RightShoulder, shoulder);
        }

        
        public void SetLeg(Legspiece legs)
        {
            Legspiece newLegspiece = legs ?? throw new ArgumentNullException(nameof(legs) + " shouldn't be null.");
            changeArmor(Legs, legs);
        }

        
        public void SetLeftArmp(Armpiece arm)
        {
            var armpiece = arm ?? throw new ArgumentNullException(nameof(arm) + " shouldn't be null.");
            changeArmor(LeftArm, arm );
        }

        
        public void SetRightArm(Armpiece arm)
        {
            Armpiece newArmpiece = arm ?? throw new ArgumentNullException(nameof(arm) + " shouldn't be null.");
            changeArmor(RightArm, arm);
        }

        
        public void SetGloves(Gloves gloves)
        {
            Gloves newGloves = gloves ?? throw new ArgumentNullException(nameof(gloves) + " shouldn't be null.");
            changeArmor(Gloves, gloves);
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
            _totalAttack -= currentWeapon?.GetDamageValue() ?? throw new ArgumentNullException(nameof(currentWeapon) + " shouldn't be null.");
            _totalAttack += newWeapon?.GetDamageValue() ?? throw new ArgumentNullException(nameof(newWeapon) + " shouldn't be null.");

            _totalWeight -= currentWeapon.Weight;
            _totalWeight += currentWeapon.Weight;
        }

        private void changeArmor(Armor currentArmorPiece, Armor newArmorPiece)
        {
            _totalWeight -= currentArmorPiece?.Weight ?? throw new ArgumentNullException(nameof(currentArmorPiece) + " shouldn't be null.");
            _totalWeight += newArmorPiece?.Weight ?? throw new ArgumentNullException(nameof(newArmorPiece) + " shouldn't be null.");

            _totalDefense -= currentArmorPiece.GetDefenseValue();
            _totalDefense += currentArmorPiece.GetDefenseValue();
        }
    }
}