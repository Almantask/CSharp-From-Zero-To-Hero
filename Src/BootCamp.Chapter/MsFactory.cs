using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory : ComputerFactory
    {
        public override DesktopComputer Assemble()
        {
            var computer = new DesktopComputer();
            var body = new Body("a ms body");
            computer.SetBody(body);

            return computer; 
        }
    }
}
