using BootCamp.Chapter.Items;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Extra assignment. 
    /// </summary>
    public class Equipment
    {
        public Weapon Weapon { get; set; }
        public Headpiece Head { get; set; }
        public Chestpiece Chest { get; set; }
        public Shoulderpiece LeftShoulder { get; set; }
        public Shoulderpiece RightShoulder { get; set; }
        public Legspiece Legs { get; set; }
        public Armpiece LeftArm { get; set; }
        public Armpiece RightArm { get; set; }
        public Gloves Gloves { get; set; }
        
        private float _weight;
        private float _defense;
        private float _attack;

        public float Weight
        {
            get
            {
                UpdateWeight();
                return _weight;
            }
        }
        
        public float Defense
        {
            get
            {
                UpdateDefense();
                return _weight;
            }
        }
        
        public float Attack
        {
            get
            {
                UpdateAttack();
                return _weight;
            }
        }
        
        private Weapon[] ListOfWeapons()
        {
            var weapons = new Weapon[]
            {
                Weapon
            };
            
            return weapons;
        }

        private Armour[] ListOfArmours()
        {
            var armours = new Armour[]
            {
                Head,
                Chest,
                LeftShoulder,
                RightShoulder,
                Legs,
                LeftArm,
                RightArm,
                Gloves
            };

            return armours;
        }

        private void UpdateWeight()
        {
            float totalWeight = 0;
            foreach (var armour in ListOfArmours())
            {
                if (armour == null) continue;
                var armourWeight = armour.Weight;
                totalWeight += armourWeight;
            }
            foreach (var weapon in ListOfWeapons())
            {
                if (weapon == null) continue;
                var weaponWeight = weapon.Weight;
                totalWeight += weaponWeight;
            }

            _weight = totalWeight;
        }

        private void UpdateDefense()
        {
            float totalDefense = 0;
            foreach (var armour in ListOfArmours())
            {
                if (armour == null) continue;
                var armourDefense = armour.BaseDefense;
                totalDefense += armourDefense;
            }

            _defense = totalDefense;
        }

        private void UpdateAttack()
        {
            float totalAttack = 0;
            foreach (var weapon in ListOfWeapons())
            {
                if (weapon == null) continue;
                var weaponDefense = weapon.BaseAttack;
                totalAttack += weaponDefense;
            }

            _attack = totalAttack;
        }
    }
}
