using System;

namespace BootCamp.Chapter.Computer
{
    public class Gpu
    {
        public Gpu()
        {

        }

        public virtual void assembleGPU()
        {
            Console.WriteLine("Install GPU");
        }

    }

    public class MsGpu : Gpu
    {

        public MsGpu()
        {
            assembleGPU();
        }

        public override void assembleGPU()
        {
            Console.WriteLine("Install Win Gpu");
        }
    }
}