using BootCamp.Chapter.Computer;
using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            MsFactory msFactory = new MsFactory();
            DesktopComputer msComputer = msFactory.Assemble(); // In a real world application, assemble should take a list of components and assemble the computer based in that input.

            MacFactory macFactory = new MacFactory();
            DesktopComputer macComputer = macFactory.Assemble(); // In a real world application, assemble should take a list of components and assemble the computer based in that input.

            var test = "debug";
        }
    }
}
