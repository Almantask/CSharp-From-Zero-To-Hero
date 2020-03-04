using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory
    {
        private DesktopComputer _msComputer;
        private string manufacturersId;

        public MsFactory()
        {
            _msComputer = new DesktopComputer();
            manufacturersId = "m$PC2020";
        }
        public MsFactory(string computerId)
        {
            _msComputer = new DesktopComputer();
        }
        public DesktopComputer Assemble()
        {
            _msComputer.SetBody(manufacturersId);
            _msComputer.SetMotherboard(manufacturersId);
            _msComputer.SetCpu();
            _msComputer.SetRam();
            _msComputer.SetGpu();
            _msComputer.SetHard();

            return _msComputer;
        }
    }
}
