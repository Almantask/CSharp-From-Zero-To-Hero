using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MacFactory
    {
        public DesktopComputer Assemble()
        {
            return new Computer.Mac.MacDesktopComputer();
        }
    }
}
