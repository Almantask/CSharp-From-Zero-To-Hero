using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MacFactory : ComputerFactory
    {
        public override void InstallBody()
        {
            _body = new Body();
        }

        public override void InstallRam()
        {
            _ram = new Ram();
        }

        public override void InstallCpu()
        {
            _cpu = new Cpu();
        }

        public override void InstallGpu()
        {
            _gpu = new Gpu();
        }

        public override void InstallHardDisk()
        {
            _hard = new HardDisk();
        }

        public override void InstallMotherboard()
        {
            _motherboard = new Motherboard();
        }

        public MacFactory()
        {
            InstallBody();
            InstallRam();
            InstallCpu();
            InstallGpu();
            InstallHardDisk();
            InstallMotherboard();
        }

        public override DesktopComputer Assemble()
        {
            return new DesktopComputer(_body, _ram, _cpu, _gpu, _hard, _motherboard);
        }
    }
}
