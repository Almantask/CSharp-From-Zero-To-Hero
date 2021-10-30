using System;

namespace BootCamp.Chapter.Computer
{
    public class Cpu
    {
        public Cpu()
        {

        }

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
    }
       

}