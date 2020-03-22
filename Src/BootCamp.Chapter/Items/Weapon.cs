﻿namespace BootCamp.Chapter.Items

{
    public class Weapon : Item

    {
        public float Damage { get; set; }

        public Weapon(string name, decimal price, float weight, float damage) : base(name, price, weight)

        {
            Damage = damage;
        }
    }
}