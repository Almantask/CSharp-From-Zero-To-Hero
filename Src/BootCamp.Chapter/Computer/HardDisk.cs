using System;

namespace BootCamp.Chapter.Computer
{
    public class HardDisk
    {
        public virtual void assembleHardDisk()
        {
            Console.WriteLine("Install HardDisk");
        }
    }

    public class MsHardDisk : HardDisk
    {
        public MsHardDisk()
        {
            assembleHardDisk();
        }

        public override void assembleHardDisk()
        {
            Console.WriteLine("Install Win HardDisk");
        }
        public override string ToString()
        {
            return string.Format("Win HardDisk");
        }
    }
    public class MacHardDisk : HardDisk
    {
        public MacHardDisk()
        {
            assembleHardDisk();
        }

        public override void assembleHardDisk()
        {
            Console.WriteLine("Install Mac HardDisk");
        }
    }
}