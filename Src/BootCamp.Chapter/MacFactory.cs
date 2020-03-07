using System;
using System.Diagnostics;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MacFactory : ComputerFactory
    {
        private DesktopComputer _macComputer;
        readonly string _manufacturersId;
        private Stopwatch _timer;

        public MacFactory()
        {
            _macComputer = new DesktopComputer();
            _manufacturersId = "mac-PC-2020";
            _timer = new Stopwatch();
        }

        public override DesktopComputer Assemble()
        {
            _timer.Start();
            Console.WriteLine("Assembly for Mac Computer started please wait.");
            CreateComputerCase();
            InstallMotherboard();
            InstallCpu();
            InstallRam();
            InstallGpu();
            InstallHardDisk();
            
            _timer.Stop();
            Console.WriteLine($"Assembly completed. Time elapsed: {_timer.ElapsedTicks}");

            return _macComputer;
        }

        public override void CreateComputerCase()
        {
            Console.WriteLine($"Creating computer case for Mac Computer, computer ID: {_manufacturersId}");
            _macComputer.SetComputerCase(_manufacturersId);
        }

        public override void InstallMotherboard()
        {
            Console.WriteLine("Installing motherboard for Mac PC");
            _macComputer.SetMotherboard();
        }

        public override void InstallCpu()
        {
            Console.WriteLine("Installing CPU for Mac PC");
            _macComputer.SetCpu();
        }

        public override void InstallRam()
        {
            Console.WriteLine("Installing RAM for Mac PC");
            _macComputer.SetRam();
        }

        public override void InstallGpu()
        {
            Console.WriteLine("Installing GPU for Mac PC");
            _macComputer.SetGpu();
        }

        public override void InstallHardDisk()
        {
            Console.WriteLine("Installing HardDisk for Mac PC");
            _macComputer.SetHard();
        }
    }
}
