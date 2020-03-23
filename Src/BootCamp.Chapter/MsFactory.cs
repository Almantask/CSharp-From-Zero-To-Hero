using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory : ComputerFactory
    {
        public override void InstallBody(DesktopComputer computer)
        {
            computer.SetBody(new Body());
        }

        public override void InstallMotherboard(DesktopComputer computer)
        {
            computer.SetMotherboard(new Motherboard());
        }

        public override void InstallCpu(DesktopComputer computer)
        {
            computer.SetCpu(new Cpu());
        }

        public override void InstallGpu(DesktopComputer computer)
        {
            computer.SetGpu(new Gpu());
        }

        public override void InstallRam(DesktopComputer computer)
        {
            computer.SetRam(new Ram());
        }

        public override void InstallHardDisk(DesktopComputer computer)
        {
            computer.SetHard(new HardDisk());
        }

        public override DesktopComputer Assemble()
        {
            var computer = new DesktopComputer();

            InstallBody(computer);
            InstallMotherboard(computer);
            InstallCpu(computer);
            InstallGpu(computer);
            InstallRam(computer);
            InstallHardDisk(computer);

            return computer;
        }
    }
}
