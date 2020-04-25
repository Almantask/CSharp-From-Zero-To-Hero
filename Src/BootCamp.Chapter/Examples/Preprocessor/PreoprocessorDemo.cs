using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.Preprocessor
{
    public static class PreoprocessorDemo
    {
        public static void Run()
        {
            // Normally compiler will complain about a being not used.
            // We can ignore such complains using #pragma.
            #pragma warning disable 219
                int a = 5;
            #pragma warning restore 219
            // Will only be printed in debug mode.
            #if DEBUG
                Console.WriteLine("Debugging");
            #endif
        }
    }
}
