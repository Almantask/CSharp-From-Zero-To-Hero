using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory
    {
        public DesktopComputer Assemble()
        {
            return new Computer.Ms.MSDesktopComputer();
        }
    }
}
