using System;

namespace BootCamp.Chapter.Examples.Singletons.Implementations
{
    public sealed class NaiveSingleton
    {
        private static readonly NaiveSingleton _instance;

        private NaiveSingleton()
        {
            Console.WriteLine("Naive singleton created");
        }

        public static NaiveSingleton Instance => _instance ?? new NaiveSingleton();
    }
}
