using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MacFactory : Factory
    {
        public override DesktopComputer Assemble()
        {
            return new Computer.Mac.MacDesktopComputer();
        }
    }
}
