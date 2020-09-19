using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MacFactory : DesktopComputer
    {
        public MacFactory()
        {
            Assemble();
            Console.WriteLine(CompletedAssembly());
        }

        public DesktopComputer Assemble()
        {
            return new DesktopComputer();
        }

        public override string CompletedAssembly()
        {
            return "Assembly of Mac computer complete.";
        }
    }
}
