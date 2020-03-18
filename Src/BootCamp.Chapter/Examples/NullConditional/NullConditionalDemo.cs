using System;
using BootCamp.Chapter.Examples.NullConditional;

// ReSharper disable All

namespace BootCamp.Chapter.Examples.NullCoalescing
{
    public static class NullConditionalDemo
    {
        public static void Run()
        {
            Play1(null);
            Play2(null);
            Console.WriteLine(CheckHunger1(null));
            Console.WriteLine(CheckHunger2(null));

            var dog = new Dog();
            Play1(dog);
            Play2(dog);
            Console.WriteLine(CheckHunger1(dog));
            Console.WriteLine(CheckHunger2(dog));
        }

        public static void Play1(Dog dog)
        {
            Console.WriteLine($"Could you please bark?");
            if (dog != null)
            {
                dog.Bark();
            }
        }

        public static void Play2(Dog dog)
        {
            Console.WriteLine($"Could you please bark?");
            dog?.Bark();
        }

        // false if dog doesn't exist
        public static bool CheckHunger1(Dog dog)
        {
            if (dog == null) return false;
            return dog.IsHungry;
        }

        // false if dog doesn't exist
        public static bool CheckHunger2(Dog dog)
        {
            var isHungry = dog?.IsHungry;

            return dog?.IsHungry == true;
        }
    }
}
