using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class DemoExtensions
    {
        private static IEnumerable<int> Numbers => ListsDemo.Numbers;

        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++[DEMO LINQ]++++++++++++");
            Console.WriteLine();

            Console.WriteLine("[Original List]");
            Numbers.PrintAll();
            Console.WriteLine("-------------------------------------------------");
            
            // Snap demo
            Console.WriteLine("[The hardest choices require the strongest wills.]");
            var thanos = Numbers.SnapFingers();
            thanos.PrintAll();
            Console.WriteLine("-------------------------------------------------");
            
            // Shuffle demo
            Console.WriteLine("[Shuffled thanos list.]");
            var shuffled = thanos.ShuffleElements();
            shuffled.PrintAll();
            Console.WriteLine("-------------------------------------------------");
        }
    }
}