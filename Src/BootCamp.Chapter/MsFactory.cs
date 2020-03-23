using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory : ComputerFactory
    {
        public override void InstallBody(DesktopComputer computer)
        {
            computer.SetBody(_body);
        }

        public override void InstallMotherboard(DesktopComputer computer)
        {
            computer.SetMotherboard(_motherboard);
        }

        public override void InstallCpu(DesktopComputer computer)
        {
            computer.SetCpu(_cpu);
        }

        public override void InstallGpu(DesktopComputer computer)
        {
            computer.SetGpu(_gpu);
        }

        public override void InstallRam(DesktopComputer computer)
        {
            computer.SetRam(_ram);
        }

        public override void InstallHardDisk(DesktopComputer computer)
        {
            computer.SetHard(_hard);
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
