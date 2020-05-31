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

        public Weapon Weapon
        {
            get => Weapon;
            set
            {
                Weapon newWeapon = value ?? throw new ArgumentNullException(nameof(value) + " shouldn't be null.");

                changeWepon(Weapon, newWeapon);
            }
        }
        public Headpiece Headpiece
        {
            get => Headpiece;
            set
            {
                Headpiece newHeadpiece = Headpiece ?? throw new ArgumentNullException(nameof(Headpiece) + " shouldn't be null.");

                changeArmor(Headpiece, Headpiece);
            }
        }
        public Chestpiece Chestpiece
        {
            get => Chestpiece;
            set
            {
                Chestpiece newChestpiece = Chestpiece ?? throw new ArgumentNullException(nameof(Chestpiece) + " shouldn't be null.");
                changeArmor(Chestpiece, Chestpiece);
            }
        }
        public Shoulderpiece LeftShoulder
        {
            get => LeftShoulder;
            set
            {
                Shoulderpiece newShoulderpiece = LeftShoulder ?? throw new ArgumentNullException(nameof(LeftShoulder) + " shouldn't be null.");
                changeArmor(LeftShoulder, LeftShoulder);
            }
        }
        public Shoulderpiece RightShoulder
        {
            get => RightShoulder;
            set
            {
                Shoulderpiece newShoulderpiece = RightShoulder ?? throw new ArgumentNullException(nameof(RightShoulder) + " shouldn't be null.");
                changeArmor(RightShoulder, RightShoulder);
            }
        }

        public Legspiece Legs
        {
            get => Legs;
            set
            {
                Legspiece newLegspiece = Legs ?? throw new ArgumentNullException(nameof(Legs) + " shouldn't be null.");
                changeArmor(Legs, Legs);
            }
        }

        public Armpiece LeftArm
        {
            get => LeftArm;
            set
            {
                var armpiece = LeftArm ?? throw new ArgumentNullException(nameof(LeftArm) + " shouldn't be null.");
                changeArmor(LeftArm, LeftArm);
            }
        }
        public Armpiece RightArm
        {
            get => RightArm; set
            {
                Armpiece newArmpiece = RightArm ?? throw new ArgumentNullException(nameof(RightArm) + " shouldn't be null.");
                changeArmor(RightArm, RightArm);
            }
        }
        public Gloves Gloves
        {
            get => Gloves; 
            set
            {
                Gloves newGloves = Gloves ?? throw new ArgumentNullException(nameof(Gloves) + " shouldn't be null.");
                changeArmor(Gloves, Gloves);
            }
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