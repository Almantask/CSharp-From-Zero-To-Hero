using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory : ComputerFactory
    {
        public override DesktopComputer Assemble()
        {
            return new DesktopComputer(_body, _ram, _cpu, _gpu, _hard, _motherboard);
        }
    }
}
