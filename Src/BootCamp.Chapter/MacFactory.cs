using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MacFactory
    {
        private DesktopComputer _macComputer;
        private string manufacturersId;

        public MacFactory()
        {
            _macComputer = new DesktopComputer();
            manufacturersId = "mac-PC-2020";
        }
        public DesktopComputer Assemble()
        {
            _macComputer.SetBody(manufacturersId);
            _macComputer.SetMotherboard(manufacturersId);
            _macComputer.SetCpu();
            _macComputer.SetRam();
            _macComputer.SetGpu();
            _macComputer.SetHard();

            return _macComputer;
        }
    }
}
