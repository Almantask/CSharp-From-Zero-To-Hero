using System;

namespace BootCamp.Chapter.Examples.CompareFruits
{
    public readonly struct Fruit
    {
        public readonly string Name;
        public readonly double Weight;

        public Fruit(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public static bool operator >(Fruit fruit1, Fruit fruit2) => fruit1.Weight > fruit2.Weight;

        // Must implement both > and <
        public static bool operator <(Fruit fruit1, Fruit fruit2) => fruit1.Weight < fruit2.Weight;
    }

    public static class CompareFruitsDemo
    {
        public static void Run()
        {
            var apple = new Fruit("Apple", 0.15);
            var banana = new Fruit("Banana", 0.2);

            Console.WriteLine($"apple(0.15) > banana(0.2) = {apple > banana}");
            Console.WriteLine($"apple(0.15) < banana(0.2) = {apple < banana}");
        }
    }
}
