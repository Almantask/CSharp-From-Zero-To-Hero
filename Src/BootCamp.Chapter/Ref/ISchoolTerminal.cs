using BootCamp.Chapter.Example.DIP.WithIoC;

namespace BootCamp.Chapter.Ref
{
    public interface ISchoolTerminal : IService
    {
        void Start();
    }
}