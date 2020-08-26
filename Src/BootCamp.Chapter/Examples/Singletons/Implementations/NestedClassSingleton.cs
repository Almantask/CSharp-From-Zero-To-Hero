using System;

namespace BootCamp.Chapter.Examples.Singletons.Implementations
{
    public sealed class NestedClassSingleton
    {
        private static readonly NestedClassSingleton _instance = new NestedClassSingleton();

        private NestedClassSingleton()
        {
            Console.WriteLine("Nested singleton created");
        }

        // Lazily initialized, because the static class gets initialized only when first referenced.
        public static NestedClassSingleton Instance => _instance; //Nested._instance;

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly NestedClassSingleton _instance = new NestedClassSingleton();
        }
    }
}
