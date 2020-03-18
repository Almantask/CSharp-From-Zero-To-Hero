using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory: Factory
    {
        public override DesktopComputer Assemble()
        {
            return new Computer.Ms.MSDesktopComputer();
        }
    }
}
