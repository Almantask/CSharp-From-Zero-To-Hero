using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
using BootCamp.Chapter.Examples;
using BootCamp.Chapter.Examples.NullCoalecing;
using BootCamp.Chapter.Examples.NullCoalescing;
using BootCamp.Chapter.Examples.PropertyInitializers;

// ReSharper disable All

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Like this, we have change-proof printing of names.
            Announce(nameof(TernaryDemo));
            TernaryDemo.Run();
            Announce(nameof(NullConditionalDemo));
            NullConditionalDemo.Run();
            Announce(nameof(NullCoalecingDemo));
            NullCoalecingDemo.Run();
            Announce(nameof(SwitchPatternMatchingDemo));
            SwitchPatternMatchingDemo.Run();
            Announce(nameof(AsAndIsDemo));
            AsAndIsDemo.Run();
            Announce(nameof(NullValueDemo));
            NullValueDemo.Run();
            Announce(nameof(DefaultParametersDemo));
            DefaultParametersDemo.Run();
        }

        private static void Announce(string demo)
        {
            Console.WriteLine("--------" + demo + "--------");
        }
    }
}
