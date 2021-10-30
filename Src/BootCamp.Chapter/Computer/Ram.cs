using System;

namespace BootCamp.Chapter.Computer
{
    public class Ram
    {
        public Ram()
        {

        }

        public virtual void assembleRam()
        {
            Console.WriteLine("Install Ram");
        }
    }

    public class MsRam : Ram
    {
        public MsRam()
        {
            assembleRam();
        }

        public override void assembleRam()
        {
            Console.WriteLine("Install Win Ram");
        }
    }
}