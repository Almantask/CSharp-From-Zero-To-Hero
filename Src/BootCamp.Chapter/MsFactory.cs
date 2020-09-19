using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory : DesktopComputer
    {
        public MsFactory()
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
            return "Assembly of Ms computer complete.";
        }
    }
}
