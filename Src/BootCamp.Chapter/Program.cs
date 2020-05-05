using BootCamp.Chapter.Computer;
using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            MsFactory msFactory = new MsFactory();
            DesktopComputer msComputer = msFactory.Assemble();
            var test = "debug";
        }
    }
}
