using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Examples.AsAndIs;
using BootCamp.Chapter.Examples.NullCoalescing;
using BootCamp.Chapter.Examples.NullConditional;

// ReSharper disable All

namespace BootCamp.Chapter.Examples
{
    public static class AsAndIsDemo
    {
        public static void Run()
        {
            Dog dog1 = null;
            Dog dog2 = new Spaniel();
            Dog dog3 = new Labrador();

            // Not really pretty :(
            var type = dog1?.GetType();
            if (type == typeof(Dog))
            {
                // won't be printed, because dog1 is null.
                Console.WriteLine($"{nameof(dog1)} is a dog.");
            }

            // or for any other type. If it's null, false will be returned.
            // Way better!
            if (dog1 is Dog)
            {
                // won't be printed, because dog1 is null.
                Console.WriteLine($"{nameof(dog1)} is a dog.");
            }

            if (dog2 is Labrador)
            {
                // Won't be printed, because dog2 is Spaniel.
                Console.WriteLine($"{nameof(dog2)} is a Labrador.");
            }

            if (dog3 is Labrador)
            {
                // Will be printed, because dog3 is Labrador.
                Console.WriteLine($"{nameof(dog3)} is a Labrador.");
            }

            if (dog3 is Dog)
            {
                // Will be printed, because dog3 is also a Dog.
                Console.WriteLine($"{nameof(dog2)} is a dog.");
            }

            if (dog3 is object)
            {
                // Will be printed, because everything is an object.
                Console.WriteLine($"{nameof(dog3)} is an object.");
            }

            const int number = 5;
            if (number is object)
            {
                // Will be printed, because everything is an object.
                Console.WriteLine($"{nameof(number)} is an object.");
            }

            // Will NOT fail, because all dogs are not spaniels and this one originally was not.
            var dog4 = dog3 as Spaniel;
            var spaniel = dog2 as Labrador;

            try
            {
                // WILL fail, because all dogs are not spaniels and this one originally was not.
                var dog5 = (Spaniel)dog3;
            }
            catch
            {
                Console.WriteLine($"{nameof(dog3)} is not a Spaniel.");
            }
        }
    }
}
