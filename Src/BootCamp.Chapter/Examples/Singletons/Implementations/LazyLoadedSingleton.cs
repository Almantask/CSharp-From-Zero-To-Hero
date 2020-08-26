using System;

namespace BootCamp.Chapter.Examples.Singletons.Implementations
{
    public sealed class LazyLoadedSingleton
    {
        private static readonly Lazy<LazyLoadedSingleton> 
            Lazy = new Lazy<LazyLoadedSingleton>(() 
                => new LazyLoadedSingleton());

        public static LazyLoadedSingleton Instance => Lazy.Value;

        private LazyLoadedSingleton()
        {
            Console.WriteLine("Lazy loaded singleton created");
        }
    }
}
