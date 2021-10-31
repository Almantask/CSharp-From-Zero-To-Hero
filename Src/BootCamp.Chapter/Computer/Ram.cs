using System;

namespace BootCamp.Chapter.Computer
{
    public class Ram
    {
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
        public override string ToString()
        {
            return string.Format("Win Ram");
        }
    }
    public class MacRam : Ram
    {
        public MacRam()
        {
            assembleRam();
        }

        public override void assembleRam()
        {
            Console.WriteLine("Install Mac Ram");
        }
    }
}