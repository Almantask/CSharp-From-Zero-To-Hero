using System;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory : ComputerFactory
    {
        readonly string _manufacturersId;
        private DesktopComputer _msComputer;


        public MsFactory()
        {
            _manufacturersId = "m$PC2020";
        }

        public override DesktopComputer Assemble()
        {
            Console.WriteLine("Assembly for Microsoft Computer started please wait...");
            _msComputer = new DesktopComputer();
            CreateComputerCase();
            InstallMotherboard();
            InstallCpu();
            InstallRam();
            InstallGpu();
            InstallHardDisk();

            Console.WriteLine("Assembly finished.");
            return _msComputer;
        }

        public override void CreateComputerCase()
        {
            Console.WriteLine($"Creating computer case for Microsoft PC, computer ID: {_manufacturersId}");
            _msComputer.SetComputerCase(_manufacturersId);
        }

        public override void InstallMotherboard()
        {
            Console.WriteLine("Installing motherboard for Microsoft PC");
            _msComputer.SetMotherboard();
        }

        public override void InstallCpu()
        {
            Console.WriteLine("Installing CPU for Microsoft PC");
            _msComputer.SetCpu();
        }

        public override void InstallRam()
        {
            Console.WriteLine("Installing RAM for Microsoft PC");
            _msComputer.SetRam();
        }

        public override void InstallGpu()
        {
            Console.WriteLine("Installing GPU for Microsoft PC");
            _msComputer.SetGpu();
        }

        public override void InstallHardDisk()
        {
            Console.WriteLine("Installing HardDisk for Microsoft PC");
            _msComputer.SetHard();
        }
    }
}
