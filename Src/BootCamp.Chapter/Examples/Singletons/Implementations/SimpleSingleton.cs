using System;

namespace BootCamp.Chapter.Examples.Singletons
{
    public sealed class SimpleSingleton
    {
        private SimpleSingleton()
        {
            Console.WriteLine("Simple singleton created");
        }

        public static SimpleSingleton Instance { get; } = new SimpleSingleton();
    }
}
