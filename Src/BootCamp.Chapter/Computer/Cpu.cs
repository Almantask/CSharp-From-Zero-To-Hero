using System;

namespace BootCamp.Chapter.Computer
{
    public class Cpu
    {
        public virtual void assembleCpu()
        {
            Console.WriteLine("Install CPU");
        }
    }

    public class MsCpu : Cpu
    {
        public MsCpu()
        {
            assembleCpu();
        }

        public override void assembleCpu()
        {
            Console.WriteLine("Install Win Cpu");
        }

        public override string ToString()
        {
            return string.Format("Win CPU");
        }
    }

    public class MacCpu : Cpu
    {
        public MacCpu()
        {
            assembleCpu();
        }

        public override void assembleCpu()
        {
            Console.WriteLine("Install Mac Cpu");
        }
        public override string ToString()
        {
            return string.Format("Mac CPU");
        }
    }


}